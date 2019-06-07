using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;

namespace Omega_System.Class.View
{
	public partial class frmFab : Form
	{
		public frmFab()
		{
			InitializeComponent();
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			frmSearchFab f1 = new frmSearchFab();
			this.Hide();
			f1.ShowDialog();
		}
		
		void Btn_cadastrarClick(object sender, EventArgs e)
		{
			Fabricantes f = new Fabricantes();
			f.setNome(txt_nome.Text);
			f.Cadastrar();
		}
	}
}
