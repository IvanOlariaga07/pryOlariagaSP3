using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOlariagaSP3
{
    public partial class frmRegistroRepuesto : Form
    {
        string[] VecRepuestos = new string[3];


         

        public frmRegistroRepuesto()
        {
            InitializeComponent();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            string VarMarca = cmbMarca.Text;
            string VarOrigen;

            if (rdbImportado.Checked == true)
            {
                VarOrigen = "Nacional";
            }
            else
            {
                VarOrigen = "Importado";
            }

            lstRegistro.Items.Add(VarMarca + ' ' + VarOrigen);
                //añadir los elementos del vector a la linea

               for (int indiceRegistro = 0; indiceRegistro < VecRepuestos.Length; indiceRegistro++)
            {
                VecRepuestos[indiceRegistro] = VarMarca + " " + VarOrigen;
                lstRegistro.Items.Add(VecRepuestos[indiceRegistro].ToString());
                
            }



        }


        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
