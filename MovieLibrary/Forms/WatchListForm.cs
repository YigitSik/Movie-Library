using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLibrary.Dal;
using System.Windows.Forms;
using MovieLibrary.Utils;
using MovieLibrary.Model;
using System.Diagnostics;
using MovieLibrary.Forms;

namespace MovieLibrary
{
    public partial class WatchListForm : DevExpress.XtraEditors.XtraForm
    {
        public WatchListForm()
        {
            InitializeComponent();
        }

        MovieLibraryEntities1 movieLibrary = new MovieLibraryEntities1();
        DetailsForm detailsForm;
        AddFavouriteForm addFavouriteForm;
        
        dynamic selectedRow;

       
        private void WatchListForm_Load(object sender, EventArgs e)
        {

            getWatchList();
        }

        public void getWatchList()
        {
            var elements = from watchList in movieLibrary.TBL_WATCHLIST
                           join watchListElement in movieLibrary.TBL_WATCHLIST_ELEMENT
                           on watchList.WatchListName equals watchListElement.WatchListName
                           join movie in movieLibrary.TBL_MOVIE
                           on watchListElement.imdbId equals movie.imdbId
                           select new
                           {
                               watchListElement.WatchListName,
                               watchListElement.Date,
                               watchListElement.Notes,
                               watchListElement.WatchListElementId,
                               movie.Title,
                               movie.Year,
                               movie.Genre,
                               movie.imdbId,
                               movie.imdbRating,
                               movie.Poster,
                               watchList.WatchListId
                           };

            watchListControl.DataSource = elements.ToList();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {


            selectedRow = gridView1.GetRow(e.FocusedRowHandle);
            if (selectedRow != null)
            {
                pictureBox.Image = MovieUtils.getImage(selectedRow.Poster);
                dateEdit.DateTime = selectedRow.Date;
                watchListNameText.Text = selectedRow.WatchListName;
                notesText.Text = selectedRow.Notes;
            }
            

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            if (selectedRow!=null)
            {
                var element = movieLibrary.TBL_WATCHLIST_ELEMENT.Find(selectedRow.WatchListElementId);
                movieLibrary.TBL_WATCHLIST_ELEMENT.Remove(element);
                movieLibrary.SaveChanges();
                MessageBox.Show("Deleted");
                getWatchList();
                gridView1.MoveNext();
            }
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
            if (selectedRow!=null)
            {
                TBL_WATCHLIST_ELEMENT element = movieLibrary.TBL_WATCHLIST_ELEMENT.Find(selectedRow.WatchListElementId);
                element.Notes = notesText.Text;
                if (dateEdit.DateTime != null) element.Date = dateEdit.DateTime;
                element.WatchListName = watchListNameText.Text;
                movieLibrary.SaveChanges();
                MessageBox.Show("Updated");
                getWatchList();
                gridView1.MoveNext();
            }
            
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            

            if (selectedRow != null && (detailsForm == null || detailsForm.IsDisposed))
            {
                string id = selectedRow.imdbId;
                detailsForm = new DetailsForm(id);
                detailsForm.Show();
            }
            
        }

        private void WatchListForm_Activated(object sender, EventArgs e)
        {
            getWatchList();
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            string path = "output.xlsx";
            watchListControl.ExportToXlsx(path);
            Process.Start(path);
        }

        private void favBtn_Click(object sender, EventArgs e)
        {

            MoviePreview moviePreview = new MoviePreview();

            moviePreview.imdbID = selectedRow.imdbId;
            moviePreview.Poster = selectedRow.Poster;
            moviePreview.Title = selectedRow.Title;
            moviePreview.Year = selectedRow.Year;
    
            
            if (selectedRow != null && (addFavouriteForm == null || addFavouriteForm.IsDisposed))
            {
                addFavouriteForm = new AddFavouriteForm(moviePreview);
                addFavouriteForm.Show();
            }
        }
    }
}
