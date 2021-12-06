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
	public partial class Motivo_Finiquito 
	{
		#region [ Variables ]
		private String m_motivo;
		private String m_glosa;
		private String m_activo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Motivo_Finiquito.
		/// </summary>
		public Motivo_Finiquito()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: MOTIVO.
		/// </summary>
		public String MOTIVO
		{
			get { return m_motivo; }
			set
			{
				if (m_motivo != value)
				{
					m_motivo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GLOSA.
		/// </summary>
		public String GLOSA
		{
			get { return m_glosa; }
			set
			{
				if (m_glosa != value)
				{
					m_glosa = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ACTIVO.
		/// </summary>
		public String ACTIVO
		{
			get { return m_activo; }
			set
			{
				if (m_activo != value)
				{
					m_activo = value;
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
