using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Doga
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Fuvar> fuvarok;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFaljBe_Click(object sender, RoutedEventArgs e)
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FileBeolvas(openFileDialog.FileName);
            }
        }
        public void FileBeolvas(string Filename)
        {
            fuvarok = new List<Fuvar>();
            foreach (var item in File.ReadAllLines(Filename))
            {
                int taxiID = int.Parse(item.Split(';')[0]);
                DateTime taxiIndulas = DateTime.Parse(item.Split(';')[1]);
                int taxiIdotartam = int.Parse(item.Split(';')[2]);
                double taxiTavolsag = double.Parse(item.Split(';')[3]);
                double taxiVetelDij = double.Parse(item.Split(';')[4]);
                double taxiBorravalo = double.Parse(item.Split(';')[5]);
                string taxiFizetesiModja = item.Split(';')[6];
                fuvarok.Add(new Fuvar(taxiID, taxiIndulas, taxiIdotartam, taxiTavolsag, taxiVetelDij, taxiBorravalo, taxiFizetesiModja));
            }
        }

        private void btnSzamol_Click(object sender, RoutedEventArgs e)
        {
            lblCount.Content ="3.feladat: "+ fuvarok.Count();
        }

        private void btnbevetel_Click(object sender, RoutedEventArgs e)
        {
            //Tanár úrat szeretném kérni hogy ezt is vegye figyelembe!
            //lblBevetel.Content ="4.feladat: " +fuvarok.Sum(x => x.ID1 == 6185);
        }

        private void btnFizetesiMod_Click(object sender, RoutedEventArgs e)
        {
            
            lbFizetésiModok.Items.Add(fuvarok.GroupBy(x => x.FizetesModja).Count());
        }

        private void btnMegtettTav_Click(object sender, RoutedEventArgs e)
        {
            lblMegtettTav.Content="6.feladat: "+ Math.Round(fuvarok.Sum(x => x.Tavolsag * 1.6),2);
        }

        private void btnLeghosszabb_Click(object sender, RoutedEventArgs e)
        {
            //Tanár úrat szeretném kérni hogy ezt is vegye figyelembe!
           //lbLeghosszabb.Items.Add(fuvarok.MaxBy(x =>x.Idotartam));
            
        }
    }
}
