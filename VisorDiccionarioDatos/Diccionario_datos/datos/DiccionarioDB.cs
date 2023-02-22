using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using System.Collections;

namespace Diccionario_datos.datos
{
    class DiccionarioDB
    {
        //Establecer la cadena de conexion
        OracleConnection miConexion = new OracleConnection(@"Data Source = localhost; User ID = prueba; Password= oracle");

        public DataSet NumeroTriggersBD()
        {
            DataSet ds = new DataSet();
            //Abrir conexion
            miConexion.Open();
            //Crear objeto de tipo comando
            OracleCommand miComando = new OracleCommand("ejercicioBd2.prcNumeroTriggers", miConexion);
            //Configuración de los parametros
            miComando.Parameters.Add("cur_cantidadTriggers", OracleDbType.RefCursor, ParameterDirection.Output);
            miComando.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);
            //Llenar el dataset a través del adaptador
            miAdaptador.Fill(ds, "numTriggers");
            //Cerrar la concexión
            miConexion.Close();
            return ds;
        }
        public DataSet InfoTriggersBD()
        {
            DataSet ds = new DataSet();
            //Abrir conexion
            miConexion.Open();
            //Crear objeto de tipo comando
            OracleCommand miComando = new OracleCommand("ejercicioBd2.prcInfoTriggers", miConexion);            
            //Configuración de los parametros
            miComando.Parameters.Add("cur_InfoTriggers", OracleDbType.RefCursor, ParameterDirection.Output);
            miComando.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter miAdaptador = new OracleDataAdapter(miComando);            
            //Llenar el dataset a traves del adaptador
            miAdaptador.Fill(ds, "infoTriggers");
            //cerrar la concexión
            miConexion.Close();
            return ds;
        }
        public ArrayList NumeroColumsNullBD(string NombreTabla)
        {
            //Abrir conexion
            miConexion.Open();
            //Crear objeto de tipo comando
            OracleCommand miComando = new OracleCommand("ejercicioBd2.prcConteoColumnasNulas", miConexion);
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.Parameters.Add("(v_nombreTabla", OracleDbType.Varchar2, 256).Value = NombreTabla;
            miComando.Parameters.Add("v_NumNoNulos", OracleDbType.Decimal,  ParameterDirection.Output);
            miComando.Parameters.Add("v_NumNulos", OracleDbType.Decimal, ParameterDirection.Output);

            miComando.ExecuteNonQuery();

            ArrayList CantNulos = new ArrayList();

            string NoNulos = miComando.Parameters["v_NumNoNulos"].Value.ToString();
            string Nulos = miComando.Parameters["v_NumNulos"].Value.ToString();

            CantNulos.Add(NoNulos);
            CantNulos.Add(Nulos);

            //Cerrar la concexión
            miConexion.Close();
            return CantNulos;
        }
    }
}
