using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RiskAI
{
    class AIPredictor
    {
        // File where training games are saved
        static readonly string _trainingGamesPath = Path.Combine(Environment.CurrentDirectory, "TrainingGames");
        // Number of features taken into account for the predicting model
        static readonly int _numberOfFeatures = 12;

        LNN NeuralNetwork = new LNN(_numberOfFeatures);
        
        public AIPredictor()
        {
            foreach(string s in Directory.EnumerateFiles(_trainingGamesPath))
            {
                Game g = new Game();
                g.LoadStates(s);
                NeuralNetwork.Train(g);
            }
            Console.WriteLine("AIPredictor succesfully created...");
        }
    }
}
