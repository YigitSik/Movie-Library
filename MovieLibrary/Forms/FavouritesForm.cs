using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Card;
using MovieLibrary.Dal;
using MovieLibrary.Model;
using MovieLibrary.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary
{
    public partial class FavouritesForm : DevExpress.XtraEditors.XtraForm
    {
        public FavouritesForm()
        {
            InitializeComponent();
        }

        MovieLibraryEntities1 movieLibraryEntities1 = new MovieLibraryEntities1();
        DetailsForm detailsForm;

        private void FavouritesForm_Load(object sender, EventArgs e)
        {
          getFavourites();

        }

        public void getFavourites()
        {

            MovieLibraryEntities1 movieLibrary = new MovieLibraryEntities1();

            //İlgili sutunları birleştir ve seç
            var elements = from x in movieLibrary.TBL_FAVOURITE
                           join y in movieLibrary.TBL_MOVIE on x.imdbId equals y.imdbId
                           join user in movieLibrary.TBL_USER on x.userId equals user.userId
                           select new
                           {
                               y.Title,
                               y.Year,
                               y.Genre,
                               y.Poster,
                               x.PersonalRating,
                               x.Notes,
                               x.FavId,
                               y.imdbId,
                               y.imdbRating,
                               user.userId
                               
                           };

            //mevcut kullanıcıya göre verileri filtrele
            var favourites= elements.Where(e => e.userId == Crud.userId).Select(e => e);

            gridControl1.DataSource = favourites.ToList();

        }
        
        // Seçilen tablo satırına göre verileri güncelle
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("Poster")!=null)
            {
                string posterUrl = gridView1.GetFocusedRowCellValue("Poster").ToString();
                pictureBoxFav.Image = MovieUtils.getImage(posterUrl);
                notesText.Text = gridView1.GetFocusedRowCellValue("Notes").ToString();
                ratingControl1.EditValue = (decimal)gridView1.GetFocusedRowCellValue("PersonalRating");
            }

        }


        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("FavId")!=null)
            {
                int id = int.Parse(gridView1.GetFocusedRowCellValue("FavId").ToString());
                var element = movieLibraryEntities1.TBL_FAVOURITE.Find(id);
                movieLibraryEntities1.TBL_FAVOURITE.Remove(element);
                movieLibraryEntities1.SaveChanges();
                MessageBox.Show("Deleted");
                getFavourites();
                gridView1.MoveNext();
            }
            else
            {
                MessageBox.Show("There Are No Elements");
            }
            
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("FavId") != null)
            {
                int id = int.Parse(gridView1.GetFocusedRowCellValue("FavId").ToString());
                var element = movieLibraryEntities1.TBL_FAVOURITE.Find(id);
                element.Notes = notesText.Text;
                element.PersonalRating = (decimal)ratingControl1.EditValue;
                movieLibraryEntities1.SaveChanges();
                MessageBox.Show("Updated");
                getFavourites();
                gridView1.MoveNext();
            }
            else
            {
                MessageBox.Show("There Are No Elements");
            }
            
        }

        private void detailsButton_Click_1(object sender, EventArgs e)
        {
            string id = gridView1.GetFocusedRowCellValue("imdbId").ToString();

            if (id != null && (detailsForm == null || detailsForm.IsDisposed))
            {
                detailsForm = new DetailsForm(id);
                detailsForm.Show();
            }
            
        }
        //Form seçildiğinde formu verilerini yenile
        private void FavouritesForm_Activated(object sender, EventArgs e)
        {
            getFavourites();
        }

        // gridControl'deki verileri excel'e aktar
        private void excelBtn_Click(object sender, EventArgs e)
        {
            string path = "output.xlsx";
            gridControl1.ExportToXlsx(path);
            Process.Start(path);
        }
    }
}
