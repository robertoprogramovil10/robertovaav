using System;
using Xamarin.Forms;

namespace Actividad7
{
	public class Pagina1: ContentPage
	{
		public Pagina1 ()
		{
			Label texto = new Label {
				Text = "Página 2",
				TextColor = Color.Green
			};

			Button boton = new Button
			{
				Text = "Has Click para ir a la página3"
			};

			boton.Clicked += (sender, e) => {
				this.Navigation.PushAsync(new Pagina2());
			};

			//Stacklayout permite apilar los controles verticalmente
			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					texto,
					boton
				}
				};


			//Como esta clase hereda de ContentPage, podemos usar estas propiedades directamente
			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);
		}
	}
}

