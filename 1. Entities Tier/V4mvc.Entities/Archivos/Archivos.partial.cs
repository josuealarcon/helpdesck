using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace V4mvc.Entities
{
	public partial class Archivos
	{

        #region [ Variables ]

        #endregion

        #region [ Propiedades ]

        public string EXTENSION { get; set; }

        public string BASENAME {
            get {
                return System.IO.Path.GetFileNameWithoutExtension(this.NOMBRE);
            } 
        }

        public string CONTENIDO_BASE64 {
            get;set;
        }

        #endregion

    }
}
