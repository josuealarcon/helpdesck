using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

	public partial class DocumentosContratistas
	{
        #region [ Variables ]

        #endregion

        #region [ Propiedades ]

        public int START { get; set; }
        public int LENGTH { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public string NOMBRE { get; set; }
        public int COUNT { get; set; }
        public string COL0 { get; set; }
        public string COL1 { get; set; }
        public string COL2 { get; set; }
        public string COL3 { get; set; }
        public ObservableCollection<Docs> ListDocumentos { get; set; }

        #endregion
    }
}