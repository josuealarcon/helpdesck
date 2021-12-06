using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
	[Serializable()]
	public partial class AAQ_Categorias
	{
		#region [ Variables ]

		private Int32 m_idcategoria;
		private Int32 m_idregimen;
		private string m_nombre;
		private string m_clasificacion;
		private string m_activo;
        private string m_regimennom;


        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase AAQ_Categorias.
        /// </summary>
        public AAQ_Categorias()
		{ }

		#endregion

		#region [ Propiedades ]

				/// <summary>
		/// Gets or sets el valor de: IDCATEGORIA.
		/// </summary>
		public Int32 IDCATEGORIA
		{
			get { return m_idcategoria; }
			set
			{
				if (m_idcategoria != value)
				{
					m_idcategoria = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: IDREGIMEN.
		/// </summary>
		public Int32 IDREGIMEN
		{
			get { return m_idregimen; }
			set
			{
				if (m_idregimen != value)
				{
					m_idregimen = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NOMBRE.
		/// </summary>
		public string NOMBRE
		{
			get { return m_nombre; }
			set
			{
				if (m_nombre != value)
				{
					m_nombre = value;
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CLASIFICACION.
		/// </summary>
		public string CLASIFICACION
		{
			get { return m_clasificacion; }
			set
			{
				if (m_clasificacion != value)
				{
					m_clasificacion = value;
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

        /// <summary>
		/// Gets or sets el valor de: IDREGIMEN.
		/// </summary>
		public string REGIMENNOM
        {
            get { return m_regimennom; }
            set
            {
                if (m_regimennom != value)
                {
                    m_regimennom = value;
                }
            }
        }

        #endregion
    }
}
