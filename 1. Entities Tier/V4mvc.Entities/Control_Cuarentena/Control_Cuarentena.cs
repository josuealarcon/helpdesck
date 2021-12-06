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
	public partial class Control_Cuarentena 
	{
		#region [ Variables ]
		private Int32 m_codigo;
		private Nullable<Int32> m_codctrl_inicial;
		private String m_rut;
		private String m_fechaini;
		private String m_fechafin;
		private String m_usuario;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Control_Cuarentena.
		/// </summary>
		public Control_Cuarentena()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CODIGO.
		/// </summary>
		public Int32 CODIGO
		{
			get { return m_codigo; }
			set
			{
				if (m_codigo != value)
				{
					m_codigo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CODCTRL_INICIAL.
		/// </summary>
		public Nullable<Int32> CODCTRL_INICIAL
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
		/// Gets or sets el valor de: FECHAINI.
		/// </summary>
		public String FECHAINI
		{
			get { return m_fechaini; }
			set
			{
				if (m_fechaini != value)
				{
					m_fechaini = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHAFIN.
		/// </summary>
		public String FECHAFIN
		{
			get { return m_fechafin; }
			set
			{
				if (m_fechafin != value)
				{
					m_fechafin = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USUARIO.
		/// </summary>
		public String USUARIO
		{
			get { return m_usuario; }
			set
			{
				if (m_usuario != value)
				{
					m_usuario = value;
				}
			}
		}

        public String F200 { get; set; }

        public String VALF200 { get; set; }
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
