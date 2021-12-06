using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Departamento
	{
		#region [ Variables ]

		private Int32 m_id_departamento;
		private string m_nombre_departamento;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Departamento.
		/// </summary>
		public Departamento()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: Id_Departamento.
		/// </summary>
		public Int32 Id_Departamento
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
		/// Gets or sets el valor de: Nombre_Departamento.
		/// </summary>
		public string Nombre_Departamento
		{
			get { return m_nombre_departamento; }
			set
			{
				if (m_nombre_departamento != value)
				{
					m_nombre_departamento = value;
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
