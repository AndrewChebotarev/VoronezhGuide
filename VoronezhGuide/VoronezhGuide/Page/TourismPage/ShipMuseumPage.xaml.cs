using Microsoft.Maui.Controls.PlatformConfiguration;

namespace VoronezhGuide.Page.TourismPage;

public partial class ShipMuseumPage : ContentPage
{
    private bool factsVisable = false;
    public ShipMuseumPage()
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
        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/193/voronezh/search/%D0%B2%D0%BE%D1%80%D0%BE%D0%BD%D0%B5%D0%B6%20%D0%BA%D0%BE%D1%80%D0%B0%D0%B1%D0%BB%D1%8C%20%D0%BC%D1%83%D0%B7%D0%B5%D0%B9/?from=tabbar&ll=39.216849%2C51.640681&sctx=ZAAAAAgCEAAaKAoSCUHTEiujmUNAERlxAWiU1ElAEhIJBTI7i96p5D8RaoXpew3B2j8iBgABAgMEBSgKOABAwQFIAWIhYWRkX3NuaXBwZXQ9dG9wb255bV9kaXNjb3ZlcnkvMS54YjJjb2xsZWN0aW9uc19yYW5raW5nX21vZGVsPWNvbGxlY3Rpb25zX3JlbGV2X3dfZHNzbWIlY29sbGVjdGlvbnNfcmVsZXZfdGhyZXNob2xkPTEwMDUwMDAwMGIgY29sbGVjdGlvbnNfcmV0dXJuX2J5X2dlb2lkPXRydWViOnJlYXJyPXNjaGVtZV9Mb2NhbC9HZW8vQ29sbGVjdGlvbnMvTWl4RWFjaE5Qb3NpdGlvbj0xMDA1MDBiQnJlYXJyPXNjaGVtZV9Mb2NhbC9HZW8vTGlzdERpc2NvdmVyeS9FbmFibGVEaXNjb3ZlcnlUZXh0UmVxdWVzdHM9MWI3cmVhcnI9c2NoZW1lX0xvY2FsL0dlby9Db2xsZWN0aW9ucy9GaXJzdFBvc2l0aW9uVG9NaXg9M2I6cmVhcnI9c2NoZW1lX0xvY2FsL0dlby9MaXN0RGlzY292ZXJ5L0VuYWJsZUVtcHR5UmVxdWVzdHM9MWI6cmVhcnI9c2NoZW1lX0xvY2FsL0dlby9MaXN0RGlzY292ZXJ5L0VuYWJsZUNvbW1vblBpY01lbnU9MWI1cmVhcnI9c2NoZW1lX0xvY2FsL0dlby9MaXN0RGlzY292ZXJ5L0VuYWJsZVJlcXVlc3RzPTFiMHJlYXJyPXNjaGVtZV9Mb2NhbC9HZW8vQXNrRGlzY292ZXJ5Rm9yVG9wb255bXM9MWIycmVhcnI9c2NoZW1lX0xvY2FsL0dlby9Db2xsZWN0aW9ucy9FbmFibGVkTWl4PXRydWViNXJlYXJyPXNjaGVtZV9Mb2NhbC9HZW8vTGlzdERpc2NvdmVyeS9FbmFibGVWZXJ0aWNhbD0xagJydZ0BzcxMPaABAKgBAL0BK%2FcZX8IBDL%2BK4czdBMj3w%2BHZAeoBAPIBAPgBAIICKNCy0L7RgNC%2B0L3QtdC2INC60L7RgNCw0LHQu9GMINC80YPQt9C10LmKAgCSAgMxOTOaAgxkZXNrdG9wLW1hcHM%3D&sll=39.216849%2C51.640681&source=serp_navig&sspn=0.126392%2C0.040307&z=13.6"));
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