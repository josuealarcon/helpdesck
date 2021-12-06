using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class CertDesautorizacionTransport
	{
		#region [ Variables ]

		private string m_patente;
		private string m_observacion;
		private string m_bloquea;
		private string m_division;
		private Guid? m_id_archivo;
		private string m_usrbloquea;
		private string m_fecbloquea;
		private string m_horabloquea;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase CertDesautorizacionTransport.
		/// </summary>
		public CertDesautorizacionTransport()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: PATENTE.
		/// </summary>
		public string PATENTE
		{
			get { return m_patente; }
			set
			{
				if (m_patente != value)
				{
					m_patente = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OBSERVACION.
		/// </summary>
		public string OBSERVACION
		{
			get { return m_observacion; }
			set
			{
				if (m_observacion != value)
				{
					m_observacion = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: BLOQUEA.
		/// </summary>
		public string BLOQUEA
		{
			get { return m_bloquea; }
			set
			{
				if (m_bloquea != value)
				{
					m_bloquea = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DIVISION.
		/// </summary>
		public string DIVISION
		{
			get { return m_division; }
			set
			{
				if (m_division != value)
				{
					m_division = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_ARCHIVO.
		/// </summary>
		public Guid? ID_ARCHIVO
		{
			get { return m_id_archivo; }
			set
			{
				if (m_id_archivo != value)
				{
					m_id_archivo = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USRBLOQUEA.
		/// </summary>
		public string USRBLOQUEA
		{
			get { return m_usrbloquea; }
			set
			{
				if (m_usrbloquea != value)
				{
					m_usrbloquea = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECBLOQUEA.
		/// </summary>
		public string FECBLOQUEA
		{
			get { return m_fecbloquea; }
			set
			{
				if (m_fecbloquea != value)
				{
					m_fecbloquea = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: HORABLOQUEA.
		/// </summary>
		public string HORABLOQUEA
		{
			get { return m_horabloquea; }
			set
			{
				if (m_horabloquea != value)
				{
					m_horabloquea = value;
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
