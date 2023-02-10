using Microsoft.Maui.Controls;

namespace VoronezhGuide;

public partial class WhiteWellPage : ContentPage
{
    private bool factsVisable = false;
	public WhiteWellPage()
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
        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/org/bely_kolodets/202985454993/?from=tabbar&ll=38.894977%2C51.463955&mode=search&sll=38.894976%2C51.463235&source=serp_navig&text=%D0%B1%D0%B5%D0%BB%D1%8B%D0%B9%20%D0%BA%D0%BE%D0%BB%D0%BE%D0%B4%D0%B5%D1%86%20%D0%BF%D0%B0%D1%80%D0%BA&z=10"));
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