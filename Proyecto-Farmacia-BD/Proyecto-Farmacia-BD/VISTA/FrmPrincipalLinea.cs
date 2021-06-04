﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Farmacia_BD.CONTROLADORES;

namespace Proyecto_Farmacia_BD.VISTA
{
    public partial class FrmPrincipalLinea : Form
    {
        public FrmPrincipalLinea()
        {
            InitializeComponent();
        }

        CLinea cLinea = new CLinea();
        private void FrmPrincipalLinea_Load(object sender, EventArgs e)
        {
            lineaBindingSource.DataSource = cLinea.Consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLinea linea = new FrmLinea();
            linea.ShowDialog();
            lineaBindingSource.DataSource = null;
            lineaBindingSource.DataSource = cLinea.Consultar();
        }
    }
}
