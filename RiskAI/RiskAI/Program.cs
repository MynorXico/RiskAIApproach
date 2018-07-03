using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RiskAI
{
    class Program
    {
        static readonly string _rutaNombresPaises = Path.Combine(Environment.CurrentDirectory, "Data", "Countries.txt");
        static readonly string _rutaVecinosPaises = Path.Combine(Environment.CurrentDirectory, "Data", "Neighbors.txt");
        static readonly string _rutaTrainingGame = Path.Combine(Environment.CurrentDirectory, "Data", "orange.txt");
        static void Main(string[] args)
        {
            MapaMundi mapa = new MapaMundi(_rutaNombresPaises, _rutaVecinosPaises);

            int[] test = { 0, 0, 0, 0 };

            modify(test);

            LNN NeuralNetwork = new LNN(15);
            Game g = new Game();
            g.LoadStates(_rutaTrainingGame);

            NeuralNetwork.Train(g);
            for(int i = 0; i < g.States.Length; i++)
            {
                Console.WriteLine($"State {i}: {NeuralNetwork.Score(g.States[i])}");
            }
            Console.ReadKey();
        }

        public static void modify(int[] test)
        {
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = i;
            }
        }

    }
}
