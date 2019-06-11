using System;
using Omega_System.Class.View;

namespace Omega_System.Class.Controller
{
	public class CadCategoriaController : ICadCategoriaController
	{
		ICadCategoria view;
		public CadCategoriaController()
		{
			view = new frmCategoria();
		}
		
		public void Cadastrar(){
			view.Cadastrar();
		}
		
		public void Voltar(){
			view.Voltar();
		}
	}
}
