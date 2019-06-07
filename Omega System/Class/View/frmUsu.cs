using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;

namespace Omega_System.Class.View
{
	public partial class frmUsu : Form
	{
		public frmUsu()
		{
			InitializeComponent();		
		}
		
		void Btn_cadastrarClick(object sender, EventArgs e)
		{
			Usuarios c1 = new Usuarios();
			
			c1.setNome(txt_nome.Text);
			c1.setLogin(txt_login.Text);
			c1.setSenha(txt_senha.Text);
			
			c1.Cadastrar();
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			frmMain f1 = new frmMain();
			this.Hide();
			f1.ShowDialog();
		}
	}
}
