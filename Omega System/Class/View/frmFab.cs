using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;
using Omega_System.Class.Controller;

namespace Omega_System.Class.View
{
	public partial class frmFab : Form, ICadFab
	{
		Fabricantes f;
		ICadFabController controller;
		public frmFab()
		{
			InitializeComponent();
			f = new Fabricantes();
			controller = new CadFabController();
		}
		
		public void Cadastrar(){
			f.setNome(txt_nome.Text);
			f.Cadastrar();
		}
		
		public void Voltar(){
			frmSearchFab f1 = new frmSearchFab();
			this.Hide();
			f1.ShowDialog();
		}
		void Btn_voltarClick(object sender, EventArgs e)
		{
			this.controller.Cadastrar();
		}
		
		void Btn_cadastrarClick(object sender, EventArgs e)
		{
			this.controller.Voltar();
		}
	}
}
