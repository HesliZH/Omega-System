using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;
using Omega_System.Class.Controller;

namespace Omega_System.Class.View
{
	public partial class frmUpdFab : Form, IUpdFab
	{	
		Fabricantes f1;
		IUpdFabController controller;
		public frmUpdFab(Fabricantes f)
		{
			InitializeComponent();
			f1 = new Fabricantes();
			txt_id.Text = Convert.ToString(f.getId());
			txt_nome.Text = f.getNome();
			controller = new UpdFabController();
		}
		
		public void Editar(){
			f1.setId(Convert.ToInt32(txt_id.Text));
			f1.setNome(txt_nome.Text);
			
			f1.Editar();
		}
		
		public void Voltar(){
			frmSearchFab f = new frmSearchFab();
			this.Hide();
			f.ShowDialog();
		}
		
		void Btn_editarClick(object sender, EventArgs e)
		{
			this.controller.Editar();
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			this.controller.Voltar();
		}
	}
}
