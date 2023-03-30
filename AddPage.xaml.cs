using Finance_Manager.Views.ElementPages;

namespace Finance_Manager;

public partial class AddPage : ContentPage
{
	public AddPage()
	{
		InitializeComponent();
	}

    private void EarningsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddEarningsPage());
    }

    private void ExpensesButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddExpensesPage());
    }

    private void NoteButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddNotePage());
    }

    private void ReminderButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddReminderPage());
    }
}