using Autofac;

namespace XamarinFormsHello.ViewModels.Base
{
    public class ViewModelLocator
    {
        private static IContainer _container;

        public ViewModelLocator()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<MainViewModel>();

            if (_container != null)
                _container.Dispose();

            _container = builder.Build();
        }

        public MainViewModel MainViewModel
        {
            get { return _container.Resolve<MainViewModel>(); }
        }
    }
}