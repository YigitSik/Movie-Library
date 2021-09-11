using MovieLibrary.Dal;
using MovieLibrary.Model;
using MovieLibrary.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.Forms
{
    public partial class AddWatchListForm : DevExpress.XtraEditors.XtraForm
    {
        MoviePreview moviePreview = new MoviePreview();

        dynamic selectedRow;

        private string watchListNotes;

        public string WatchListNotes
        {
            get { return watchListNotes; }
            set { watchListNotes = value; }
        }


        private DateTime watchListDate = DateTime.Today;

        public DateTime WatchListDate
        {
            get { return watchListDate; }
            set { watchListDate = value; }
        }

        public AddWatchListForm()
        {
            InitializeComponent();
        }

        public AddWatchListForm(MoviePreview moviePreview)
        {
            InitializeComponent();
            this.moviePreview = moviePreview;
        }

        private void AddWatchListForm_Load(object sender, EventArgs e)
        {
            GetWatchList();
        }

        public void GetWatchList()
        {
            pictureBox.Image = MovieUtils.getImage(moviePreview.Poster);
            textTitle.Text = moviePreview.Title;
            textYear.Text = moviePreview.Year;

            MovieLibraryEntities1 movieLibrary = new MovieLibraryEntities1();

            var elements = from watchList in movieLibrary.TBL_WATCHLIST
                           join watchListElement in movieLibrary.TBL_WATCHLIST_ELEMENT
                           on watchList.WatchListName equals watchListElement.WatchListName
                           join movie in movieLibrary.TBL_MOVIE
                           on watchListElement.imdbId equals movie.imdbId
                           select new
                           {
                               watchListElement.WatchListName,
                               watchListElement.Date,
                               movie.Title,
                               movie.Year,
                               movie.Genre,
                               movie.imdbId,
                               movie.Poster,
                               movie.imdbRating,
                               watchList.WatchListId

                           };

            watchListControl.DataSource = elements.ToList();
        }

        private async void watchListSubmit_Click(object sender, EventArgs e)
        {

            if (WatchListNameText.Text.Length>0)
            {
                try
                {
                    IDictionary<string, object> valuePairs = new Dictionary<string, object>();
                    valuePairs.Add("WatchListDate", WatchListDate);
                    valuePairs.Add("WatchListNotes", WatchListNotes);
                    valuePairs.Add("WatchListName", WatchListNameText.Text);
                    valuePairs.Add("imdbId", moviePreview.imdbID);

                   await Crud.AddWatchListElement(valuePairs) ;
                    GetWatchList();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
               
            }
            else
            {
                MessageBox.Show("Watch List Name Cannot Be Empty");
            }

           


        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
                WatchListDate = dateEdit1.DateTime;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            WatchListNotes = richTextBox1.Text;
        }

        

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            selectedRow = gridView1.GetRow(e.FocusedRowHandle);
            if (selectedRow != null)
            {
                WatchListNameText.Text = selectedRow.WatchListName;
            }
        }
    }
}
