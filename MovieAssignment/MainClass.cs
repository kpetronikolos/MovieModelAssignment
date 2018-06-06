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
            var i = 0;

            List<Movie> Movies = new List<Movie>();

            var review = new Dictionary<int, string>() { { 10, "Perfect" }, { 6, "Good" }, { 9, "Very Good" } };
            var review0 = new Dictionary<int, string>() { { 10, "Perfect" }, { 8, "Very Good" } };
            var review1 = new Dictionary<int, string>() { { 10, "Perfect" }, { 6, "Good" }, { 8, "Very Good" }, { 9, "Very Good" } };
            var review2 = new Dictionary<int, string>() { { 10, "Perfect" }, { 5, "Good" }, { 7, "Very Good" }, { 8, "Very Good" } };
            var review3 = new Dictionary<int, string>() { { 10, "Perfect" }, { 9, "Very Good" }, { 8, "Very Good" } };
            var review4 = new Dictionary<int, string>() { { 7, "Good" }, { 5, "Good" } };
            var review5 = new Dictionary<int, string>() { { 7, "Good" }, { 6, "Good" }, { 9, "Very Good" } };
            var review6 = new Dictionary<int, string>() { { 10, "Perfect" } };
            var review7 = new Dictionary<int, string>() { { 10, "Perfect" }, { 9, "Very Good" } };
            var review8 = new Dictionary<int, string>() { { 10, "Perfect" }, { 9, "Very Good" }, { 8, "Very Good" }, { 7, "Very Good" } };
            var review9 = new Dictionary<int, string>() { { 6, "Good" }, { 5, "Good" }, { 7, "Very Good" } };
            var review10 = new Dictionary<int, string>() { { 8, "Very Good" }, { 6, "Good" } };
            var review11 = new Dictionary<int, string>() { { 5, "Good" }, { 6, "Good" }, { 9, "Very Good" } };


            Movies.Add(new Movie() { Title = "Rambo I", Rating = review.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = review });
            Movies.Add(new Movie() { Title = "Rambo II", Rating = review1.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = review1 });
            Movies.Add(new Movie() { Title = "Rambo III", Rating = review2.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = review2 });
            Movies.Add(new Movie() { Title = "Rambo IV", Rating = review3.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = review3 });
            Movies.Add(new Movie() { Title = "Rocky I", Rating = review4.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = review4 });
            Movies.Add(new Movie() { Title = "Rocky II", Rating = review5.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = review5 });
            Movies.Add(new Movie() { Title = "Rocky III", Rating = review6.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = review6 });
            Movies.Add(new Movie() { Title = "Rocky IV", Rating = review7.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = review7 });
            Movies.Add(new Movie() { Title = "Over the Top", Rating = review8.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = review8 });
            Movies.Add(new Movie() { Title = "Cobra", Rating = review9.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = review9 });
            Movies.Add(new Movie() { Title = "Lock Up", Rating = review10.Average(x => x.Key), Actor = "Stallone", Money = 1000, Review = review10 });
            Movies.Add(new Movie() { Title = "Fargo", Rating = review11.Average(x => x.Key), Actor = "William H. Macy", Money = 1000, Review = review11 });
            Movies.Add(new Movie() { Title = "The Wraith", Rating = review0.Average(x => x.Key), Actor = "Charlie Seen", Money = 1000, Review = review0 });
            Movies.Add(new Movie() { Title = "Top Gun", Rating = review1.Average(x => x.Key), Actor = "Tom Cruise", Money = 1000, Review = review1 });
            Movies.Add(new Movie() { Title = "Thrashin'", Rating = review2.Average(x => x.Key), Actor = "Josh Brolin", Money = 1000, Review = review2 });

            Movies.Sort((x, y) => y.Rating.CompareTo(x.Rating));

            foreach (Movie m in Movies)
            {
                i += 1;
                if (i > 10)
                {
                    break;
                }

                Console.WriteLine("Movie: " + m.Title);
                Console.WriteLine("Rating: " + m.Rating);
            }

        }
    }
}
