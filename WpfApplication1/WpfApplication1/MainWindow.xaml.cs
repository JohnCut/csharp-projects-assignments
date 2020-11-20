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

namespace WpfApplication1
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


        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OEKbutton_Click(object sender, RoutedEventArgs e)
        {
            if (this.ONtextBox.Text != "" || this.ADtextBox.Text != "" || this.SAtextBox.Text != "" || this.AStextBox.Text != "" || this.ODtextBox.Text != "" || this.FItextBox.Text != "")
            {
                ONlistBox.Items.Add(this.ONtextBox.Text);
                this.ONtextBox.Focus();
                this.ONtextBox.Clear();
                ADlistBox.Items.Add(this.ADtextBox.Text);
                this.ADtextBox.Focus();
                this.ADtextBox.Clear();
                SAlistBox.Items.Add(this.SAtextBox.Text);
                this.SAtextBox.Focus();
                this.SAtextBox.Clear();
                ASlistBox.Items.Add(this.AStextBox.Text);
                this.AStextBox.Focus();
                this.AStextBox.Clear();
                ODlistBox.Items.Add(this.ODtextBox.Text);
                this.ODtextBox.Focus();
                this.ODtextBox.Clear();
                FIlistBox.Items.Add(this.FItextBox.Text);
                this.FItextBox.Focus();
                this.FItextBox.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen eklemek istediğiniz verileri giriniz.", "Hata", MessageBoxButton.OK);
                this.ONtextBox.Focus();
            }
        }

        private void ONlistbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ADlistBox.SelectedIndex = ONlistBox.SelectedIndex;
            SAlistBox.SelectedIndex = ONlistBox.SelectedIndex;
            ASlistBox.SelectedIndex = ONlistBox.SelectedIndex;
            ODlistBox.SelectedIndex = ONlistBox.SelectedIndex;
            FIlistBox.SelectedIndex = ONlistBox.SelectedIndex;
        }
        private void ADlistbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ONlistBox.SelectedItem = ADlistBox.SelectedItem;
        }

        private void GORbutton_Click(object sender, RoutedEventArgs e)
        {
            decimal AS_sum = 0;
            decimal AS_ave = 0;

            for (int i = 0; i < ASlistBox.Items.Count; i++)
            {
                AS_sum += Convert.ToDecimal(ASlistBox.Items[i].ToString());
                AS_ave = Convert.ToDecimal((AS_sum / (ASlistBox.Items.Count)).ToString());
            }

            decimal OD_sum = 0;
            decimal OD_ave = 0;

            for (int i = 0; i < ODlistBox.Items.Count; i++)
            {
                OD_sum += Convert.ToDecimal(ODlistBox.Items[i].ToString());
                OD_ave = Convert.ToDecimal((OD_sum / (ASlistBox.Items.Count)).ToString());
            }

            decimal FI_sum = 0;
            decimal FI_ave = 0;

            for (int i = 0; i < FIlistBox.Items.Count; i++)
            {
                FI_sum += Convert.ToDecimal(FIlistBox.Items[i].ToString());
                FI_ave = Convert.ToDecimal((FI_sum / (ASlistBox.Items.Count)).ToString());
            }

            GORlabel.Content = Convert.ToString((AS_ave + OD_ave + FI_ave) / 3);
        }
    }
}
