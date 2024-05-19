using ProjectSol.Classes;
using ProjectSol.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ProjectSol
{
    /// <summary>
    /// Logica di interazione per Window1.xaml
    /// </summary>
    public partial class Impostazione : Window
    {
        public Impostazione()
        {
            InitializeComponent();

            List<string> ListaRisoluzioni = new List<string>();
            List<string> ListaDifficolta = new List<string>();
            List<string> ListaOfLingue = new List<string>();
            RisoluzioniClasse risoluzioniClasse = new RisoluzioniClasse();


            // Ciclo le proprietà di un oggetto per ciclare i valori dentro un oggetto 
            ListaRisoluzioni.Add("Nessuna Risoluzione selezionata");
            Type myType = risoluzioniClasse.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
            foreach (PropertyInfo prop in props)
            {
                ListaRisoluzioni.Add(prop.GetValue(risoluzioniClasse, null).ToString());
            }
            //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::


            ListaDifficolta.Add("Facile");
            ListaDifficolta.Add("Normale");
            ListaDifficolta.Add("Difficile");
            ListaOfLingue.AddRange(new List<string>{ "Italiano", "Inglese", "Zingarese"});
            Risoluzioni.ItemsSource = ListaRisoluzioni;
            Difficolta.ItemsSource = ListaDifficolta;
            Lingua.ItemsSource = ListaOfLingue;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Livello_0xaml livello_0Xaml = new Livello_0xaml(Risoluzioni.SelectedItem.ToString().Split("-")[1], Risoluzioni.SelectedItem.ToString().Split("-")[0], Difficolta.SelectedItem.ToString(), Lingua.SelectedItem.ToString());
            livello_0Xaml.Show();
            this.Close();
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }
        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
