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

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_PasesMdte(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE)
        {
            try
            {
                var funcionarios = this.Repository.GetAllLotePasesFun_PasesMdte(IDPASE, ID_EMPRESA, DIVCOD, FEC_INI, FEC_FIN, TIPO_PASE);
                foreach(var funcionario in funcionarios)
                {
                    funcionario.ZONAS_CONDUCCION = this.IDALocal_Repository.GetAllLocal_v2_PasesMdte(funcionario.RUTLOTE, DIVCOD, IDPASE, ID_EMPRESA);
                }
                return funcionarios;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_v2_PasesMdte(int IDPASE, string ID_EMPRESA, string DIVCOD, string FEC_INI, string FEC_FIN, string TIPO_PASE)
        {
            try
            {
                return this.Repository.GetAllLotePasesFun_v2_PasesMdte(IDPASE, ID_EMPRESA, DIVCOD, FEC_INI, FEC_FIN, TIPO_PASE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_Funcionarios_CertificacionMdte(LotePases modelo)
        {
            try
            {
                return this.Repository.GetAllLotePasesFun_Funcionarios_CertificacionMdte(modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_Empresas_CertificacionMdte(int IDPASE)
        {
            try
            {
                return this.Repository.GetAllLotePasesFun_Empresas_CertificacionMdte(IDPASE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<LotePasesFun> GetAllLotePasesFun_Vehiculos_CertificacionMdte(int IDPASE)
        {
            try
            {
                return this.Repository.GetAllLotePasesFun_Vehiculos_CertificacionMdte(IDPASE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarContDotacionSubCat_PasesMdte(string OST, int TIPO, int CONT_DOTACION, int LOTENUM, string FEC_INI, string FEC_FIN)
        {
            try
            {
                return this.Repository.ValidarContDotacionSubCat_PasesMdte(OST, TIPO, CONT_DOTACION, LOTENUM, FEC_INI, FEC_FIN);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Informes ]

        #endregion

        #region [ Metodos ]

        public bool SavePase_PasesMdte(LotePases pase, ObservableCollection<LotePasesFun> funcionarios, ObservableCollection<LotePasesFun> vehiculos)
        {

            try
            {
                bool resultado = false;
                using (TransactionScope transaccion = new TransactionScope())
                {
                    var originalesFuncionarios = this.Repository.GetAllLotePasesFun_PasesMdte(pase.LOTENUM, pase.EMPRESA_PASE, pase.DIV_COD, pase.FECHA_INICIO, pase.FECHA_FIN, pase.TIPO_PASE);
                    var originalesVehiculos = this.Repository.GetAllLotePasesFun_v2_PasesMdte(pase.LOTENUM, pase.EMPRESA_PASE, pase.DIV_COD, pase.FECHA_INICIO, pase.FECHA_FIN, pase.TIPO_PASE);

                    var funcionariosEliminar = originalesFuncionarios.Except(funcionarios, new FuncionarioComparer()).ToList();
                    var vehiculosEliminar = originalesVehiculos.Except(vehiculos, new VehiculoComparer()).ToList();

                    resultado = true;

                    if (funcionarios != null)
                    {
                        foreach (var funcionarioNuevo in funcionarios)
                        {
                            funcionarioNuevo.ID_PASE = pase.LOTENUM;
                            funcionarioNuevo.ID_EMPRESA = pase.EMPRESA_PASE;

                            this.Repository.SaveLotePasesFun_PasesMdte(funcionarioNuevo);
                            if (funcionarioNuevo.ZONAS_CONDUCCION != null && funcionarioNuevo.ZONAS_CONDUCCION.Count() > 0)
                            {
                                var zonasChequeadas = funcionarioNuevo.ZONAS_CONDUCCION.Where(a => a.CHECKED == true && a.DISABLED == false);
                                if (zonasChequeadas.Count() > 0)
                                {
                                    List<string> zonasExistentes = new List<string>();
                                    string concatLocales = string.Empty;
                                    foreach (var zona in zonasChequeadas)
                                    {
                                        zonasExistentes.Add(zona.LOCAL);
                                    }

                                    concatLocales = "#" + string.Join("#", zonasExistentes) + "#";

                                    this.IDAWorkerZonaPase_Repository.DelWorkerZonaPase_PasesMdte(pase.LOTENUM, funcionarioNuevo.RUTLOTE, concatLocales);

                                    foreach (var zona in zonasChequeadas)
                                    {

                                        WorkerZonaPase zonaPase = new WorkerZonaPase();
                                        zonaPase.IDPASE = pase.LOTENUM;
                                        zonaPase.RUT = funcionarioNuevo.RUTLOTE;
                                        zonaPase.LOCAL = zona.LOCAL;
                                        zonaPase.EMPRESA = pase.EMPRESA_PASE;
                                        zonaPase.USUARIO = pase.USUARIO;

                                        this.IDAWorkerZonaPase_Repository.SaveWorkerZonaPase_PasesMdte(zonaPase);
                                    }

                                    this.IDAWorkerZonaPaseHst_Repository.SaveWorkerZonaPaseHst_PasesMdte(pase.LOTENUM, funcionarioNuevo.RUTLOTE, pase.EMPRESA_PASE);
                                }
                            }
                        }

                    }

                    if (vehiculos != null)
                    {
                        foreach (var vehiculo in vehiculos)
                        {
                            vehiculo.ID_PASE = pase.LOTENUM;
                            vehiculo.ID_EMPRESA = pase.EMPRESA_PASE;
                            
                            this.Repository.SaveLotePasesFun_v2_PasesMdte(vehiculo);
                        }
                    }

                    if (funcionariosEliminar != null)
                    {
                        foreach (var funcionario in funcionariosEliminar)
                        {
                            funcionario.ID_PASE = pase.LOTENUM;
                            funcionario.ID_EMPRESA = pase.EMPRESA_PASE;
                            this.Repository.DelLotePasesFun_PasesMdte(funcionario);
                        }
                    }

                    if (vehiculosEliminar != null)
                    {
                        foreach (var vehiculo in vehiculosEliminar)
                        {
                            vehiculo.ID_PASE = pase.LOTENUM;
                            vehiculo.ID_EMPRESA = pase.EMPRESA_PASE;
                            this.Repository.DelLotePasesFun_v2_PasesMdte(vehiculo);
                        }
                    }

                    transaccion.Complete();
                }

                return resultado;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
