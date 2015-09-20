using System;
using Xamarin.Forms;

namespace Actividad3
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage { 
				Content = new Label {
					Text = "Cambiando color, fondo y ubicación Roberto Vazquez Avila!",
					VerticalOptions = LayoutOptions.EndAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
					BackgroundColor = Color. Silver,
					TextColor = Color. Green
				},
			};
		}
	}
}

