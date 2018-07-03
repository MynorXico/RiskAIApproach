using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskAI
{
    class LNN
    {
        const double learningRate = 0.1;
        const double propagationRate = 1;
        double[] weights;

        public LNN(int numberOfFeatures)
        {
            weights = new double[numberOfFeatures];
            for(int i = 0; i < weights.Length; i++)
            {
                weights[i] = (double)1 / (5*weights.Length);
            }
        }

        /// <summary>
        /// Score given a set of weights x and a set containing game features
        /// </summary>
        /// <returns> Value between 0 and 1 </returns>
        public double Score(State s)
        {
            return MathUtilities.SigmoidFnc(MathUtilities.DotProduct(s.GetVector(), weights));
        }

        public double Variation(State s0, State s1)
        {
            double score0 = Score(s0);
            double score1 = Score(s1);
            return Score(s1) - Score(s0);
        }

        public void Train(Game trainingGame)
        {
            State[] states = trainingGame.States;
            for(int i = 0; i < weights.Length; i++)
            {
                double derivativesSum = 0;

                for (int t = 0; t < states.Length-1; t++)
                {
                    double propagationSum = 0;
                    for (int j = t; j < states.Length-1; j++)
                    {
                        propagationSum += Math.Pow(propagationRate, j - t)*Variation(states[t+1],states[t]);
                    }
                    derivativesSum +=  MathUtilities.SigmoidDerivative(Score(states[t]))*states[t].GetNormalizedVector()[i] * propagationSum;
                }
                weights[i] += learningRate * derivativesSum;
            } 
        }

        public void Train(Game[] trainingGames)
        {
            for (int i = 0; i < trainingGames.Length; i++)
            {
                Train(trainingGames[i]);
            }
        }
    }
}
