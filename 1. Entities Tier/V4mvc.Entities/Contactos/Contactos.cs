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
	public partial class Contactos 
	{
		#region [ Variables ]
		private Int32 m_codctrl_inicial;
		private String m_rut_referencia;
		private String m_rut;
		private String m_nombres;
		private String m_apellidos;
		private String m_celular;
		private String m_fecha;
		private String m_hora;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Contactos.
		/// </summary>
		public Contactos()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CODCTRL_INICIAL.
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
		/// Gets or sets el valor de: RUT_REFERENCIA.
		/// </summary>
		public String RUT_REFERENCIA
		{
			get { return m_rut_referencia; }
			set
			{
				if (m_rut_referencia != value)
				{
					m_rut_referencia = value;
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
		/// Gets or sets el valor de: NOMBRES.
		/// </summary>
		public String NOMBRES
		{
			get { return m_nombres; }
			set
			{
				if (m_nombres != value)
				{
					m_nombres = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: APELLIDOS.
		/// </summary>
		public String APELLIDOS
		{
			get { return m_apellidos; }
			set
			{
				if (m_apellidos != value)
				{
					m_apellidos = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CELULAR.
		/// </summary>
		public String CELULAR
		{
			get { return m_celular; }
			set
			{
				if (m_celular != value)
				{
					m_celular = value;
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
		/// Gets or sets el valor de: HORA.
		/// </summary>
		public String HORA
		{
			get { return m_hora; }
			set
			{
				if (m_hora != value)
				{
					m_hora = value;
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
