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
	public partial class CursosSalas 
	{
		#region [ Variables ]
		private String m_lugar;
		private String m_sala;
		private Nullable<Int32> m_capacidad;
		private String m_ubicacion;
		private String m_activa;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase CursosSalas.
		/// </summary>
		public CursosSalas()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: LUGAR.
		/// </summary>
		public String LUGAR
		{
			get { return m_lugar; }
			set
			{
				if (m_lugar != value)
				{
					m_lugar = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SALA.
		/// </summary>
		public String SALA
		{
			get { return m_sala; }
			set
			{
				if (m_sala != value)
				{
					m_sala = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CAPACIDAD.
		/// </summary>
		public Nullable<Int32> CAPACIDAD
		{
			get { return m_capacidad; }
			set
			{
				if (m_capacidad != value)
				{
					m_capacidad = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: UBICACION.
		/// </summary>
		public String UBICACION
		{
			get { return m_ubicacion; }
			set
			{
				if (m_ubicacion != value)
				{
					m_ubicacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ACTIVA.
		/// </summary>
		public String ACTIVA
		{
			get { return m_activa; }
			set
			{
				if (m_activa != value)
				{
					m_activa = value;
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
