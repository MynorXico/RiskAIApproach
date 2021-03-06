﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskAI
{
    class LNN
    {
        const double learningRate = 0.1;
        const double propagationRate = 0.7;
        double[] weights;

        public LNN(int numberOfFeatures)
        {   
            weights = new double[numberOfFeatures];
            for(int i = 0; i < weights.Length; i++)
            {
                weights[i] = (double)1 / (12*weights.Length);
                //weights[i] = 1;
            }
        }

        /// <summary>
        /// Score given a set of weights x and a set containing game features
        /// </summary>
        /// <returns> Value between 0 and 1 </returns>
        public double Score(FeaturesState s)
        {
            return MathUtilities.SigmoidFnc(MathUtilities.DotProduct(s.GetVector(), weights));
        }

        public double Variation(FeaturesState s0, FeaturesState s1)
        {
            if (s1.isFinalState)
            {
                return (s1.Reward) - Score(s0);
            }
            if (s0.isFinalState)
            {
                throw new Exception("Not expected: *");
            }
            return Score(s1) - Score(s0);
        }

        public void Train(GameRegister trainingGame)
        {
            FeaturesState[] states = trainingGame.States;
            for(int i = 0; i < weights.Length; i++)
            {
                double derivativesSum = 0;

                for (int t = 0; t < states.Length-1; t++)
                {
                    double propagationSum = 0;
                    for (int j = t; j < states.Length-1; j++)
                    {
                        propagationSum += Math.Pow(propagationRate, j - t)*Variation(states[t],states[t+1]);
                    }

                    derivativesSum +=  MathUtilities.SigmoidDerivative(Score(states[t]))*states[t].GetNormalizedVector()[i] * propagationSum;
                }
                weights[i] += learningRate * derivativesSum;
            } 
        }

        private double Variation(FeaturesState state, int v)
        {
            return 1 - Score(state);
        }

        public void Train(GameRegister[] trainingGames)
        {
            for (int i = 0; i < trainingGames.Length; i++)
            {
                Train(trainingGames[i]);
            }
        }
    }
}
