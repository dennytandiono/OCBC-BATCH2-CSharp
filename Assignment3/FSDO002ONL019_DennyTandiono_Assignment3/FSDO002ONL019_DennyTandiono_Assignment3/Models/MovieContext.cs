using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDO002ONL019_DennyTandiono_Assignment3.Models
{
    public class MovieContext
    {
        public string ConnectionString { get; set; }

        public MovieContext(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MovieItem> AddMovie(MovieItem data)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO movies(MovieName, Genre, Duration,ReleaseDate) VALUES(@movieName, @genre, @duration, @releaseDate)", conn);

                cmd.Parameters.AddWithValue("@movieName", data.movieName);
                cmd.Parameters.AddWithValue("@genre", data.genre);
                cmd.Parameters.AddWithValue("@duration", data.duration);
                cmd.Parameters.AddWithValue("@releaseDate", data.releaseDate);

                cmd.ExecuteNonQuery();
                var Id = cmd.LastInsertedId;
                conn.Close();
                return GetMovie(Id.ToString());
            }
        }

        public List<MovieItem> UpdateMovie(MovieItem data)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE movies SET MovieName = @movieName, " +
                                                    "Genre = @genre, " +
                                                    "Duration = @duration, " +
                                                    "ReleaseDate = @releaseDate " +
                                                    "WHERE Id = @id", conn);

                cmd.Parameters.AddWithValue("@id", data.id);
                cmd.Parameters.AddWithValue("@movieName", data.movieName);
                cmd.Parameters.AddWithValue("@genre", data.genre);
                cmd.Parameters.AddWithValue("@duration", data.duration);
                cmd.Parameters.AddWithValue("@releaseDate", data.releaseDate);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return list;
        }

        public List<MovieItem> DeleteMovie(string id)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM movies WHERE id= @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("Id"),
                            movieName = reader.GetString("MovieName"),
                            genre = reader.GetString("Genre"),
                            duration = reader.GetString("Duration"),
                            releaseDate = reader.GetDateTime("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> GetAllMovies()
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movies", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("Id"),
                            movieName = reader.GetString("MovieName"),
                            genre = reader.GetString("Genre"),
                            duration = reader.GetString("Duration"),
                            releaseDate = reader.GetDateTime("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }

        public List<MovieItem> GetMovie(string id)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movies WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("Id"),
                            movieName = reader.GetString("MovieName"),
                            genre = reader.GetString("Genre"),
                            duration = reader.GetString("Duration"),
                            releaseDate = reader.GetDateTime("ReleaseDate")
                        });
                    }
                }
            }
            return list;
        }
    }
}
