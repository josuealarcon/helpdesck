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
	[Serializable()]
	public partial class Aprobacion_SubContratos
    {
		#region [ Variables ]
		private Int32 m_id;
		private String m_empresa;
		private String m_ost;
		private String m_finicio;
		private String m_ftermino;
		private Int32 m_monto;
        private Int32 m_nivel;
        private Int32 m_dotacion;
        private String m_correo_adm_ctta;
        private Int32 m_dotacion_vehi;
        private String m_madre;
        private String m_admin_ctta;
        private String m_telefono;
        private Guid m_id_archivo;
        private String m_licitacion;
        private String m_validado;
        private String m_usr_solicita;
        private String m_fec_solicita;
        private String m_hora_solicita;
        private String m_adm_valida_estado;
        private String m_adm_valida;
        private String m_fec_adm_valida;
        private String m_hora_adm_valida;
        private String m_obs_adm_valida;
        private String m_adm_supchain_estado;
        private String m_adm_supchain_valida;
        private String m_fec_supchain_valida;
        private String m_hora_supchain_valida;
        private String m_obs_supchain_valida;
        private String m_adm_gseguridad_estado;
        private String m_adm_gseguridad_valida;
        private String m_fec_gseguridad_valida;
        private String m_hora_gseguridad_valida;
        private String m_obs_gseguridad_valida;
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Archivos.
        /// </summary>
        public Aprobacion_SubContratos()
		{  }
        #endregion

        #region [ Propiedades ]
        /// <summary>
        /// Gets or sets el valor de: ID.
        /// </summary>
        public Int32 ID
        {
            get { return m_id; }
            set
            {
                if (m_id != value)
                {
                    m_id = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: EMPRESA.
        /// </summary>
        public String EMPRESA
        {
			get { return m_empresa; }
			set
			{
				if (m_empresa != value)
				{
                    m_empresa = value;
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: OST.
        /// </summary>
        public String OST
        {
			get { return m_ost; }
			set
			{
				if (m_ost != value)
				{
                    m_ost = value;
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: FINICIO.
        /// </summary>
        public String FINICIO
        {
			get { return m_finicio; }
			set
			{
				if (m_finicio != value)
				{
                    m_finicio = value;
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: FTERMINO.
        /// </summary>
        public String FTERMINO
        {
			get { return m_ftermino; }
			set
			{
				if (m_ftermino != value)
				{
                    m_ftermino = value;
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: MONTO.
        /// </summary>
        public Int32 MONTO
        {
			get { return m_monto; }
			set
			{
				if (m_monto != value)
				{
                    m_monto = value;
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: DOTACION.
        /// </summary>
        public Int32 DOTACION
        {
            get { return m_dotacion; }
            set
            {
                if (m_dotacion != value)
                {
                    m_dotacion = value;
                }
            }
        }
        /// <summary>
		/// Gets or sets el valor de: NIVEL.
		/// </summary>
		public Int32 NIVEL
        {
            get { return m_nivel; }
            set
            {
                if (m_nivel != value)
                {
                    m_nivel = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: CORREO_ADM_CTTA.
        /// </summary>
        public String CORREO_ADM_CTTA
        {
            get { return m_correo_adm_ctta; }
            set
            {
                if (m_correo_adm_ctta != value)
                {
                    m_correo_adm_ctta = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: DOTACION_VEHI.
        /// </summary>
        public Int32 DOTACION_VEHI
        {
            get { return m_dotacion_vehi; }
            set
            {
                if (m_dotacion_vehi != value)
                {
                    m_dotacion_vehi = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: MADRE.
        /// </summary>
        public String MADRE
        {
            get { return m_madre; }
            set
            {
                if (m_madre != value)
                {
                    m_madre = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: ADMIN_CTTA.
        /// </summary>
        public String ADMIN_CTTA
        {
            get { return m_admin_ctta; }
            set
            {
                if (m_admin_ctta != value)
                {
                    m_admin_ctta = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: TELEFONO.
        /// </summary>
        public String TELEFONO
        {
            get { return m_telefono; }
            set
            {
                if (m_telefono != value)
                {
                    m_telefono = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: ID_ARCHIVO.
        /// </summary>
        public Guid ID_ARCHIVO
        {
            get { return m_id_archivo; }
            set
            {
                if (m_id_archivo != value)
                {
                    m_id_archivo = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: LICITACION.
        /// </summary>
        public String LICITACION
        {
            get { return m_licitacion; }
            set
            {
                if (m_licitacion != value)
                {
                    m_licitacion = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: VALIDADO.
        /// </summary>
        public String VALIDADO
        {
            get { return m_validado; }
            set
            {
                if (m_validado != value)
                {
                    m_validado = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: USR_SOLICITA.
        /// </summary>
        public String USR_SOLICITA
        {
            get { return m_usr_solicita; }
            set
            {
                if (m_usr_solicita != value)
                {
                    m_usr_solicita = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: FEC_SOLICITA.
        /// </summary>
        public String FEC_SOLICITA
        {
            get { return m_fec_solicita; }
            set
            {
                if (m_fec_solicita != value)
                {
                    m_fec_solicita = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: HORA_SOLICITA.
        /// </summary>
        public String HORA_SOLICITA
        {
            get { return m_hora_solicita; }
            set
            {
                if (m_hora_solicita != value)
                {
                    m_hora_solicita = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ADM_VALIDA_ESTADO.
        /// </summary>
        public String ADM_VALIDA_ESTADO
        {
            get { return m_adm_valida_estado; }
            set
            {
                if (m_adm_valida_estado != value)
                {
                    m_adm_valida_estado = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: ADM_VALIDA.
        /// </summary>
        public String ADM_VALIDA
        {
            get { return m_adm_valida; }
            set
            {
                if (m_adm_valida != value)
                {
                    m_adm_valida = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: FEC_ADM_VALIDA.
        /// </summary>
        public String FEC_ADM_VALIDA
        {
            get { return m_fec_adm_valida; }
            set
            {
                if (m_fec_adm_valida != value)
                {
                    m_fec_adm_valida = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: HORA_ADM_VALIDA.
        /// </summary>
        public String HORA_ADM_VALIDA
        {
            get { return m_hora_adm_valida; }
            set
            {
                if (m_hora_adm_valida != value)
                {
                    m_hora_adm_valida = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: OBS_ADM_VALIDA.
        /// </summary>
        public String OBS_ADM_VALIDA
        {
            get { return m_obs_adm_valida; }
            set
            {
                if (m_obs_adm_valida != value)
                {
                    m_obs_adm_valida = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: ADM_SUPCHAIN_ESTADO.
        /// </summary>
        public String ADM_SUPCHAIN_ESTADO
        {
            get { return m_adm_supchain_estado; }
            set
            {
                if (m_adm_supchain_estado != value)
                {
                    m_adm_supchain_estado = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: ADM_SUPCHAIN_VALIDA.
        /// </summary>
        public String ADM_SUPCHAIN_VALIDA
        {
            get { return m_adm_supchain_valida; }
            set
            {
                if (m_adm_supchain_valida != value)
                {
                    m_adm_supchain_valida = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: FEC_SUPCHAIN_VALIDA.
        /// </summary>
        public String FEC_SUPCHAIN_VALIDA
        {
            get { return m_fec_supchain_valida; }
            set
            {
                if (m_fec_supchain_valida != value)
                {
                    m_fec_supchain_valida = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: HORA_SUPCHAIN_VALIDA.
        /// </summary>
        public String HORA_SUPCHAIN_VALIDA
        {
            get { return m_hora_supchain_valida; }
            set
            {
                if (m_hora_supchain_valida != value)
                {
                    m_hora_supchain_valida = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: OBS_SUPCHAIN_VALIDA.
        /// </summary>
        public String OBS_SUPCHAIN_VALIDA
        {
            get { return m_obs_supchain_valida; }
            set
            {
                if (m_obs_supchain_valida != value)
                {
                    m_obs_supchain_valida = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: ADM_GSEGURIDAD_ESTADO.
        /// </summary>
        public String ADM_GSEGURIDAD_ESTADO
        {
            get { return m_adm_gseguridad_estado; }
            set
            {
                if (m_adm_gseguridad_estado != value)
                {
                    m_adm_gseguridad_estado = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: ADM_GSEGURIDAD_VALIDA.
        /// </summary>
        public String ADM_GSEGURIDAD_VALIDA
        {
            get { return m_adm_gseguridad_valida; }
            set
            {
                if (m_adm_gseguridad_valida != value)
                {
                    m_adm_gseguridad_valida = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: FEC_GSEGURIDAD_VALIDA.
        /// </summary>
        public String FEC_GSEGURIDAD_VALIDA
        {
            get { return m_fec_gseguridad_valida; }
            set
            {
                if (m_fec_gseguridad_valida != value)
                {
                    m_fec_gseguridad_valida = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: HORA_GSEGURIDAD_VALIDA.
        /// </summary>
        public String HORA_GSEGURIDAD_VALIDA
        {
            get { return m_hora_gseguridad_valida; }
            set
            {
                if (m_hora_gseguridad_valida != value)
                {
                    m_hora_gseguridad_valida = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: OBS_GSEGURIDAD_VALIDA.
        /// </summary>
        public String OBS_GSEGURIDAD_VALIDA
        {
            get { return m_obs_gseguridad_valida; }
            set
            {
                if (m_obs_gseguridad_valida != value)
                {
                    m_obs_gseguridad_valida = value;
                }
            }
        }

        #endregion

        #region [ Instance Entity ]
        public InstanceEntity m_instance;
		
		/// <summary>
		/// Gets or sets el valor de: InstanceEntity.
		/// </summary>
		public InstanceEntity Instance
		{
			get { return m_instance; }
			set { m_instance = value; }
		}
		
		#endregion

	}
}
