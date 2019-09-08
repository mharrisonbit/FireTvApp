using FireTvApp.Core.Services;
using FireTvApp.Core.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;

namespace FireTvApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IPopulateListService, PopulateListService>();

            RegisterAppStart<ListViewModel>();
        }
    }
}
