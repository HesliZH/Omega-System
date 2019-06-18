using System;
using System.Drawing;
using System.Windows.Forms;
using Omega_System.Class.Controller;
using Omega_System.Class.Model;

namespace Omega_System.Class.View
{
	public partial class frmSearchProdutos : Form, IFormProdutos
	{		
		Produtos p;
		IProdutosController controller;
		
		public frmSearchProdutos()
		{
			InitializeComponent();
			p = new Produtos();
			controller = new ProdutosController();
		}
		
		public void Incluir(){
			frmPro f2 = new frmPro();
			this.Hide();
			f2.ShowDialog();
		}
		
		public void Editar(){
			p.Editar();
		}
		
		public void Excluir(){
		}
		
		public void Voltar(){
			frmMain f1 = new frmMain();
			this.Hide();
			f1.ShowDialog();
		}
		
			
		void Btn_incluirClick(object sender, EventArgs e)
		{
			this.controller.Incluir();
		}
		
		void Btn_editarClick(object sender, EventArgs e)
		{
			this.controller.Editar();
		}
		
		void Btn_excluirClick(object sender, EventArgs e)
		{
			this.controller.Excluir();
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			this.controller.Voltar();
		}
		
		void dgv_produtosCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			p.setCodigo(Convert.ToInt32(dgv_produtos.Rows[e.RowIndex].Cells[0].Value));
			p.setDescricao(Convert.ToString(dgv_produtos.Rows[e.RowIndex].Cells[1].Value));
			p.setMarca(Convert.ToString(dgv_produtos.Rows[e.RowIndex].Cells[2].Value));
			p.setVenda(Convert.ToDouble(dgv_produtos.Rows[e.RowIndex].Cells[3].Value));
			p.setQtd(Convert.ToDouble(dgv_produtos.Rows[e.RowIndex].Cells[4].Value));
			p.setCategoria(Convert.ToString(dgv_produtos.Rows[e.RowIndex].Cells[5].Value));
			this.controller.Editar();
		}
	}
}
