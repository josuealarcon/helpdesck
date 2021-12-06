using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class FlotaBus
	{
		#region [ Variables ]

		private Int32 m_idflota;
		private string m_flota;
		private Int32? m_valor;
		private string m_division;
		private string m_activo;
		

		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase FlotaBus.
		/// </summary>
		public FlotaBus()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: IDFLOTA.
		/// </summary>
		public Int32 IDFLOTA
		{
			get { return m_idflota; }
			set
			{
				if (m_idflota != value)
				{
					m_idflota = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FLOTA.
		/// </summary>
		public string FLOTA
		{
			get { return m_flota; }
			set
			{
				if (m_flota != value)
				{
					m_flota = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: VALOR.
		/// </summary>
		public Int32? VALOR
		{
			get { return m_valor; }
			set
			{
				if (m_valor != value)
				{
					m_valor = value;
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
		/// Gets or sets el valor de: ACTIVO.
		/// </summary>
		public string ACTIVO
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
