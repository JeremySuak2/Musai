using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDominio
{
   public class Validacion
    {

       public int SoloNumero(int Tecla) 
       {
           switch (Tecla) 
           {
               case 48:
               case 49:
               case 50:
               case 51:
               case 52:
               case 53:
               case 54:
               case 55:
               case 56:
               case 57:
               case 46:
               case 08:
               case 13:
                   return Tecla;


               default:

                   MessageBox.Show("No ingresar letra");
                   break;

                           
           
           
           }
           return Tecla = 0;
       
       
       
       
       }





    }
}
