using System;
using Xamarin.Forms;

namespace Actividad7
{
	public class Pagina3: ContentPage
	{
		public Pagina3 ()
		{
			Label texto = new Label {
				Text = "Página 3",
				TextColor = Color.Red
			};
			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					texto

				}
				};
			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);
		}
	}
}

