using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Interfaces;
using Omega_System.Class.Controller;

namespace Omega_System.Class.View
{
	public partial class frmMain : Form
	{
		IControleFormularios i;
		public frmMain()
		{
			InitializeComponent();
			i = new ControleFormularios();
		}
		
		void Btn_usuClick(object sender, EventArgs e)
		{
			this.Hide();
			i.AbreFormUsuarios();
		}
		
		void Btn_cadProdClick(object sender, EventArgs e)
		{
			i.AbreFormProdutos();
		}
		
		void Btn_cadcatClick(object sender, EventArgs e)
		{
			this.Hide();
			i.AbreFormCategorias();
		}
		
		void Btn_cadfabClick(object sender, EventArgs e)
		{
			this.Hide();
			i.AbreFormFabricantes();
		}
	}
}
