using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace treino
{
    public partial class FormLogin : Form
    {
        Thread nt;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value += 10;
            if (progressBar1.Value >= 100) {
                timer1.Enabled = false;
                nt = new Thread(abreFormPrincipal);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
                this.Close();
            }    
        }

        private void abreFormPrincipal(object obj)
        {
            Application.Run(new FormPrincipal());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.progressBar1.Maximum = 100;
            

        }
    }
}
