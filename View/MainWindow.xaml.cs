using Dagbog.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Dagbog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDeAndEn _deAndEN;
        private readonly IDeAndEn _deAndEN;
        public MainWindow()
        {
            InitializeComponent();
            _deAndEN = new DeAndEn();
        }


        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var text = PasswordBox.Text;
                var endoetext = _deAndEN.EncodeToBase64(text.ToString());
                MessageBox.Show(endoetext);
            }
        }
    }
}
