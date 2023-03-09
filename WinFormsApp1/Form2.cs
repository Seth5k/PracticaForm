using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TemaColor.Tema();
            //this.BackColor = TemaColor.Barra;
            //this.BarraT = TemaColor.Barra;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 frm = (Form1)this.Owner;
            frm.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
