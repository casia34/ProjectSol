using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace ProjectSol.Classes
{
    class Animations : INotifyPropertyChanged
    {
        //public Animations(InteropBitmap animation)
        //{
        //    Animation = animation;
        //}

        static private BitmapSource _Animation { get; set; }
        public BitmapSource Animation
        {
            get { return _Animation; }
            set
            {
                _Animation = value;
                OnPropertyChanged("Animation");
            }
        }
       
        //BitmapImage  _bitmapImage {  get; set; }
        //public BitmapImage bitmapImage
        //{
        //    get { return _bitmapImage; }
        //    set
        //    {
        //        _bitmapImage = value;
        //        OnPropertyChanged("bitmapImage");
        //    }
        //} 
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
