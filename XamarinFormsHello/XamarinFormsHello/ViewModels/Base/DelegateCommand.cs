﻿using System;
using System.Windows.Input;

namespace XamarinFormsHello.ViewModels.Base
{
    public class DelegateCommand : ICommand
    {
        private Action _execute;
        private Func<bool> _canExecute;

        public DelegateCommand(
            Action execute, Func<bool> canExecute)
        {
            _execute = execute;
		    _canExecute = canExecute;
	    }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;

		    return _canExecute();
	    }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            //if (_execute != null) _execute();
            _execute?.Invoke();
        }

        public void RaiseCanExecuteChanged()
        {
            //var handle = CanExecuteChanged;
            //if (handle != null)
            //    handle(this, new EventArgs());
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
