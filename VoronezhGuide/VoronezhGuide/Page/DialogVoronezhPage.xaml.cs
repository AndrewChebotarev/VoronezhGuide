namespace VoronezhGuide;

public partial class DialogVoronezhPage : ContentPage
{
    private static string[] DialogText = new string[] { "Воронеж!.. Родина. Любовь.", "Девушка, раньше я был котёнком и жил в Воронеже, на улице Лизюкова.", "Воронеж хрен догонишь!" };

    MainPage mainPage;

    private int exam = 0;
    public DialogVoronezhPage(MainPage mainPage)
	{
		InitializeComponent();

        this.mainPage = mainPage;
	}

    protected override async void OnAppearing()
	{
        base.OnAppearing();

        if (exam == 0)
        {
            exam++;
            textForDialogVoronezh.Text = DialogText[exam];
            return;
        }

        else if (exam == 1)
        {
            exam++;
            textForDialogVoronezh.Text = DialogText[exam];
            return;
        }

        else if (exam == 2)
        {
            exam -= 2;
            textForDialogVoronezh.Text = DialogText[exam];
            return;
        }

        else
            return;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(mainPage);
    }
}