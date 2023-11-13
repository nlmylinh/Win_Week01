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

namespace EnglishVocabulary
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

        private void engButton_Click(object sender, RoutedEventArgs e)
        {
            string[] quotes =
            {
                "Ghostwrite",
                "Academic",
                "Highlight",
                "Erod",
                "Reasonably",
                "Identify",
                "Grateful",
                "Feature",
                "Mobilize",
                "Random",
                "Basis",
                "Define",
                "Rapidly",
                "Challenge",
                "Negotiation"
            };

            string[] avatars =
            {
                "Images/english01.jpg",
                "Images/english02.jpg",
                "Images/english03.jpg",
                "Images/english04.jpg",
                "Images/english05.jpg",
                "Images/english06.jpg",
                "Images/english07.jpg",
                "Images/english08.jpg",
                "Images/english09.jpg",
                "Images/english10.jpg",
                "Images/english11.jpg",
                "Images/english12.jpg",
                "Images/english13.jpg",
                "Images/english14.jpg",
                "Images/english15.jpg",
            };

            Random rng = new Random();

            int i = rng.Next(quotes.Length);
            string quote = quotes[i];
            engLabel.Content = quote;
            string avatar = avatars[i];

            var bitmap = new BitmapImage(new Uri(avatar, UriKind.Relative)
            ); // Unique resource identifier
            engImage.Source = bitmap;
        }
    }
}
