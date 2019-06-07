using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;

namespace Omega_System.Class.View
{
	public partial class frmCategoria : Form
	{
		Categoria c;
		public frmCategoria()
		{
			new Categoria();
			InitializeComponent();
		}
		
		void Btn_cadastrarClick(object sender, EventArgs e)
		{
			if(txt_descricao.Text == "" || txt_descricao.Text == null){
				MessageBox.Show("Campos em branco!");
			}else{
				Categoria c = new Categoria();
				c.setDescricao(txt_descricao.Text);
				c.Cadastrar();
			}
			
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			frmMain f1 = new frmMain();
			this.Hide();
			f1.ShowDialog();
		}
	}
}
