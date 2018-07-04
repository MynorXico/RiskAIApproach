using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RiskAI
{
    class Game
    {
        public State[] States { get; set; }

        public State[] LoadStates(string filePath)
        {
            List<State> result = new List<State>();
            string[] fileLines = File.ReadAllLines(filePath);
            for(int i = 1; i < fileLines.Length; i++)
            {
                string currentLine = fileLines[i];
                string[] fields = currentLine.Split(',');
                State s = new State(int.Parse(fields[0]), int.Parse(fields[1]), int.Parse(fields[2]),
                    int.Parse(fields[3]), int.Parse(fields[4]), int.Parse(fields[5]), int.Parse(fields[6]),
                    int.Parse(fields[7]), int.Parse(fields[8]), int.Parse(fields[9]), int.Parse(fields[10]),
                    int.Parse(fields[11]), int.Parse(fields[12]), int.Parse(fields[13]));
                result.Add(s);
            }
            State s1 = new State(int.Parse(fileLines[0]));
            result.Add(s1);
            States = result.ToArray();
            return result.ToArray();
        }
    }
}
