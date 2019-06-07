using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omega_System.Class.View;
using Omega_System.Class.Interfaces;
using System.Windows.Forms;
using System.Drawing;

namespace Omega_System.Class.Controller
{
    class ControleFormularios : IControleFormularios
    {
        public void AbreFormProdutos() {
            frmPro f1 = new frmPro();
            f1.ShowDialog();
        }

        public void AbreFormCategorias() {
            frmSearchCat f2 = new frmSearchCat();
            f2.ShowDialog();
        }

        public void AbreFormFabricantes() {
            frmSearchFab f3 = new frmSearchFab();
            f3.ShowDialog();
        }

        public void AbreFormPrincipal() {
            frmMain f4 = new frmMain();
            f4.ShowDialog();
        }
    	
    	public void AbreFormUsuarios() {
            frmSearchUsuario f5 = new frmSearchUsuario();
            f5.ShowDialog();
        }
    }
}
