using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskAI
{
    /// <summary>
    /// State of the board at a given turn
    /// </summary>
    public class State
    {
        // Number of armies a player is given at the begining of the turn
        double NewArmies { get; }
        // Number of troops an enemy has at the begining of the turn
        double EnemyNewArmies { get; }

        // Number of troops a player has at the begining of the turn
        double Troops { get; }
        // Number of troops the enemy has at the begining of the turn
        double EnemyTroops { get; }

        // Number of clusters a player owns
        double Clusters { get; }
        // Number of clusters the enemy owns
        double EnemyClusters { get; }

        // Number of countries a playwer owns
        double Countries { get; }
        // Number of not allied countries
        double EnemyCountries { get; }
        // Number of free countries (nobody owns them)
        double FreeCountries { get; }

        // Number of bordering countries
        double BorderingCountries { get; }
        // Number of not allied neighbors
        double NearbyEnemies { get; }
        // Number of countries owned by nobody
        double FreeNearbyCountries { get; }

        // Number of troops in largest cluster
        double LargestClusterTroops { get; }
        // Number of troops in largest enemy cluster
        double LargestEnemyClusterTroops { get; }

        // Number of countries in largest cluster
        double LargestClusterCountries { get; }
        // Number of countries in largest enemy cluster1
        double LargestEnemyClusterCountries { get; }

        // Difference between nearby enemies minus troops in ith country , i belongs to {1,2,...,41,42}
        double EnemyMCurrent1 { get; }
        double EnemyMCurrent2 { get; }
        double EnemyMCurrent3 { get; }
        double EnemyMCurrent4 { get; }
        double EnemyMCurrent5 { get; }
        double EnemyMCurrent6 { get; }
        double EnemyMCurrent7 { get; }
        double EnemyMCurrent8 { get; }
        double EnemyMCurrent9 { get; }
        double EnemyMCurrent10 { get; }
        double EnemyMCurrent11 { get; }
        double EnemyMCurrent12 { get; }
        double EnemyMCurrent13 { get; }
        double EnemyMCurrent14 { get; }
        double EnemyMCurrent15 { get; }
        double EnemyMCurrent16 { get; }
        double EnemyMCurrent17 { get; }
        double EnemyMCurrent18 { get; }
        double EnemyMCurrent19 { get; }
        double EnemyMCurrent20 { get; }
        double EnemyMCurrent21 { get; }
        double EnemyMCurrent22 { get; }
        double EnemyMCurrent23 { get; }
        double EnemyMCurrent24 { get; }
        double EnemyMCurrent25 { get; }
        double EnemyMCurrent26 { get; }
        double EnemyMCurrent27 { get; }
        double EnemyMCurrent28 { get; }
        double EnemyMCurrent29 { get; }
        double EnemyMCurrent30 { get; }
        double EnemyMCurrent31 { get; }
        double EnemyMCurrent32 { get; }
        double EnemyMCurrent33 { get; }
        double EnemyMCurrent34 { get; }
        double EnemyMCurrent35 { get; }
        double EnemyMCurrent36 { get; }
        double EnemyMCurrent37 { get; }
        double EnemyMCurrent38 { get; }
        double EnemyMCurrent39 { get; }
        double EnemyMCurrent40 { get; }
        double EnemyMCurrent41 { get; }
        double EnemyMCurrent42 { get; }


        // 1 -> win / 0-> lost
        
        // Vector containing each feature
        public double[] GetVector()
        {
            double[] vector = {
                NewArmies,
                EnemyNewArmies,
                Troops,
                EnemyTroops,
                Clusters,
                EnemyClusters,
                Countries,
                EnemyCountries,
                FreeCountries,
                BorderingCountries,
                NearbyEnemies,
                FreeNearbyCountries,
                LargestClusterTroops,
                LargestEnemyClusterTroops,
                LargestClusterCountries,
                LargestEnemyClusterCountries,
                Math.Pow(EnemyMCurrent1,2),
                Math.Pow(EnemyMCurrent2,2),
                Math.Pow(EnemyMCurrent3,2),
                Math.Pow(EnemyMCurrent4,2),
                Math.Pow(EnemyMCurrent5,2),
                Math.Pow(EnemyMCurrent6,2),
                Math.Pow(EnemyMCurrent7,2),
                Math.Pow(EnemyMCurrent8,2),
                Math.Pow(EnemyMCurrent9,2),
                Math.Pow(EnemyMCurrent10,2),
                Math.Pow(EnemyMCurrent11,2),
                Math.Pow(EnemyMCurrent12,2),
                Math.Pow(EnemyMCurrent13,2),
                Math.Pow(EnemyMCurrent14,2),
                Math.Pow(EnemyMCurrent15,2),
                Math.Pow(EnemyMCurrent16,2),
                Math.Pow(EnemyMCurrent17,2),
                Math.Pow(EnemyMCurrent18,2),
                Math.Pow(EnemyMCurrent19,2),
                Math.Pow(EnemyMCurrent20,2),
                Math.Pow(EnemyMCurrent21,2),
                Math.Pow(EnemyMCurrent22,2),
                Math.Pow(EnemyMCurrent23,2),
                Math.Pow(EnemyMCurrent24,2),
                Math.Pow(EnemyMCurrent25,2),
                Math.Pow(EnemyMCurrent26,2),
                Math.Pow(EnemyMCurrent27,2),
                Math.Pow(EnemyMCurrent28,2),
                Math.Pow(EnemyMCurrent29,2),
                Math.Pow(EnemyMCurrent30,2),
                Math.Pow(EnemyMCurrent31,2),
                Math.Pow(EnemyMCurrent32,2),
                Math.Pow(EnemyMCurrent33,2),
                Math.Pow(EnemyMCurrent34,2),
                Math.Pow(EnemyMCurrent35,2),
                Math.Pow(EnemyMCurrent36,2),
                Math.Pow(EnemyMCurrent37,2),
                Math.Pow(EnemyMCurrent38,2),
                Math.Pow(EnemyMCurrent39,2),
                Math.Pow(EnemyMCurrent40,2),
                Math.Pow(EnemyMCurrent41,2),
                Math.Pow(EnemyMCurrent42,2)
            };
            return vector;
        }

        // Vector containing features between 0 and 1
        public double[] GetNormalizedVector()
        {
            double[] max = { 27, 27, Troops+EnemyTroops, Troops+EnemyTroops, 42, 42, 42, 42, 42, 8, 42, 42, 95, 95, 42, 42,
                10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
                10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
                10, 10, 10, 10 };
            return MathUtilities.ItemWiseDivision(GetVector(), max);
        }

        public bool isFinalState = false;
        
        public double Reward { get; set; }

        public State(int reward)
        {
            this.Reward = reward;
            isFinalState = true;
        }

        public State(
            double newArmies,
            double enemyNewArmies,
            double troops,
            double enemyTroops,
            double clusters,
            double enemyClusters,
            double countries,
            double enemyCountries,
            double freeCountries,
            double borderingCountries,
            double nearbyEnemies,
            double freeNearbyCountries,
            double largestClusterTroops,
            double largestEnemyClusterTroops,
            double largestClusterCountries,
            double largestEnemyClusterCountries,
            double enemyMcurrent1,
            double enemyMcurrent2,
            double enemyMcurrent3,
            double enemyMcurrent4,
            double enemyMcurrent5,
            double enemyMcurrent6,
            double enemyMcurrent7,
            double enemyMcurrent8,
            double enemyMcurrent9,
            double enemyMcurrent10,
            double enemyMcurrent11,
            double enemyMcurrent12,
            double enemyMcurrent13,
            double enemyMcurrent14,
            double enemyMcurrent15,
            double enemyMcurrent16,
            double enemyMcurrent17,
            double enemyMcurrent18,
            double enemyMcurrent19,
            double enemyMcurrent20,
            double enemyMcurrent21,
            double enemyMcurrent22,
            double enemyMcurrent23,
            double enemyMcurrent24,
            double enemyMcurrent25,
            double enemyMcurrent26,
            double enemyMcurrent27,
            double enemyMcurrent28,
            double enemyMcurrent29,
            double enemyMcurrent30,
            double enemyMcurrent31,
            double enemyMcurrent32,
            double enemyMcurrent33,
            double enemyMcurrent34,
            double enemyMcurrent35,
            double enemyMcurrent36,
            double enemyMcurrent37,
            double enemyMcurrent38,
            double enemyMcurrent39,
            double enemyMcurrent40,
            double enemyMcurrent41,
            double enemyMcurrent42)
        {
            NewArmies = newArmies;
            EnemyNewArmies = enemyNewArmies;
            Troops = troops;
            EnemyTroops = enemyTroops;
            Clusters = clusters;
            EnemyClusters = enemyClusters;
            Countries = countries;
            EnemyCountries = enemyCountries;
            FreeCountries = freeCountries;
            BorderingCountries = borderingCountries;
            NearbyEnemies = nearbyEnemies;
            FreeNearbyCountries = freeNearbyCountries;
            LargestClusterTroops = largestClusterTroops;
            LargestEnemyClusterTroops = largestEnemyClusterTroops;
            LargestClusterCountries = largestClusterCountries;
            LargestEnemyClusterTroops = largestEnemyClusterCountries;
            EnemyMCurrent1 = enemyMcurrent1;
            EnemyMCurrent2 = enemyMcurrent1;
            EnemyMCurrent3 = enemyMcurrent1;
            EnemyMCurrent4 = enemyMcurrent1;
            EnemyMCurrent5 = enemyMcurrent1;
            EnemyMCurrent6 = enemyMcurrent1;
            EnemyMCurrent7 = enemyMcurrent1;
            EnemyMCurrent8 = enemyMcurrent1;
            EnemyMCurrent9 = enemyMcurrent1;
            EnemyMCurrent10 = enemyMcurrent1;
            EnemyMCurrent11 = enemyMcurrent1;
            EnemyMCurrent12 = enemyMcurrent1;
            EnemyMCurrent13 = enemyMcurrent1;
            EnemyMCurrent14 = enemyMcurrent1;
            EnemyMCurrent15 = enemyMcurrent1;
            EnemyMCurrent16 = enemyMcurrent1;
            EnemyMCurrent17 = enemyMcurrent1;
            EnemyMCurrent18 = enemyMcurrent1;
            EnemyMCurrent19 = enemyMcurrent1;
            EnemyMCurrent20 = enemyMcurrent1;
            EnemyMCurrent21 = enemyMcurrent1;
            EnemyMCurrent22 = enemyMcurrent1;
            EnemyMCurrent23 = enemyMcurrent1;
            EnemyMCurrent24 = enemyMcurrent1;
            EnemyMCurrent25 = enemyMcurrent1;
            EnemyMCurrent26 = enemyMcurrent1;
            EnemyMCurrent27 = enemyMcurrent1;
            EnemyMCurrent28 = enemyMcurrent1;
            EnemyMCurrent29 = enemyMcurrent1;
            EnemyMCurrent30 = enemyMcurrent1;
            EnemyMCurrent31 = enemyMcurrent1;
            EnemyMCurrent32 = enemyMcurrent1;
            EnemyMCurrent33 = enemyMcurrent1;
            EnemyMCurrent34 = enemyMcurrent1;
            EnemyMCurrent35 = enemyMcurrent1;
            EnemyMCurrent36 = enemyMcurrent1;
            EnemyMCurrent37 = enemyMcurrent1;
            EnemyMCurrent38 = enemyMcurrent1;
            EnemyMCurrent39 = enemyMcurrent1;
            EnemyMCurrent40 = enemyMcurrent1;
            EnemyMCurrent41 = enemyMcurrent1;
            EnemyMCurrent42 = enemyMcurrent1;

        }
    }
}
