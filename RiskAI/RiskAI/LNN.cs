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
        const double propagationRate = 0.6;
        double[] weights = { 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5 };


        /// <summary>
        /// Score given a set of weights x and a set containing game features
        /// </summary>
        /// <returns> Value between 0 and 1 </returns>
        public double Score(State s, double[] x)
        {
            return MathUtilities.LogiscticFnc(MathUtilities.DotProduct(s.GetVector(), x));
        }

        public double Variation(State s0, State s1)
        {
            return Score(s1, weights) - Score(s0, weights);
        }

        public void UpdateWeights(double[] weights, Game trainingGame)
        {
            State[] states = trainingGame.States;
            for(int i = 0; i < weights.Length; i++)
            {
                double currentWeight = weights[i];
                double derivativesSum = 0;

                for (int j = 1; j < states.Length; j++)
                {
                    double propagationSum = 0;
                    for (int k = j; k < states.Length; k++)
                    {
                        propagationSum += Math.Pow(propagationRate, k - j)*Variation(states[j+1],states[j]);
                    }
                    derivativesSum +=  MathUtilities.LogisticDerivative(Score(states[j], weights))*states[j].GetVector()[i] * propagationSum;
                }
                weights[i] = learningRate * derivativesSum;
            }
        }
    }
}
