using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectSol.Views
{
    /// <summary>
    /// Logica di interazione per Livello_0xaml.xaml
    /// </summary>
    public partial class Livello_0xaml : Window
    {
        public Livello_0xaml(string H, string W, string Difficolta,string Lingua)
        {
            this.Width = int.Parse(W);
            this.Height = int.Parse(H);

            InitializeComponent();
        }
    }
}
