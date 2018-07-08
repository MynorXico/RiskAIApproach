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
        // File where training games are stored
        static readonly string _trainingGamesPath = Path.Combine(Environment.CurrentDirectory, "TrainingGames");
        // Number of features taken into account for the predicting model
        static readonly int _numberOfFeatures = 56;

        LNN NeuralNetwork = new LNN(_numberOfFeatures);
        
        /// <summary>
        /// Reads each of the file in _trainngGamesPath Directory 
        /// and trains the NeuralNetwork
        /// </summary>
        public AIPredictor()
        {
            foreach(string s in Directory.EnumerateFiles(_trainingGamesPath))
            {
                GameRegister g = new GameRegister();
                g.LoadStates(s);
                NeuralNetwork.Train(g);
            }
            Console.WriteLine("AIPredictor succesfully created...");
        }

        public FeaturesState NextMove(FeaturesState state)
        {
            List<Country> OwnedCountries = new List<Country>(); // It comes from the call
            double CurrentScore = NeuralNetwork.Score(state);
            for(int i = 0; i < OwnedCountries.Count; i++)
            {
                for(int j = 0; j < OwnedCountries[i].Vecinos.Count; j++)
                {

                }
            }

            return null;
        }

        public List<Move> AIStage23(FeaturesState s0, int stage)
        {
            // These come in some way
            List<Country> ownedCountries = new List<Country>();

            FeaturesState currentState = s0;
            FeaturesState movingState = s0;
            
            bool changed = false;
            List<Move> Moves = new List<Move>();
            double maxScore = NeuralNetwork.Score(s0);
            do
            {
                Move bestMove = null;
                changed = false;
                foreach (Country c in ownedCountries)
                {
                    foreach (Country n in c.Vecinos)
                    {
                        bool condition = (stage == 2) ? (c.Owner != n.Owner) : (c.Owner == n.Owner);
                        if (condition)
                        {
                            for (int i = 1; i < c.Troops; i++)
                            {
                                Move m = new Move(c, n, i);
                                currentState = movingState;
                                FeaturesState tmpStat = currentState.Excecute(m);
                                if (NeuralNetwork.Score(tmpStat) > maxScore)
                                {
                                    maxScore = NeuralNetwork.Score(tmpStat);
                                    bestMove = m;
                                    changed = true;
                                }
                            }
                        }
                    }
                }
                if (changed)
                {
                    if(bestMove != null)
                    {
                        Moves.Add(bestMove);
                        movingState.Excecute(bestMove);
                    }
                }
            
            } while (changed);

            return Moves;
        }
        public List<Move> Stage1(FeaturesState s0, int nTroops)
        {
            List<Country> OwnedCountries = new List<Country>();

            FeaturesState currentSate = s0;
            FeaturesState movingState = s0;
            List<Move> Moves = new List<Move>();
            int FreeTroops = nTroops;
            for(int i = 0; i < nTroops; i++)
            {
                Move bestMove = null;
                double maxScore = 0;
                foreach(Country c in OwnedCountries)
                {
                    Move m = new Move(null, c, 1);
                    currentSate = movingState;
                    FeaturesState tmpState = currentSate.Excecute(m);
                    if(NeuralNetwork.Score(tmpState) > maxScore)
                    {
                        maxScore = NeuralNetwork.Score(tmpState);
                        bestMove = m;
                    }
                }
                Moves.Add(bestMove);
                movingState.Excecute(bestMove);
            }
            return Moves;
        }
    }
}
