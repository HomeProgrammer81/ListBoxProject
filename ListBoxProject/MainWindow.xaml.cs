using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace ListBoxProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ObservableCollection<Fruits> FruitsList = new ObservableCollection<Fruits>()
        {
            new Fruits( "apple", "りんご" ),
            new Fruits( "banana", "ばなな" ),
            new Fruits( "orange", "みかん"),
        };

        public MainWindow()
        {
            InitializeComponent();

            ListBox_FriutsList.ItemsSource = FruitsList;
        }

        /// <summary>
        /// フルーツ
        /// </summary>
        private class Fruits
        {
            public string _id { get; set; }

            public string _name { get; set; }

            public Fruits(string _id, string _name)
            {
                this._id = _id;
                this._name = _name;
            }
        }

        /// <summary>
        /// アイテムクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = ListBox_FriutsList.SelectedIndex;
            if (selectedIndex != -1)
            {
                return;
            }
            string id = FruitsList[selectedIndex]._id;
        }
    }
}
