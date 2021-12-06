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
	public partial class Finiquitos 
	{
		#region [ Variables ]
		private String m_rut;
		private String m_fechacambio;
		private String m_emporigen;
		private String m_empdest;
		private String m_fechamod;
		private String m_horamod;
		private Nullable<Int32> m_nropase;
		private String m_finiquito;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Finiquitos.
		/// </summary>
		public Finiquitos()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Rut.
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
		/// Gets or sets el valor de: FechaCambio.
		/// </summary>
		public String FechaCambio
		{
			get { return m_fechacambio; }
			set
			{
				if (m_fechacambio != value)
				{
					m_fechacambio = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EmpOrigen.
		/// </summary>
		public String EmpOrigen
		{
			get { return m_emporigen; }
			set
			{
				if (m_emporigen != value)
				{
					m_emporigen = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EmpDest.
		/// </summary>
		public String EmpDest
		{
			get { return m_empdest; }
			set
			{
				if (m_empdest != value)
				{
					m_empdest = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FechaMod.
		/// </summary>
		public String FechaMod
		{
			get { return m_fechamod; }
			set
			{
				if (m_fechamod != value)
				{
					m_fechamod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HoraMod.
		/// </summary>
		public String HoraMod
		{
			get { return m_horamod; }
			set
			{
				if (m_horamod != value)
				{
					m_horamod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NroPase.
		/// </summary>
		public Nullable<Int32> NroPase
		{
			get { return m_nropase; }
			set
			{
				if (m_nropase != value)
				{
					m_nropase = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: Finiquito.
		/// </summary>
		public String Finiquito
		{
			get { return m_finiquito; }
			set
			{
				if (m_finiquito != value)
				{
					m_finiquito = value;
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
