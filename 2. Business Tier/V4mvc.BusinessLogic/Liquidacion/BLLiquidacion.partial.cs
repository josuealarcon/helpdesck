using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Transactions;
using System.Globalization;
using System.IO;

namespace V4mvc.BusinessLogic
{
	public partial class BLLiquidacion
	{

		#region [ Consultas ]
		public ObservableCollection<Liquidacion> GetLiquidacionUploadFuncionarios(string RUT, string EMPRESA)
		{
			try
			{
				var liquidaciones = Repository.GetLiquidacionUploadFuncionarios(RUT, EMPRESA);

                if (liquidaciones!=null)
                {
					foreach (var item in liquidaciones)
					{
						item.DISPUTA = RepositoryLiquidacion_Disputa.GetLiquidacion_DisputaTop1(RUT, item.FECHA, EMPRESA);
					}
				}


				return liquidaciones;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		private IEnumerable<string[]> leerLineaCSV(byte[] buffer, char[] separators)
		{
			string currentLine;

			using (var stream = new MemoryStream(buffer))
			{

				using (var reader = new StreamReader(stream, Encoding.Default, true, 1024))
				{
					while ((currentLine = reader.ReadLine()) != null)
					{
						yield return currentLine.Split(separators, StringSplitOptions.None);
					}
				}

			}
		}

		public ObservableCollection<Liquidacion> GetAllLiquidacion_ControlLaboralCtta(Archivos archivo, string USUARIO, string IDEMPRESA)
		{
			ObservableCollection<Liquidacion> resultados = new ObservableCollection<Liquidacion>();
			try
			{
				Func<string[], int, string, string> valueOrDefault = (string[] row, int index, string _default) => {
					string ret_value = _default;
					if(index < row.Length && !string.IsNullOrEmpty(row[index]))
                    {
						ret_value = row[index];
                    }
					return ret_value;
				};

				Func<string, char[], string> removeChars = (string value, char[] removables) => {
					return string.Join("", value.Split(removables));
				};

				Func<string, int, int, string> trySubStr = (string value, int subs_start, int subs_len) => {
					string ret_value = value;
                    if (subs_start < value.Length && (subs_start + subs_len - 1) < value.Length)
                    {
						ret_value = value.Substring(subs_start, subs_len);
                    }
					return ret_value;
				}; 


				bool primero = true;
				foreach(var linea in leerLineaCSV(archivo.ARCHIVO, new[]{';'}))
                {
                    if (primero)
                    {

						primero = false;
						if (trySubStr(removeChars(valueOrDefault(linea, 0, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "RUT")
							break;
						if (trySubStr(removeChars(valueOrDefault(linea, 1, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "PERIODO")
							break;
						if (trySubStr(removeChars(valueOrDefault(linea, 2, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "IMPONIBLE")
							break;
						if (trySubStr(removeChars(valueOrDefault(linea, 3, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "LIQUIDO")
							break;
						if (trySubStr(removeChars(valueOrDefault(linea, 4, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "TRANSFERIDO")
							break;
						if (trySubStr(removeChars(valueOrDefault(linea, 5, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "EMPRESA")
							break;
						if (trySubStr(removeChars(valueOrDefault(linea, 6, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "BONOIP")
							break;
						if (trySubStr(removeChars(valueOrDefault(linea, 7, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "BONOIS")
							break;
						if (trySubStr(removeChars(valueOrDefault(linea, 8, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "SUELDOBASE")
							break;
						if (trySubStr(removeChars(valueOrDefault(linea, 9, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "GRATIFICACION")
							break;
						if (trySubStr(removeChars(valueOrDefault(linea, 10, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "INCLUYE_F301")
							break;
						if (trySubStr(removeChars(valueOrDefault(linea, 11, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "OST")
							break;
						if (trySubStr(removeChars(valueOrDefault(linea, 12, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "")
							break;
						if (trySubStr(removeChars(valueOrDefault(linea, 12, ""), new[] { '-', '.', ',', ' ' }), 0, 15).ToUpper() != "")
							break;
						continue;
                    } 
					 
					Liquidacion liquidacion = new Liquidacion();
					liquidacion.RUT = trySubStr(removeChars(valueOrDefault(linea, 0, ""), new[] {'-', '.', ',', ' '}), 0, 10).ToUpper();
					liquidacion.PERIODO = trySubStr(removeChars(valueOrDefault(linea, 1, "19000101"), new[] { '-', '/', ' ' }), 0, 8);
					liquidacion.IMPONIBLE = Convert.ToInt32(trySubStr(removeChars(valueOrDefault(linea, 2, "0"), new[] { '.', ',', ' ' }), 0, 8));
					liquidacion.LIQUIDO = Convert.ToInt32(trySubStr(removeChars(valueOrDefault(linea, 3, "0"), new[] { '.', ',', ' ' }), 0, 8));
					liquidacion.TRANSFERIDO = Convert.ToInt32(trySubStr(removeChars(valueOrDefault(linea, 4, "0"), new[] { '.', ',', ' ' }), 0, 8));
					liquidacion.EMPRESA = trySubStr(removeChars(valueOrDefault(linea, 5, ""), new[] { '-', '.', ',', ' ' }), 0, 10).ToUpper();
					liquidacion.BONOIP = Convert.ToInt32(trySubStr(removeChars(valueOrDefault(linea, 6, "0"), new[] { '.', ',', ' ' }), 0, 8));
					liquidacion.BONOIS = Convert.ToInt32(trySubStr(removeChars(valueOrDefault(linea, 7, "0"), new[] { '.', ',', ' ' }), 0, 8));
					liquidacion.SUELDOBASE = Convert.ToInt32(trySubStr(removeChars(valueOrDefault(linea, 8, "0"), new[] { '.', ',', ' ' }), 0, 8));
					liquidacion.GRATIFICACION = Convert.ToInt32(trySubStr(removeChars(valueOrDefault(linea, 9, "0"), new[] { '.', ',', ' ' }), 0, 8));
					liquidacion.INCLU_F301 = trySubStr(removeChars(valueOrDefault(linea, 10, ""), new[] { '.', ',', ' ' }), 0, 2).ToUpper();
					liquidacion.OST = trySubStr(removeChars(valueOrDefault(linea, 11, ""), new[] { '.', ',', ' ' }), 0, 14);
					liquidacion.EMPRESA = IDEMPRESA;
					liquidacion.USUARIO = USUARIO;
					resultados.Add(liquidacion);
				}
				Utils.custom_debug_obj(resultados);
				return resultados;
			}
			catch (Exception ex)
			{
				resultados = new ObservableCollection<Liquidacion>();
				throw ex; 
			}
		}

		public Liquidacion GetLiquidacionFuncionariosCtta(string RUT, string FECHA, string EMPRESA)
		{
			try
			{
				var response = Repository.GetLiquidacionFuncionariosCtta(RUT, FECHA, EMPRESA);
				response.docs_Tipo_Rechazos = RepositoryDocs_Tipo_Rechazo.GetDocsTipoRechazoLiquidacionFuncionariosCtta(RUT, FECHA, EMPRESA);
				response.FECHA_FORMATEADA = Utils.Fec_User(response.FECHA, Utils.Formato_Fecha.Guion);
				response.VALIDADO_NOMBRE_LARGO = response.VALIDADO == "RE" ? "RECHAZADO" : response.VALIDADO == "SI" ? "VALIDADO" : "PENDIENTE";
				response.DISPUTA = RepositoryLiquidacion_Disputa.GetLiquidacion_DisputaTop1(RUT, FECHA, EMPRESA);
				return response;

			}
			catch (Exception ex)
			{ throw ex; }
		}


		#endregion

		#region [ Metodos ]
		public bool InsertLiquidacionUploadFuncionarios(Liquidacion Item)
		{
			try
			{
				using (TransactionScope tran = new TransactionScope())
				{

					var archivo = Item.ARCHIVO_CARGADO;
					if (archivo.ARCHIVO != null)
					{
						this.RepositoryArchivos.Save(ref archivo);
					}
					Item.ID = archivo.ID;
					Item.TIPO_CONTENIDO = archivo.TIPOCONTENIDO;
					Item.NOMBRE_ARCHIVO = archivo.NOMBRE;
					this.Repository.InsertLiquidacionUploadFuncionarios(Item);
					tran.Complete();
				}

				return true;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool DeleteLiquidacionFuncionariosCtta(string RUT, string FECHA, string EMPRESA, int ID_DISPUTA, string USUARIO)
		{
			try
			{
				return this.Repository.DeleteLiquidacionFuncionariosCtta(RUT, FECHA, EMPRESA, ID_DISPUTA, USUARIO);

			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool UpdateLiquidacionFuncionariosCtta(Liquidacion Item)
		{
			try
			{
				using (TransactionScope tran = new TransactionScope())
				{
					bool cargoArchivo = false;
					var archivo = Item.ARCHIVO_CARGADO;
					if (archivo.ARCHIVO != null)
					{
						this.RepositoryArchivos.Save(ref archivo);
						cargoArchivo = true;
					}
					Item.ID = archivo.ID;
					Item.CARGO_ARCHIVO = cargoArchivo;
					Item.TIPO_CONTENIDO = archivo.TIPOCONTENIDO;
					Item.NOMBRE_ARCHIVO = archivo.NOMBRE;
					this.Repository.UpdateLiquidacionFuncionariosCtta(Item);
					tran.Complete();
				}

				return true;

			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool InsertLiquidacionDisputaFuncionariosCtta(string RUT, string FECHA, string EMPRESA, string OBSERVACION, string USUARIO)
		{
			try
			{
				return this.Repository.InsertLiquidacionDisputaFuncionariosCtta(RUT, FECHA, EMPRESA, OBSERVACION, USUARIO);

			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool SaveLiquidacion_ControlLaboralCtta(List<Archivos> archivos, Liquidacion liquidacion)
		{
			try
			{
				using (TransactionScope tran = new TransactionScope())
				{
					foreach(var archivo in archivos)
                    {
						var _archivo = archivo;
						this.RepositoryArchivos.Save(ref _archivo);
						
						liquidacion.RUT = _archivo.BASENAME; //NOMBRE sin extension
						liquidacion.USUARIO = _archivo.USUARIO;
						liquidacion.ID_ARCHIVO = _archivo.ID;
						liquidacion.NOMBRE_ARCHIVO = _archivo.NOMBRE;
						liquidacion.TIPO_CONTENIDO = _archivo.TIPOCONTENIDO;

						this.Repository.SaveLiquidacion_ControlLaboralCtta(liquidacion);
					}
					tran.Complete();
				}

				return true;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveBatchLiquidacion_ControlLaboralCtta(ref ObservableCollection<Liquidacion> liquidaciones, ref Liquidacion resumen)
		{
			try
			{
				int i;

				resumen.REGISTROS_LEIDOS = 0;
				resumen.REGISTROS_INGRESADOS = 0;
				resumen.REGISTROS_INVALIDOS = 0;
				resumen.REGISTROS_REPETIDOS = 0;

				using (TransactionScope tran = new TransactionScope())
				{
					for(i = 0; i < liquidaciones.Count; ++i)
					{
						Liquidacion liquidacion = liquidaciones[i];
						this.Repository.SaveLiquidacion_v2_ControlLaboralCtta(ref liquidacion);
						liquidaciones[i] = liquidacion;

						if(liquidacion.INSERCION_OK == 1){
							resumen.REGISTROS_INGRESADOS = resumen.REGISTROS_INGRESADOS + 1;
						}
                        else
                        {
							if (liquidacion.RUT_INVALIDO == 1)
							{
								resumen.REGISTROS_INVALIDOS = resumen.REGISTROS_INVALIDOS + 1;
							}
							if (liquidacion.REPETIDO == 1)
							{
								resumen.REGISTROS_REPETIDOS = resumen.REGISTROS_REPETIDOS + 1;
							}
						}
					}

					resumen.REGISTROS_LEIDOS = i;

					tran.Complete();
				}

				return true;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool ValidarLiquidacionCtta(ref Liquidacion liquidacion)
		{
			try
			{
				return this.Repository.ValidarLiquidacionCtta(ref liquidacion);

			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
