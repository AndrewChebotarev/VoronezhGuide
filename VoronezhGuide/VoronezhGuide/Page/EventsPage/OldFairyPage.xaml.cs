using Microsoft.Maui.Controls.PlatformConfiguration;

namespace VoronezhGuide.Page.EventsPage;

public partial class OldFairyPage : ContentPage
{
    private bool factsVisable = false;
    public OldFairyPage()
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
        await Launcher.OpenAsync(new Uri("https://vk.com/album-188496135_284234851"));
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