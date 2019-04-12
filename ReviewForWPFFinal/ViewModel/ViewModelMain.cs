using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewForWPFFinal.Model;
using ReviewForFinalWPF.Helpers;
using System.Windows;

namespace ReviewForWPFFinal.ViewModel
{
    class ViewModelMain : INotifyPropertyChanged 
    {
        public RelayCommand exitCommand { get; set; }
        public RelayCommand addCommand { get; set; }
        public RelayCommand changeCommand { get; set; }
        private ObservableCollection<Square> Squares_;

        public ObservableCollection<Square> Squares
        {
            get { return Squares_; }
            set { Squares_ = value; }

        }

        public ViewModelMain()
        {
            Squares = new ObservableCollection<Square>();
            for(int i=0; i<10; i++)
            {
                Squares.Add(new Square());
            }
            setNumbers();
            exitCommand = new RelayCommand(exitC);
            addCommand = new RelayCommand(changeC);
            changeCommand = new RelayCommand(addC);
        }

        private int myIndex_;

        public int MyIndex
        {
            get { return myIndex_; }
            set
            {
                myIndex_ = value;
                RaisePropertyChanged("MyIndex");
            }

        }

        private void changeC(object obj)
        {
          //HAHA Dave Gay
          if(myIndex_ != -1)
            {
                int temp = myIndex_;
                Square s = Squares[temp];
                Squares.RemoveAt(temp);
                Squares.Insert(temp, new Square());
                setNumbers();
            }

        }

        private void addC(object obj)
        {
            Squares.Add(new Square());
            setNumbers();
        }

        private void exitC(object obj)
        {
            Application.Current.Shutdown();
        }

        private void setNumbers()
        {
            Red = Squares.Where(c => c.MyColor == "Red").Count();
            BlanchedAlmond = Squares.Where(c => c.MyColor == "BlanchedAlmond").Count();
            Aquamrine = Squares.Where(c => c.MyColor == "Aquamarine").Count();
            Yellow = Squares.Where(c => c.MyColor == "Yellow").Count();
            bisque = Squares.Where(c => c.MyColor == "Bisque").Count();

            cyan = Squares.Where(c => c.MyColor == "Cyan").Count();

        }

        private int red_;

        public int Red
        {
            get { return red_; }
            set
            {
                red_ = value;
                RaisePropertyChanged(nameof(Red));
            }
        }

        private int blanchedalmond_;

        public int BlanchedAlmond
        {
            get { return red_; }
            set
            {
                red_ = value;
                RaisePropertyChanged(nameof(Red));
            }
        }

        private int aquamarine_;

        public int Aquamrine
        {
            get { return red_; }
            set
            {
                red_ = value;
                RaisePropertyChanged(nameof(Red));
            }
        }
        private int yellow_;

        public int Yellow
        {
            get { return red_; }
            set
            {
                red_ = value;
                RaisePropertyChanged(nameof(Red));
            }
        }

        private int cyan_;

        public int cyan
        {
            get { return red_; }
            set
            {
                red_ = value;
                RaisePropertyChanged(nameof(Red));
            }
        }

        private int bisque_;

        public int bisque
        {
            get { return red_; }
            set
            {
                red_ = value;
                RaisePropertyChanged(nameof(Red));
            }
        }

        //basic ViewModelBase
        internal void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
