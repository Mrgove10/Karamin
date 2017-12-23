using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using Android.Support.Annotation;
using Xamarin.Forms;

namespace Karamin
{
	public partial class App : Application
	{
	    ///
	    /// VARIABLES
	    /// 
        
	    int[] ArrayPricipale = new int[4] {0,0,0,0};
        
        public App()
	    {
	        InitializeComponent();
            //Definition du text D'intro
            Label TextHaut = new Label()
	        {
	            Text = "Bienvenue dans Karmin, un solver de diagrame de karnaug , coder en Xamarin.Forms."
	        };
            //definition des boutons
	        var B1 = new Button()
	        {
	            Text = ArrayPricipale[0].ToString(),
	            VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
	        };
	        var B2 = new Button()
	        {
	            Text = ArrayPricipale[1].ToString(),
	            VerticalOptions = LayoutOptions.FillAndExpand,
	            BackgroundColor = Color.White,
            };
	        var B3 = new Button()
	        {
	            Text = ArrayPricipale[2].ToString(),
	            VerticalOptions = LayoutOptions.FillAndExpand,
	            BackgroundColor = Color.White,
            };
	        var B4 = new Button()
	        {
	            Text = ArrayPricipale[3].ToString(),
	            VerticalOptions = LayoutOptions.FillAndExpand,
	            BackgroundColor = Color.White,
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

            //ajout des boutons a la grille
	        GrillePrincipale.Children.Add((B1), 1, 0);
	        GrillePrincipale.Children.Add((B2), 2, 0);
	        GrillePrincipale.Children.Add((B3), 3, 0);
	        GrillePrincipale.Children.Add((B4), 4, 0);
            
            //definition button remise a 0
            var all0Button = new Button()
	        {
	            Text = "all = 0",
	            HorizontalOptions = LayoutOptions.FillAndExpand,
	            VerticalOptions = LayoutOptions.End,
            };

            //definition button remise a 1
            var all1Button = new Button()
	        {
	            Text = "all = 1",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.End,
	        };

            /// 
            /// Appelle de fontions.
            /// 
	        all0Button.Clicked += foncAll0;
	        all1Button.Clicked += foncAl1;
	        B1.Clicked += buttonPressInGrid0;
	        B2.Clicked += buttonPressInGrid1;
	        B3.Clicked += buttonPressInGrid2;
	        B4.Clicked += buttonPressInGrid3;

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
            /// 
            /// Definition des fonction
            /// 
 	        void UpdateButtons()
	        {
	            B1.Text = ArrayPricipale[0].ToString();
	            B2.Text = ArrayPricipale[1].ToString();
	            B3.Text = ArrayPricipale[2].ToString();
	            B4.Text = ArrayPricipale[3].ToString();
	        }

            void foncAll0(object sender, EventArgs e)
	        {
	            for (int i = 0; i < ArrayPricipale.Length; i++)
	            {
	                ArrayPricipale[i] = 0;
	            }
                UpdateButtons();
            }

            void foncAl1(object sender, EventArgs e)
	        {
	            for (int i = 0; i < ArrayPricipale.Length; i++)
	            {
	                ArrayPricipale[i] = 1;
	            }
	            UpdateButtons();
	        }

	        void buttonPressInGrid0(object sender, EventArgs e)
	        {
                switch (ArrayPricipale[0])
                {
                    case 0:
                        ArrayPricipale[0] = 1;
                        break;
                    case 1:
                        ArrayPricipale[0] = 0;
                        break;
                }
	            UpdateButtons();
            }
	        void buttonPressInGrid1(object sender, EventArgs e)
	        {
	            switch (ArrayPricipale[1])
	            {
	                case 0:
	                    ArrayPricipale[1] = 1;
	                    break;
	                case 1:
	                    ArrayPricipale[1] = 0;
	                    break;
	            }
	            UpdateButtons();
	        }
	        void buttonPressInGrid2(object sender, EventArgs e)
	        {
	            switch (ArrayPricipale[2])
	            {
	                case 0:
	                    ArrayPricipale[2] = 1;
	                    break;
	                case 1:
	                    ArrayPricipale[2] = 0;
	                    break;
	            }
	            UpdateButtons();
	        }
	        void buttonPressInGrid3(object sender, EventArgs e)
	        {
	            switch (ArrayPricipale[3])
	            {
	                case 0:
	                    ArrayPricipale[3] = 1;
	                    break;
	                case 1:
	                    ArrayPricipale[3] = 0;
	                    break;
	            }
	            UpdateButtons();
	        }

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
