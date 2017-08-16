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
using System.Windows.Shapes;

namespace WpfAppEx
{
    /// <summary>
    /// Interaction logic for windowex1.xaml
    /// </summary>
    public partial class windowex1 : Window
    {
        private string _text;
        public windowex1(string text)
        {
            InitializeComponent();
            _text = text;
            tb1.Text = _text;
        }
    }
}
