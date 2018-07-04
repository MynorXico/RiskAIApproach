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

        // 1 -> win / 0-> lost
        double Win { get; }
        /*
         *
         *  Pending to add the number of enemy neighbors 
         * each allied country has. In case the player 
         * doesn't own a country, it has a value of zero
        */
        
        public double[] GetVector()
        {
            double[] vector = { NewArmies, EnemyNewArmies, Troops, EnemyTroops, Clusters,EnemyClusters,Countries,EnemyCountries,FreeCountries,BorderingCountries,NearbyEnemies,FreeNearbyCountries,LargestClusterTroops,LargestClusterCountries,Win};
            return vector;
        }

        public double[] GetNormalizedVector()
        {
            double[] max = { 27, 27, 95, 95, 42, 42, 42, 42, 42, 8, 42, 42, 95, 42, 1};
            return MathUtilities.ItemWiseDivision(GetVector(), max);
        }

        public bool isFinalState = false;
        
        public double Reward { get; set; }

        public State(int reward)
        {
            this.Reward = reward;
            isFinalState = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newArmies"></param>
        /// <param name="enemyNewArmies"></param>
        /// <param name="troops"></param>
        /// <param name="enemyTroops"></param>
        /// <param name="clusters"></param>
        /// <param name="enemyClusters"></param>
        /// <param name="countries"></param>
        /// <param name="enemyCountries"></param>
        /// <param name="freeCountries"></param>
        /// <param name="borderingCountries"></param>
        /// <param name="nearbyEnemies"></param>
        /// <param name="freeNearbyCountries"></param>
        /// <param name="largestClusterTroops"></param>
        /// <param name="largestClusterCountries"></param>
        /// <param name="largestEnemyClusterCountries"></param>
        public State(double newArmies, double enemyNewArmies, double troops, double enemyTroops,
            double clusters, double enemyClusters, double countries, double enemyCountries, 
            double freeCountries, double borderingCountries, double nearbyEnemies, 
            double freeNearbyCountries, double largestClusterTroops, double largestClusterCountries)
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
            LargestClusterCountries = largestClusterCountries;
            Win = 1;
        }
    }
}
