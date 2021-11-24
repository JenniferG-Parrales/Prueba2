using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmPrestamo : Form
    {
        private ICalendarioRepos calendarioRepos;
        public FrmPrestamo(ICalendarioRepos calendarioRepos)
        {
            this.calendarioRepos = calendarioRepos;
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal n, p;
            n = nudTasas.Value/ 100;
            p = nudTerminos.Value * 12;
            CalendarioPrest a = new CalendarioPrest()
            {
                Id = calendarioRepos.GetLastIndex(),
                Principal = nudPrestamos.Value*(1+n)/p,
                Interes = (nudPrestamos.Value*n)/p,
                Estado = Domain.Enums.Estado.Pendiente,
                Cuota = nudCuota.Value,
                FechaPago = dtpFechaDePago.Value
               
            };
            calendarioRepos.Create(a);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = calendarioRepos.GetAll();
        }
    }
}
