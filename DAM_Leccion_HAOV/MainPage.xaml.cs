using DAM_Leccion_HAOV.Model;
using DAM_Leccion_HAOV.ViewModel;

namespace DAM_Leccion_HAOV
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        MainPageViewModel mainPageViewModel = new MainPageViewModel();
        public PersonasModel personaModel { get; set; }


        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
            
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
       
        //Evente Guardar 
        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
          
            //DisplayAlert("Asistente del sistema", "Se ha guardado en la BD", "Aceptar","ayos");
            //personaModel.Nombre="Alondra";
            //personaModel.Apellido = "Montalvo";
            //personaModel.Edad = "20";
            
        }
    }

}
