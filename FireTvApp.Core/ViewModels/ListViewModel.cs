using System;
using System.Threading.Tasks;
using System.Windows.Input;
using FireTvApp.Core.Models;
using FireTvApp.Core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace FireTvApp.Core.ViewModels
{
    public class ListViewModel : MvxViewModel
    {
        readonly IPopulateListService _popList;

        public ListViewModel(IPopulateListService popList)
        {
            _popList = popList;
            CreateListMethod();
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            Title = "Homepage";
        }

        string _Title;
        public string Title
        {
            get { return _Title; }
            set { SetProperty(ref _Title, value); }
        }

        private MvxObservableCollection<Movie> _MovieList;
        public MvxObservableCollection<Movie> MovieList
        {
            get { return _MovieList; }
            set { _MovieList = value; RaisePropertyChanged(() => MovieList); }
        }

        public ICommand Save
        {
            get
            {
                return new MvxCommand(() => Console.WriteLine("Hello"));
            }
        }

        async Task<bool> CreateListMethod()
        {
            MovieList = _popList.GetMovieList();

            return true;
        }
    }
}
