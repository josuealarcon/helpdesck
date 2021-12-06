using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4mvc.Entities
{

    public partial class CheckDetail
    {

        #region [ Propiedades ]
        public string OPCIONES { get; set; }
        public string OPCIONES_SELECT { get; set; }
        public string PREGUNTA { get; set; }
        public string NOMGRUPO { get; set; }
        public string OBSVALIDA { get; set; }

        public string NOMOPCION { get; set; }
        public bool CHECKED { get; set; }

        public List<CheckDetail> ListOpciones
        {
            get
            {
                var listOpcionesReturn = new List<CheckDetail>();
                if (!string.IsNullOrEmpty(OPCIONES))
                {
                    var splitOptions = OPCIONES.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    foreach (var item in splitOptions)
                    {
                        listOpcionesReturn.Add(new CheckDetail()
                        {
                            CHECKED = (!string.IsNullOrEmpty(OPCIONES_SELECT) ? (OPCIONES_SELECT.Contains(item) ? true : false) : false)
                                                                 ,
                            NOMOPCION = item
                        });
                    }
                }
                return listOpcionesReturn;
            }
        }

        #endregion
    }
}