using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using FireTvApp.Core.ViewModels;

namespace FireTvApp.Droid.Views
{
    [Activity(Label = "FireTv App", MainLauncher = true)]
    public class ListView : MvxActivity<ListViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ListView);
        }
    }
}
