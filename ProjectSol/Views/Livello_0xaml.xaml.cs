using ProjectSol.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using Brushes = System.Drawing.Brushes;


namespace ProjectSol.Views
{

    public partial class Livello_0xaml : Window
    {
        static ObservableCollection<InteropBitmap> Animationsclass = new ObservableCollection<InteropBitmap>();
        static bool FlagForAnimation = false;
        Animations objAnimation = new Animations();
        public Livello_0xaml(string H, string W, string Difficolta, string Lingua)
        {
            this.Width = int.Parse(W);
            this.Height = int.Parse(H);
            InitializeComponent();
        }


        private void InviaMessaggio_Click(object sender, RoutedEventArgs e)
        {
            //people.Add(new Person(Messaggio.Text, "Smith", 32));
            //Messaggio.Text = "";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GenerateThred();
        }

        private async void GenerateThred()
        {
            await Task.Run(() =>
            {
                GenerateThredForAnimation();
            });

        }


        private async void GenerateThredForAnimation()
        {
            for (;;)
            {
                await Task.Delay(800);
                await Task.Run(() =>
                {
                    AnimationManager(null, null);
                });
            }
        }

        private void AnimationManager(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //AnimationFrame.Source = objAnimation.Animation;
            Bitmap DRS = new Bitmap(500, 500);
            Graphics graP = Graphics.FromImage(DRS);
            graP.FillEllipse(Brushes.Yellow, 100F, 100F, 100, 50F);

            this.Dispatcher.Invoke(() =>
            {
                AnimationFrame.Source = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(

                  DRS.GetHbitmap(),
                 IntPtr.Zero,
                 System.Windows.Int32Rect.Empty,
                 BitmapSizeOptions.FromWidthAndHeight(500, 500));
            });
        }

        private void AnimationFrame_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
