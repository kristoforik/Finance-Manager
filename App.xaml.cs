﻿namespace Finance_Manager;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		//MainPage = new NavigationPage(new ProfilePage());
    }
}
