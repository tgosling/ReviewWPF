using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewForWPFFinal.Model
{
    class Square : INotifyPropertyChanged
    {
        private string myColor_;

        public string MyColor
        {
            get { return myColor_; }
            set
            {
                myColor_ = value;
                RaisePropertyChanged("MyColor");
            }
        }

        private static Random sTheRand = null;

        public Square()
        {
            if(sTheRand == null)
            {
                sTheRand = new Random();
            }
            this.m_SetRandomColor();
        }

        private void m_SetRandomColor()
        {
            int theColor = sTheRand.Next(0, 5);
            switch(theColor)
            {
                case 0: MyColor = "Red"; break;
                case 1: MyColor = "BlanchedAlmond"; break;
                case 2: MyColor = "Aquamarine"; break;
                case 3: MyColor = "Yellow"; break;
                case 4: MyColor = "Bisque"; break;
                case 5: MyColor = "Cyan"; break;
                

            }
        }

      


        public override string ToString()
        {
            return MyColor;
        }

        //basic ViewModelBase
        internal void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
