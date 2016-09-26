using System;
using Xamarin.Forms;
namespace StackLayoutExample
{
	public class ContentPageExample : ContentPage
	{
		public ContentPageExample()
		{
			StackLayout stackLayout = new StackLayout { 
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = { 
				
				} 
			};
		}
	}
}
