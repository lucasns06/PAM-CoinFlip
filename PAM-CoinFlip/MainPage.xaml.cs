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

            public void Sortear() {
                int resultado = new Random().Next(2);

                if (resultado == 0)
                {
                    LadoSorteado = "Cara";
                }
                else
                {
                    LadoSorteado = "Coroa";
                }
            }

        }
        private void flipButton_Clicked(object sender, EventArgs e)
        {
            string nome = nameEntry.Text;
            string ladoSelecionado = ChoosePicker.SelectedItem.ToString();
            Moeda moeda = new Moeda();
            moeda.Sortear();
            
            if (moeda.LadoSorteado1 == ladoSelecionado)
            {
              
                resultLabel.Text = $"Parabens! {nome} Você escolheu {ladoSelecionado} e caiu {moeda.LadoSorteado1}";
            }
            else
            {
             
                resultLabel.Text = $"Que pena!  {nome} Você escolheu {ladoSelecionado} e caiu {moeda.LadoSorteado1}";
            }
            imageMoeda.Source = $"{moeda.LadoSorteado1}.jfif";
        }
    }

}
