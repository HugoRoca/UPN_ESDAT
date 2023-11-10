using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_05_Forms
{
    public partial class Queue : Form
    {
        LinkedList<string> list = new LinkedList<string>();
        public Queue()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string val = txtText.Text;

            list.AddLast(val);

            lbList.Items.Add(val);

            txtText.Clear();
            txtText.Focus();
        }

        private void ExportToFile()
        {
            foreach (var item in list)
            {
                lbList.Items.Add(item);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\UPN\\Documents\\GitHub\\UPN_ESDAT\\Week_05_Forms\\Files\\Data.txt";

            using (var sw = new StreamWriter(path))
            {
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                }
            }

            MessageBox.Show("File exported successfully");
        }
    }
}
