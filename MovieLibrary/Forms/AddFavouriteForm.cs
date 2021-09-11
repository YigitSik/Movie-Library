using MovieLibrary.Dal;
using MovieLibrary.Model;
using MovieLibrary.Service;
using MovieLibrary.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary.Forms
{
    public partial class AddFavouriteForm : DevExpress.XtraEditors.XtraForm
    {

        private MoviePreview moviePreview;

        private decimal userRating=0;
        public decimal UserRating
        {
            get { return userRating; }
            set { userRating = value; }
        }

        private string userNotes="";
        public string UserNotes
        {
            get { return userNotes; }
            set { userNotes = value; }
        }


        public AddFavouriteForm()
        {
            InitializeComponent();
        }

        public AddFavouriteForm(MoviePreview moviePreview)
        {
            InitializeComponent();
            this.moviePreview = moviePreview;
        }

       
        private void AddFavouriteForm_Load(object sender, EventArgs e)
        {
            pictureBoxFav.Image = MovieUtils.getImage(moviePreview.Poster);
            textTitle.Text = moviePreview.Title;
            textYear.Text = moviePreview.Year;
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            IDictionary<string, object> valuePairs = new Dictionary<string, object>();
            valuePairs.Add("PersonalRating", UserRating);
            valuePairs.Add("Notes", UserNotes);
            valuePairs.Add("imdbId", moviePreview.imdbID);
            Crud.AddFavourite(valuePairs);

            this.Close();
        }

        private void ratingControlFav_EditValueChanged(object sender, EventArgs e)
        {
            UserRating = ratingControlFav.Rating;
        }

        private void richTextNotes_TextChanged(object sender, EventArgs e)
        {
            UserNotes = richTextNotes.Text;
        }
    }
}
