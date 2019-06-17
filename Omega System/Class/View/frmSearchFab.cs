using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;
using System.Data;
using System.Collections.Generic;
using Omega_System.Class.Controller;

namespace Omega_System.Class.View
{
	public partial class frmSearchFab : Form, IFormFabricante
	{
		int id;
		Fabricantes f;
		IFabricanteController i;
		public frmSearchFab()
		{
			InitializeComponent();
			f = new Fabricantes();
			i = new FabricantesController();
		}
		
		public void Incluir(){
			frmFab f1 = new frmFab();
			this.Hide();
			f1.ShowDialog();
		
		}
		
		public void Editar(){
			
			
			frmUpdFab f3 = new frmUpdFab(f);
			this.Hide();
			f3.ShowDialog();
		}
		
		public void Excluir(){
			f.setId(id);
			f.Deletar();
		}
		
		public void Filtrar(){
			this.dgv_fab.DataSource = f.Buscar();		
		}
		
		public void Voltar(){
			frmMain f3 = new frmMain();
			this.Hide();
			f3.ShowDialog();
		}
		void Btn_filtrarClick(object sender, EventArgs e)
		{
			i.Filtrar();
		}
		
		void Btn_incluirClick(object sender, EventArgs e)
		{
			i.Incluir();
		}
		
		void Dgv_fabCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			f.setId(Convert.ToInt32(dgv_fab.Rows[e.RowIndex].Cells[0].Value));
			f.setNome(Convert.ToString(dgv_fab.Rows[e.RowIndex].Cells[1].Value));
			i.Editar();
		}
		
		void Dgv_fabCellClick(object sender, DataGridViewCellEventArgs e)
		{
			id = Convert.ToInt32(dgv_fab.Rows[e.RowIndex].Cells[0].Value);
		}
		
		void Btn_excluirClick(object sender, EventArgs e)
		{
			i.Excluir();
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			i.Voltar();
		}
	}
}
