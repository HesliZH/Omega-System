using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omega_System.Class.Controller
{
    interface IControleFormularios
    {	
    	//Interface responsável pela abertura dos FORMS frmMain
        void AbreFormProdutos();
        void AbreFormCategorias();
        void AbreFormFabricantes();
        void AbreFormPrincipal();
        void AbreFormUsuarios();
    }
}
