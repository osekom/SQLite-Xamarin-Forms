using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLiteExample.Helpers;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteExample.Droid.Helpers.LocalDB))]
namespace SQLiteExample.Droid.Helpers
{
    public class LocalDB : ILocalDB
    {
        private string Directorio;

        public string directorio
        {
            get
            {
                if (string.IsNullOrEmpty(Directorio))
                {
                    Directorio = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return Directorio;
            }
        }
    }
}