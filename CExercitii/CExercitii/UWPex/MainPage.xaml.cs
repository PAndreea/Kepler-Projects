using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPex
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog(Ex1.message());
            await dialog.ShowAsync();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog(Ex2.message());
            await dialog.ShowAsync();
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog(Ex10.message());
            await dialog.ShowAsync();
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog(Ex3.message(textBox1.Text));
            await dialog.ShowAsync();
            
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog(Ex6.message(textBox2.Text));
            await dialog.ShowAsync();
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

            string x = textBox4.Text;
            string[] xArray = x.Split(',');
            temp = xArray.ToList();

            temp = Ex9.exercitiu(bton, textBox3.Text, temp);
            string[] tempArray = temp.ToArray();
            string tempFull = string.Join(",", tempArray);
            textBox4.Text = tempFull;
        }
    }

    public class Ex1
    {
        public static string message()
        {
            return "Hey!Ce faci? :)";
        }
    }

    public class Ex2
    {
        public static string message()
        {
            var name = "Steve";
            var prop = "Hei,John!";
            return $"Hello {name}!\n" + $"{prop} How are you?";
        }
    }

    public class Ex10
    {
        public static string message()
        {
            var lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            foreach (var x in lista)
            {
                sum += x;
            }
            return "\nSuma este: " + sum;
        }
    }

    public class Ex3
    {
        public static string message(string text)
        {
            string one = "Hello ";
            string two = "Martha!";
            string combined = one + two;

            if (text == "loud")
            {
                combined = combined.ToUpper();

            }
            else if (text == "quiet")
            {
                combined = combined.ToLower();

            }
            return combined;
        }
    }

    public class Ex6
    {
        public static string message(string hour)
        {
            var hour2 = int.Parse(hour);
            if ((hour2 >= 6) && (hour2 <= 10))
                return "Good Morning";
            if ((hour2 >= 11) && (hour2 <= 19))
                return "Good Afternoon";
            if ((hour2 >= 20) && (hour2 <= 22))
                return "Good Evening";
            if (((hour2 >= 22) && (hour2 <= 23)) || ((hour2 >= 0) && (hour2 <= 5)))
                return "Good Night";
            return "Ora invalida.";
        }
    }

    public class Ex9
    {
        public static List<string> exercitiu(string text, string text2, List<string> colors)
        {

            if (colors[0] == "")
                colors = new List<string>();

            if (text == "+")
            {
                colors.Add(text2);
            }
            else if (text == "-")
            {
                if (colors.Any())
                    colors.Remove(text2);
            }
            else if (text == "--")
            {
                colors.Clear();
            }

            return colors;

        }
    }
}
