using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diccionario_datos.datos;
using System.Data;
using System.Collections;

namespace Diccionario_datos.logica
{
    class DiccionarioDatos
    {
        //Crear un objeto para comunicarse con la capa de datos
        DiccionarioDB dicBD = new DiccionarioDB();

        public DataSet numTriggers()
        {
            return dicBD.NumeroTriggersBD();
        }
        public DataSet infoTriggers()
        {
            return dicBD.InfoTriggersBD();
        }
        public ArrayList numColumsNull(string nomTabla)
        {
            return dicBD.NumeroColumsNullBD(nomTabla);
        }
    }
}
