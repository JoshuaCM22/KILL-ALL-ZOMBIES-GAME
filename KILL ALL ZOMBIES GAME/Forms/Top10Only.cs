using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KILL_ALL_ZOMBIES_GAME // Created by: Joshua C. Magoliman
{
    static class Top10Only
    {
        #region Fields
        private static readonly string file = "HighKills.txt";
        private static readonly List<Top10OnlyEntry> entries = new List<Top10OnlyEntry>();
        #endregion

        #region User Defined Methods
        private static void GetTop10Only()
        {
            entries.Clear();
            if (File.Exists(file))
            {
                StreamReader read = new StreamReader(file);
                using (read)
                {
                    string line = read.ReadLine();
                    while (line != null)
                    {
                        string[] res = line.Split();
                        Top10OnlyEntry entry = new Top10OnlyEntry
                        {
                            Date = res[0],
                            Kills = int.Parse(res[1])
                        };
                        entries.Add(entry);
                        line = read.ReadLine();
                    }
                }
            }
        }
        public static void CheckResultInTop10Only(string param_Date, int param_Score)
        {
            if (Top10Only.CheckingIfScoreIsAcceptable(param_Score))
            {
                Top10OnlyEntry entry = new Top10OnlyEntry();
                entry.Date = param_Date;
                entry.Kills = param_Score;
                Top10Only.EnterTop10Only(entry);
            }
        }
        public static bool CheckingIfScoreIsAcceptable(int result)
        {
            GetTop10Only();
            if (result == 0)
            {
                return false;
            }
            if (entries.Count < 10)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < entries.Count; i++)
                {
                    if (result > entries[i].Kills)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public static void EnterTop10Only(Top10OnlyEntry entry)
        {
            entries.Add(entry);
            if (entries.Count > 10)
            {
                int min = int.MaxValue;
                int pos = 0;
                for (int i = 0; i < entries.Count; i++)
                {
                    if (entries[i].Kills < min)
                    {
                        min = entries[i].Kills;
                        pos = i;
                    }
                }
                entries.RemoveAt(pos);
            }
            SaveTop10OnlyEntry();
        }
        private static void SaveTop10OnlyEntry()
        {
            StreamWriter write = new StreamWriter(file, false);
            using (write)
            {
                for (int i = 0; i < entries.Count; i++)
                {
                    write.WriteLine("{0} {1}", entries[i].Date, entries[i].Kills);
                }
            }
        }
        public static string AddingCommasInScore(string param_Score)
        {
            string output = "";
            if (param_Score.Length >= 4)
            {
                double patternFormat = Convert.ToDouble(param_Score);
                output = patternFormat.ToString("#,##0");
            }
            else if (param_Score.Length < 4)
            {
                output = param_Score;
            }
            return output;
        }
        public static void Show(Label param_Rank, Label param_Date, Label param_Kill)
        {
            GetTop10Only();
            var list = from entry in entries
                       orderby entry.Kills descending
                       select entry;
            int counter = 1;

            if (!File.Exists(file))
            {
                param_Rank.Text += "\n\n\n\n\n    The file HighScores.txt doesn't exist!";
            }
            else
            {
                if (new FileInfo(file).Length == 0)
                {
                    param_Date.Text += "\n\n\n\n\nNO SCORES YET";
                }
                else
                {
                    foreach (var item in list)
                    {
                        if (counter % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        if (counter % 3 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        string spaces;
                        if (counter == 10)
                        {
                            spaces = "  ";
                        }
                        else
                        {
                            spaces = "   ";
                        }
                        param_Rank.Text += Convert.ToString("\n" + spaces + counter);
                        param_Date.Text += Convert.ToString("\n" + item.Date);
                        param_Kill.Text += Convert.ToString("\n" + AddingCommasInScore(Convert.ToString(item.Kills)));
                        counter++;
                    }
                }
            }
        }
        #endregion
    }
}