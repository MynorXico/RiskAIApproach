using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskAI
{

    public class Country
    {
        string Nombre { get; }
        public List<Country> Vecinos { get; }
        int Tropas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_Nombre"></param>
        public Country(string _Nombre)
        {
            Vecinos = new List<Country>();
            this.Nombre = _Nombre;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public void AgregarVecino(Country p)
        {
            Vecinos.Add(p);
        }
    }

  
}
