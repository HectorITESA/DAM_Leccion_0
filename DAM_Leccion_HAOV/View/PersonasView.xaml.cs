using DAM_Leccion_HAOV.ViewModel;

namespace DAM_Leccion_HAOV.View;

public partial class PersonasView : ContentPage
{
	public PersonasView()
	{
		InitializeComponent();

		BindingContext = new PersonasViewModel();
	}
}