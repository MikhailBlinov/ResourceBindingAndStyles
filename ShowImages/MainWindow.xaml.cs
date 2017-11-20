using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            this.ImageLeft.Source = new BitmapImage(new Uri("Winter.jpg", UriKind.Relative))
                                 {
                                     CreateOptions =
                                         BitmapCreateOptions
                                         .IgnoreImageCache
                                 };

            this.ImageRight.Source = new BitmapImage(new Uri(@"Images\Blue hills.jpg", UriKind.Relative))
            {
                CreateOptions =
                             BitmapCreateOptions
                             .IgnoreImageCache
            };

        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            BitmapImage myBitmapImage1 = new BitmapImage();

            myBitmapImage1.BeginInit();

            string path = Directory.GetCurrentDirectory() + @"\sadface.jpg";

            myBitmapImage1.UriSource = new Uri(path, UriKind.Absolute);
            myBitmapImage1.EndInit();

            ImageLeft.Source = myBitmapImage1; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Работатет , если в результате построения дистрибутива будет создан каталог Images, а в нем размещен файл sadface.jpg 
            BitmapImage myBitmapImage1 = new BitmapImage();
            string path = Directory.GetCurrentDirectory();
            myBitmapImage1.BeginInit();
            myBitmapImage1.UriSource = new Uri(path + @"\Images\sadface.jpg", UriKind.Absolute);
            myBitmapImage1.EndInit();
            ImageRight.Source = myBitmapImage1;
        }
    }
}
