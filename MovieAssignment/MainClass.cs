using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAssignment
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<Movie> Movies = new List<Movie>();

            var rating = new Dictionary<int, string>() { { 10, "Perfect" }, { 6, "Good" }, { 9, "Very Good" } };
            var rating0 = new Dictionary<int, string>() { { 10, "Perfect" }, { 8, "Very Good" } };
            var rating1 = new Dictionary<int, string>() { { 10, "Perfect" }, { 6, "Good" }, { 8, "Very Good" }, { 9, "Very Good" } };
            var rating2 = new Dictionary<int, string>() { { 10, "Perfect" }, { 5, "Good" }, { 7, "Very Good" }, { 8, "Very Good" } };
            var rating3 = new Dictionary<int, string>() { { 10, "Perfect" }, { 9, "Very Good" }, { 8, "Very Good" } };
            var rating4 = new Dictionary<int, string>() { { 7, "Good" }, { 5, "Good" } };
            var rating5 = new Dictionary<int, string>() { { 7, "Good" }, { 6, "Good" }, { 9, "Very Good" } };
            var rating6 = new Dictionary<int, string>() { { 10, "Perfect" } };
            var rating7 = new Dictionary<int, string>() { { 10, "Perfect" }, { 9, "Very Good" } };
            var rating8 = new Dictionary<int, string>() { { 10, "Perfect" }, { 9, "Very Good" }, { 8, "Very Good" }, { 7, "Very Good" } };
            var rating9 = new Dictionary<int, string>() { { 6, "Good" }, { 5, "Good" }, { 7, "Very Good" } };
            var rating10 = new Dictionary<int, string>() { { 8, "Very Good" }, { 6, "Good" } };
            var rating11 = new Dictionary<int, string>() { { 5, "Good" }, { 6, "Good" }, { 9, "Very Good" } };


            Movies.Add(new Movie() { Title = "Rambo I", Rating = rating.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = rating });
            Movies.Add(new Movie() { Title = "Rambo II", Rating = rating1.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = rating1 });
            Movies.Add(new Movie() { Title = "Rambo III", Rating = rating2.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = rating2 });
            Movies.Add(new Movie() { Title = "Rambo IV", Rating = rating3.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = rating3 });
            Movies.Add(new Movie() { Title = "Rocky I", Rating = rating4.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = rating4 });
            Movies.Add(new Movie() { Title = "Rocky II", Rating = rating5.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = rating5 });
            Movies.Add(new Movie() { Title = "Rocky III", Rating = rating6.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = rating6 });
            Movies.Add(new Movie() { Title = "Rocky IV", Rating = rating7.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = rating7 });
            Movies.Add(new Movie() { Title = "Over the Top", Rating = rating8.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = rating8 });
            Movies.Add(new Movie() { Title = "Cobra", Rating = rating9.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = rating9 });
            Movies.Add(new Movie() { Title = "Lock Up", Rating = rating10.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = rating10 });
            Movies.Add(new Movie() { Title = "Fargo", Rating = rating11.Average(x => x.Key), Actor = "William H. Macy", Money = 1000, Review = rating11 });
            Movies.Add(new Movie() { Title = "The Wraith", Rating = rating0.Average(x => x.Key), Actor = "Charlie Seen", Money = 1000, Review = rating0 });
            Movies.Add(new Movie() { Title = "Top Gun", Rating = rating1.Average(x => x.Key), Actor = "Tom Cruise", Money = 1000, Review = rating1 });
            Movies.Add(new Movie() { Title = "Thrashin'", Rating = rating2.Average(x => x.Key), Actor = "Josh Brolin", Money = 1000, Review = rating2 });


            foreach (Movie m in Movies)
            {
                Console.WriteLine("Movie: " + m.Title);
                Console.WriteLine("Rating: " + m.Rating);
            }

        }
    }
}
