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
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace IStone_Card_Game
{

    public partial class MainWindow : INotifyPropertyChanged
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string[] ShuffledDeckOfCards = new string[52];
        public int CurrentCardIndex = 0;
        public string CurrentCardValue = "";
        public const int NumberOfCards = 52;

        public string _buttonNextCard = "Hidden";
        public string ButtonNextCard
        {
            get { return _buttonNextCard; }
            set
            {
                _buttonNextCard = value;
                OnPropertyChanged();
            }
        }


        public ObservableCollection<string> _oldCards = new ObservableCollection<string>();
        public ObservableCollection<string> OldCards
        {
            get { return _oldCards; }
            set
            {
                _oldCards = value;
                OnPropertyChanged();
            }
        }


        public string _cardImageUrl = "Images/cards/Back.png";
        public string CardImageUrl
        {
            get { return _cardImageUrl; }
            set
            {
                _cardImageUrl = value;
                OnPropertyChanged();
            }
        }

        public void ShuffleCards(object sender, RoutedEventArgs e)
        {
            Deck deck1 = new Deck();
            deck1.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                ShuffledDeckOfCards[i] = deck1.DealCard().ToString();
            }
            //nollställ
            ButtonNextCard = "Visible";
            OldCards = new ObservableCollection<string>();
            CurrentCardIndex = 0;
            CurrentCardValue = "";
            CardImageUrl = "Images/cards/Back.png";
        }

        private void ButtonClickedNext(object sender, RoutedEventArgs e)
        {
            if (CurrentCardIndex < 52)
            {
                CurrentCardValue = ShuffledDeckOfCards[CurrentCardIndex];
                CardImageUrl = String.Format("/Images/cards/{0}.png", CurrentCardValue);

                OldCards.Add(CurrentCardValue);

                CurrentCardIndex++;

                Console.WriteLine(NumberOfCards);
                Console.WriteLine(CurrentCardIndex);
                Console.WriteLine(CardImageUrl);
                Console.WriteLine(CurrentCardValue);
                Console.WriteLine(OldCards[CurrentCardIndex - 1]);

            }
            else
            {
                MessageBox.Show("End of deck");
                Console.WriteLine("End Of Deck");
            }

        }


        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.SortDescriptions.Add(
                        new System.ComponentModel.SortDescription("",
                        System.ComponentModel.ListSortDirection.Ascending));
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
