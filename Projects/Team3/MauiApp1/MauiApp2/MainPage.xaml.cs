//using Smart_House;
using MauiApp2.ViewModel;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {

        HouseViewModel houseViewModel;
        public MainPage()
        {
            InitializeComponent();
            houseViewModel = new HouseViewModel() { Temperature = 44 };
            this.BindingContext = houseViewModel;
        }
        // private House house { get; set; }= new House();
        public async void BtnRun_Clicked(object sender, EventArgs e)
        {
            
            await DisplayAlert("House", "Run", "Ok");
            //houseViewModel.Temperature = -2;
            houseViewModel.ChangeT();
        }
    }



     
}