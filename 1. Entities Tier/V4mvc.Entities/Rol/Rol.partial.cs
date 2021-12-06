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
    public partial class Rol
    {

        #region [ Propiedades ]

        public int START { get; set; }
        public int LENGTH { get; set; }
        public int COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public string DESCRIPCION { get; set; }
        public string COL0 { get; set; }
        public string COL1 { get; set; }
        public string COL2 { get; set; }
        public string COL3 { get; set; }
        public string COL4 { get; set; }
        public string COL5 { get; set; }
        public string COL6 { get; set; }
        public string COL7 { get; set; }
        public int COUNT { get; set; }

        #endregion

    }
}
