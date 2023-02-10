namespace VoronezhGuide;

public partial class MainPage : ContentPage
{
    private bool openDialogVoronezhPageCheck = false;
    private bool openMenuPageCheck = false;

    private DialogVoronezhPage dialogVoronezhPage;
    private MenuPage menuPage;
    public MainPage()
    {
        InitializeComponent();    
    }

    private async void OnButtonToDialogVoronezhPage(object sender, EventArgs e)
    {
        if (openDialogVoronezhPageCheck == false)
        {
            dialogVoronezhPage = new(this);
            await Navigation.PushModalAsync(dialogVoronezhPage, true);
            openDialogVoronezhPageCheck = true;
        }

        else
        {
            await Navigation.PushModalAsync(dialogVoronezhPage, true);
        }
    }

    private async void OnButtonMenuPage(object sender, EventArgs e)
    {
        if (openMenuPageCheck == false)
        {
            menuPage = new(this);
            await Navigation.PushModalAsync(menuPage, true);
            openMenuPageCheck = true;
        }

        else
        {
            await Navigation.PushModalAsync(menuPage, true);
        }
    }
}

