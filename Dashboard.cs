using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Help_Desk
{
    public partial class Dashboard : Form
    {
        public int CurrentUserID { get; set; }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void DashboardTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*            TicketsView frmTicketView = new TicketsView();

                        // Set the properties for the Ticket form
                        frmTicketView.TopLevel = false;
                        frmTicketView.FormBorderStyle = FormBorderStyle.None;
                        frmTicketView.Dock = DockStyle.Fill;

                        FrmFileTicket frmFileTicket = new FrmFileTicket();
                        frmFileTicket.CurrentUserID = this.CurrentUserID; 

                        // Get the parent container (MainContainer)
                        MainContainer mainContainer = (MainContainer)this.ParentForm;

                        // Add the Ticket form to the panelContainer in the MainContainer
                        mainContainer.ShowFormInPanel(frmTicketView);

                        // Show the Ticket form*/
            /* frmTicketView.Show();*/
                this.Hide();
                TicketsView ticketsView = new TicketsView();
                MainContainer mainContainer = (MainContainer)this.ParentForm;
                ticketsView.CurrentUserID = this.CurrentUserID;
                mainContainer.ShowFormInPanel(ticketsView);
            

        }


        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();

        }

        private void btnKnowledgeBase_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKnowledgeBase knowledgeBase = new FrmKnowledgeBase();
            MainContainer mainContainer = (MainContainer)this.ParentForm;
            mainContainer.ShowFormInPanel(knowledgeBase);
        }
    }


}
