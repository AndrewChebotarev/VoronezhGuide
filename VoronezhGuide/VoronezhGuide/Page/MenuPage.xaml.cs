using System.Windows.Input;
using VoronezhGuide.Page;
using VoronezhGuide.Page.EntertainmentCentersPage;
using VoronezhGuide.Page.EventsPage;
using VoronezhGuide.Page.FoodPage;
using VoronezhGuide.Page.TourismPage;

namespace VoronezhGuide;
public partial class MenuPage : ContentPage
{
    private ICommand ForgotPasswordCommand;
    private MainPage mainPage;

    private List<Label> TourismList = new();
    private List<Label> FoodList = new();
    private List<Label> EntertainmentCentersList = new();
    private List<Label> EventsList = new();

    private bool TourismVisiableCheck = false;
    private bool FoodCheck = false;
    private bool EntertainmentCentersCheck = false;
    private bool EventsCheck = false;

    public MenuPage(MainPage mainPage)
	{
		InitializeComponent();
        BindingContext = this;
        ForgotPasswordCommand= new Command(OnForgotPassword);
        this.mainPage = mainPage;
    }

    public async void OnForgotPassword()
    {
        TourismList.Add(whiteWell);
        TourismList.Add(voronezhPalace);
        TourismList.Add(shipMuseum);
        FoodList.Add(oldCity);
        FoodList.Add(artist);
        EntertainmentCentersList.Add(galleryChizhov);
        EntertainmentCentersList.Add(moscowAvenue);
        EventsList.Add(newHorizon);
        EventsList.Add(oldCity);

        foreach (var item in TourismList)
            item.IsVisible = true;

        foreach (var item in FoodList)
            item.IsVisible = true;

        foreach (var item in EntertainmentCentersList)
            item.IsVisible = true;

        foreach (var item in EventsList)
            item.IsVisible = true;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        ForgotPasswordCommand = new Command(OnForgotPassword);
    }

    private void TapTourism_Tapped(object sender, EventArgs e)
    {
        if (TourismVisiableCheck == false) 
        {
            whiteWell.IsVisible = true; 
            voronezhPalace.IsVisible = true; 
            shipMuseum.IsVisible = true; 
            TourismVisiableCheck = true;
        }

        else
        {
            whiteWell.IsVisible = false;
            voronezhPalace.IsVisible=false;
            shipMuseum.IsVisible=false; 
            TourismVisiableCheck = false;
        }
    }

    private void TapFood_Tapped(object sender, EventArgs e)
    {
        if (FoodCheck == false)
        {
            oldCity.IsVisible = true;
            artist.IsVisible = true;
            FoodCheck = true;
        }

        else
        {
            oldCity.IsVisible = false;
            artist.IsVisible = false;
            FoodCheck = false;
        }
    }

    private void TapEntertainmentCenters_Tapped(object sender, EventArgs e)
    {
        if (EntertainmentCentersCheck == false)
        {
            galleryChizhov.IsVisible = true;
            moscowAvenue.IsVisible = true;
            EntertainmentCentersCheck = true;
        }

        else
        {
            galleryChizhov.IsVisible = false;
            moscowAvenue.IsVisible = false;
            EntertainmentCentersCheck = false;
        }
    }

    private void TapEvents_Tapped(object sender, EventArgs e)
    {
        if (EventsCheck == false)
        {
            newHorizon.IsVisible = true;
            OldFairyTale.IsVisible = true;
            EventsCheck = true;
        }

        else
        {
            newHorizon.IsVisible = false;
            OldFairyTale.IsVisible = false;
            EventsCheck= false;
        }
    }

    private async void ButtonBack_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(mainPage);
    }
    private async void TapWhiteWell_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new WhiteWellPage(), true);
    }
    private async void TapVoronezhPalace_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new VoronezhPalacePage(), true);
    }
    private async void TapShipMuseum_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ShipMuseumPage(), true);
    }
    private async void TapOldCity_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new OldCityPage(), true);
    }
    private async void TapArtist_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ArtistPage(), true);
    }
    private async void TapGalleryChizhov_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new GalleryChizhovPage(), true);
    }
    private async void TapMoscowAvenue_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MoscowAvenuePage(), true);
    }
    private async void TapNewHorizon_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new NewHorizonPage(), true);
    }
    private async void TapOldFairyTale_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new OldFairyPage(), true);
    }

    private async void ButtonInfo_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync(new Uri("https://vk.com/sokolov_development_studio"));
    }
}