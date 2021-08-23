using CLASE02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLASE02.DAORE
{
    public class PersonaRepositore
    {
        public List<ClsPersona > ObtenerPersona()
        {
            return new List<ClsPersona>() {
            
             new ClsPersona
             {
                 id=1,
                 nombre="Nelson"
             },
             
             new ClsPersona
             {
                 id=2,
                 nombre="Ahsly"
             },

             new ClsPersona
             {
                 id=3,
                 nombre="Sofia"
             }
            
            };
        }
    }
}