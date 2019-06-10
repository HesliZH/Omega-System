using System;
using Omega_System.Class.View;

namespace Omega_System.Class.Controller
{
	public class MainController : IMainController
	{
		IFormMain view;
		public MainController()
		{
			view = new frmMain();
		}
		
		public void Usuarios(){
			this.view.Usuarios();
		}
		public void Categorias(){
			this.view.Categorias();
		}
		public void Produtos(){
			this.view.Produtos();
		}
		public void Fabricantes(){
			this.view.Fabricantes();
		}
	}
}
