using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Modals;

namespace TrackerUI
{
    public partial class createTournament : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public createTournament()
        {
            InitializeComponent();
            WireUpLists();

        }
        private void WireUpLists()
        {

            teamDropdown.DataSource = null;
            teamDropdown.DataSource = availableTeams;
            teamDropdown.DisplayMember = "TeamName";

            teamsList.DataSource = null;
            teamsList.DataSource = selectedTeams;
            teamsList.DisplayMember = "TeamName";

            prizesList.DataSource = null;
            prizesList.DataSource = selectedPrizes;
            prizesList.DisplayMember = "PlaceName";

        }

        private void addTeamBtn_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)teamDropdown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }

        }
        private void createPrizeBtn_Click(object sender, EventArgs e)
        {
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        private void teamOneScoreValue_TextChanged(object sender, EventArgs e)
        {

        }
        private void teamTwoScoreValue_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void roundDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void teamOneScoreLabel_Click(object sender, EventArgs e)
        {

        }
        private void roundLabel_Click(object sender, EventArgs e)
        {

        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void deleteTeamBtn_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)teamsList.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void deletePrizeBtn_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesList.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);

                WireUpLists();
            }
        }

        private void createTournamentBtn_Click(object sender, EventArgs e)
        {
            decimal fee = 0;

            bool feeValid = decimal.TryParse(entryFeeValue.Text, out fee);

            if (!feeValid)
            {
                MessageBox.Show("Invalid entry fee");
                return;
            }

            TournamentModel tm = new TournamentModel();
            tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            TournamentLogic.CreateRounds(tm);

            GlobalConfig.Connection.CreateTournament(tm);

        }
    }
}
