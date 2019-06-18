using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;
using Omega_System.Class.Controller;

namespace Omega_System.Class.View
{
	public partial class frmUpdFab : Form, IUpdFab
	{	
		Fabricantes f;
		IUpdFabController controller;
		public frmUpdFab()
		{
			InitializeComponent();
			f = new Fabricantes();
			txt_id.Text = Convert.ToString(f.getId());
			txt_nome.Text = f.getNome();
			controller = new UpdFabController();
		}
		
		public void Editar(){
			f.setId(Convert.ToInt32(txt_id.Text));
			f.setNome(txt_nome.Text);
			
			f.Editar();
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
