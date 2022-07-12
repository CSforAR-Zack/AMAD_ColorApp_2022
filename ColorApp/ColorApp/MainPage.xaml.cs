namespace ColorApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void MagentaClicked(object sender, EventArgs e)
	{
        cPage.BackgroundColor = new Color(255, 0, 255);
    }

	private void OrangeClicked(object sender, EventArgs e)
    {
        cPage.BackgroundColor = Color.Parse("Orange");
    }

	private void ResetClicked(object sender, EventArgs e)
    {
        cPage.BackgroundColor = Color.Parse("Black");
    }
}

