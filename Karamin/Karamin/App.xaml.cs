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
            var LabelB0 = new Label()
            {
                Text = "00"
            };
	        var B0 = new Button()
	        {
	            Text = ArrayPricipale[0].ToString(),
	            VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
	        };
            //
	        var LabelB1 = new Label()
	        {
	            Text = "01"
	        };
            var B1 = new Button()
	        {
	            Text = ArrayPricipale[1].ToString(),
	            VerticalOptions = LayoutOptions.FillAndExpand,
	            BackgroundColor = Color.White,
            };
            //
	        var LabelB2 = new Label()
	        {
	            Text = "10"
	        };
            var B2 = new Button()
	        {
	            Text = ArrayPricipale[2].ToString(),
	            VerticalOptions = LayoutOptions.FillAndExpand,
	            BackgroundColor = Color.White,
            };
            //
	        var LabelB3 = new Label()
	        {
	            Text = "11"
	        };
            var B3 = new Button()
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
                BackgroundColor = Color.DarkGray,
                Padding = 7,
	        };

            //ajout des boutons a la grille
	        GrillePrincipale.Children.Add(LabelB0, 1, 0);
            GrillePrincipale.Children.Add(B0, 1, 1);

	        GrillePrincipale.Children.Add(LabelB1, 1, 0);
            GrillePrincipale.Children.Add(B1, 2, 1);

	        GrillePrincipale.Children.Add(LabelB2, 1, 0);
            GrillePrincipale.Children.Add(B2, 3, 1);

	        GrillePrincipale.Children.Add(LabelB3, 1, 0);
            GrillePrincipale.Children.Add(B3, 4, 1);
            
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
	        B0.Clicked += buttonPressInGrid0;
	        B1.Clicked += buttonPressInGrid1;
	        B2.Clicked += buttonPressInGrid2;
	        B3.Clicked += buttonPressInGrid3;

            MainPage = new ContentPage
	        {
	            Content = new StackLayout
	            {
	                BackgroundColor = Color.White,
                    Spacing = 10,
                    Padding = 1,
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

            //fonction tu updates the label of buttons
 	        void UpdateButtons()
	        {
	            B0.Text = ArrayPricipale[0].ToString();
	            B1.Text = ArrayPricipale[1].ToString();
	            B2.Text = ArrayPricipale[2].ToString();
	            B3.Text = ArrayPricipale[3].ToString();
	        }

	        //fonction to put them all at 0
            void foncAll0(object sender, EventArgs e)
	        {
	            for (int i = 0; i < ArrayPricipale.Length; i++)
	            {
	                ArrayPricipale[i] = 0;
	            }
                UpdateButtons();
            }

            //fonction to put them all at 1
            void foncAl1(object sender, EventArgs e)
	        {
	            for (int i = 0; i < ArrayPricipale.Length; i++)
	            {
	                ArrayPricipale[i] = 1;
	            }
	            UpdateButtons();
	        }

            //button switch 
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

	        void calculeExpression()
	        {
	            
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
