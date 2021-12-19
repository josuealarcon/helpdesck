using System;
using System.Collections.ObjectModel;

namespace V4mvc.Entities
{
    public partial class Admin
    {

        #region [ Variables]


        #endregion

        #region [ Propiedades  ]

        public String NOMBRES { get; set; }
        public String APELLIDOS { get; set; }
        public String TIPOUSUARIO { get; set; }
        public String COLABORADOR { get; set; }
        public int EXPIRA { get; set; }
        public string ADMEMAIL_O
        {
            get { return Utils.EmailOculto(ADMEMAIL); }
        }
        #endregion

    }
}
