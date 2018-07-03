using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RiskAI
{
    class MapaMundi
    {
        public List<Country> Paises { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        public void AgregarPais(String nombre)
        {
            Country p = new Country(nombre);
            Paises.Add(p);
        }

        public MapaMundi()
        {
            Paises = new List<Country>();
        }
        
        public MapaMundi(string _rutaNombresPaises, string _rutaVecinosPaises)
        {
            string[] lineas = File.ReadAllLines(_rutaNombresPaises);
            Paises = new List<Country>();

            for (int i = 0; i < lineas.Length; i++)
            {
                string lineaActual = lineas[i];
                string nombrePais = lineaActual.Split(',')[1];

                this.AgregarPais(nombrePais);
            }

            lineas = File.ReadAllLines(_rutaVecinosPaises);
            for (int i = 0; i < lineas.Length; i++)
            {
                string lineaActual = lineas[i];
                string[] data = lineaActual.Split(',');
                int indicePais = int.Parse(data[0]) - 1;
                for (int j = 1; j < data.Length; j++)
                {
                    int indiceVecino = int.Parse(data[j]) - 1;
                    this.Paises[indicePais].AgregarVecino(this.Paises[indiceVecino]);
                }
            }
        }
    }
}
