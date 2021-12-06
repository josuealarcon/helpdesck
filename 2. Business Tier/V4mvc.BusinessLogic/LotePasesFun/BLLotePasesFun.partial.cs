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
    public partial class BLLotePasesFun
    {

        #region [ Consultas ]

        public LotePasesFun GetLotePasesFunConduccionPase(string RUT, string DIVCOD)
        {
            try
            {
                return this.Repository.GetLotePasesFunConduccionPase(RUT, DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_PasesCtta(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE)
        {
            try
            {
                var funcionarios = this.Repository.GetAllLotePasesFun_PasesCtta(IDPASE, ID_EMPRESA, DIVCOD, FEC_INI, FEC_FIN, TIPO_PASE);
                foreach(var funcionario in funcionarios)
                {
                    funcionario.ZONAS_CONDUCCION = this.IDALocal_Repository.GetAllLocal_v2_PasesCtta(funcionario.RUTLOTE, DIVCOD, IDPASE, ID_EMPRESA);
                }
                foreach (var funcionario in funcionarios)
                {
                    funcionario.ZONAS_ACCESO = this.IDALocal_Repository.GetAllLocalAcceso_v2_PasesCtta(funcionario.RUTLOTE, DIVCOD, IDPASE, ID_EMPRESA);
                }

                return funcionarios;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_v2_PasesCtta(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN)
        {
            try
            {
                return this.Repository.GetAllLotePasesFun_v2_PasesCtta(IDPASE, ID_EMPRESA, DIVCOD, FEC_INI, FEC_FIN);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public int ValidarFuncionarioPase(string RUT, int IDPASE, string DIVISION, string TIPOPASE, string FEC_INI, string FEC_FIN, string TABLA)
        {
            try
            {
                return this.Repository.ValidarFuncionarioPase(RUT, IDPASE, DIVISION, TIPOPASE, FEC_INI, FEC_FIN, TABLA);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
            public bool ValidarContDotacionSubCat_PasesCtta(string OST, int TIPO, int CONT_DOTACION, int LOTENUM, string FEC_INI, string FEC_FIN)
        {
            try
            {
                return this.Repository.ValidarContDotacionSubCat_PasesCtta(OST, TIPO, CONT_DOTACION, LOTENUM, FEC_INI, FEC_FIN);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarCantOST_PasesCtta(string OST, int CONT_RUT_HOTEL, int LOTENUM, string FEC_INI, string FEC_FIN, out int err_value)
        {
            try
            {
                return this.Repository.ValidarCantOST_PasesCtta(OST, CONT_RUT_HOTEL, LOTENUM, FEC_INI, FEC_FIN, out err_value);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
        #region [ Informes ]
        public ObservableCollection<LotePasesFun> GetLotePasesFun_VehiculosInformeConsultaRapidaCtta(LotePasesFun request)
        {
            try
            {
                return this.Repository.GetLotePasesFun_VehiculosInformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<LotePasesFun> GetLotePasesFun_FuncionariosInformeConsultaRapidaCtta(LotePasesFun Item)
        {
            try
            {
                var response = Repository.GetLotePasesFun_FuncionariosInformeConsultaRapidaCtta(Item);

                if (response != null)
                {
                    foreach (var item in response)
                    {
                        item.ACRONIMO = IDAEnterprise_Repository.GetOne(item.EMPRESALT).ACRONIMO;
                    }
                }
                return response;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public LotePasesFun GetLotePasesFun_DatosPaseInformeConsultaRapidaCtta(LotePasesFun request)
        {
            try
            {
                return Repository.GetLotePasesFun_DatosPaseInformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public LotePasesFun GetLotePasesFun_ValidaExistenciaNlote_InformeConsultaRapidaCtta(LotePasesFun request)
        {
            try
            {
                return Repository.GetLotePasesFun_ValidaExistenciaNlote_InformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<LotePasesFun> GetLotePasesFun_PasesHistoricos_InformeConsultasAdicionalesCtta(LotePasesFun request)
        {
            try
            {
                return Repository.GetLotePasesFun_PasesHistoricos_InformeFuncionariosCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }        
        #endregion
        #region [ Metodos ]

        public bool SaveLotePasesFunQuitarConduccionPase(string RUT, string IDEMPRESA, string DIVCOD, string LICONDLT)
        {
            try
            {
                return this.Repository.SaveLotePasesFunQuitarConduccionPase(RUT, IDEMPRESA, DIVCOD, LICONDLT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SavePase_PasesCtta(int IDPASE, string DIVCOD,string ID_EMPRESA, string USUARIO, ObservableCollection<LotePasesFun> funcionarios, ObservableCollection<LotePasesFun> rem_funcionarios, ObservableCollection<LotePasesFun> vehiculos, ObservableCollection<LotePasesFun> rem_vehiculos)
        {
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    var lotepases = new LotePases();
                    lotepases.LOTENUM = IDPASE;
                    lotepases.USUARIO = USUARIO;
                    if (funcionarios != null)
                    {
                        foreach (var funcionario in funcionarios)
                        {
                            funcionario.ID_PASE = IDPASE;
                            funcionario.ID_EMPRESA = ID_EMPRESA;
                            if (funcionario.CASINO_TXT == "SI")
                                funcionario.CASINO = true;
                            this.Repository.SaveLotePasesFun_PasesCtta(funcionario);
                            if(funcionario.ZONAS_CONDUCCION != null && funcionario.ZONAS_CONDUCCION.Count() > 0)
                            {
                                var checked_zones = funcionario.ZONAS_CONDUCCION.Where(a => a.CHECKED == true && a.DISABLED == false);
                                if (checked_zones.Count() > 0)
                                {
                                    List<string> zonas_existentes = new List<string>();
                                    string concat_locales = string.Empty;
                                    foreach (var zona in checked_zones)
                                    {
                                        zonas_existentes.Add(zona.LOCAL);
                                    }

                                    concat_locales = "#" + string.Join("#", zonas_existentes) + "#";

                                    this.IDAWorkerZonaPase_Repository.DelWorkerZonaPase_PasesCtta(IDPASE, funcionario.RUTLOTE, concat_locales, "1");

                                    foreach (var zona in checked_zones)
                                    {

                                        WorkerZonaPase zona_pase = new WorkerZonaPase();
                                        zona_pase.IDPASE = IDPASE;
                                        zona_pase.RUT = funcionario.RUTLOTE;
                                        zona_pase.LOCAL = zona.LOCAL;
                                        zona_pase.EMPRESA = ID_EMPRESA;
                                        zona_pase.USUARIO = USUARIO;
                                        this.IDAWorkerZonaPase_Repository.SaveWorkerZonaPase_PasesCtta(zona_pase);
                                    }

                                    //this.IDAWorkerZonaPaseHst_Repository.SaveWorkerZonaPaseHst_PasesCtta(IDPASE, funcionario.RUTLOTE, ID_EMPRESA);
                                }
                                else
                                { 
                                    this.IDAWorkerZonaPase_Repository.DelWorkerZonaPase_PasesCtta(IDPASE, funcionario.RUTLOTE, " ", "0"); 
                                }
                            }
                            if (funcionario.ZONAS_ACCESO != null && funcionario.ZONAS_ACCESO.Count() > 0)
                            {
                                var checked_zones = funcionario.ZONAS_ACCESO.Where(a => a.CHECKED == true && a.DISABLED == false);
                                if (checked_zones.Count() > 0)
                                {
                                    List<string> zonas_existentes = new List<string>();
                                    string concat_locales = string.Empty;
                                    foreach (var zona in checked_zones)
                                    {
                                        zonas_existentes.Add(zona.LOCAL);
                                    }

                                    concat_locales = "#" + string.Join("#", zonas_existentes) + "#";

                                    this.IDAWorkerZonaPase_Repository.DelWorkerZonaPaseAccesos_PasesCtta(IDPASE, funcionario.RUTLOTE, concat_locales, "1");
                                    var id = -1;
                                    foreach (var zona in checked_zones)
                                    {

                                        WorkerZonaPase zona_pase = new WorkerZonaPase();
                                        zona_pase.IDPASE = id;
                                        zona_pase.RUT = funcionario.RUTLOTE;
                                        zona_pase.LOCAL = zona.LOCAL;
                                        zona_pase.EMPRESA = ID_EMPRESA;
                                        zona_pase.USUARIO = USUARIO;
                                        zona_pase.DIVISION = DIVCOD;
                                        this.IDAWorkerZonaPase_Repository.SaveWorkerZonaPaseAcceso_PasesCtta(zona_pase);
                                        id--;
                                    }

                                    //this.IDAWorkerZonaPaseHst_Repository.SaveWorkerZonaPaseHst_PasesCtta(IDPASE, funcionario.RUTLOTE, ID_EMPRESA);
                                }
                                else {
                                    this.IDAWorkerZonaPase_Repository.DelWorkerZonaPaseAccesos_PasesCtta(IDPASE, funcionario.RUTLOTE, " ", "0");
                                }
                            }
                        }
                    }

                    if (vehiculos != null)
                    {
                        foreach (var vehiculo in vehiculos)
                        {
                            vehiculo.ID_PASE = IDPASE;
                            vehiculo.ID_EMPRESA = ID_EMPRESA;
                            this.Repository.SaveLotePasesFun_v2_PasesCtta(vehiculo);
                        }
                    }

                    if (rem_funcionarios != null) {
                        foreach (var funcionario in rem_funcionarios)
                        {
                            funcionario.ID_PASE = IDPASE;
                            funcionario.ID_EMPRESA = ID_EMPRESA;
                            this.Repository.DelLotePasesFun_PasesCtta(funcionario);
                        }
                    }

                    if (rem_vehiculos != null)
                    {
                        foreach (var vehiculo in rem_vehiculos)
                        {
                            vehiculo.ID_PASE = IDPASE;
                            vehiculo.ID_EMPRESA = ID_EMPRESA;
                            this.Repository.DelLotePasesFun_v2_PasesCtta(vehiculo);
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
