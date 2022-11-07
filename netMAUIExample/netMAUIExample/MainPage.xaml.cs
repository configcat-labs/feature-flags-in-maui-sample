namespace netMAUIExample;
using ConfigCat.Client;
public partial class MainPage : ContentPage
{
    bool seeCat = false;
    public MainPage()
    {
        InitializeComponent();

        var client = new ConfigCatClient("YOUR-SDK-KEY");
        seeCat = client.GetValue("seeCat", false);

        flagLogic();
    }


    private void flagLogic()
    {
        if (seeCat == true)
        {
            mainLabel.Text = $"Here's the cute ConfigCat!";
            mainImage.Source = ImageSource.FromFile("cat_red.png");
        }
        else
        {
            mainLabel.Text = $"Sorry, the cat is sleeping :(";
            mainImage.Source = ImageSource.FromFile(null);
        }
    }
}
	

