using Microsoft.Maui.Controls.PlatformConfiguration;

namespace VoronezhGuide.Page.FoodPage;

public partial class ArtistPage : ContentPage
{
    private bool factsVisable = false;
    public ArtistPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
    }

    private async void ButtonBack_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/artist/225038488687/?ll=39.266337%2C51.734910&source=wizbiz_new_map_multi&z=11.34"));
    }

    private async void TapFacts_Tapped(object sender, EventArgs e)
    {
        if (factsVisable)
        {
            facts.IsVisible = true;
            factsVisable = false;
        }

        else
        {
            facts.IsVisible = false;
            factsVisable = true;
        }

        await scrollView.ScrollToAsync(facts, ScrollToPosition.End, true);

    }
}