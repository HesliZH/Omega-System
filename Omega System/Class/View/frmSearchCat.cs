using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;
using System.Data;
using System.Collections.Generic;
using Omega_System.Class.Controller;

namespace Omega_System.Class.View
{
	public partial class frmSearchCat : Form, IFormCategoria
	{
		Categoria c;
		ICategoriaController controller;
		public frmSearchCat()
		{
			InitializeComponent();
			c = new Categoria();
			controller = new CategoriaController();
		}
		
		public void Filtrar(){
			this.dgv_cat.DataSource = c.Listar();
		}
		public void Incluir(){
			frmCategoria f1 = new frmCategoria();
			this.Hide();
			f1.ShowDialog();
		}
		public void Editar(){
			view.Editar();
		}
		public void Excluir(){
			view.Excluir();
		}
		
		void Btn_filtrarClick(object sender, EventArgs e)
		{
			this.controller.Filtrar();
		}
		
		void Btn_incluirClick(object sender, EventArgs e)
		{
			this.controller.Incluir();
		}
		
		void Btn_excluirClick(object sender, EventArgs e)
		{
			this.controller.Excluir();
		}
	}
}
