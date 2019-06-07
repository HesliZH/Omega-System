using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;

namespace Omega_System.Class.View
{
	public partial class frmUpdUsu : Form
	{
		public frmUpdUsu(Usuarios u)
		{
			InitializeComponent();
			txt_id.Text = Convert.ToString(u.getId());
			txt_login.Text = u.getLogin();
			txt_nome.Text = u.getNome();
			txt_senha.Text = u.getSenha();

		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			frmMain f1 = new frmMain();
			this.Hide();
			f1.ShowDialog();
		}
		
		void Btn_editarClick(object sender, EventArgs e)
		{
			Usuarios u = new Usuarios();
			u.setId(Convert.ToInt32(txt_id.Text));
			u.setLogin(txt_login.Text);
			u.setNome(txt_nome.Text);
			
			u.Editar();
		}
	}
}
