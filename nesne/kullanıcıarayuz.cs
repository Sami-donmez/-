using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesne
{
    public partial class kullanıcıarayuz : Form
    {
        public kullanıcıarayuz()
        {
            
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kulad = kaditxt.Text;
            string kulsifre = sifretxt.Text;
            Boolean b = kullanıcı.login(kulad, kulsifre);
            MessageBox.Show(b.ToString());
            lbl.Text = kullanıcı.name+kullanıcı.adres+kullanıcı.tel;
        }

        

    }
}
