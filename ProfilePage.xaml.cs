namespace Finance_Manager;

public partial class ProfilePage : ContentPage
{	
	public ProfilePage()
	{
		InitializeComponent();
		List<string> functions = new List<string>()
		{
			"UserProfile",
			"Settings",
			"QR code",
			"Saved",
			"Order and payments",
			"Digital Collectibles",
			"Favourites",
			"Terms and Conditions"
		};

        functionsListView.ItemsSource = functions;

    }

    private async void OnFunctionSelected(object sender, SelectedItemChangedEventArgs e)
    {
        // Get the name of the function that was selected
        string functionName = e.SelectedItem.ToString();

        // Navigate to the appropriate page based on the function name
        switch (functionName)
        {
            case "UserProfile":
                await Navigation.PushAsync(new UserProfile());
                break;
            //case "Settings":
            //    await Navigation.PushAsync(new Settings());
            //    break;
            //case "Scanner":
            //    await Navigation.PushAsync(new Scanner());
            //    break;
                // Add cases for the other functions here
        }
        // Deselect the selected item so that it doesn't stay highlighted
        functionsListView.SelectedItem = null;
    }


}
