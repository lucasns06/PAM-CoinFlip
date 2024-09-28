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
            string ladoSelecionado = ChoosePicker.SelectedItem.ToString();
            Moeda moeda = new Moeda();
            moeda.Sortear();
            
            if (moeda.LadoSorteado1 == ladoSelecionado)
            {
              
                resultLabel.Text = "Parabens! Você escolheu " + moeda.LadoSorteado1 +" e tirou " + ladoSelecionado;
            }
            else
            {
             
                resultLabel.Text = "Que pena! Você escolheu {LadoSelecionado} e tirou {ladoSelecionado}";
            }
            imageMoeda.Source = $"{moeda.LadoSorteado1}.jfif";
        }
    }

}
