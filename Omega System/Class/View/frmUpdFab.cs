using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;

namespace Omega_System.Class.View
{
	public partial class frmUpdFab : Form
	{
		public frmUpdFab(Fabricantes f)
		{
			InitializeComponent();
			txt_id.Text = Convert.ToString(f.getId());
			txt_nome.Text = f.getNome();
		}
		
		void Btn_editarClick(object sender, EventArgs e)
		{
			Fabricantes f = new Fabricantes();
			f.setId(Convert.ToInt32(txt_id.Text));
			f.setNome(txt_nome.Text);
			
			f.Editar();
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			frmSearchFab f = new frmSearchFab();
			this.Hide();
			f.ShowDialog();
		}
	}
}
