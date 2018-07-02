using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskAI
{

    public class Pais
    {
        string Nombre { get; }
        List<Pais> Vecinos { get; }
        int Tropas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_Nombre"></param>
        public Pais(string _Nombre)
        {
            Vecinos = new List<Pais>();
            this.Nombre = _Nombre;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public void AgregarVecino(Pais p)
        {
            Vecinos.Add(p);
        }
    }

  
}
