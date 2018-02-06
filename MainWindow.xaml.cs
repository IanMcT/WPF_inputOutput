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

        private void sliderNumber_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliderOutput != null)
            { sliderOutput.Content = sliderNumber.Value.ToString(); }
            
        }

        private void btnImage_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("https://mrmctavish.files.wordpress.com/2017/06/mctlogo.png"));
            imgPicture.Source = bi;
        }

        private void chkTrue_Checked(object sender, RoutedEventArgs e)
        {
            chkOutput.Content = chkTrue.IsChecked;
            
        }

        private void txtEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtEntry.Text !=null && lblTxtEntry != null)
                lblTxtEntry.Content = txtEntry.Text;
        }
    }
}
