using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

	public partial class AAQ_Categorias
	{
        #region[ Propiedades ]

        public string REGIMEN { get; set; }
        public int START { get; set; }
        public int LENGTH { get; set; }
        public string COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public int COUNT { get; set; } 
         
        #endregion

        #region [ Propiedades ]

        public string TIPO { get; set; }
        public ObservableCollection<AAQ_Regimen> LISTADO_REGIMEN { get; set; }

        #endregion
    }
}