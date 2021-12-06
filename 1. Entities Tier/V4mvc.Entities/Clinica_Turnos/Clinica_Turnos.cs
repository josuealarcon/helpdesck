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
	public partial class Clinica_Turnos 
	{
		#region [ Variables ]
		private Int32 m_codigo;
		private Int32 m_codctrl_inicial;
		private String m_rut;
		private String m_ruc;
		private String m_hora;
		private String m_fecha;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Clinica_Turnos.
		/// </summary>
		public Clinica_Turnos()
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
		/// Gets or sets el valor de: RUC.
		/// </summary>
		public String RUC
		{
			get { return m_ruc; }
			set
			{
				if (m_ruc != value)
				{
					m_ruc = value;
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
