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
        int NewArmies { get; }
        // Number of troops an enemy has at the begining of the turn
        int EnemyNewArmies { get; }

        // Number of troops a player has at the begining of the turn
        int Troops { get; }
        // Number of troops the enemy has at the begining of the turn
        int EnemyTroops { get; }

        // Number of clusters a player owns
        int Clusters { get; }
        // Number of clusters the enemy owns
        int EnemyClusters { get; }

        // Number of countries a playwer owns
        int Countries { get; }
        // Number of not allied countries
        int EnemyCountries { get; }

        // Number of bordering countries
        int BorderingCountries { get; }
        // Number of not allied neighbors
        int NearbyEnemies { get; }
       
        // Number of troops in largest cluster
        int LargestClusterTroops { get; }
        // Number of troops in largest enemy cluster
        int LargestEnemyClusterTroops { get; }

        // Number of countries in largest cluster
        int LargestClusterCountries { get; }
        // Number of countries in largest enemy cluster1
        int LargestEnemyClusterCountries { get; }

        // 1 -> win / 0-> lost
        int Win { get; }
        /*
         *
         *  Pending to add the number of enemy neighbors 
         * each allied country has. In case the player 
         * doesn't own a country, it has a value of zero
        */
        public double[] GetVector()
        {
            double[] vector = { NewArmies,EnemyNewArmies,Clusters,EnemyClusters,Countries, Win};

            return vector;
        }

    }
}
