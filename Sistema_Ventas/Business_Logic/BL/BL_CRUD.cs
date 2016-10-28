using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.BL
{
    public class BL_CRUD
    {
        #region Insertar

        public bool Insertar(string Bar_Code, string Descripcion, string Pre_V, string Pre_C, string sto, string min_st) {

            return new DataAcesss.DA.DA_CRUD().Inserta(Bar_Code, Descripcion, Pre_V, Pre_C, sto, min_st);
            
        }


        #endregion Insertar

        #region BuscarProducto

        public string[] BuscarProducto(string Bar_Code) {

            return new DataAcesss.DA.DA_CRUD().BuscarProducto(Bar_Code);
        
        }

        #endregion BuscarProducto

    }
}
