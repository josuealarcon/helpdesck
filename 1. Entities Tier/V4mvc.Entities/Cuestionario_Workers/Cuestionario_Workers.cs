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
	public partial class Cuestionario_Workers 
	{
        #region [ Variables ]
        private int m_codctrl_inicial;
        private String m_rut;
        private int m_codcuarentena;
        private string m_fecha;
        private String m_codformato;
		private Nullable<Int32> m_codcuestionario;
		private Nullable<Int32> m_codalternativa;
        private String m_dato;
        private String m_comentario;
		private String m_fechasube;
		private String m_horasube;
		private String m_fechavalida;
		private String m_horavalida;
		private String m_usuariosube;
		private String m_usuariovalida;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Cuestionario_Workers.
		/// </summary>
		public Cuestionario_Workers()
		{  }
        #endregion

        #region [ Propiedades ]

        /// <summary>
        /// Gets or sets el valor de: RUT.
        /// </summary>
        public Int32 CODCTRL_INICIAL
        {
            get { return m_codctrl_inicial; }
            set
            {
                if (m_codctrl_inicial != value)
                {
                    m_codctrl_inicial = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: RUT.
        /// </summary>
        public String RUT
		{
			get { return m_rut; }
			set
			{
				if (m_rut != value)
				{
					m_rut = value;
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: CODCUARENTENA.
        /// </summary>
        public Int32 CODCUARENTENA
        {
            get { return m_codcuarentena; }
            set
            {
                if (m_codcuarentena != value)
                {
                    m_codcuarentena = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: FECHA.
        /// </summary>
        public String FECHA
        {
            get { return m_fecha; }
            set
            {
                if (m_fecha != value)
                {
                    m_fecha = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CODFORMATO.
        /// </summary>
        public String CODFORMATO
		{
			get { return m_codformato; }
			set
			{
				if (m_codformato != value)
				{
					m_codformato = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CODCUESTIONARIO.
		/// </summary>
		public Nullable<Int32> CODCUESTIONARIO
		{
			get { return m_codcuestionario; }
			set
			{
				if (m_codcuestionario != value)
				{
					m_codcuestionario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CODALTERNATIVA.
		/// </summary>
		public Nullable<Int32> CODALTERNATIVA
		{
			get { return m_codalternativa; }
			set
			{
				if (m_codalternativa != value)
				{
					m_codalternativa = value;
				}
			}
		}

        /// <summary>
		/// Gets or sets el valor de: DATO.
		/// </summary>
		public String DATO
        {
            get { return m_dato; }
            set
            {
                if (m_dato != value)
                {
                    m_dato = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: COMENTARIO.
        /// </summary>
        public String COMENTARIO
		{
			get { return m_comentario; }
			set
			{
				if (m_comentario != value)
				{
					m_comentario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHASUBE.
		/// </summary>
		public String FECHASUBE
		{
			get { return m_fechasube; }
			set
			{
				if (m_fechasube != value)
				{
					m_fechasube = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORASUBE.
		/// </summary>
		public String HORASUBE
		{
			get { return m_horasube; }
			set
			{
				if (m_horasube != value)
				{
					m_horasube = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHAVALIDA.
		/// </summary>
		public String FECHAVALIDA
		{
			get { return m_fechavalida; }
			set
			{
				if (m_fechavalida != value)
				{
					m_fechavalida = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORAVALIDA.
		/// </summary>
		public String HORAVALIDA
		{
			get { return m_horavalida; }
			set
			{
				if (m_horavalida != value)
				{
					m_horavalida = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USUARIOSUBE.
		/// </summary>
		public String USUARIOSUBE
		{
			get { return m_usuariosube; }
			set
			{
				if (m_usuariosube != value)
				{
					m_usuariosube = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USUARIOVALIDA.
		/// </summary>
		public String USUARIOVALIDA
		{
			get { return m_usuariovalida; }
			set
			{
				if (m_usuariovalida != value)
				{
					m_usuariovalida = value;
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
