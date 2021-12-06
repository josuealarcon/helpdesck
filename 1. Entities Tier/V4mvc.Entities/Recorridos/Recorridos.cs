using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class Recorridos
	{
		#region [ Variables ]

		private Int32 m_idrecorrido;
		private string m_recorrido;
		private Int32? m_capacidad_libera;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Recorridos.
		/// </summary>
		public Recorridos()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: IDRECORRIDO.
		/// </summary>
		public Int32 IDRECORRIDO
		{
			get { return m_idrecorrido; }
			set
			{
				if (m_idrecorrido != value)
				{
					m_idrecorrido = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: RECORRIDO.
		/// </summary>
		public string RECORRIDO
		{
			get { return m_recorrido; }
			set
			{
				if (m_recorrido != value)
				{
					m_recorrido = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CAPACIDAD_LIBERA.
		/// </summary>
		public Int32? CAPACIDAD_LIBERA
		{
			get { return m_capacidad_libera; }
			set
			{
				if (m_capacidad_libera != value)
				{
					m_capacidad_libera = value;
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
