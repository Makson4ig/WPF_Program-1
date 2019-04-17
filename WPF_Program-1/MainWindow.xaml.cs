using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPF_Program_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void TableAdd()
        {
            dGrid.Items.Add(new Item() {
                Izdelie = txtIzdelie.Text,
                SumViryhka = Convert.ToInt32(txtSumViryhka.Text),
                ZatrataProizvod = Convert.ToInt32(txtZatrataProizvod.Text),
                ZatrataRealiza = Convert.ToInt32(txtZatrataRealiza.Text),
                Sebestoimost = Convert.ToInt32(txtZatrataProizvod.Text) + Convert.ToInt32(txtZatrataRealiza.Text),
                SumVozvrat = Convert.ToInt32((Convert.ToInt32(txtZatrataProizvod.Text)- Convert.ToInt32(txtZatrataProizvod.Text) + Convert.ToInt32(txtZatrataRealiza.Text))/ (Convert.ToInt32(txtZatrataProizvod.Text) - Convert.ToInt32(txtZatrataProizvod.Text) + Convert.ToInt32(txtZatrataRealiza.Text)*100)) });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtSumViryhka.Text != "" && txtZatrataProizvod.Text != "" && txtZatrataRealiza.Text != "")
            {
                TableAdd();
            }
            else
            {
                MessageBox.Show("Поля пустые!", "Error");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dGrid.Items.Clear();
        }
    }

    class Item
    {
        public string Izdelie { get; set; }
        public int SumViryhka { get; set; }
        public int ZatrataProizvod { get; set; }
        public int ZatrataRealiza { get; set; }
        public int Sebestoimost { get; set; }
        public int SumVozvrat { get; set; }

    }


}
