using FireTvApp.Core.Models;
using MvvmCross.ViewModels;

namespace FireTvApp.Core.Services
{
    public interface IPopulateListService
    {
        MvxObservableCollection<Movie> GetMovieList();
    }
}
