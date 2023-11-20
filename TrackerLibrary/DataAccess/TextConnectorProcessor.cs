using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Modals;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    internal static class TextConnectorProcessor
    {
        public static string FullFilePath(this string filename)
        {
            return $"{ConfigurationManager.AppSettings["filepath"] }\\ {filename} ";
        }
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePer = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.Email = cols[3];
                output.Add(p);
            }

            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(",");
                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] PersonIds = cols[2].Split('|');
                foreach (string id in PersonIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }
            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines, string teamFileName, string peopleFileName, string prizeFileName)
        {

            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
            List<PrizeModel> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.matchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(",");
                TournamentModel t = new TournamentModel();
                t.Id= int.Parse(cols[0]);
                t.TournamentName = cols[1];
                t.EntryFee = int.Parse(cols[2]);
                string[] TeamIds = cols[3].Split('|');
                foreach (string id in TeamIds)
                {
                    t.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }
                if (cols[4].Length > 0)
                {
                    string[] prizeIds = cols[4].Split('|');
                    foreach (string id in prizeIds)
                    {
                        t.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    }
                }


                string[] rounds = cols[5].Split('|');

                foreach (string round in rounds)
                {
                    string[] msText = round.Split('^');
                    List<MatchupModel> ms = new List<MatchupModel>();

                    foreach (string m in msText)
                    {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(m)).First());
                    }

                    t.Rounds.Add(ms);
                }

                output.Add(t);
            }
            return output;

        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePer}");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }
        public static void SaveToPeopleFile(this List<PersonModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.Email}");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ ConvertPeopleListToString(t.TeamMembers) }");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }

        public static void SaveRoundsToFile(this TournamentModel model, string matchupFile, string matchupEntryFile)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach(MatchupModel matchup in round)
                {
                    matchup.SaveMatchupToFile(matchupFile);

                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        entry.SaveEntryToFile(matchupEntryFile);
                    }
                }
            }
        }

        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModel(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<string> entries = GlobalConfig.matchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();

            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(',');

                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }
            output = matchingEntries.ConvertToMatchupEntryModels();

            return output;
        }

        private static TeamModel LookupTeamById(int id)
        {
            List<string> teams = GlobalConfig.teamFile.FullFilePath().LoadFile();

            foreach (string team in teams)
            {
                string[] cols = team.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingTeams = new List<string>();
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertToTeamModels(GlobalConfig.peopleFile).First();
                }
            }
            return null;
        }

        private static MatchupModel LookupMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.matchupFile.FullFilePath().LoadFile();

            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);
                    return matchingMatchups.ConvertToMatchupModels().First();
                }
            }
            return null;

        }
        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupModel p = new MatchupModel();
                p.Id = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntryModel(cols[1]);
                if (cols[2] != " ")
                {
                    p.Winner = LookupTeamById(int.Parse(cols[2]));
                } else
                {
                    p.Winner = null;
                }
                
                p.MatchupRound = int.Parse(cols[3]);
                output.Add(p);
            }

            return output;
        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> input)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();

            foreach (string line in input) {
                string[] cols = line.Split(",");

                MatchupEntryModel entry = new MatchupEntryModel();
                entry.Id = int.Parse(cols[0]);
                if (cols[1] != " " )
                {
                    entry.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                    
                }
                else
                {
                    entry.TeamCompeting = null;
                }
                entry.Score = double.Parse(cols[2]);

                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {
                    entry.ParentMatchup = LookupMatchupById(parentId);
                }
                else
                {
                    entry.ParentMatchup = null;
                }

                output.Add(entry);
            }


            return output;

        }

        public static void SaveMatchupToFile(this MatchupModel matchup, string matchupFile)
        {

            List<MatchupModel> matchpus = GlobalConfig.matchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            int CurrentId = 1;

            if (matchpus.Count > 0)
            {
                CurrentId = matchpus.OrderByDescending(x => x.Id).First().Id + 1;
            }

            matchup.Id = CurrentId;
            
            matchpus.Add(matchup);


            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile(GlobalConfig.matchupEntryFile);
            }

            List<string> lines = new List<string>();

            foreach (MatchupModel m in matchpus)
            {
                string winner = "";
                if (m.Winner != null)
                {   
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id}, { ConvertMatchupEntryListToString(m.Entries) }, { winner }, { m.MatchupRound }");
            }

            File.WriteAllLines(GlobalConfig.matchupFile.FullFilePath(), lines);
        }

        public static void SaveEntryToFile(this MatchupEntryModel entry, string matchupEntryFile)
        {
            List<MatchupEntryModel> entries = GlobalConfig.matchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int CurrentId = 1;

            if (entries.Count > 0)
            {
                CurrentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }

            entry.Id = CurrentId;
            entries.Add(entry);

            List<string> lines = new List<string>();

            foreach(MatchupEntryModel e in entries)
            {
                string parent = "";
                if(e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{ e.Id }, { teamCompeting }, { e.Score }, { parent }");
            }

            File.WriteAllLines(GlobalConfig.matchupEntryFile.FullFilePath(), lines);

        }
        public static void SaveToTournamentFile(this List<TournamentModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel t in models)
            {
                lines.Add($"{t.Id},{t.TournamentName},{t.EntryFee},{ConvertTeamListToString(t.EnteredTeams)},{ConvertPrizeListToString(t.Prizes)}, {ConvertRoundListToString(t.Rounds)} ");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";
            if (people.Count == 0)
            {
                return "";
            }

            foreach (PersonModel p in people)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";
            if (teams.Count == 0)
            {
                return "";
            }

            foreach (TeamModel t in teams)
            {
                output += $"{t.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";
            if (prizes.Count == 0)
            {
                return "";
            }

            foreach (PrizeModel p in prizes)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";
            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ConvertMatchupListToString(r)}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";
            if (matchups.Count == 0)
            {
                return "";
            }

            foreach (MatchupModel m in matchups)
            {
                output += $"{m.Id}^";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMatchupEntryListToString(List<MatchupEntryModel> entries)
        {
            string output = "";
            if (entries.Count == 0)
            {
                return "";
            }

            foreach (MatchupEntryModel e in entries)
            {
                output += $"{e.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

    }
}
