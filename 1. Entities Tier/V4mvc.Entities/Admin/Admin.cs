using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    
    public partial class Admin
    {
        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Colab_Usuario.
        /// </summary>
        public Admin()
        { }
        #endregion
        public string ADMRUT { get; set; }
        public string ADMCLAVE { get; set; }
        public string ADMTIPO { get; set; }
        public string ADMEMAIL { get; set; }
        public string ADMRUTEMPRESA { get; set; }
        public string ADMLOCAL { get; set; }
        public string ADMLUGAR { get; set; }
        public int ADMPUERTOS { get; set; }
        public string ADMUSERID { get; set; }
        public string ADMRUTVER { get; set; }
        public string ADMSUP { get; set; }
        public string FECHAMOD { get; set; }
        public string HORAMOD { get; set; }
        public string GRABO { get; set; }
        public string ACTIVO { get; set; }
        public string ADMDIVISION { get; set; }
        public string FECHAVENCE { get; set; }
        public long IDSYNC { get; set; }
        public string ADMADLOGIN { get; set; }
        public string APRUEBA_COND { get; set; }

        #region [ Instance Entity ]
        public InstanceEntity m_instance;

        public InstanceEntity Instance
        {
            get { return m_instance; }
            set { m_instance = value; }
        }

        protected void RefreshInstanceEntity()
        {
            if (Instance != InstanceEntity.New && Instance != InstanceEntity.Delete)
            { Instance = InstanceEntity.Modify; }
        }
        #endregion
    }
}
