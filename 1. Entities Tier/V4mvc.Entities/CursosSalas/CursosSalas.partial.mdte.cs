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
    public partial class CursosSalas
    {


        #region[ Propiedades ]
        public int START { get; set; }
        public int LENGTH { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public int COUNT { get; set; }
        public string COL0 { get; set; }
        public string COL1 { get; set; }
        public string COL2 { get; set; }
        public string COL3 { get; set; }
        public string COL4 { get; set; }
        public string COL5 { get; set; }

        #endregion


    }
}
