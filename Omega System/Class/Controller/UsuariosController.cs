using System;
using Omega_System.Class.View;
using Omega_System.Class.Interfaces;

namespace Omega_System.Class.Controller
{
	public class UsuariosController : IUsuarioController
	{
		IFormUsuarios view;
		public UsuariosController()
		{
			view = new frmSearchUsuario();
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
		
		public void Voltar(){
			view.Voltar();
		}
	}
}
