using System;
using Plugin.Connectivity;
using Xamarin.Forms;

namespace DemoCheckInternet
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    public void VerifyInternet(object sender, EventArgs e)
	    {
	        Status.Text = CrossConnectivity.Current.IsConnected ? "Connected" : "Disconnected";
	    }
    }
}
