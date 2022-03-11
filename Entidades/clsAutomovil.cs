using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //niveles de acceso
    //publico cualquiera puede accederlo dentro y fuera del ensamblado
    //private nadie tiene acceso al objeto
    //protect acceso solo y unicamente mediante la herencia
    // internal es publica pero solo dentro del ensamblado/proyecto
    //internal protect solo con herencia pero dentro del emsamblado.
    public class clsAutomovil
    {
        //caracteristicas propias del objeto
        //atributos y propiedades
        //nivel de acceso,tipodedato,identificador,valor de inicializacion.
        //tipos de datos string,decimal,bool,short,int,float,date,datetime,char,Array,list,coleccion,Enumerable,object
        // var 
        //private int numerollanta;
        //private string marca;
        //private int modelo;
        //private decimal kilometraje;
        //private string color;

        //encapsulado-set,get
        public int numerollanta { get; set; }
        public string marca { get; set; }
        public int modelo { get; set; }
        public decimal kilometraje{ get; set; }
        public string color { get; set; }




        //constructor



        //acciones


    }
}
