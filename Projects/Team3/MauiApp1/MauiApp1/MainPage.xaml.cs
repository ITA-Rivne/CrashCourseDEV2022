using MauiApp1.ViewModel;
using System.Diagnostics;

namespace MauiApp1;

public partial class MainPage : ContentPage
{


    public MainPage()
	{
		InitializeComponent();
		var phpneViewMode = new PhoneViewModel();
		this.BindingContext = phpneViewMode;	

		
	}


	
}

