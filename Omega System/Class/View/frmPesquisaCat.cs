using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Omega_System.Class.Model;
using System.Data;

namespace Omega_System.Class.View
{	public partial class frmPesquisaCat : Form
	{
		public frmPesquisaCat()
		{
			InitializeComponent();
		}
		
		void Btn_filtrarClick(object sender, EventArgs e)
		{
			Categoria c = new Categoria();
			this.dgv_cat.DataSource = c.Listar();			
		}
		
		void Dgv_catCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.Hide();
			Program.id_categoria = Convert.ToInt32(dgv_cat.Rows[e.RowIndex].Cells[0].Value);
		}
		
		public void Dispara(){
			this.ShowDialog();
		}
	}
}
