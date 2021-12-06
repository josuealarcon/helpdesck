using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Sector
	{
		#region [ Variables ]

		private Int32 m_id_sector;
		private string m_nombre_sector;
		private Int32? m_id_departamento;
		private Int32? m_id_tipo_sector;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Sector.
		/// </summary>
		public Sector()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: ID_SECTOR.
		/// </summary>
		public Int32 ID_SECTOR
		{
			get { return m_id_sector; }
			set
			{
				if (m_id_sector != value)
				{
					m_id_sector = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NOMBRE_SECTOR.
		/// </summary>
		public string NOMBRE_SECTOR
		{
			get { return m_nombre_sector; }
			set
			{
				if (m_nombre_sector != value)
				{
					m_nombre_sector = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_DEPARTAMENTO.
		/// </summary>
		public Int32? ID_DEPARTAMENTO
		{
			get { return m_id_departamento; }
			set
			{
				if (m_id_departamento != value)
				{
					m_id_departamento = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ID_TIPO_SECTOR.
		/// </summary>
		public Int32? ID_TIPO_SECTOR
		{
			get { return m_id_tipo_sector; }
			set
			{
				if (m_id_tipo_sector != value)
				{
					m_id_tipo_sector = value;
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
