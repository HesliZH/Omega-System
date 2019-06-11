using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;
using Omega_System.Class.Controller;

namespace Omega_System.Class.View
{
	public partial class frmCategoria : Form, ICadCategoria
	{
		Categoria c;
		ICadCategoriaController controller;
		public frmCategoria()
		{
			c = new Categoria();
			controller = new CadCategoriaController();
			InitializeComponent();
		}
		
		public void Cadastrar(){
			if(txt_descricao.Text == "" || txt_descricao.Text == null){
					MessageBox.Show("Campos em branco!");
			}else{
				Categoria c = new Categoria();
				c.setDescricao(txt_descricao.Text);
				c.Cadastrar();
			}
		}
		
		public void Voltar(){
			frmMain f1 = new frmMain();
			this.Hide();
			f1.ShowDialog();
		}
		
		void Btn_cadastrarClick(object sender, EventArgs e)
		{
			this.controller.Cadastrar();
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			this.controller.Voltar();
		}
	}
}
