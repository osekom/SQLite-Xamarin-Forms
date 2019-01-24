using SQLite;
using SQLiteExample.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace SQLiteExample.Helpers
{
    public class LocalCrudCnn : IDisposable
    {
        /// <summary>
        /// ORM CRUD datatable
        /// </summary>
        private SQLiteConnection cnn;

        //constructor de la base de datos DB3
        public LocalCrudCnn()
        {
            var configuracion = DependencyService.Get<ILocalDB>();
            cnn = new SQLiteConnection(Path.Combine(configuracion.directorio, "DBName.db3"), false);
            cnn.CreateTable<tableExample>();
        }

        // se utiliza para cerrar la coneccion
        public void Dispose()
        {
            cnn.Dispose();
        }

        //---------------------------------------------------------------------------------
        // Insertar datos en la tabla.
        public void InsertDataExample(tableExample modelo)
        {
            cnn.Insert(modelo);
        }

        // obtiene los datos guardado
        public List<tableExample> getDataTableExample()
        {
            return cnn.Table<tableExample>().ToList();
        }
    }
}
