namespace PAM_CoinFlip
{
    public partial class MainPage : ContentPage
    {
  

        public MainPage()
        {
            InitializeComponent();
        }
        public class Moeda
        {
            private string LadoSorteado;

            public string LadoSorteado1 { get => LadoSorteado; set => LadoSorteado = value; }

            public int SortearLado() {
                return new Random().Next(1, 2);
            }
        }
        private void flipButton_Clicked(object sender, EventArgs e)
        {

        }
    }

}
