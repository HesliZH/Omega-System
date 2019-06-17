using System;
using Omega_System.Class.View;

namespace Omega_System.Class.Controller
{
	public class UpdProdController : IUpdProdController
	{
		IUpdPro view;
		public UpdProdController()
		{
			view = new frmUpdPro();
		}
		
		public void Editar(){
			view.Editar();
		}
		
		public void Voltar(){
			view.Voltar();
		}
	}
}
