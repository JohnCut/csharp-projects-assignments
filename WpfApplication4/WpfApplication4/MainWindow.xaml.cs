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
using System.Data.OleDb;
using System.Data;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =|DataDirectory|\\GaleriVeriTabani.mdb");
        public MainWindow()
        {
            InitializeComponent();
        }
        public void veriCek()
        {
            try
            {
                connection.Open();

                DataSet table = new DataSet();//DataSet nesnesini oluştur
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM GaleriTabani", connection);//DataAdapter nesnesini oluştur(sql ifadesini belirterek)
                da.Fill(table, "GaleriTabani");//Verileri veri tabanından DataSet içindeki "Çalışanlar" tablosuna yükle

                MainDGrid.ItemsSource = table.Tables["GaleriTabani"].DefaultView;//DataGrid bileşeninin veri kaynağı olarak DataSet'in tablolarından "Çalışanlar" tablosunu göster
                //MainDGrid.ItemsSource = kume.Tables["Çalışanlar"].DefaultView;

                connection.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void ekleButton_Click(object sender, RoutedEventArgs e)
        {

            connection.Open();//Bağlantıyı aç
                              /*
                               * SQL Cümlesini oluşturuyoruz. @ ile başlayan ifadeler birer parametredir. Bu parametrelere değerler 
                               * verebiliyoruz.
                               */
            string kod = "INSERT INTO GaleriTabani ( Plaka, Marka, Model, ModelYili, TescilTarihi, Renk, Kilometresi, HasarDurumu ) VALUES (@plaka, @marka, @model, @model_yili, @tescil_tarihi, @renk, @km, @hasar_durumu)";

            //SQL komutlarını/ifadelerini OleDbCommand kullanarak veritabanına gönderebiliyoruz.
            OleDbCommand komut = new OleDbCommand(kod, connection);

            //Daha önce tanımladığımız parametrelerin değerlerini ilgili bileşenden(TextBox) alarak SQL cümlesinin içine yerleşmesini sağlıyoruz
            komut.Parameters.AddWithValue("@plaka", plakaTb.Text);
            komut.Parameters.AddWithValue("@marka", markaTb.Text);
            komut.Parameters.AddWithValue("@model", modelTb.Text);
            komut.Parameters.AddWithValue("@model_yili", myiliTb.Text);
            komut.Parameters.AddWithValue("@tescil_tarihi", testarDp.Text);
            komut.Parameters.AddWithValue("@renk", renkCb.Text);
            komut.Parameters.AddWithValue("@km", kmTb.Text);
            komut.Parameters.AddWithValue("@hasar_durumu", hasarCb.Text);
            //INSERT,UPDATE ve DELETE sorguları için ExecuteNonQuery kullanıyoruz
            komut.ExecuteNonQuery();
            DataSet table = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM GaleriTabani", connection);
            da.Fill(table, "GaleriTabani");
            MainDGrid.ItemsSource = table.Tables["GaleriTabani"].DefaultView;
            //İşimiz bitince bağlantıyı kapatıyoruz
            connection.Close();

            MessageBox.Show("Kayıt Oluşturuldu");
            plakaTb.Clear();
            markaTb.Clear();
            modelTb.Clear();
            myiliTb.Clear();
            //DatePicker resetleme yok.
            renkCb.Items.Clear();
            kmTb.Clear();
            hasarCb.Items.Clear();

        }
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            {
                veriCek();
            }

        }
        private void silButton_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Alan Temizlendi!");
            plakaTb.Clear();
            markaTb.Clear();
            modelTb.Clear();
            //DatePicker resetleme yok.
            renkCb.Items.Clear();
            kmTb.Clear();
            hasarCb.Items.Clear();

        }
        private void MainDGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var secili = (DataRowView)MainDGrid.SelectedItem;
            plakaTb.Text = secili[0].ToString();
            markaTb.Text = secili[1].ToString();
            modelTb.Text = secili[2].ToString();
            myiliTb.Text = secili[3].ToString();
            testarDp.Text = secili[4].ToString();
            renkCb.Text = secili[5].ToString();
            kmTb.Text = secili[6].ToString();
            hasarCb.Text = secili[7].ToString();


        }
        private void guncelButton_Click(object sender, RoutedEventArgs e)
        {

            connection.Open();
            String kod = "UPDATE GaleriTabani SET Marka=@marka, Model=@model, Renk=@renk, Kilometresi=@km, TescilTarihi=@tescil_tarihi, HasarDurumu=@hasar_durumu, ModelYili=@model_yili WHERE Plaka=@plaka";
            OleDbCommand komut = new OleDbCommand(kod, connection);

            komut.Parameters.AddWithValue("@marka", markaTb.Text);
            komut.Parameters.AddWithValue("@model", modelTb.Text);
            komut.Parameters.AddWithValue("@renk", renkCb.Text);
            komut.Parameters.AddWithValue("@km", kmTb.Text);
            komut.Parameters.AddWithValue("@tescil_tarihi", testarDp.Text);
            komut.Parameters.AddWithValue("@hasar_durumu", hasarCb.Text);
            komut.Parameters.AddWithValue("@model_yili", myiliTb.Text);
            komut.Parameters.AddWithValue("@plaka", plakaTb.Text);

            komut.ExecuteNonQuery();

            connection.Close();
            veriCek();

        }

        private void aramaButton_Click(object sender, RoutedEventArgs e)
        {

            connection.Open();
            String kod = "SELECT * FROM GaleriTabani WHERE Plaka LIKE '" + aramaTb.Text + "%'";
            //MessageBox.Show(sql);
            //OleDbCommand komut = new OleDbCommand("SELECT * FROM Çalışanlar WHERE Adı LIKE '@adi%'", baglanti);
            //komut.Parameters.AddWithValue("@adi", tbSorgula.Text);
            DataSet table = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(kod, connection);

            da.Fill(table, "GaleriTabani");
            MainDGrid.ItemsSource = table.Tables["GaleriTabani"].DefaultView;

            connection.Close();

        }

        private void renkCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
