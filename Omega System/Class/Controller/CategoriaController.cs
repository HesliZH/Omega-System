using System;
using Omega_System.Class.View;

namespace Omega_System.Class.Controller
{
	public class CategoriaController : ICategoriaController
	{
		IFormCategoria view;
		public CategoriaController()
		{
			view = new frmSearchCat();
		}
		
		public void Filtrar(){
			view.Filtrar();
		}
		public void Incluir(){
			view.Incluir();
		}
		public void Editar(){
			view.Editar();
		}
		public void Excluir(){
			view.Excluir();
		}
	}
}
