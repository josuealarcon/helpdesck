using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class TalleresVeh
	{
		#region [ Variables ]

		private Int32 m_idtaller;
		private string m_taller;
		private string m_usermod;
		private string m_fechamod;
		private string m_horamod;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase TalleresVeh.
		/// </summary>
		public TalleresVeh()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: IDTALLER.
		/// </summary>
		public Int32 IDTALLER
		{
			get { return m_idtaller; }
			set
			{
				if (m_idtaller != value)
				{
					m_idtaller = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TALLER.
		/// </summary>
		public string TALLER
		{
			get { return m_taller; }
			set
			{
				if (m_taller != value)
				{
					m_taller = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USERMOD.
		/// </summary>
		public string USERMOD
		{
			get { return m_usermod; }
			set
			{
				if (m_usermod != value)
				{
					m_usermod = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FECHAMOD.
		/// </summary>
		public string FECHAMOD
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
		/// Gets or sets el valor de: HORAMOD.
		/// </summary>
		public string HORAMOD
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
