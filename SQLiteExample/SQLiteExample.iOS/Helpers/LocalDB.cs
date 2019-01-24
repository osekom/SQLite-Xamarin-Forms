using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using SQLiteExample.Helpers;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteExample.iOS.Helpers.LocalDB))]
namespace SQLiteExample.iOS.Helpers
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
                    var dir = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    Directorio = Path.Combine(dir, "..", "Library");
                }
                return Directorio;
            }
        }
    }
}