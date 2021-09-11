using MovieLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//**********************************************************************************************************************

//Burada ADO.Net yöntemiyle veritabanı işlemlerini gerçekleştirmiştim. Fakat proje ilerledikçe linq kullanmayı tercih ettim.

//**********************************************************************************************************************


namespace MovieLibrary.Dal
{
    public class CrudOld
    {

        public static void AddFavourite(IDictionary<string,object> values )
        {

            MoviePreview moviePreview = (MoviePreview)values["MoviePreview"];
            Movie movie = (Movie)values["Movie"];
            bool condition1 = false;
            bool condition2 = false;

            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO TBL_FAVOURITES (PersonalRating,Notes,imdbId,Title,Year,Genre,Poster) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", DatabaseConnection.connection());
                command.Parameters.AddWithValue("@p1", values["PersonalRating"]);
                command.Parameters.AddWithValue("@p2", values["Notes"]);
                command.Parameters.AddWithValue("@p3", moviePreview.imdbID);
                command.Parameters.AddWithValue("@p4", movie.Title);
                command.Parameters.AddWithValue("@p5", movie.Year);
                command.Parameters.AddWithValue("@p6", movie.Genre);
                command.Parameters.AddWithValue("@p7", movie.Poster);
                command.ExecuteNonQuery();
                DatabaseConnection.connection().Close();
                condition1 = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO TBL_MOVIE (Poster,Title,Rated,Year,Released,Genre,Director,Type,Language,Country,Awards,Production,MetaScore,imdbRating,imdbVotes,Website,Plot,Actors,Writer,imdbId) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,p20)", DatabaseConnection.connection());
                command.Parameters.AddWithValue("@p1", movie.Poster);
                command.Parameters.AddWithValue("@p2", movie.Title);
                command.Parameters.AddWithValue("@p3", movie.Rated);
                command.Parameters.AddWithValue("@p4", movie.Year);
                command.Parameters.AddWithValue("@p5", movie.Released);
                command.Parameters.AddWithValue("@p6", movie.Genre);
                command.Parameters.AddWithValue("@p7", movie.Director);
                command.Parameters.AddWithValue("@p8", movie.Type);
                command.Parameters.AddWithValue("@p9", movie.Language);
                command.Parameters.AddWithValue("@p10", movie.Country);
                command.Parameters.AddWithValue("@p11", movie.Awards);
                command.Parameters.AddWithValue("@p12", movie.Production);
                command.Parameters.AddWithValue("@p13", movie.Metascore);
                command.Parameters.AddWithValue("@p14", movie.imdbRating);
                command.Parameters.AddWithValue("@p15", movie.imdbVotes);
                command.Parameters.AddWithValue("@p16", movie.Website);
                command.Parameters.AddWithValue("@p17", movie.Plot);
                command.Parameters.AddWithValue("@p18", movie.Actors);
                command.Parameters.AddWithValue("@p19", movie.Writer);
                command.Parameters.AddWithValue("@p20", movie.imdbID);
                command.ExecuteNonQuery();
                DatabaseConnection.connection().Close();
                condition2 = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            if (condition1&&condition2)
            {
                MessageBox.Show("Succesfully Saved To Your Favourites", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void AddWatchlist(IDictionary<string, object> values)
        {

            MoviePreview movie = (MoviePreview)values["Movie"];

            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO TBL_WATCHLIST (Date,Notes,imdbId) VALUES (@p1,@p2,@p3)", DatabaseConnection.connection());
                command.Parameters.AddWithValue("@p1", values["WatchListDate"]);
                command.Parameters.AddWithValue("@p2", values["WatchListNotes"]);
                command.Parameters.AddWithValue("@p3", movie.imdbID);
                command.ExecuteNonQuery();
                DatabaseConnection.connection().Close();
                MessageBox.Show("Succesfully Saved To Your Watch List", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                if (e.HResult == -2146232060)
                {
                    MessageBox.Show("You Have Already Saved It");
                    MessageBox.Show(e.Message);
                }
                else
                {
                    MessageBox.Show(e.Message);
                }
            } 

            
        }

        public static void DeleteOneFavourite(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM TBL_FAVOURITES WHERE ID=@p1", DatabaseConnection.connection());
            command.Parameters.AddWithValue("@p1", id);
            command.ExecuteNonQuery();
            DatabaseConnection.connection().Close();
            MessageBox.Show("Successfully Deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void DeleteOneWatchList(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM TBL_WATCHLIST WHERE ID=@p1", DatabaseConnection.connection());
            command.Parameters.AddWithValue("@p1", id);
            command.ExecuteNonQuery();
            DatabaseConnection.connection().Close();
            MessageBox.Show("Successfully Deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static Movie GetMovieById(string id)
        {
            Movie movie = new Movie();
            SqlCommand sqlCommand = new SqlCommand($"Select * From TBL_FAVOURITES Where MovieId = {id}", DatabaseConnection.connection());
            SqlDataReader reader= sqlCommand.ExecuteReader();

            

            DatabaseConnection.connection().Close();
            return movie;
        }

        public static DataTable GetFavourites()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From TBL_FAVOURITES", DatabaseConnection.connection());
            sqlDataAdapter.Fill(dataTable);
            return dataTable;

        }


    }
}
