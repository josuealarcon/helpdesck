using System.Collections.ObjectModel;

namespace V4mvc.Entities
{
    public partial class Ccostos
    {

        #region [ Variables Validación ]

        public string ACRONIMO { get; set; }
        public ObservableCollection<Ccostos> LIST_CCOSTOS { get; set; }

        #endregion

        #region [ Propiedades ]
        public int START { get; set; }
        public int LENGTH { get; set; }
        public int COLUMN { get; set; }
        public string DIRECTION { get; set; }
        public int COUNT { get; set; }
        public string COL0 { get; set; }
        public string COL1 { get; set; }
        public string COL2 { get; set; }
        #endregion

    }
}
