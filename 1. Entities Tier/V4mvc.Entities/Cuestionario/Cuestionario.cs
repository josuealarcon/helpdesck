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
	public partial class Cuestionario 
	{
		#region [ Variables ]
		private Int32 m_codigo;
		private String m_codformato;
		private String m_descripcion;
		private Int32 m_orden;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Cuestionario.
		/// </summary>
		public Cuestionario()
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
		/// Gets or sets el valor de: DESCRIPCION.
		/// </summary>
		public String DESCRIPCION
		{
			get { return m_descripcion; }
			set
			{
				if (m_descripcion != value)
				{
					m_descripcion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ORDEN.
		/// </summary>
		public Int32 ORDEN
		{
			get { return m_orden; }
			set
			{
				if (m_orden != value)
				{
					m_orden = value;
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
