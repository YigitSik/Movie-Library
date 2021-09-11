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
                    setImage(searchResponse.Search[0].Poster);
                }
                else
                {
                    MessageBox.Show("There Is No Result", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void favouritesBtn_Click(object sender, EventArgs e)
        {
            if (selectedDataRow != null&&(addFavouriteForm==null||addFavouriteForm.IsDisposed))
            {
                addFavouriteForm = new AddFavouriteForm(SelectedDataRow);
                addFavouriteForm.Show();
            }
        }

        private void watchListBtn_Click(object sender, EventArgs e)
        {
            if (selectedDataRow != null && (addWatchListForm == null || addWatchListForm.IsDisposed))
            {
                addWatchListForm = new AddWatchListForm(SelectedDataRow);
                addWatchListForm.Show();
            }
           
        }

     
        private void detailsBtn_Click(object sender, EventArgs e)
        {
            if (selectedDataRow != null && (detailsForm == null || detailsForm.IsDisposed))
            {
                detailsForm = new DetailsForm(SelectedDataRow.imdbID);
                detailsForm.Show();
            }
        }

        private void dataGrid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            selectedDataRow = (MoviePreview)dataGrid.GetRow(e.FocusedRowHandle);

            if (selectedDataRow != null)
            {
                setImage(selectedDataRow.Poster);
            }
        }

    }
}
