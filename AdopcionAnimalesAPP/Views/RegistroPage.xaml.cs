using AdopcionAnimalesAPP.Models;
using AdopcionAnimalesAPP.Service;
using AdopcionAnimalesAPP.ViewModels;


namespace AdopcionAnimalesAPP;

public partial class RegistroPage : ContentPage
{
    //private Cliente _clientenuevo;

    //private readonly ApiService _ApiService;
    public RegistroPage(/*ApiService apiService*/)
	{
		InitializeComponent();
        BindingContext = new RegistroViewModel();
        //_ApiService = apiService;
        
    }
    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();
    //    _clientenuevo = BindingContext as Cliente;
    //    if (_clientenuevo != null)
    //    {
    //        Cedula.Text = _clientenuevo.Cedula;
    //        Password.Text = _clientenuevo.Password;

    //    }
    //}

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    Cliente cliente = new Cliente
    //    {
    //        Cedula = Cedula.Text,
    //        Nombre= Nombre.Text,
    //        Direccion=Direccion.Text,
    //        Password= Password.Text,
    //    };

    //    await _ApiService.PostCliente(cliente);
    //    await Navigation.PopAsync();
    //}

    //private void Boton_Login(object sender, EventArgs e)
    //{
    //    Navigation.PushAsync(new LoginPage());
    //}
}