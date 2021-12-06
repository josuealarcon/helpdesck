using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
   public partial class Reservas_Revision_Vehicular
    {
        public decimal ID { get; set; }
        public string EMPRESA { get; set; }
        public string PATENTE { get; set; }
        public string FECHARES { get; set; }
        public string HORAINICIO { get; set; }
        public string HORATERMINO { get; set; }
        public int? MINUTOS { get; set; }
        public string ASISTIO { get; set; }
        public int? MOTIVO { get; set; }
        public string FECHASOL { get; set; }
        public string HORASOL { get; set; }
        public string FECHAMOD { get; set; }
        public string HORAMOD { get; set; }
        public string USUARIOSOL { get; set; }
        public string DIVISION { get; set; }
        public string OST { get; set; }
        public int? IDMOTIVORESERVA { get; set; }

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
