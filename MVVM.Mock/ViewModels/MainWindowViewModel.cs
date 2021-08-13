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
        private double _input;
        public double Input
        {
            get { return _input; }
            set { _input = value; this.RaisePropertyChanged("Input"); }
        }


        private double _pattern;
        public double Pattern
        {
            get { return _pattern; }
            set { _pattern = value; this.RaisePropertyChanged("Pattern"); }
        }

        private double _result;
        public double Result
        {
            get { return _result; }
            set { _result = value; this.RaisePropertyChanged("Result"); }
        }


        //private double input1;

        //public double Input1
        //{
        //    get { return input1; }
        //    set
        //    {
        //        input1 = value;
        //        this.RaisePropertyChanged("Input1");
        //    }
        //}

        //private double input2;

        //public double Input2
        //{
        //    get { return input2; }
        //    set
        //    {
        //        input2 = value;
        //        this.RaisePropertyChanged("Input2");
        //    }
        //}

        //private double result;

        //public double Result
        //{
        //    get { return result; }
        //    set
        //    {
        //        result = value;
        //        this.RaisePropertyChanged("Result");
        //    }
        //}

        public DelegateCommand AddCommand { get; set; }

        public void Add(object parameter)
        {
            this.Result = this.Input + this.Pattern;
        }
        public MainWindowViewModel()
        {
            AddCommand = new DelegateCommand();
            AddCommand.ExecuteAction = new Action<object>(this.Add);
        }


    }
}
