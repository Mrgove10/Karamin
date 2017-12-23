using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Karamin
{
	public partial class App : Application
	{
        public App()
	    {
	        InitializeComponent();
            ///
            /// VARIABLES
            /// 
            //Definition du text D'intro
	        Label TextHaut = new Label()
	        {
	            Text = "Bienvenue dans Karmin, un solver de diagrame de karnaug , coder en Xamarin.Forms."
	        };

            //definition de la grille de bouton
	        Grid GrillePrincipale = new Grid()
	        {
	            VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
	            {
	                new RowDefinition {Height = GridLength.Auto},
	            },
	            ColumnDefinitions =
	            {
	                new ColumnDefinition {Width = GridLength.Auto},
	            },
	        };

            //definition bouton 1
	        GrillePrincipale.Children.Add(new Button
	        {
	            Text = "1",
                TextColor = Color.Black,
	            BackgroundColor = Color.Gray,
	            FontSize = 20,
	            HeightRequest = 50,
            }, 1, 0);

	        //definition bouton 2
	        GrillePrincipale.Children.Add(new Button
	        {
	            Text = "2",
	            TextColor = Color.Black,
	            BackgroundColor = Color.Gray,
	            FontSize = 20,
	            HeightRequest = 50,
	        }, 2, 0);

	        //definition bouton 3
            GrillePrincipale.Children.Add(new Button
	        {
	            Text = "2",
	            TextColor = Color.Black,
                BackgroundColor = Color.Gray,
	            FontSize = 20,
	            HeightRequest = 50,
            }, 3, 0);

	        //definition bouton 4
            GrillePrincipale.Children.Add(new Button
	        {
	            Text = "3",
	            TextColor = Color.Black,
                BackgroundColor = Color.Gray,
	            FontSize = 20,
	            HeightRequest = 50,
            }, 4, 0);

            //definition button remise a 0
	        var all0Button = new Button()
	        {
	            Text = "all = 0",
	            HorizontalOptions = LayoutOptions.End,
	            VerticalOptions = LayoutOptions.FillAndExpand,
	        };

            //definition button remise a 1
            var all1Button = new Button()
	        {
	            Text = "all = 1",
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.FillAndExpand,
	        };

            ///
            /// Appelle de fontions.
            /// 
	        GrillePrincipale. Clicked += OnButtonClickedplus;

            MainPage = new ContentPage
	        {
	            Content = new StackLayout
	            {
	                BackgroundColor = Color.White,
                    Spacing = 10,
                    Padding = 10,
	                Children =
	                {
	                    TextHaut,
                        GrillePrincipale,
	                    all0Button,
                        all1Button,
	                },

	            }
	        };
	    }

	    protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
