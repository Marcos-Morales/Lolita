using System;
using System.Collections.Generic;
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

namespace Random_Seat_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> brokenSeatNumber = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFileExplorer_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            var file = dialog.ShowDialog();
            FileName.Text = dialog.FileName;
        }

        private void ReadFile_Click(object sender, RoutedEventArgs e)
        {
            if(File.Exists(FileName.Text) == true)
            {
                var line = File.ReadAllLines(FileName.Text);
                List<int> random = new List<int>();

                Random Random = new Random();

                for(int i = 0; i < line.Length; i++)
                {
                    int number;

                    var column = line[i].Split(',');
                    string FirstName = column[0];
                    string LastName = column[1];

                    do
                    {
                        number = Random.Next(1, line.Length + 1);
                    } while (random.Contains(number));

                    SeatList.Items.Add($"{LastName}, {FirstName} - Computer #{number}");

                    random.Add(number);
                }
            }
        }

        private void FileName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FileName_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BrokenSeats_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
