using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Model;

namespace Omega_System.Class.View
{
	public partial class frmPro : Form
	{
		public frmPro()
		{
			InitializeComponent();
		}
		
		void Btn_cadproClick(object sender, EventArgs e)
		{
			if(txt_descricao.Text == null || txt_fabricante.Text == null || txt_valor.Text == null || txt_qtd.Text == null){
				MessageBox.Show("Campos em branco");
			}else{
				Produtos p = new Produtos();
				p.setDescricao(txt_descricao.Text);
				p.setMarca(txt_fabricante.Text);
				p.setCategoria(txt_cat.Text);
				p.setVenda(Convert.ToDouble(txt_valor.Text));
				p.setQtd(Convert.ToDouble(txt_qtd.Text));
				
				p.Cadastrar();
			}
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			frmMain f1 = new frmMain();
			this.Hide();
			f1.ShowDialog();
		}
		
		void Btn_procucatClick(object sender, EventArgs e)
		{
			frmPesquisaCat f1 = new frmPesquisaCat();
			f1.Dispara();
			txt_cat.Text = Convert.ToString(Program.id_categoria);
		}
	}
}
