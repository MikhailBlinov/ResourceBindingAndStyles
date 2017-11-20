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

namespace ResourceBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person person;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetResource_OnClick(object sender, RoutedEventArgs e)
        {
            person = (Person) Resources["SmallPerson"];
        }

        private void ChangeResource_OnClickResource_OnClick(object sender, RoutedEventArgs e)
        {
            if (person == null) return;

            person.Age = 1001;
            person.FirstName = "1001xxxx";
            person.LastName = "1001yyyyy";
        }

        private void ShowChangedResource_OnClick(object sender, RoutedEventArgs e)
        {
            if (person == null) return;

            MessageBox.Show(person.Age.ToString() + " " + person.LastName + " " + person.FirstName);
        }
    }
}
