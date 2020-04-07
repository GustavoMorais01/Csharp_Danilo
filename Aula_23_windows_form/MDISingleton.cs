using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_23_windows_form
{
    public class MDISingleton
    {
        private MDISingleton() { }

        private static MDIParentPrincipal instanciaMDIParentPrincipal;

        public static MDIParentPrincipal InstanciaMDI()
        {
            if (instanciaMDIParentPrincipal == null)
            {
                instanciaMDIParentPrincipal = new MDIParentPrincipal();
                return instanciaMDIParentPrincipal;
            }

            return instanciaMDIParentPrincipal;
        }

    }
}
