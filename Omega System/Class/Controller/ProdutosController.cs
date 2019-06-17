using System;
using Omega_System.Class.View;
using Omega_System.Class.Model;

namespace Omega_System.Class.Controller
{
	public class ProdutosController : IProdutosController
	{
		IFormProdutos view;
		public ProdutosController()
		{
			view = new frmSearchProdutos();
		}
		
		public void Incluir(){
			view.Incluir();
		}
		
		public void Editar(Produtos p){
			view.Editar(p);
		}
		
		public void Excluir(){
			view.Excluir();
		}
		
		public void Voltar(){
			view.Voltar();
		} 
	}
}
