namespace MauiApp2;
using ConfigCat.Client;
public partial class MainPage : ContentPage
{
	int count = 0;
    bool demoSwitch = false;
 
    public MainPage()
	{

		InitializeComponent();

        var client = new ConfigCatClient("8z7aCC-DZEaPwUCnitpksg/TbJ8oi7sMUynCb8MxtTUDw");
        demoSwitch = client.GetValue("demoSwitch", false);

        buttonLogic();

    }


    public void buttonLogic()
    {
        if (demoSwitch == true)
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

