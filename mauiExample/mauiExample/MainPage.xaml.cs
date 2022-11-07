namespace MauiApp2;
using ConfigCat.Client;
public partial class MainPage : ContentPage
{
	int count = 0;
    bool seeCats = false;
 
    public MainPage()
	{

		InitializeComponent();

        var client = new ConfigCatClient("YOUR-SDK-KEY");
        seeCats = client.GetValue("seeCats", false);

        buttonLogic();

    }


    public void buttonLogic()
    {
        if (seeCats == true)
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

