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
using Point = System.Drawing.Point;
using Rectangle = System.Drawing.Rectangle;


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
            Bitmap DRS = new Bitmap(1000, 1000);
            //Graphics graP = Graphics.FromImage(DRS);
            //g.FillEllipse(Brushes.Yellow, 100F, 100F, 100, 50F);
            //g.FillEllipse(Brushes.Yellow, 200F, 100F, 100, 50F);
            Graphics g = Graphics.FromImage(DRS);

            // Draw the body of the monster
            Rectangle body = new Rectangle(300, 150, 200, 300);
            g.FillRectangle(Brushes.DarkSlateGray, body);
            g.DrawRectangle(Pens.Black, body);

            // Draw the head of the monster
            Rectangle head = new Rectangle(350, 100, 100, 100);
            g.FillEllipse(Brushes.Gray, head);
            g.DrawEllipse(Pens.Black, head);

            // Draw the eyes of the monster
            Rectangle leftEye = new Rectangle(370, 130, 20, 20);
            Rectangle rightEye = new Rectangle(410, 130, 20, 20);
            g.FillEllipse(Brushes.Red, leftEye);
            g.FillEllipse(Brushes.Red, rightEye);
            g.DrawEllipse(Pens.Black, leftEye);
            g.DrawEllipse(Pens.Black, rightEye);

            // Draw the mouth of the monster
            Point[] mouthPoints = {
                new Point(370, 170),
                new Point(400, 190),
                new Point(430, 170)
            };
            g.DrawCurve(Pens.Black, mouthPoints);

            // Draw the armor on the body
            Rectangle armorPlate1 = new Rectangle(300, 250, 200, 30);
            Rectangle armorPlate2 = new Rectangle(300, 300, 200, 30);
            g.FillRectangle(Brushes.DarkSlateGray, armorPlate1);
            g.FillRectangle(Brushes.DarkSlateGray, armorPlate2);
            g.DrawRectangle(Pens.Black, armorPlate1);
            g.DrawRectangle(Pens.Black, armorPlate2);

            // Draw the arms of the monster
            Point[] leftArm = {
                new Point(300, 200),
                new Point(250, 250),
                new Point(250, 350),
                new Point(300, 300)
            };
            Point[] rightArm = {
                new Point(500, 200),
                new Point(550, 250),
                new Point(550, 350),
                new Point(500, 300)
            };
            g.FillPolygon(Brushes.DarkSlateGray, leftArm);
            g.FillPolygon(Brushes.DarkSlateGray, rightArm);
            g.DrawPolygon(Pens.Black, leftArm);
            g.DrawPolygon(Pens.Black, rightArm);

            // Draw the weapon
            Point[] weapon = {
                new Point(550, 250),
                new Point(600, 230),
                new Point(600, 350),
                new Point(550, 370)
            };
            g.FillPolygon(Brushes.Gray, weapon);
            g.DrawPolygon(Pens.Black, weapon);

            // Draw the legs of the monster
            Point[] leftLeg = {
                new Point(350, 450),
                new Point(330, 550),
                new Point(370, 550),
                new Point(390, 450)
            };
            Point[] rightLeg = {
                new Point(450, 450),
                new Point(430, 550),
                new Point(470, 550),
                new Point(490, 450)
            };
            g.FillPolygon(Brushes.DarkSlateGray, leftLeg);
            g.FillPolygon(Brushes.DarkSlateGray, rightLeg);
            g.DrawPolygon(Pens.Black, leftLeg);
            g.DrawPolygon(Pens.Black, rightLeg);


            this.Dispatcher.Invoke(() =>
            {
                AnimationFrame.Source = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                 
                  DRS.GetHbitmap(),
                 IntPtr.Zero,
                 System.Windows.Int32Rect.Empty,
                 BitmapSizeOptions.FromWidthAndHeight(1000, 1000));
            });
        }

        private void AnimationFrame_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
