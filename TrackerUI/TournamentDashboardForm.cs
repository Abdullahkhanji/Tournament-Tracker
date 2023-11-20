using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Modals;

namespace TrackerUI
{
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> Tournaments = GlobalConfig.Connection.GetTournament_All();
        public TournamentDashboardForm()
        {
            InitializeComponent();
            WireUpLists();

        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void TournamentDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void WireUpLists()
        {
            tournamentDropdown.DataSource = Tournaments;
            tournamentDropdown.DisplayMember = "TournamentName";
        }

        private void createTournamentBtn_Click(object sender, EventArgs e)
        {
            createTournament frm = new createTournament();
            frm.Show();
        }
    }
}
