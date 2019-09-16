using System.Windows.Input;
using XamarinFormsHello.ViewModels.Base;

namespace XamarinFormsHello.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private int counter;
        private string _message;
        private DelegateCommand btnCommand;

        public MainViewModel()
        {
            counter = 0;
            Message = "Hola Xamarin.Forms MVVM!";
	    }

        public string Message
        {
            get { return string.Format("Botón pulsado {0} veces", counter); }
            set {
                _message = value;
			    RaisePropertyChanged("Message");
		    }
        }

        public ICommand BtnCommand
        {
            get {
                return btnCommand = btnCommand ?? 
                    new DelegateCommand(
                    BtnCommandExecute, null);
            }
        }

        private void BtnCommandExecute()
        {
            counter++;
            RaisePropertyChanged("Message");
        }
    }
}