using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinFormsHello.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            //PropertyChangedEventHandler handle = PropertyChanged;
            //if (handle != null) handle(this, new PropertyChangedEventArgs(propertyName));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}