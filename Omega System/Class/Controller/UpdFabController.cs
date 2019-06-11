using System;
using Omega_System.Class.View;
using Omega_System.Class.Model;

namespace Omega_System.Class.Controller
{
	public class UpdFabController : IUpdFabController
	{
		IUpdFab view;
		public UpdFabController(){
			view = new frmUpdFab(f);
		}
		public void Editar(Fabricantes f){
			view.Editar(f);
		}
		public void Voltar(){
			view.Voltar();
		}
	}
}
