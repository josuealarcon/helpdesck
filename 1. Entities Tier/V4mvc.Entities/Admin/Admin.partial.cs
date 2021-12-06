using System;
using System.Collections.ObjectModel;

namespace V4mvc.Entities
{
    public partial class Admin
    {

        #region [ Variables]

        public ObservableCollection<Docs_Manuales> LIST_DOCS_MANUALES { get; set; }

        #endregion

        #region [ Propiedades  ]

        public String NOMBRES { get; set; }
        public String APELLIDOS { get; set; }
        public String TIPOUSUARIO { get; set; }
        public int EXPIRA { get; set; }
        public string ADMEMAIL_O
        {
            get { return Utils.EmailOculto(ADMEMAIL); }
        }
        #endregion

    }
}
