using System;
using Omega_System.Class.View;

namespace Omega_System.Class.Controller
{
	public class UpdCategoriaController : IUpdCateController
	{
		IUpdCategoria view;
		public UpdCategoriaController()
		{
			view = new frmUpdCategoria();
		}
		
		public void Editar(){
			view.Editar();
		}
		public void Voltar(){
			view.Voltar();
		}
	}
}
