using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
    public partial class BLCharlas
    {

        #region [ Consultas ]

        public ObservableCollection<Charlas> GetListCharlasDivision_Mdte(ref Charlas charlas)
        {
            try
            {
                return this.Repository.GetListCharlasDivision_Mdte(ref charlas);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Charlas GetOneCharla_Mdte(int IDCHARLA)
        {
            try
            {
                 var  model = this.Repository.GetOneCharla_Mdte(IDCHARLA);
                return model;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Charlas> GetCursosMdteSearcherMdte(ref Charlas model)
        {
            try
            {
                return this.Repository.GetCursosMdteSearcherMdte(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]


        public bool SaveCharlas_Mdte(ref Charlas charla)
        {
            try
            {

                using (TransactionScope tran = new TransactionScope())
                {
                    this.Repository.SaveCharlas_Mdte(ref charla);
                    if (charla.Instance == InstanceEntity.Modify)
                        this.RepositoryCharlasDivision.DeleteAll(charla.IDCHARLA);
                    if (charla.ListDivisiones != null)
                    {
                        foreach (var _item in charla.ListDivisiones)
                        {
                            var charlasDivision = new Charlas_Division();
                            charlasDivision.IDCHARLA = charla.IDCHARLA;
                            charlasDivision.DIVISION = _item.DIVCOD;
                            charlasDivision.Instance = InstanceEntity.New;
                            this.RepositoryCharlasDivision.Save(ref charlasDivision);
                        }
                    }
                    tran.Complete();
                }
                return true;


            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
