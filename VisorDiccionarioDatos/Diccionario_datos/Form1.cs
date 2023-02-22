using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diccionario_datos.logica;
using System.Collections;

namespace Diccionario_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DiccionarioDatos dd = new DiccionarioDatos();
        private void btnConsultarTipoTrigger_Click(object sender, EventArgs e)
        {
            //Creo un dataset
            DataSet ds = new DataSet();
            //El dataset que se crea, se llena con el metodo que esta en la logica
            ds = dd.numTriggers();
            
            //Se crean 2 arraylist
            ArrayList triggerType = new ArrayList();
            ArrayList contTriggerName = new ArrayList();

            //Se recorre dataset
            string valor1, valor2;
            foreach (DataRow drow in ds.Tables[0].Rows)
            {
                //Se obtiene el valor con el nombre de la columna
                valor1 = drow["TIPO DE TRIGGERS"].ToString();
                triggerType.Add(valor1);

                valor2 = drow["NUMERO DE TRIGGERS"].ToString();
                contTriggerName.Add(valor2);
            }
            //Configura los ejes del chart1 
            chtVisorNumTipoTriggers.Series[0].Points.DataBindXY(triggerType, contTriggerName);
        }

        private void btnInfoTriggers_Click(object sender, EventArgs e)
        {
            //Creo un dataset
            DataSet ds = new DataSet();
            //El dataset que se crea, se llena con el metodo que esta en la logica
            ds = dd.infoTriggers();
            //Vamos a llenar la grilla con ese dataset
            dgvInfoTriggers.DataSource = ds;
            dgvInfoTriggers.DataMember = "infoTriggers";
        }

        private void btnNumColNull_Click(object sender, EventArgs e)
        {
            string NameTable;

            NameTable = txtNomTable.Text;

            if (NameTable.Equals(""))
            {
                MessageBox.Show("Campo sin llenar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ArrayList nomTipoColum = new ArrayList();
                ArrayList CantidadNulos = new ArrayList();

                CantidadNulos = dd.numColumsNull(NameTable);

                nomTipoColum.Add("NO NULL");
                nomTipoColum.Add("NULL");

                //Configura los ejes del chart2           
                chtVisorNumColNull.Series[0].Points.DataBindXY(nomTipoColum, CantidadNulos);
                txtNomTable.ResetText();
            }            
        }
    }
}
