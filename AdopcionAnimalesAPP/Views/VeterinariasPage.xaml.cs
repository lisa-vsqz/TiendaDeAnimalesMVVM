using AdopcionAnimalesAPP.Models;
using AdopcionAnimalesAPP.Service;
using AdopcionAnimalesAPP.ViewModels;
using System.Collections.ObjectModel;

namespace AdopcionAnimalesAPP;

public partial class VeterinariasPage : ContentPage
{

	//private Veterinario _veterinario;
 //   private readonly ApiService _ApiService;

    public VeterinariasPage()
    {
       
       //ApiService veterinarioservice = new ApiService();
       // _ApiService = veterinarioservice;
        InitializeComponent();
        BindingContext = new VeterinariasViewModel();

    }
    //protected override async void OnAppearing()
    //{
    //    base.OnAppearing();
    //    List<Veterinario> ListaVeterinario = await _ApiService.GetAllVeterinarios();
    //    var veterinarios = new ObservableCollection<Veterinario>(ListaVeterinario);
    //    listaVet.ItemsSource = veterinarios;
    //}

    //private async void ClickImg(object sender, EventArgs e)
    //{
    //    await Navigation.PopAsync();
    //}
}