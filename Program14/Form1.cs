using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Program14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            string[] name = Directory.GetFiles(@"c:\test");
        
            pb.Image = Image.FromFile(name[lb1.SelectedIndex]);
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] name = Directory.GetFiles(@"c:\test");
            ArrayList arr = new ArrayList();
            foreach (string str in name)
            {
                str.Substring(8, str.Length);
                arr.Add(str);
            }
           
            
            
            lb1.DataSource = arr;
        }
    }
}
