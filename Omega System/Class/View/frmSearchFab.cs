using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;
using System.Data;
using System.Collections.Generic;

namespace Omega_System.Class.View
{
	public partial class frmSearchFab : Form
	{
		int id;
		public frmSearchFab()
		{
			InitializeComponent();
		}
		
		void Btn_filtrarClick(object sender, EventArgs e)
		{
			Fabricantes f = new Fabricantes();
			this.dgv_fab.DataSource = f.Buscar();
		}
		
		void Btn_incluirClick(object sender, EventArgs e)
		{
			frmFab f1 = new frmFab();
			this.Hide();
			f1.ShowDialog();
		}
		
		void Dgv_fabCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Fabricantes f = new Fabricantes();
			f.setId(Convert.ToInt32(dgv_fab.Rows[e.RowIndex].Cells[0].Value));
			f.setNome(Convert.ToString(dgv_fab.Rows[e.RowIndex].Cells[1].Value));
			
			frmUpdFab f3 = new frmUpdFab(f);
			this.Hide();
			f3.ShowDialog();
		}
		
		void Dgv_fabCellClick(object sender, DataGridViewCellEventArgs e)
		{
			id = Convert.ToInt32(dgv_fab.Rows[e.RowIndex].Cells[0].Value);
		}
		
		void Btn_excluirClick(object sender, EventArgs e)
		{
			Fabricantes f = new Fabricantes();
			MessageBox.Show(Convert.ToString(id));
			f.setId(id);
			f.Deletar();
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			frmMain f3 = new frmMain();
			this.Hide();
			f3.ShowDialog();
		}
	}
}
