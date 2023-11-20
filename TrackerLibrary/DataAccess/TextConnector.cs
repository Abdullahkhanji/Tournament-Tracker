using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Modals;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    internal class TextConnector : IDataConnection
    {
        private const string prizesFile = "PrizeModels.csv";
        private const string peopleFile = "PeopleModels.csv";
        private const string teamFile = "TeamModels.csv";
        private const string tournamentFile = "TouranementModels.csv";
        private const string matchupFile = "MatchupModels.csv";
        private const string matchupEntryFile = "MatchupEntryModels.csv";



        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> People = peopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int CurrentId = 1;
            if (People.Count > 0)
            {
                CurrentId = People.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = CurrentId;

            People.Add(model);

            People.SaveToPeopleFile(peopleFile);

            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> Prizes = prizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int CurrentId = 1;
            if (Prizes.Count > 0)
            {
                CurrentId = Prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = CurrentId;

            Prizes.Add(model);

            Prizes.SaveToPrizeFile(prizesFile);

            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return peopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = teamFile.FullFilePath().LoadFile().ConvertToTeamModels(peopleFile);

            int CurrentId = 1;

            if (teams.Count > 0)
            {
                CurrentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = CurrentId;
            teams.Add(model);
            teams.SaveToTeamFile(teamFile);

            return model;
        }

        public List<TeamModel> GetTeam_All()
        {
            return teamFile.FullFilePath().LoadFile().ConvertToTeamModels(peopleFile);
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = tournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels(teamFile, peopleFile, prizesFile);

            int CurrentId = 1;

            if (tournaments.Count > 0)
            {
                CurrentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id=CurrentId;

            model.SaveRoundsToFile(matchupFile, matchupEntryFile);
            tournaments.Add(model);
            tournaments.SaveToTournamentFile(tournamentFile);

        }

        public List<TournamentModel> GetTournament_All()
        {
            return tournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels(teamFile, peopleFile, prizesFile);
        }
    }
}
