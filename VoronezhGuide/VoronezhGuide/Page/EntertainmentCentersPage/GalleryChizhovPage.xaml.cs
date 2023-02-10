namespace VoronezhGuide.Page.EntertainmentCentersPage;

public partial class GalleryChizhovPage : ContentPage
{
    private bool factsVisable = false;
    public GalleryChizhovPage()
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
        await Launcher.OpenAsync(new Uri("https://yandex.ru/maps/193/voronezh/search/%D0%B3%D0%B0%D0%BB%D0%B5%D1%80%D0%B5%D1%8F%20%D1%87%D0%B8%D0%B6%D0%BE%D0%B2%D0%B0/?ll=39.207829%2C51.661722&sctx=ZAAAAAgBEAAaKAoSCUHTEiujmUNAERlxAWiU1ElAEhIJBTI7i96p5D8RaoXpew3B2j8iBgABAgQFBigKOABAsc0GSAFiJG1pZGRsZV95YW5kZXhfdHJhdmVsX0VuYWJsZUNhdFJvb209MWIlY29sbGVjdGlvbnNfcmVsZXZfdGhyZXNob2xkPTEwMDUwMDAwMGIyY29sbGVjdGlvbnNfcmFua2luZ19tb2RlbD1jb2xsZWN0aW9uc19yZWxldl93X2Rzc21iIGNvbGxlY3Rpb25zX3JldHVybl9ieV9nZW9pZD10cnVlYiptaWRkbGVfeWFuZGV4X3RyYXZlbF9DYXRSb29tTWF4T3RoZXJQY3Q9MjViIWFkZF9zbmlwcGV0PXRvcG9ueW1fZGlzY292ZXJ5LzEueGIcYWRkX3NuaXBwZXQ9bWFpbl9hc3BlY3RzLzEueGIobWlkZGxlX3lhbmRleF90cmF2ZWxfQXV0b0NhdFJvb21Gb3JBbGw9MWInbWlkZGxlX3lhbmRleF90cmF2ZWxfQ2F0Um9vbVNob3dPdGhlcj0wYjpyZWFycj1zY2hlbWVfTG9jYWwvR2VvL0NvbGxlY3Rpb25zL01peEVhY2hOUG9zaXRpb249MTAwNTAwYkJyZWFycj1zY2hlbWVfTG9jYWwvR2VvL0xpc3REaXNjb3ZlcnkvRW5hYmxlRGlzY292ZXJ5VGV4dFJlcXVlc3RzPTFiN3JlYXJyPXNjaGVtZV9Mb2NhbC9HZW8vQ29sbGVjdGlvbnMvRmlyc3RQb3NpdGlvblRvTWl4PTNiOnJlYXJyPXNjaGVtZV9Mb2NhbC9HZW8vTGlzdERpc2NvdmVyeS9FbmFibGVFbXB0eVJlcXVlc3RzPTFiMHJlYXJyPXNjaGVtZV9Mb2NhbC9HZW91cHBlci9BZGRGaXhlZFRvcEdlb2pzb249MWI6cmVhcnI9c2NoZW1lX0xvY2FsL0dlby9MaXN0RGlzY292ZXJ5L0VuYWJsZUNvbW1vblBpY01lbnU9MWI1cmVhcnI9c2NoZW1lX0xvY2FsL0dlby9MaXN0RGlzY292ZXJ5L0VuYWJsZVJlcXVlc3RzPTFiMHJlYXJyPXNjaGVtZV9Mb2NhbC9HZW8vQXNrRGlzY292ZXJ5Rm9yVG9wb255bXM9MWIycmVhcnI9c2NoZW1lX0xvY2FsL0dlby9Db2xsZWN0aW9ucy9FbmFibGVkTWl4PXRydWViNXJlYXJyPXNjaGVtZV9Mb2NhbC9HZW8vTGlzdERpc2NvdmVyeS9FbmFibGVWZXJ0aWNhbD0xagJydZUBAAAAAJ0BzcxMPqABAagBAL0BrfQvNcIBKt3ZlZsEs8iC0IgGnojS3gbLscTbBO%2Fq2%2BsDu72wqATO8tGABMPejrP8AuoBAPIBAPgBAIICG9Cz0LDQu9C10YDQtdGPINGH0LjQttC%2B0LLQsIoCAJICBTIwMjI3mgIMZGVza3RvcC1tYXBz&sll=39.207829%2C51.661722&source=wizbiz_new_map_multi&sspn=0.072593%2C0.023140&z=14.4"));
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