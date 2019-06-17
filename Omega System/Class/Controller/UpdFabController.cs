﻿using System;
using Omega_System.Class.View;
using Omega_System.Class.Model;

namespace Omega_System.Class.Controller
{
	public class UpdFabController : IUpdFabController
	{
		IUpdFab view;
		public UpdFabController(){
			view = new frmUpdFab();
		}
		public void Editar(){
			view.Editar();
		}
		public void Voltar(){
			view.Voltar();
		}
	}
}
