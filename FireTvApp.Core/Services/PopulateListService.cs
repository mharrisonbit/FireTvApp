using System;
using FireTvApp.Core.Models;
using MvvmCross.ViewModels;

namespace FireTvApp.Core.Services
{
    public class PopulateListService : IPopulateListService
    {
        public MvxObservableCollection<Movie> GetMovieList()
        {
            Console.WriteLine("text");

            MvxObservableCollection<Movie> movies = new MvxObservableCollection<Movie>();

            for (int i = 0; i < 5; i++)
            {
                movies.Add(new Movie
                {
                    Rating = "R",
                    Title = $"Movie {i}"
                });
            }
            return movies;
        }
    }
}
