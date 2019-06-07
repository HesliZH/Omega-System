using System;
using Omega_System.Class.Interfaces;
using Omega_System.Class.View;

namespace Omega_System.Class.Controller
{
	public class ControleFormUsuarios : IFormUsuarios
	{
		public ControleFormUsuarios()
		{
		}
		
		public void IncluiUsuario(){
			frmUsu f1 = new frmUsu();
			f1.ShowDialog();
		}
		
		public void EditaUsuario(){
			frmUsu f2 = new frmUsu();
			f2.ShowDialog();
		}
		
		public void ExcluiUsuario(){
			frmUsu f3 = new frmUsu();
			f3.ShowDialog();
		}
		
		public void Voltar(){
			frmSearchUsuario f4 = new frmSearchUsuario();
			f4.ShowDialog();
		}
	}
}
