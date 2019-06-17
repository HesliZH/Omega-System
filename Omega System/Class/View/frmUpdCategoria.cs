using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Controller;
using Omega_System.Class.Model;

namespace Omega_System.Class.View
{
	public partial class frmUpdCategoria : Form, IUpdCategoria
	{
		Categoria c;
		IUpdCateController controller;
		public frmUpdCategoria()
		{
			InitializeComponent();
			c = new Categoria();
			controller = new UpdCategoriaController();
		}
		
		
		public void Editar(){
			c.Editar();
		}
		
		public void Voltar(){
			frmSearchCat f1 = new frmSearchCat();
			this.Hide();
			f1.ShowDialog();
		}
		
		void Btn_cadastrarClick(object sender, EventArgs e)
		{
			this.controller.Editar();
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			this.controller.Voltar();
		}
	}
}
