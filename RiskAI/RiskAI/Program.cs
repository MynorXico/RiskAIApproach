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
        static readonly string _rutaTrainingGame1 = Path.Combine(Environment.CurrentDirectory, "Data", "w1.txt");
        static readonly string _rutaTrainingGame2 = Path.Combine(Environment.CurrentDirectory, "Data", "w2.txt");
        static readonly string _rutaTrainingGame3 = Path.Combine(Environment.CurrentDirectory, "Data", "w3.txt");
        static readonly string _rutaTrainingGame4 = Path.Combine(Environment.CurrentDirectory, "Data", "w4.txt");
        static readonly string _rutaTrainingGame5 = Path.Combine(Environment.CurrentDirectory, "Data", "l1.txt");



        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(0, 0));
            MapaMundi mapa = new MapaMundi(_rutaNombresPaises, _rutaVecinosPaises);

            int[] test = { 0, 0, 0, 0 };


            LNN NeuralNetwork = new LNN(14);
            Game g = new Game();
            g.LoadStates(_rutaTrainingGame1);

            Game g2 = new Game();
            g2.LoadStates(_rutaTrainingGame2);


            Game g3 = new Game();
            g3.LoadStates(_rutaTrainingGame3);

            Game g4 = new Game();
            g4.LoadStates(_rutaTrainingGame4);

            Game g5 = new Game();
            g5.LoadStates(_rutaTrainingGame5);

            Game[] games = { g5, g2, g3, g4, g};



            NeuralNetwork.Train(games);

            for(int j = 0; j < games.Length; j++)
            {
                Console.WriteLine($"========= GAME {j} =============");
                for (int i = 0; i < games[j].States.Length; i++)
                {
                    Console.WriteLine($"State {i}: {NeuralNetwork.Score(games[j].States[i])}");
                }

            }
            Console.ReadKey();


        }
    }
}
