using System;
using Xamarin.Forms;

namespace Actividad10
{
	public class Contenido: ContentPage
	{
		public Contenido ()

		Entry usuario = new Entry { Placeholder = "Contenido" };
		Entry clave = new Entry { Placeholder = "Contenido", IsPassword = true };
		{
		Button boton = new Button {
			Text = "Contenido",
			TextColor = Color.Blue,
			BackgroundColor = Color.FromHex ("77D065") 
		};

		boton.Clicked += (sender, e) => {

			if(usuario.Text.Equals("Contenido")){
				Navigation.PushAsync(new Contenido());
			}
		};

		{
			//El control ListView muestra el contenido en forma de tabla 
			//Con RowHeight le indicamos el alto de cada renglón
			var listView = new ListView
			{
				RowHeight = 40
			};

			//El contenido de la tabla 
			//Por el momento usamos un arreglo de cadenas
			String[] arreglo = new string []
			{
				"Pera",
				"Manzana",
				"Plátano",
				"Mango",
				"Piña"
			};

			//Le indicamos al ListView de donde tomar los datos
			listView.ItemsSource = arreglo;

			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = { listView }
			};
		}
	}
}
}
