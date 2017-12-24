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
                Text = "Bienvenue dans Karamin, un solver de diagrame de karnaug , coder en Xamarin.Forms.",
                FontSize = 25,
            };

            Label TextAB = new Label()
            {
                Text = "AB",
                FontSize = 25,
            };

            //definition des boutons
            //case 0
            Label LabelB0 = new Label()
            {
                Text = "00",
                FontSize = 25,
            };
            Button B0 = new Button()
            {
                Text = ArrayPricipale[0].ToString(),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                FontSize = 35,
            };
            //case 1
            Label LabelB1 = new Label()
            {
                Text = "01",
                FontSize = 25,
            };
            Button B1 = new Button()
            {
                Text = ArrayPricipale[1].ToString(),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                FontSize = 35,
            };
            //case 2
            Label LabelB2 = new Label()
            {
                Text = "11",
                FontSize = 25,
            };
            Button B2 = new Button()
            {
                Text = ArrayPricipale[2].ToString(),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                FontSize = 35,
            };
            //case 3
            Label LabelB3 = new Label()
            {
                Text = "10",
                FontSize = 25,
            };
            Button B3 = new Button()
            {
                Text = ArrayPricipale[3].ToString(),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                FontSize = 35,
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
            GrillePrincipale.Children.Add(TextAB, 0, 0);

            GrillePrincipale.Children.Add(LabelB0, 1, 0);
            GrillePrincipale.Children.Add(B0, 1, 1);

            GrillePrincipale.Children.Add(LabelB1, 2, 0);
            GrillePrincipale.Children.Add(B1, 2, 1);

            GrillePrincipale.Children.Add(LabelB2, 3, 0);
            GrillePrincipale.Children.Add(B2, 3, 1);

            GrillePrincipale.Children.Add(LabelB3, 4, 0);
            GrillePrincipale.Children.Add(B3, 4, 1);

            Label textBas = new Label()
            {
                Text = "Solution : ",
                FontSize = 25,
            };

            //definition button remise a 0
            var all0Button = new Button()
            {
                Text = "all = 0",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.End,
                FontSize = 25,
            };

            //definition button remise a 1
            var all1Button = new Button()
            {
                Text = "all = 1",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.End,
                FontSize = 25,
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
                        textBas,
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
                calculeExpression();
            }

            //fonction to put them all at 1
            void foncAl1(object sender, EventArgs e)
            {
                for (int i = 0; i < ArrayPricipale.Length; i++)
                {
                    ArrayPricipale[i] = 1;
                }
                UpdateButtons();
                calculeExpression();
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
                calculeExpression();
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
                calculeExpression();
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
                calculeExpression();
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
                calculeExpression();
            }

            void calculeExpression()
            {

                if (ArrayPricipale[0] == 0 && ArrayPricipale[1] == 0 && ArrayPricipale[2] == 0 && ArrayPricipale[3] == 0)
                {
                    textBas.Text = "Solution : 0";
                }
                if (ArrayPricipale[0] == 1 && ArrayPricipale[1] == 1 && ArrayPricipale[2] == 1 && ArrayPricipale[3] == 1)
                {
                    textBas.Text = "Solution : 1";
                }
                //1
                if (ArrayPricipale[0] == 1 && ArrayPricipale[1] == 0 && ArrayPricipale[2] == 0 && ArrayPricipale[3] == 0)
                {
                    textBas.Text = "Solution : /A /B";
                }
                if (ArrayPricipale[0] == 0 && ArrayPricipale[1] == 1 && ArrayPricipale[2] == 0 && ArrayPricipale[3] == 0)
                {
                    textBas.Text = "Solution : /A B";
                }
                if (ArrayPricipale[0] == 0 && ArrayPricipale[1] == 0 && ArrayPricipale[2] == 1 && ArrayPricipale[3] == 0)
                {
                    textBas.Text = "Solution : A B";
                }
                if (ArrayPricipale[0] == 0 && ArrayPricipale[1] == 0 && ArrayPricipale[2] == 0 && ArrayPricipale[3] == 1)
                {
                    textBas.Text = "Solution : A /B";
                }

                //2
                if (ArrayPricipale[0] == 1 && ArrayPricipale[1] == 1 && ArrayPricipale[2] == 0 && ArrayPricipale[3] == 0)
                {
                    textBas.Text = "Solution : /A";
                }
                if (ArrayPricipale[0] == 1 && ArrayPricipale[1] == 0 && ArrayPricipale[2] == 1 && ArrayPricipale[3] == 0)
                {
                    textBas.Text = "Solution : /A /B + A B";
                }
                if (ArrayPricipale[0] == 0 && ArrayPricipale[1] == 1 && ArrayPricipale[2] == 1 && ArrayPricipale[3] == 0)
                {
                    textBas.Text = "Solution : B";
                }
                if (ArrayPricipale[0] == 0 && ArrayPricipale[1] == 1 && ArrayPricipale[2] == 0 && ArrayPricipale[3] == 1)
                {
                    textBas.Text = "Solution : /A B + A /B";
                }
                if (ArrayPricipale[0] == 0 && ArrayPricipale[1] == 0 && ArrayPricipale[2] == 1 && ArrayPricipale[3] == 1)
                {
                    textBas.Text = "Solution : A ";
                }
                if (ArrayPricipale[0] == 1 && ArrayPricipale[1] == 0 && ArrayPricipale[2] == 0 && ArrayPricipale[3] == 1)
                {
                    textBas.Text = "Solution : /B ";
                }
                //3
                if (ArrayPricipale[0] == 1 && ArrayPricipale[1] == 1 && ArrayPricipale[2] == 1 && ArrayPricipale[3] == 0)
                {
                    textBas.Text = "Solution : /A + B";
                }
                if (ArrayPricipale[0] == 1 && ArrayPricipale[1] == 1 && ArrayPricipale[2] == 0 && ArrayPricipale[3] == 1)
                {
                    textBas.Text = "Solution : /A + /B";
                }
                if (ArrayPricipale[0] == 0 && ArrayPricipale[1] == 1 && ArrayPricipale[2] == 1 && ArrayPricipale[3] == 1)
                {
                    textBas.Text = "Solution : B + A";
                }
                if (ArrayPricipale[0] == 1 && ArrayPricipale[1] == 0 && ArrayPricipale[2] == 1 && ArrayPricipale[3] == 1)
                {
                    textBas.Text = "Solution : /B + A ";
                }

            }
        }

	    protected override void OnStart ()
		{

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
