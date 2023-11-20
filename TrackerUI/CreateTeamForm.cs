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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedMembers = new List<PersonModel>();
        private ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            WireUpList();
            callingForm = caller;
        }


        private void WireUpList()
        {
            selectMemberDropdown.DataSource = null;

            selectMemberDropdown.DataSource = availableMembers;
            selectMemberDropdown.DisplayMember = "FullName";

            teamMembersList.DataSource = null;

            teamMembersList.DataSource = selectedMembers;
            teamMembersList.DisplayMember = "FullName";


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void createTeamBtn_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedMembers;

            t = GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }

        private void createMemberBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.Email = emailValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                selectedMembers.Add(p);
                WireUpList();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";

            }
            else
            {
                MessageBox.Show("You need to fill in all fields");
            }

        }
        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectMemberDropdown.SelectedItem;

            if (p != null)
            {
                availableMembers.Remove(p);
                selectedMembers.Add(p);

                WireUpList();
            }

        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void removeSelectedBtn_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersList.SelectedItem;

            if (p != null)
            {
                selectedMembers.Remove(p);
                availableMembers.Add(p);

                WireUpList();
            }

        }
    }
}
