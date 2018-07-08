using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RiskAI
{
    class GameRegister
    {
        public FeaturesState[] States { get; set; }

        public FeaturesState[] LoadStates(string filePath)
        {
            List<FeaturesState> result = new List<FeaturesState>();
            string[] fileLines = File.ReadAllLines(filePath);
            for(int i = 1; i < fileLines.Length; i++)
            {
                string currentLine = fileLines[i];
                string[] fields = currentLine.Split(',');
                FeaturesState s = new FeaturesState(
                    double.Parse(fields[0]),    // New armies
                    double.Parse(fields[1]),    // Enemy new armies
                    double.Parse(fields[2]),    // Troops
                    double.Parse(fields[3]),    // Enemy troops
                    double.Parse(fields[4]),    // Clusters
                    double.Parse(fields[5]),    // Enemy clusters
                    double.Parse(fields[6]),    // Countries
                    double.Parse(fields[7]),    // Enemy Countries
                    double.Parse(fields[8]),    // Free countries
                    double.Parse(fields[9]),    // Bordering Countries
                    double.Parse(fields[10]),   // Nearby Enemies
                    double.Parse(fields[11]),   // Free Nearby Countries
                    double.Parse(fields[12]),   // Largest Cluster Troops
                    double.Parse(fields[13]),   // Largest Enemy Cluster Troops
                    double.Parse(fields[13]),   // Largest Cluster Countries
                    double.Parse(fields[14]),   // Largest Enemy Cluster Countries
                    double.Parse(fields[15]),   // Nearby-Actual1
                    double.Parse(fields[16]),   // Nearby-Actual2
                    double.Parse(fields[17]),   // Nearby-Actual3
                    double.Parse(fields[18]),   // Nearby-Acutal4
                    double.Parse(fields[19]),   // Nearby-Actual5
                    double.Parse(fields[20]),   // Nearby-Actual6
                    double.Parse(fields[21]),   // Nearby-Actual7
                    double.Parse(fields[22]),   // Nearby-Actual8
                    double.Parse(fields[23]),   // Nearby-Actual9
                    double.Parse(fields[24]),   // Nearby-Actual10
                    double.Parse(fields[25]),   // Nearby-Actual11
                    double.Parse(fields[26]),   // Nearby-Actual12
                    double.Parse(fields[27]),   // Nearby-Actual13
                    double.Parse(fields[28]),   // Nearby-Actual14
                    double.Parse(fields[29]),   // Nearby-Actual15
                    double.Parse(fields[30]),   // Nearby-Actual16
                    double.Parse(fields[31]),   // Nearby-Actual17
                    double.Parse(fields[32]),   // Nearby-Actual18
                    double.Parse(fields[33]),   // Nearby-Actual19
                    double.Parse(fields[34]),   // Nearby-Actual20
                    double.Parse(fields[35]),   // Nearby-Actual21
                    double.Parse(fields[36]),   // Nearby-Actual22
                    double.Parse(fields[37]),   // Nearby-Actual23
                    double.Parse(fields[38]),   // Nearby-Actual24
                    double.Parse(fields[39]),   // Nearby-Actual25
                    double.Parse(fields[40]),   // Nearby-Actual26
                    double.Parse(fields[41]),   // Nearby-Actual27
                    double.Parse(fields[42]),   // Nearby-Actual28
                    double.Parse(fields[43]),   // Nearby-Actual29
                    double.Parse(fields[44]),   // Nearby-Actual30
                    double.Parse(fields[45]),   // Nearby-Actual31
                    double.Parse(fields[46]),   // Nearby-Actual32
                    double.Parse(fields[47]),   // Nearby-Actual33
                    double.Parse(fields[48]),   // Nearby-Actual34
                    double.Parse(fields[49]),   // Nearby-Actual35
                    double.Parse(fields[50]),   // Nearby-Actual36
                    double.Parse(fields[51]),   // Nearby-Actual37
                    double.Parse(fields[52]),   // Nearby-Actual38
                    double.Parse(fields[53]),   // Nearby-Actual39
                    double.Parse(fields[54]),   // Nearby-Actual40
                    double.Parse(fields[55]),   // Nearby-Actual41
                    double.Parse(fields[56])    // Nearby-Actual42
                    );
                result.Add(s);
            }
            FeaturesState s1 = new FeaturesState(int.Parse(fileLines[0]));
            result.Add(s1);
            States = result.ToArray();
            return result.ToArray();
        }
    }
}
