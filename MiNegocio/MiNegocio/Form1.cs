using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiNegocio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.dParcela.Clear();
        }

        private void CrearNota_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button nButon = (System.Windows.Forms.Button) sender;
            MessageBox.Show(nButon.Name, "Mi nombre es");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
