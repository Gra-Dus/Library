using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Библиотека;
using System.Diagnostics;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form thisForm in forms)
            {
                if (thisForm.Name != "Form1") thisForm.Close();
            }

            Books BForm = new Books(this);
            BForm.MdiParent = this;
            BForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            //this.Width = Width + toolStrip1.Width;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            //{
             //   if (Application.OpenForms[i].Name != "Form1")
             //   {
             //       Application.OpenForms[i].Close();   
             //   }
           // }
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form thisForm in forms)
            {
                if (thisForm.Name != "Form1") thisForm.Close();
            }
            Authors AForm = new Authors(this);
            AForm.MdiParent = this;
            AForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Process SysInfo = new Process();
                SysInfo.StartInfo.ErrorDialog = true;
                SysInfo.StartInfo.FileName = "Help.chm";
                SysInfo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form thisForm in forms)
            {
                if (thisForm.Name != "Form1") thisForm.Close();
            }
           Form AForm = new Forformular1(this);
            AForm.MdiParent = this;
            AForm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    
}
