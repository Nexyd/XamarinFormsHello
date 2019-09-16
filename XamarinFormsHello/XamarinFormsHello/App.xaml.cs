using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsHello.ViewModels.Base;
using XamarinFormsHello.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinFormsHello
{
    public partial class App : Application
    {
        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator
        {
            get { return _locator ?? new ViewModelLocator(); }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new MainView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
