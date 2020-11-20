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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonTmm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("merhaba " + tbAd.Text);
        }

        private void buttonEkle_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add(tbAd.Text);
        }

        private void buttonCikar_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void buttonSecili__Click(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked == true) 
            {
                MessageBox.Show("Seçili");
            }
            else
            {
                MessageBox.Show("Seçili değil");
            }
        }

        private void buttonSagaGec_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(listBox.SelectedItem);
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void buttonSolaGec_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
