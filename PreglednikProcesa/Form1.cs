using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreglednikProcesa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            popuniPopisProcesa();
        }
        
        
        private void popuniPopisProcesa()
        {
            var popisProcesa = System.Diagnostics.Process.GetProcesses();            

            foreach(System.Diagnostics.Process p in popisProcesa)
            {
                PodatakProcesa pp = new PodatakProcesa(p);
                listBox1.Items.Add(pp); 
            }
        }

        private void tipkaPokaziPopisProcesa_Click(object sender, EventArgs e)
        {
            
            popuniPopisProcesa();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PodatakProcesa pp = (PodatakProcesa)listBox1.SelectedItem;
            System.Diagnostics.Process p = pp.p;
            textBox1.Text = p.ProcessName;
            textBox2.Text = p.Id.ToString();
            textBox3.Text = p.WorkingSet64.ToString() + "  B";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Sorted = checkBox1.Checked;
        }

        private void killTipka_Click(object sender, EventArgs e)
        {
            PodatakProcesa pp = (PodatakProcesa)listBox1.SelectedItem;
            pp.p.Kill();

        }
    }
}
