﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp7
{
    public partial class Diploma : Form
    {
        public Diploma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DiplomaDataSet.Maquette". При необходимости она может быть перемещена или удалена.
            this.MaquetteTableAdapter.Fill(this.DiplomaDataSet.Maquette);

            this.reportViewer1.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {


        }

        private void добавлениеНовогоМакетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_maquette m = new Add_maquette();
            if (m.ShowDialog() == DialogResult.OK)
            {
                File.Copy(m.label2.Text, "Maquette//"+Path.GetFileName(m.label2.Text));
                Maquette maq = new Maquette();
                maq.Insert(m.textBox1.Text, Path.GetFileName(m.label2.Text), Program.user_id);
            }
        }
    }
}
