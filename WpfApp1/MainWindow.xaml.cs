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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> list = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            list.Add("Daniil<3");
            list.Add("Amir");
            list.Add("StariyBog");
            list.Add("Lublumamy");
        }

        void Load()
        {
            ListForDaniil.Items.Clear();
            foreach (var item in list)
            {
                ListForDaniil.Items.Add(item);
            }
        }

        void Add()
        {
            list.Add(zxc.Text);
        }

        void Delete()
        {
            list.Remove(zxc.Text);
        }

        private void btn_AmirClick(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void btn_AnastasiyaClick(object sender, RoutedEventArgs e)
        {

        }

        private void btn_YaroslavClick(object sender, RoutedEventArgs e)
        {
            Add();
            Load();
        }

        private void btn_OldGoooooDClick(object sender, RoutedEventArgs e)
        {
            Delete();
            Load();
        }
    }
}
