using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.andrea
{
    public partial class EventProfilePage : UserControl
    {
        public EventProfilePage()
        {
            InitializeComponent();
            friends();
            
        }

        public EventProfilePage(string eventName, string venueName, Color categoryColor, Image background, string organizerName, string organizerSurename, DateTime  eventDateTime, double ticketPrice, string description)
        {
            InitializeComponent();
            
            friends();
            categoryColorPanel.BackColor = categoryColor;
            eventNameLabel.Text = eventName; 
            //monthLabel.Text =      // Tha Kaneis mia methodo pou tha emfanizei ta 3 prwta grammata tou mhna pou ginete, se kefalaia
            //dayLabel               // Mono thn mera, des to design
            //categoryColorLabel.BackColor = categoryColor; // Auto tha einai to onoma tou xrwmatos sto VS. To VS an parathrhseis exei kai onomata pera apo RGB. Des an mporeis na to efarmwseis me ta onomata, alliws tha s dwsw RGB
            backgroundPictureBox.BackgroundImage = background;
            locationTextBox.Text = venueName;
            organizerTextBox.Text = organizerName; // !!!!!! Niko, sunduase ta string organizerName kai organizerSurname. Den kathisa na psaksw pws to kaneis, opote prosorina egrapsa mono to organizerName. Allakse to.
            //dayTimeTextBox.Text = eventDateTime; // !!!!!! Niko, auto vgazei error gt prepei na deis pws na kaneis convert to date se string.
            ticketPriceLabel.Text = (ticketPrice).ToString(); // !!!!! Tsekare an einai double to ticket price apo th vash. Kai den eimai sigourh an douleuei auth h ToSting().
            descriptionTextBox.Text = description;
        }

        private void friends()
        {
            for (int i = 0; i < 5; i++)
            {
                friendsFlowPanel.Controls.Add(new UIs.Common.FriendsAttending());
            }
        }

        private void EventProfilePage_Load(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
