using Xamarin.Forms;
using XamarinFormsHello.ViewModels;

namespace XamarinFormsHello.Views
{
    public partial class MainView : ContentPage
    {
        private object Parameter { get; set; }

        public MainView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;
            // BindingContext = App.Locator.MainViewModel;
            BindingContext = new MainViewModel();
        }

        protected override void OnAppearing()
        {
            //base.OnAppearing();
            var viewModel = BindingContext as MainViewModel;
            //if (viewModel != null) viewModel.OnAppearing(Parameter);
        }

        protected override void OnDisappearing()
        {
            //base.OnDisappearing();
            var viewModel = BindingContext as MainViewModel;
            //if (viewModel != null) viewModel.OnDisappearing(Parameter);
        }
    }
}