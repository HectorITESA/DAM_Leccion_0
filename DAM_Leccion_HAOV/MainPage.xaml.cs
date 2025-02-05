using DAM_Leccion_HAOV.Model;

namespace DAM_Leccion_HAOV
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public PersonaModel personaModel { get; set; }


        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
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
        public void Ejecutar() {
            personaModel = new PersonaModel() {
                Nombre = "Hola Hector O",
            };
            BindingContext = personaModel;
           // txtNombre.Text = personaModel.Nombre;
           /*Binding peronsaBinding= new Binding();
            peronsaBinding.Source = personaModel; //Origen
            peronsaBinding.Path = "Nombre";
            txtNombre.SetBinding(Entry.TextProperty,peronsaBinding);*/


        }
        //Evente Guardar 
        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Asistente del sistema", "Se ha guardado en la BD", "Aceptar","ayos");
            personaModel.Nombre="Alondra Montalvo";
            
        }
    }

}
