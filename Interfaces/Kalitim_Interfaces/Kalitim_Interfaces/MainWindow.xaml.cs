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

namespace Kalitim_Interfaces
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>;
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Bisiklet bisiklet = new Bisiklet();
            bisiklet._model = "4x4;";
            bisiklet._adres = "İzmir";
            bisiklet._hiz = 15;
            bisiklet._marka = "Bisan";

            MessageBox.Show("Bisiklet Özellikleri : \n"+ bisiklet._model+"\n"+ bisiklet._adres+"\n"+ bisiklet._hiz.ToString() +"\n"+ bisiklet._marka);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MotorSiklet Motor = new MotorSiklet();
            Motor._IAdres = "Manisa";
            Motor._IHiz = 100;
            Motor._IMarka = "kawasaki";
            Motor._IRenk = "Pembe";
            Motor.Model = "1020x";
            MessageBox.Show("Motorsiklet Özellikleri : \n" + Motor.Model + "\n" + Motor._IRenk + "\n" + Motor._IMarka + "\n" + Motor._IHiz.ToString()+"\n"+ Motor._IAdres);

        }
    }
}
