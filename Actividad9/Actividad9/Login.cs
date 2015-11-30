﻿using System;
using Xamarin.Forms;

namespace Actividad9
{
	public class Login: ContentPage
	{
		public Login ()
		{
			Entry usuario = new Entry { Placeholder = "Clave" };
			Entry clave = new Entry { Placeholder = "Clave", IsPassword = true };

			Button boton = new Button {
				Text = "Clave",
				TextColor = Color.Silver,
				BackgroundColor = Color.FromHex ("77D065") 
			};

			boton.Clicked += (sender, e) => {

				if(usuario.Text.Equals("Clave")){
					Navigation.PushAsync(new Contenido());
				}
			};

			//Stacklayout permite apilar los controles verticalmente
			StackLayout stackLayout = new StackLayout
			{
				Spacing = 20, 
				Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children =
				{
					usuario,
					clave,
					boton
				}
				};

			//Como esta clase hereda de ContentPage, podemos usar estas propiedades directamente
			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);
		}
	}
}
	