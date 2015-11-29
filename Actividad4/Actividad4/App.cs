using System;
using Xamarin.Forms;

namespace Actividad4
{
	public class App
	{
		public static Page GetMainPage ()
		{    
			return new ContentPage {
				Content = new Label {
					Text = "Cambiando propiedades por inicializadores de objetos",
					Text = "Roberto Vazquez Avila",
					BackgroundColor = Color.Red,
					TextColor = Color.blue,
					VerticalOptions = LayuoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center,
				},
			};    
		}    
	}
}
