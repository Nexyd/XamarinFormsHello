//using Autofac;
//using System.ComponentModel;

//namespace XamarinFormsHello.ViewModels.Base
//{
//    class ViewModelLocator
//    {
//        private static IContainer _container;

//        public ViewModelLocator()
//        {
//            ContainerBuilder builder = new ContainerBuilder();

//            // View Models
//            builder.registerType<MainViewModel>();

//            if (_container != null)
//                _container.Dispose();

//            _container = builder.Build();
//        }

//        public MainViewModel MainViewModel {
//            get { return _container.Resolve<MainViewModel>(); }
//        }
//    }
//}
