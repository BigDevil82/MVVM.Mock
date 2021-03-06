using System;
using System.Windows.Input;

namespace MVVM.Mock.Commands
{
    public class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public Action<object> ExecuteAction { get; set; }
        public Func<object, bool> CanExecuteFunc { get; set; }

        public bool CanExecute(object parameter)
        {
            if (this.CanExecuteFunc == null)
            {
                return true;
            }
            return this.CanExecuteFunc(parameter);
        }

        public void Execute(object parameter)
        {
            if (this.ExecuteAction == null)
            {
                return;
            }

            this.ExecuteAction(parameter);
        }
    }
}
