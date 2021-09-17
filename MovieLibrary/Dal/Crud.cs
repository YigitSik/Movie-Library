using MovieLibrary.Model;
using MovieLibrary.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace MovieLibrary.Dal
{
    public class Crud
    {

        static MovieLibraryEntities1 movieEntity = new MovieLibraryEntities1();

        public static short userId { get; set; }

        public async static void AddFavourite(IDictionary<string, object> values)
        {

            string imdbId = (string) values["imdbId"];
            decimal rating = (decimal)values["PersonalRating"];
            string notes = (string)values["Notes"];

            try
            {

                TBL_MOVIE movie = await AddMovie(imdbId);

                TBL_FAVOURITE favs = new TBL_FAVOURITE();

                favs.imdbId = movie.imdbId;
                favs.PersonalRating = rating;
                favs.Notes = notes;
                favs.userId = userId;
                movieEntity.TBL_FAVOURITE.Add(favs);
                movieEntity.SaveChanges();


                MessageBox.Show("Succesfully Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
        }
        public async static Task<TBL_MOVIE> AddMovie(string imdbId)
        {
            if (movieEntity.TBL_MOVIE.Find(imdbId) != null)
            {

                var query = from x in movieEntity.TBL_MOVIE
                                     where x.imdbId == imdbId
                                     select x;

                var movie = query.FirstOrDefault();

                return movie;
            }
            else
            {
                TBL_MOVIE movie = await OmdbApi.GetMovieFromApi(imdbId);

                TBL_MOVIE mov = new TBL_MOVIE();
                mov.Actors = movie.Actors;
                mov.Awards = movie.Awards;
                mov.Country = movie.Country;
                mov.Director = movie.Director;
                mov.DVD = movie.DVD;
                mov.Genre = movie.Genre;
                mov.imdbId = movie.imdbId;
                mov.imdbRating = movie.imdbRating;
                mov.Language = movie.Language;
                mov.Metascore = movie.Metascore;
                mov.Plot = movie.Plot;
                mov.Poster = movie.Poster;
                mov.Production = movie.Production;
                mov.Rated = movie.Rated;
                mov.Released = movie.Released;
                mov.Title = movie.Title;
                mov.Type = movie.Type;
                mov.Website = movie.Website;
                mov.Writer = movie.Writer;
                mov.Year = movie.Year;
                movieEntity.TBL_MOVIE.Add(mov);
                movieEntity.SaveChanges();
                return movie;
                
            }

        }

        public async static Task<TBL_WATCHLIST_ELEMENT> AddWatchListElement(IDictionary<string, object> values)
        {
            string imdbId = (string)values["imdbId"];
            DateTime date = (DateTime)values["WatchListDate"];
            string notes = (string)values["WatchListNotes"];
            string watchListName = (string)values["WatchListName"];

            
                TBL_WATCHLIST_ELEMENT element = new TBL_WATCHLIST_ELEMENT();

                TBL_MOVIE movie = await AddMovie(imdbId);

            if (movieEntity.TBL_WATCHLIST.Find(watchListName) == null)
            {
                AddWatchList(watchListName);
            }
            
                element.Date =  date;
                element.Notes = notes;
                element.WatchListName = watchListName;
                element.imdbId = imdbId;
                movieEntity.TBL_WATCHLIST_ELEMENT.Add(element);
                movieEntity.SaveChanges();

            return element;
        }

        public static void AddWatchList(string name)
        {
           
            string watchListName = name;
            
                TBL_WATCHLIST watch = new TBL_WATCHLIST();

                watch.WatchListName = name;
                watch.userId = userId;
                movieEntity.TBL_WATCHLIST.Add(watch);
                movieEntity.SaveChanges();
            
        }

        //Burada kullanıcı bulut veri tabanıyla ilk etkileşimini gerçekleştiriyor.
        //Azure SQL trafiği az olan server ları uyku moduna geçiriyor buda ilk bağlanılmaya çalışıldığında hataya sebep oluyor
        //Bu işlem genellikle sadece ilk 1 dakika içinde gerçekleşiyor. 
        //Buradaki kod ile de bu işemi birkaç kez deneyerek, programı geçiçi hatalara karşı esnek bir hale getiriyoruz
        public static void Register(string username,string password)
        {

            int totalNumberOfTimesToTry = 4;
            int retryIntervalSeconds = 10;

            for (int tries = 1; tries <= totalNumberOfTimesToTry; tries++)
            {

                try
                {

                    if (tries > 1)
                    {
                        Console.WriteLine
                          ("Transient error encountered. Will begin attempt number {0} of {1} max...",
                          tries, totalNumberOfTimesToTry
                          );
                        System.Threading.Thread.Sleep(1000 * retryIntervalSeconds);
                        retryIntervalSeconds = Convert.ToInt32
                          (retryIntervalSeconds * 1.5);
                        
                    }
                    TBL_USER user = new TBL_USER();

                    user.userName = username;
                    user.password = password;
                    movieEntity.TBL_USER.Add(user);
                    movieEntity.SaveChanges();

                    MessageBox.Show("You Have Successfully Registered");
                    break;

                }
                catch (Exception )
                {
                    string message = String.Format("Transient error encountered. Will begin attempt number {0} of {1} max...", tries, totalNumberOfTimesToTry);
                    MessageBox.Show(message);
                   
                }

            }

        }

        //Burada kullanıcı bulut veri tabanıyla ilk etkileşimini gerçekleştiriyor.
        //Azure SQL trafiği az olan server ları uyku moduna geçiriyor buda ilk bağlanılmaya çalışıldığında hataya sebep oluyor
        //Bu işlem genellikle sadece ilk 1 dakika içinde gerçekleşiyor. 
        //Buradaki kod ile de bu işemi birkaç kez deneyerek, programı geçiçi hatalara karşı esnek bir hale getiriyoruz
        public static IDictionary<string, object> Authenticate(string username,string password)
        {

            IDictionary<string, object> valuePairs = new Dictionary<string, object>();


            int totalNumberOfTimesToTry = 4;
            int retryIntervalSeconds = 10;

            for (int tries = 1; tries <= totalNumberOfTimesToTry; tries++)
            {


                try
                {

                    if (tries > 1)
                    {
                        Console.WriteLine
                          ("Transient error encountered. Will begin attempt number {0} of {1} max...",
                          tries, totalNumberOfTimesToTry
                          );
                        System.Threading.Thread.Sleep(1000 * retryIntervalSeconds);
                        retryIntervalSeconds = Convert.ToInt32
                          (retryIntervalSeconds * 1.5);
                    }
                
     
                    var user = from x in movieEntity.TBL_USER
                               where x.userName == username && x.password == password
                               select x;

                    TBL_USER element = user.FirstOrDefault();

                    if (element != null)
                    {
                        valuePairs.Add("Result", true);
                        valuePairs.Add("UserId", element.userId);
                        valuePairs.Add("UserName", element.userName);

                        userId = element.userId;
                    }
                    else
                    {
                        valuePairs.Add("Result", false);
                    }
                    return valuePairs;

                    
                }
                catch (Exception)
                {
                    string message = String.Format("Transient error encountered. Will begin attempt number {0} of {1} max...", tries, totalNumberOfTimesToTry);
                    MessageBox.Show(message);
                }

                

            }

            return valuePairs;

        }


        
    }
}
