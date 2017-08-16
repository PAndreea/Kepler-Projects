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
using CExercitii;


namespace WpfAppEx
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Ex10.message());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Ex1.message());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Ex2.message());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Ex3.message(textbox1.Text));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Ex6.message(textbox2.Text));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string bton = "";
            if (radioButton1.IsChecked == true)
            {
                bton = "+";
            }
            if (radioButton2.IsChecked == true)
            {
                bton = "-";
            }
            if (radioButton3.IsChecked == true)
            {
                bton = "--";
            }

            List<string> temp;

            string x = textbox4.Text;
            string[] xArray = x.Split(',');
            temp = xArray.ToList();

            temp = Ex9.exercitiu(bton, textbox3.Text, temp);
            string[] tempArray = temp.ToArray();
            string tempFull = string.Join(",", tempArray);
            textbox4.Text = tempFull;
        }

        private void buton_Click(object sender, RoutedEventArgs e)
        {
            windowex1 win = new windowex1(Ex1.message());
            win.Show();
        }
    }
}
