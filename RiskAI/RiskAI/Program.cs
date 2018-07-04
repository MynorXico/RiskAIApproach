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
        static readonly string _rutaTrainingGame1 = Path.Combine(Environment.CurrentDirectory, "Data", "orange.txt");
        static readonly string _rutaTrainingGame2 = Path.Combine(Environment.CurrentDirectory, "Data", "red.txt");
        static readonly string _rutaTrainingGame3 = Path.Combine(Environment.CurrentDirectory, "Data", "green.txt");

        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(0, 0));
            MapaMundi mapa = new MapaMundi(_rutaNombresPaises, _rutaVecinosPaises);

            int[] test = { 0, 0, 0, 0 };

            modify(test);

            LNN NeuralNetwork = new LNN(15);
            Game g = new Game();
            g.LoadStates(_rutaTrainingGame1);

            Game g2 = new Game();
            g2.LoadStates(_rutaTrainingGame2);


            Game g3 = new Game();

            Game[] games = { g, g2, g3 };

            g3.LoadStates(_rutaTrainingGame3);
            NeuralNetwork.Train(games);

            Console.WriteLine("=========================================");
            for (int i = 0; i < g.States.Length; i++)
            {
                Console.WriteLine($"1-State {i}: {NeuralNetwork.Score(g.States[i])}");
            }
            Console.WriteLine("=========================================");

            for (int i = 0; i < g2.States.Length; i++)
            {
                Console.WriteLine($"2-State {i}: {NeuralNetwork.Score(g2.States[i])}");
            }

            Console.WriteLine("=========================================");

            for (int i = 0; i < g3.States.Length; i++)
            {
                Console.WriteLine($"3-State {i}: {NeuralNetwork.Score(g3.States[i])}");
            }

            Console.ReadKey();

        }
    }
}
