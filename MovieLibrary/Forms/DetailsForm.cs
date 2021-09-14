using MovieLibrary.Dal;
using MovieLibrary.Model;
using MovieLibrary.Service;
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

namespace MovieLibrary
{
    public partial class DetailsForm : DevExpress.XtraEditors.XtraForm
    {

        public string imdbId { get; set; }

        public DetailsForm()
        {
            InitializeComponent();
        }

        public DetailsForm(string imdbId)
        {
            InitializeComponent();
            this.imdbId = imdbId;
        }

        MovieLibraryEntities1 movieEntity = new MovieLibraryEntities1();

        private async void DetailsForm_Load(object sender, EventArgs e)
        {
            TBL_MOVIE movie;

            //Burda eğer film verisi halihazırda verisetinde mevcut ise api'dan çekmek yerine veri setinden veriileri döndürüyoruz

            if (movieEntity.TBL_MOVIE.Find(imdbId) != null)
            {

                var query = from x in movieEntity.TBL_MOVIE
                                     where x.imdbId == imdbId
                                     select x;

                 movie = query.FirstOrDefault();
                
            } // Bulamaz ise api çağrısı yapıyor
            else
            {
                 movie = await OmdbApi.GetMovieFromApi(imdbId);

            }

            pictureBox.Image = MovieUtils.getImage(movie.Poster);
            plotTextBox.Text = movie.Plot;
            actorText.Text = movie.Actors;
            writerText.Text = movie.Writer;
            yearText.Text = movie.Year;
            ratedText.Text = movie.Rated;
            releasedText.Text = movie.Released;
            genreText.Text = movie.Genre;
            directorText.Text = movie.Director;
            typeText.Text = movie.Type;
            languageText.Text = movie.Language;
            countryText.Text = movie.Country;
            awardsText.Text = movie.Awards;
            productionText.Text = movie.Production;
            metaScoreText.Text = movie.Metascore;
            imdbRatingText.Text = movie.imdbRating;
            titleLabel.Text = movie.Title;

            //Convert rating scale from 10 to 5
            ratingControl.EditValue = (Convert.ToDouble(movie.imdbRating) / 2.0).ToString();

        }

       
    }
}
