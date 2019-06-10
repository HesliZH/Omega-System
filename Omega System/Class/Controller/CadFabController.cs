using System;
using Omega_System.Class.View;

namespace Omega_System.Class.Controller
{
	public class CadFabController
	{
		ICadFab view;
		public CadFabController()
		{
			view = new frmFab();
		}
		public void Cadastrar(){
			view.Cadastrar();
		}	
		public void Voltar(){
			view.Voltar();
		}
	}
}
