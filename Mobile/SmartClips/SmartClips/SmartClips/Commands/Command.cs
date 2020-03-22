using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SmartClips.Commands
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action<object> CanExecuteMethod;
        Func<object, bool> ExecuteMethod;

        public Command(Action<object> CanExecuteMethod, Func<object, bool> ExecuteMethod)
        {
            this.CanExecuteMethod = CanExecuteMethod;
            this.ExecuteMethod = ExecuteMethod;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ExecuteMethod(parameter);
        }
    }
}
