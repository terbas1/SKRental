using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Logín.ViewModels;
using Logín.Models;
using Plugin.Media;
using System.Collections.ObjectModel;

namespace Logín.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MylistPage : ContentPage
	{
        

		public MylistPage ()
		{
			InitializeComponent ();
            
            BindingContext = new MylistPageViewModel();

		}
        private async void OneItemSelected(object sender, ItemTappedEventArgs e)
        {
            var mydetail= e.Item as MylistDocuments;
            await  Navigation.PushAsync(new ObsPreventivaPage());
        }

       
    }
}