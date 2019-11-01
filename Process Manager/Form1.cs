using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Manager
{
    public partial class Form1 : Form
    {
        const string Version = "v1.0a";

        public Form1()
        {
            InitializeComponent();
            UpdateProcessList();
            v.Text = Version;
        }

        private void UpdateProcessList()
        {
            // clear the list
            lstProcess.Items.Clear();

            // search for processes and add each one to the list
            foreach (System.Diagnostics.Process e in
            System.Diagnostics.Process.GetProcesses())
            {
                lstProcess.Items.Add(e.ProcessName + " - " + e.Id);
            }

            txtProcesses.Text = "Processes running:" + lstProcess.Items.Count.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            foreach (System.Diagnostics.Process p in
            System.Diagnostics.Process.GetProcesses())
            {
                string[] arr = lstProcess.SelectedItem.ToString().Split('-');
                string sProcess = arr[0].Trim();
                int iId = Convert.ToInt32(arr[1].Trim());
                if (p.ProcessName == sProcess && p.Id == iId)
                {
                    p.Kill();
                }

                UpdateProcessList();
            }
        }
    }
}
