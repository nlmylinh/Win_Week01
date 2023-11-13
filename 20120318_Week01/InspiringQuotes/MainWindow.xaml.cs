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

namespace InspiringQuotes
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

        private void quoteButton_Click(object sender, RoutedEventArgs e)
        {
            string[] quotes =
            {
                "Tough times don’t last. Tough people do. \n\t – Robert H. Schuller",
                "Pain is temporary. Quitting lasts forever. \n\t – Lance Armstrong",
                "A problem is a chance for you to do your best. \n\t – Duke Ellington",
                "Motivation is what gets you started. Habit is what keeps you going. \n\t – Jim Rohn",
                "A little progress each day adds up to big results. \n\t – Satya Nani",
                "If you get tired, learn to rest, not quit.\n\t – Unknown",
                "Success consists of getting up just one more time than you fall.\n\t – Oliver Goldsmith",
                "Don’t stop until you’re proud.\n\t – Unknown",
                "Focus on your goal. Don’t look in any direction but ahead.\n\t – Unknown",
                "Courage is one step ahead of fear.\n\t – Coleman Young",
                "I find that the harder I work, the more luck I seem to have.\n\t – Thomas Jefferson",
                "Success is the sum of small efforts repeated day-in and day-out.\n\t – Robert Collier",
                "We must embrace pain and burn it as fuel for our journey.\n\t – Kenji Miyazawa",
                "Believe you can and you’re halfway there.\n\t – Theodore Roosevelt",
                "Difficult roads always lead to beautiful destinations.\n\t – Zig Ziglar"
            };

            string[] avatars =
            {
                "Images/quote01.jpg",
                "Images/quote02.jpg",
                "Images/quote03.jpg",
                "Images/quote04.jpg",
                "Images/quote05.jpg",
                "Images/quote06.jpg",
                "Images/quote07.jpg",
                "Images/quote08.jpg",
                "Images/quote09.jpg",
                "Images/quote10.jpg",
                "Images/quote11.jpg",
                "Images/quote12.jpg",
                "Images/quote13.jpg",
                "Images/quote14.jpg",
                "Images/quote15.jpg",
            };

            Random rng = new Random();

            int i = rng.Next(quotes.Length);
            string quote = quotes[i];
            quoteText.Text = quote;      
            string avatar = avatars[i];

            var bitmap = new BitmapImage(new Uri(avatar, UriKind.Relative)
            ); // Unique resource identifier
            quoteImage.Source = bitmap;
        }
    }
}
