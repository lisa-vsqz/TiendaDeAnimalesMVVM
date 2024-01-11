using AdopcionAnimalesAPP.Models;
using AdopcionAnimalesAPP.Service;
using AdopcionAnimalesAPP.ViewModels;

namespace AdopcionAnimalesAPP;

public partial class DetallesAnimalPage : ContentPage
{
    private Animal _animal;
    //private string _cedulaCliente;
    //private readonly ApiService _apiService;

    public DetallesAnimalPage(Animal animal)
    {
        InitializeComponent();
        _animal = animal;
        BindingContext = new DetallesAnimalViewModel(_animal);
        //ApiService apiservice = new ApiService();
        //InitializeComponent();
        //_apiService = apiservice;
        //_cedulaCliente = Preferences.Get("Cedula", "0"); 

    }

    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();
    //    _animal = BindingContext as Animal;
    //    if (_animal.Status == 1 || _animal.Status == 2)
    //    {
    //        btnSoli.IsVisible = false;
    //    }
    //    Img.Source = _animal.Img;
    //    Nombre.Text = _animal.Nombre;
    //    nombreCientifico.Text = _animal.NombreCientifico;
    //    paisOrigen.Text = _animal.PaisOrigen;
    //    altura.Text = _animal.Altura.ToString();
    //    peso.Text = _animal.Peso.ToString();
    //    enfermedad.Text = _animal.Enfermedad;

    //}

    //private async void OnClickAdoptar(object sender, EventArgs e)
    //{
    //    _animal.Status = 1;
    //    _animal.Propietario = _cedulaCliente;
    //    Img.Source = _animal.Img;
    //    Nombre.Text = _animal.Nombre;
    //    nombreCientifico.Text = _animal.NombreCientifico;
    //    paisOrigen.Text = _animal.PaisOrigen;
    //    altura.Text = _animal.Altura.ToString();
    //    peso.Text = _animal.Peso.ToString();
    //    enfermedad.Text = _animal.Enfermedad;

    //    await _apiService.UpdateAnimal(_animal.Id, _animal);
    //    await Navigation.PopAsync();
    //}
    //private async void ClickImg(object sender, EventArgs e)
    //{
    //    await Navigation.PopAsync();
    //}
}