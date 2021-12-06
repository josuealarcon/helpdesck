using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    [Serializable()]
    public partial class Destinatarios
    {
        #region [ Variables ]
        private String m_email;
        private String m_modulo;
        #endregion

        #region [ Constructores ]
        ///<summary>
        ///Inicializar una nueva instancia de la clase Destinatarios
        /// </summary>
        public Destinatarios()
        { }
        #endregion

        #region [ Propiedades ]
        ///<summary>
        ///Gets or sets el valor de: EMAIL
        /// </summary>
        public String EMAIL
        {
            get { return m_email; }
            set
            {
                if (m_email != value)
                {
                    m_email = value;
                }
            }
        }
        ///<summary>
        ///Gets or sets el valor de: MODULO
        /// </summary>
        public String MODULO
        {
            get { return m_modulo; }
            set
            {
                if (m_modulo != value)
                {
                    m_modulo = value;
                }
            }
        }
        #endregion

        #region [ Instance Entity ]
        public InstanceEntity m_instance;

        ///<summary>
        ///Gets or sets el valor de: InstanceEntity.
        /// </summary>
        public InstanceEntity Instance
        {
            get { return m_instance; }
            set { m_instance = value; }
        }
        #endregion
    }
}
