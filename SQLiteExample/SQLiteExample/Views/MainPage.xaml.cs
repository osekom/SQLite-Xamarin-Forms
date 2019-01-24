using SQLiteExample.Helpers;
using SQLiteExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteExample.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{

        public static LocalCrudCnn db = null;

        public MainPage ()
		{
			InitializeComponent ();
            if (db == null)
            {
                db = new LocalCrudCnn();
            }
		}

        private void ButtonSave_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EntrySave.Text))
            {
                tableExample modelo = new tableExample()
                {
                    Label = EntrySave.Text
                };

                db.InsertDataExample(modelo);
                EntrySave.Text = "";
            }
            else
            {
                DisplayAlert("Error", "el campo debe contener datos para ser guardados.","OK");
            }
        }

        private void ButtonShow_Clicked(object sender, EventArgs e)
        {
            List<tableExample> data = db.getDataTableExample();
            ListViewShow.ItemsSource = data;
        }
    }
}