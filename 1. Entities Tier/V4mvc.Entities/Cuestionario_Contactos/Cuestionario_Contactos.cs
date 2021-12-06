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
	public partial class Cuestionario_Contactos 
	{
		#region [ Variables ]
		private Int32 m_codcuestionario;
		private Int32 m_codalternativa;
		private String m_rut;
		private Int32 m_codctrl_inicial;
		private String m_rut_referencia;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Cuestionario_Contactos.
		/// </summary>
		public Cuestionario_Contactos()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CODCUESTIONARIO.
		/// </summary>
		public Int32 CODCUESTIONARIO
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
		public Int32 CODALTERNATIVA
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
