using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{
    public partial class Docs
    {
        public string EXTST { get; set; }
        public int ID_DOC_APOYO { get; set; }

        public string DOCUMENTO_ID { get; set; }
        public int SOLICITADO { get; set; }

        public string NOMBRE_CONTRATO { get; set; }

        public string TIPO_VEHICULO { get; set; }

        public string ESTADO_DOCUMENTO { get; set; }

        public int PRIMERO { get; set; }

        public string SOLICITADO_CADENA { get; set; }

        public string EMPRESA { get; set; }

        public string TIPO { get; set; }

        public int OPCION { get; set; }

        public string ACRONIMO { get; set; }

        public Nullable<Guid> DOCUMENTO_IDENTIFICADOR { get; set; }

        public string DOCUMENTO_ESTADO { get; set; }

        public int ITEM_CHECKLIST { get; set; }
        public string NOMBRE_DOCUMENTO { get; set; }
        public string DEPENDENCIA { get; set; }
        public string DOCUMENTO { get; set; }
        public Docs listNombreDocumento { get; set; }
        public ObservableCollection<ReqVal_Docs> listRequisitosValidacion { get; set; }
        public ObservableCollection<Empresascertificadoras> listEmpresasCertificadoras { get; set; }
        public ObservableCollection<Docs_Fec> ListDocsFecFechasNombres { get; set; }
        public ObservableCollection<Divisiones> ListDivisiones { get; set; }
        public ObservableCollection<A024_Divisiones> listDivisionesChecked { get; set; }
        public Archivos ARCHIVO_CARGADO { get; set; }
        public Docs documentos { get; set; }
        public Docs transport { get; set; }
        public int NRO { get; set; }
        public int ORDENGRUPO { get; set; }
     
       
    }
 
}
