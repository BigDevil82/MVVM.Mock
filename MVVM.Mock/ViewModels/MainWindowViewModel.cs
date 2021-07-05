using MVVM.Mock.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Mock.ViewModels
{
    class MainWindowViewModel:NotificationObject
    {
        private string _input;
        public string Input
        {
            get { return _input; }
            set { _input = value; this.RaisePropertyChanged("Input"); }
        }


        private string _pattern;
        public string Pattern
        {
            get { return _pattern; }
            set { _pattern = value; this.RaisePropertyChanged("Pattern"); }
        }

        private string _result;
        public string Result
        {
            get { return _result; }
            set { _result = value; this.RaisePropertyChanged("Result"); }
        }

        public DelegateCommand ExecuteAdd;
        public void Add(object parameter)
        {
            this.Result = this.Input + this.Pattern;
        }

        public MainWindowViewModel()
        {
            ExecuteAdd = new DelegateCommand();
            ExecuteAdd.ExecuteAction = new Action<object>(this.Add);
        }


    }
}
