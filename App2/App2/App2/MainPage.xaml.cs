using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;


namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            bool didAppCrash = await Crashes.HasCrashedInLastSessionAsync();

            if (didAppCrash)
            {
                await DisplayAlert("Sorry Inconvinience", "Application crashes", "OK");
            }
        }

        /// <summary>
        /// Event for blue button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void btnBlue_Clicked(object sender, EventArgs e)
        {
            var param = new Dictionary<string, string>();
            param.Add("Blue button", "Button");

            Analytics.TrackEvent("Blue button was clicked", param);

            await DisplayAlert("Alert Message", "You clicked the blue button", "OK");
        }

        /// <summary>
        /// Event for Green button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void btnGreen_Clicked(object sender, EventArgs e)
        {

            Convert.ToInt32("fdsafdsfdsa");

            var param = new Dictionary<string, string>();
            param.Add("Green button", "Button");

            Analytics.TrackEvent("Green button was clicked", param);

            await DisplayAlert("Alert Message", "You clicked the green button", "OK");
        }

        /// <summary>
        /// Event for red button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void btnRed_Clicked(object sender, EventArgs e)
        {
            var param = new Dictionary<string, string>();
            param.Add("Red button", "Button");

            Analytics.TrackEvent("Red button was clicked", param);

            await DisplayAlert("Alert Message", "You clicked the red button", "OK");
        }
    }
}
