using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Controller;
using Omega_System.Class.Model;

namespace Omega_System.Class.View
{
	public partial class frmUpdPro : Form, IUpdPro
	{
		Produtos p;
		IUpdProdController controller;
		public frmUpdPro()
		{
			InitializeComponent();
			p = new Produtos();
			controller = new UpdProdController();
		}
		
		public void Editar(){
			
		}
		
		public void Voltar(){
			frmMain f = new frmMain();
			this.Hide();
			f.ShowDialog();
		}
		
		void Btn_cadproClick(object sender, EventArgs e)
		{
			this.controller.Editar();
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			this.controller.Voltar();
		}
	}
}
