using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteExample.Helpers
{
    /// <summary>
    /// Interfaz de coneccion para las distintas plataformas
    /// </summary>
    /// 
    public interface ILocalDB
    {
        string directorio { get; }                  //directorio del .db3.
    }
}
