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

namespace Kapsulleme
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

        private void btn_yazdir_Click(object sender, RoutedEventArgs e)
        {
            Insan insan = new Insan();
            insan.Adi = txt_name.Text;
            insan.Meslek = txt_meslek.Text;
            insan.Yas = Convert.ToInt32(txt_yas.Text);
            EkranaYaz(insan);
        }

        public void EkranaYaz(Insan insan)
        {
            if (insan._status)
            {
                MessageBox.Show("Adi :" + insan.Adi + "\n" + "Yaşi :" + insan.Yas.ToString() + "\n" + "Meslek :" + insan.Meslek);
            }
        }
    }
}
