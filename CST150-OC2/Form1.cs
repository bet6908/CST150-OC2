using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST150_OC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            while (MaskYes.Checked)
            {
                if ((fever.Checked) && (LostSmell.Checked) || (LostTaste.Checked) || (Chils.Checked))
                {
                    MessageBox.Show("Send home imediately with Self testing kit", "Message", MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }
                else if ((fever.Checked) && (check_cough.Checked) || (Aches.Checked) || (Chils.Checked))
                {
                    MessageBox.Show("Send home with Self testing kit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Administer rapid covid test", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              
            }

            while (MaskNo.Checked)
            {
                if ((fever.Checked) && (LostSmell.Checked) || (LostTaste.Checked) || (Chils.Checked))
                {
                    MessageBox.Show("Send home imediately with Self testing kit" + "\n" +  "Contact trace" , "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if ((fever.Checked) && (check_cough.Checked) || (Aches.Checked) || (Chils.Checked))
                {
                    MessageBox.Show("Send home with Self testing kit" + "\n" + "Contact trace", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Administer rapid covid test" + "\n" + "Contact trace", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.Close();
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            label2.BackColor = Color.Transparent;
        }
    }
}
