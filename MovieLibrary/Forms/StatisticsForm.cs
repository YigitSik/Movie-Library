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
    public partial class StatisticsForm : DevExpress.XtraEditors.XtraForm
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        MovieLibraryEntities1 movieLibrary = new MovieLibraryEntities1();
        private void StatisticsForm_Load(object sender, EventArgs e)
        {

            LoadStatistics();
           
         
        }

        public void LoadStatistics()
        {

            ClearCharts();
            LoadGenreData();
            LoadRatingsData();
            LoadLanguageData();
            LoadCountryData();
        }

        private void ClearCharts()
        {
              
            while (genreChart.Series["Series 1"].Points.Count > 0)
            {
                genreChart.Series["Series 1"].Points.RemoveAt(0);
            }

            while (languageChart.Series["Series 1"].Points.Count > 0)
            {
                languageChart.Series["Series 1"].Points.RemoveAt(0);
            }

            while (countryChart.Series["Series 1"].Points.Count > 0)
            {
                countryChart.Series["Series 1"].Points.RemoveAt(0);
            }

            while (ratingsChart.Series["Imdb Ratings"].Points.Count > 0)
            {
                ratingsChart.Series["Imdb Ratings"].Points.RemoveAt(0);
                ratingsChart.Series["Avearage Rating"].Points.RemoveAt(0);
            }

        }

        private void LoadRatingsData()
        {
            var imdbRatingsQuery = (from x in movieLibrary.TBL_FAVOURITE
                              join y in movieLibrary.TBL_MOVIE on x.imdbId equals y.imdbId
                              select y.imdbRating).ToList();

            List<double> imdbRatings = new List<double>();

            double average = 0;
            double sum = 0;
           

            foreach (var item in imdbRatingsQuery)
            {
                 imdbRatings.Add(Convert.ToDouble(item));

                sum += Convert.ToDouble(item);

            }

            double size = imdbRatings.Count;
            double count = 0;
            average =  sum / size;

            foreach (var item in imdbRatings)
            {
                ratingsChart.Series["Imdb Ratings"].Points.AddPoint(count,item);
                ratingsChart.Series["Avearage Rating"].Points.AddPoint(count, Math.Round(average,2));
                count++;
            }
            
        }

        private void LoadCountryData()
        {
            var countryQuery = (from x in movieLibrary.TBL_FAVOURITE
                                 join y in movieLibrary.TBL_MOVIE on x.imdbId equals y.imdbId
                                 select y.Country).ToList();

            List<string> rawCountry = new List<string>();

            string[] words = new string[10];

            foreach (var item in countryQuery)
            {
               
                words = item.Split(',');
               
                foreach (var subitem in words)
                {
                    rawCountry.Add(subitem.Trim());
                }
            }

            var groupedCountries = (from word in rawCountry
                                    group word by word
                                 into result
                                    select new
                                    { Genre = result.Key, Count = result.Count() });

            foreach (var item in groupedCountries)
            {
                countryChart.Series["Series 1"].Points.AddPoint(item.Genre, item.Count);
            }
        }

        private void LoadLanguageData()
        {
            var languageQuery = (from x in movieLibrary.TBL_FAVOURITE
                                join y in movieLibrary.TBL_MOVIE on x.imdbId equals y.imdbId
                                select y.Language).ToList();

            List<string> rawlanguage = new List<string>();

            string[] words = new string[10];

            foreach (var item in languageQuery)
            {
                
                words = item.Split(',');

                foreach (var subitem in words)
                {
                    rawlanguage.Add(subitem.Trim());
                }
            }

            var groupedLanguage = (from word in rawlanguage
                                 group word by word
                                 into result
                                    select new
                                    { Genre = result.Key, Count = result.Count() });

            foreach (var item in groupedLanguage)
            {
                languageChart.Series["Series 1"].Points.AddPoint(item.Genre, item.Count);
            }
        }

        private void LoadGenreData()
        {
            var genreQuery = (from x in movieLibrary.TBL_FAVOURITE
                              join y in movieLibrary.TBL_MOVIE on x.imdbId equals y.imdbId
                              select y.Genre).ToList();

            List<string> rawGenres = new List<string>();

            string[] words = new string[10];

            foreach (var item in genreQuery)
            {
                
                words = item.Split(',');

                foreach (var subitem in words)
                {
                    rawGenres.Add(subitem.Trim());
                }
            }

            var groupedGenres = (from word in rawGenres
                                 group word by word
                                 into result
                                 select new
                                 { Genre = result.Key, Count = result.Count() });

            foreach (var item in groupedGenres)
            {
                genreChart.Series["Series 1"].Points.AddPoint(item.Genre, item.Count);
            }
        }

        private void StatisticsForm_Activated(object sender, EventArgs e)
        {
            LoadStatistics();
        }
    }
}
