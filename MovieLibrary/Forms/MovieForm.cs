using DevExpress.XtraEditors.Repository;
using MovieLibrary.Forms;
using MovieLibrary.Model;
using MovieLibrary.Service;
using MovieLibrary.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MovieLibrary
{
    public partial class MovieForm : DevExpress.XtraEditors.XtraForm
    {
        public MovieForm()
        {
            InitializeComponent();

        }

        AddFavouriteForm addFavouriteForm;
        AddWatchListForm addWatchListForm;
        DetailsForm detailsForm;
        TrailerForm trailerForm;

        private MoviePreview selectedDataRow;
        public MoviePreview SelectedDataRow
        {
            get { return selectedDataRow; }
            set { selectedDataRow = value; }
        }

        
       
        public void setImage(string url)
        {
            pictureEdit1.Image = MovieUtils.getImage(url);
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {

            string Query = searchBox.Text;

            if (Query.Length > 0)
            {
               
                SearchResponse searchResponse = await OmdbApi.GetMoviePreview(Query);

                if (searchResponse.Response == "True")
                {
                    MovieGrid.DataSource = searchResponse.Search;
                    dataGrid.MoveNext();
                }
                else
                {
                    MessageBox.Show("There Is No Result", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void favouritesBtn_Click(object sender, EventArgs e)
        {
            // Eğer seçilen form daha önce seçilmemişse veya kapatılmışsa yeniden aç
            if (selectedDataRow != null&&(addFavouriteForm==null||addFavouriteForm.IsDisposed))
            {
                addFavouriteForm = new AddFavouriteForm(SelectedDataRow);
                addFavouriteForm.Show();
            } // Eğer zaten açıksa formu seç
            else
            {
                addFavouriteForm.Select();
            }
        }

        private void watchListBtn_Click(object sender, EventArgs e)
        {
            if (selectedDataRow != null && (addWatchListForm == null || addWatchListForm.IsDisposed))
            {
                addWatchListForm = new AddWatchListForm(SelectedDataRow);
                addWatchListForm.Show();
            }
            else
            {
                addWatchListForm.Select();
            }
           
        }

     
        private void detailsBtn_Click(object sender, EventArgs e)
        {
            if (selectedDataRow != null && (detailsForm == null || detailsForm.IsDisposed))
            {
                detailsForm = new DetailsForm(SelectedDataRow.imdbID);
                detailsForm.Show();
            }
            else
            {
                detailsForm.Select();
            }
        }

        //seçilen satıra göre posteri yenile
        private void dataGrid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            selectedDataRow = (MoviePreview)dataGrid.GetRow(e.FocusedRowHandle);

            if (selectedDataRow != null)
            {
                setImage(selectedDataRow.Poster);
            }
        }

        
        private async void trailerBtn_Click(object sender, EventArgs e)
        {
            if (selectedDataRow != null && (trailerForm == null || trailerForm.IsDisposed))
            {
                trailerForm = new TrailerForm(selectedDataRow.Title,selectedDataRow.Year);
                trailerForm.Show();
            }
            else
            {
               await trailerForm.Search(selectedDataRow.Title, selectedDataRow.Year);
            }
    }

}
}
