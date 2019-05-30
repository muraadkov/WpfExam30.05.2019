using Exam30._05._2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using Newtonsoft.Json;

namespace Exam30._05._2019
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Property> _properties = new List<Property>();
        public MainWindow()
        {

        InitializeComponent();
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (int.TryParse(countOfEarthQuakes.Text, out int count)) {
                string result = "";
            using (var webClient = new WebClient())
            {
                result = webClient.DownloadString("https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&orderby=time");
            }
            Earthquakes earthquakes = JsonConvert.DeserializeObject<Earthquakes>(result);
            for (int i = 0; i < count; i++)
            {
                _properties.Add(earthquakes.features[i].properties);

            }
            itemsGrid.ItemsSource = _properties;
            }
        }
    }
}
