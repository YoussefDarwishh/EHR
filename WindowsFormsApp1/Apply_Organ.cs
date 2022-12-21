﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Apply_Organ : Form
    {
        Controller ctrl;
        string id;
        
        public Apply_Organ(string idt)
        {
            InitializeComponent();
            id = idt;
            ctrl = new Controller();
           DataTable dt = ctrl.GetOrgan_Donor_1(id);
            if (dt == null)
            {
                return;
            }
            DataRowCollection dr1 = dt.Rows;
            foreach (DataRow i in dr1)
            {
                if (Convert.ToString(i[0]) == "Part of Intestine")
                {
                    Intestine.Checked = true;
                    Intestine.Enabled = false;
                }
                if (Convert.ToString(i[0]) == "Part of Liver")
                {
                    Liver.Checked = true;
                    Liver.Enabled = false;
                }
                if (Convert.ToString(i[0]) == "Part of Pancreas")
                {
                    Pancreas.Checked = true;
                    Pancreas.Enabled = false;
                }
                if (Convert.ToString(i[0]) == "Lung")
                {
                    Lung.Checked = true;
                    Lung.Enabled = false;
                }
                if (Convert.ToString(i[0]) == "Kidney")
                {
                    Kidney.Checked = true;
                    Kidney.Enabled = false;
                }
            }
            DataTable dt1 = ctrl.getpatientstatusupondeath(id);
            DataRowCollection dr2 = dt1.Rows;
            if(Convert.ToBoolean(dr2[0][0]) == true)
            {
                kryptonCheckBox6.Checked = true;
                kryptonCheckBox6.Enabled = false;
            }
        }

        private void Oragn_Dono_Load(object sender, EventArgs e)
        {
          
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            if (kryptonCheckBox6.Checked == true && kryptonCheckBox6.Enabled == true)
            {
                ctrl.OrganDonorUponDeath(id);
                
            }
            if (Kidney.Checked == true && Kidney.Enabled == true)
            {
                DataTable dt = ctrl.GetOrgan_Donor(Kidney.Text, id);
                ctrl.InsertOrganDonor(Kidney.Text.ToString(), id, 1);
                
            }
            
            if (Intestine.Checked == true && Intestine.Enabled == true)
            {
                ctrl.InsertOrganDonor(Intestine.Text.ToString(), id, 1);
                
            }
            if (Pancreas.Checked == true && Pancreas.Enabled == true)
            {
                ctrl.InsertOrganDonor(Pancreas.Text.ToString(), id, 1);
            }
            if (Liver.Checked == true && Liver.Enabled == true)
            {
                ctrl.InsertOrganDonor(Liver.Text.ToString(), id, 1);
                
            }
            if (Lung.Checked == true && Lung.Enabled == true)
            {
                ctrl.InsertOrganDonor(Lung.Text.ToString(), id, 1);
                
            }
            MessageBox.Show("Thank you for your contribution");
            this.Close();
        }

        private void kryptonCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Kidney_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void kryptonCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Lung_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Liver_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Pancreas_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Intestine_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void kryptonCheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
