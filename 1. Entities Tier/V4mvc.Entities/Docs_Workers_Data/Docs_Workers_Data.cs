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
	public partial class Docs_Workers_Data
	{
		#region [ Variables ]
		private Int32 m_id;
		private Nullable<Guid> m_id_doc;
		private String m_salario;
		private Nullable<Int32> m_cargo;
		private String m_turno;
		private String m_ost;
		private String m_tipocontrato;
		private String m_sueldo_base;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Docs_Workers_Data.
		/// </summary>
		public Docs_Workers_Data()
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
		/// Gets or sets el valor de: ID_DOC.
		/// </summary>
		public Nullable<Guid> ID_DOC
		{
			get { return m_id_doc; }
			set
			{
				if (m_id_doc != value)
				{
					m_id_doc = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SALARIO.
		/// </summary>
		public String SALARIO
		{
			get { return m_salario; }
			set
			{
				if (m_salario != value)
				{
					m_salario = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CARGO.
		/// </summary>
		public Nullable<Int32> CARGO
		{
			get { return m_cargo; }
			set
			{
				if (m_cargo != value)
				{
					m_cargo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TURNO.
		/// </summary>
		public String TURNO
		{
			get { return m_turno; }
			set
			{
				if (m_turno != value)
				{
					m_turno = value;
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
		/// Gets or sets el valor de: TIPOCONTRATO.
		/// </summary>
		public String TIPOCONTRATO
		{
			get { return m_tipocontrato; }
			set
			{
				if (m_tipocontrato != value)
				{
					m_tipocontrato = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SUELDO_BASE.
		/// </summary>
		public String SUELDO_BASE
		{
			get { return m_sueldo_base; }
			set
			{
				if (m_sueldo_base != value)
				{
					m_sueldo_base = value;
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
