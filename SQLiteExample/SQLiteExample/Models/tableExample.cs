using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SQLiteExample.Models
{
    public class tableExample : INotifyPropertyChanged
    {
        /// <summary>
        /// Tabla de ejemplo.
        /// </summary>
        /// 
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChange(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        private int idRow { get; set; }

        [PrimaryKey, AutoIncrement]
        public int IdRow
        {
            get
            {
                return idRow;
            }
            set
            {
                if (idRow != value)
                {
                    idRow = value;
                    OnPropertyChange("IdRow");
                }
            }
        }

        private string label { get; set; }

        public string Label
        {
            get
            {
                return label;
            }
            set
            {
                if (label != value)
                {
                    label = value;
                    OnPropertyChange("Label");
                }
            }
        }
    }
}
