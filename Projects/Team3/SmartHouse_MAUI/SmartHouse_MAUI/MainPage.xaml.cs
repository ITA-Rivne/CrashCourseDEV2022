using SmartHouse_MAU.ViewModel;

namespace SmartHouse_MAUI;

public partial class MainPage : ContentPage
{

    HouseViewModel houseViewModel;
    public MainPage()
	{
		InitializeComponent();
        //houseViewModel = new HouseViewModel() { Temperature = -44 };
        houseViewModel = new HouseViewModel() ;// start temp = 20
        houseViewModel.OuterTemperature = 20;
        this.BindingContext = houseViewModel;
    }

	
}

