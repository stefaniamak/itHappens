using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using dbstuff;

namespace itHappens.UIs.anna
{
    public partial class CreateEventPage : UserControl
    {

        private static DbConnector dbCon = new DbConnector();
        private static string conStr = dbCon.GetConnectionString();

        public CreateEventPage()
        {
            InitializeComponent();
        }

        private void CreateEventPage_Load(object sender, EventArgs e)
        {
            fillVenues();
            fillTheDate();
            fillCategories();
            fillTime();
            SDaycomboBox.SelectedIndex = 0;
            EDaycomboBox.SelectedIndex = 0;
            SMonthcomboBox.SelectedIndex = 0;
            EMonthcomboBox.SelectedIndex = 0;
            SYearcomboBox.SelectedIndex = 0;
            EYearcomboBox.SelectedIndex = 0;
            HourComboBox.SelectedIndex = 0;
            MinutesComboBox.SelectedIndex = 0;
            CategorycomboBox.Items.Insert(0, "Select");
            CategorycomboBox.SelectedIndex = 0;
            VenuecomboBox.Items.Insert(0, "Select");
            VenuecomboBox.SelectedIndex = 0;
        }

        public void fillTime()
        {
            for (int i = 0; i <= 24; i++)
            {
                HourComboBox.Items.Add(i.ToString());
            }

            for(int j= 0; j <= 59; j++)
            {
                MinutesComboBox.Items.Add(j.ToString());
            }

        }

        public void fillTheDate()
        {
            for (int i = 1; i <= 31; i++)
            {
                SDaycomboBox.Items.Add(i.ToString());
                EDaycomboBox.Items.Add(i.ToString());
            }

            for (int j = 1; j <= 12; j++)
            {
                SMonthcomboBox.Items.Add(j.ToString());
                EMonthcomboBox.Items.Add(j.ToString());
            }

            for (int k = DateTime.Now.Year; k <= 2025; k++)
            {
                SYearcomboBox.Items.Add(k.ToString());
                EYearcomboBox.Items.Add(k.ToString());
            }
        }

        public void fillCategories()
        {
            MySqlConnection con;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select distinct categories from categories";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    CategorycomboBox.Items.Add(dataReader.GetString(0));
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }

        }

        public void fillVenues()
        {
            MySqlConnection con;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select distinct name from venues";

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    VenuecomboBox.Items.Add(dataReader.GetString(0));
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }

        }


        private void EventNameTextbox_Validated(object sender, EventArgs e)
        {
            if (!EventNameTextbox.Text.Equals(""))
            {
                if (Char.IsLetter(EventNameTextbox.Text[0]))
                {
                    NameValLabel.Text = "";
                }
                else
                {
                    NameValLabel.Text = "Must start with letter";
                }

            }
        }

        private void EventNameTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (EventNameTextbox.Text.Equals(""))
            {
                NameValLabel.Text = "Event Name is empty";
            }
            else
            {
                NameValLabel.Text = "";
            }
        }



        private void PriceTextbox_Validated(object sender, EventArgs e)
        {
            if (!PriceTextbox.Text.Equals(""))
            {
                if (isAllDigits(PriceTextbox.Text))
                {
                    TPriceValLabel.Text = "";
                }
                else
                {
                    TPriceValLabel.Text = "Write only digits";
                }

            }
        }

        private void PriceTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (PriceTextbox.Text.Equals(""))
            {
                TPriceValLabel.Text = "Ticket Price is empty";
            }
            else
            {
                TPriceValLabel.Text = "";
            }
        }

        private void TagsTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (TagsTextbox.Text.Equals(""))
            {
                TagsValLabel.Text = "Tags field is empty";
            }
            else
            {
                TagsValLabel.Text = "";
            }
        }


        public static bool isAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void CategorycomboBox_Validating(object sender, CancelEventArgs e)
        {
            if (CategorycomboBox.Text.Equals("Select"))
            {
                CategoryValLabel.Text = "Select a category";
            }
            else
            {
                CategoryValLabel.Text = "";
            }
        }

        private void DescTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (DescTextbox.Text.Equals(""))
            {
                DescValLabel.Text = "Must write description";
            }
            else
            {
                DescValLabel.Text = "";
            }
        }

        private void VenuecomboBox_Validating(object sender, CancelEventArgs e)
        {          
            if (VenuecomboBox.Text.Equals("Select"))
            {
                VenueValLabel.Text = "Select a category";
            }
            else
            {
                VenueValLabel.Text = "";
            }
        }

        public void clearTextBoxes()
        {
            EventNameTextbox.Text = "";
            VenuecomboBox.Text = "Select";
            CategorycomboBox.Text = "Select";
            TagsTextbox.Text = "";
            PriceTextbox.Text = "";
            DescTextbox.Text = "";
        }

        private void CreateEventButton_Click(object sender, EventArgs e)
        {
            if (EventNameTextbox.Text.Equals("") || VenuecomboBox.Text.Equals("Select")
                || CategorycomboBox.Text.Equals("Select") || TagsTextbox.Text.Equals("")
                || PriceTextbox.Text.Equals("") || DescTextbox.Text.Equals(""))
            {
                MessageBox.Show("Fill the fields right", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!NameValLabel.Text.Equals("") || !VenueValLabel.Text.Equals("") || !CategoryValLabel.Text.Equals("")
                     || !TagsValLabel.Text.Equals("") || !TPriceValLabel.Text.Equals("") || !DescValLabel.Text.Equals(""))
            {
                     MessageBox.Show("Correct the fields right", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DateTime StartingDate = convertDate(SYearcomboBox.Text,SMonthcomboBox.Text, 
                                                    SDaycomboBox.Text,HourComboBox.Text,MinutesComboBox.Text);
                DateTime EndingDate = convertDate(EYearcomboBox.Text, EMonthcomboBox.Text,
                                                    EDaycomboBox.Text, "0", "0");
                int venue = getVenueId(VenuecomboBox.Text);
                int category = getCategoryId(CategorycomboBox.Text);
                int ownerId = getOwnerId(UIs.anna.LogInPage.userName);
                createEventCon(EventNameTextbox.Text,venue,ownerId,StartingDate,EndingDate,category,TagsTextbox.Text,
                    Convert.ToDouble(PriceTextbox.Text),DescTextbox.Text);
                MessageBox.Show("You successfully made an event!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                //Emfanish tou EventProfile (kanonika tha prepei me ta stoixeia tou event)
                Controllers.UIController.eventsProfileToolStripMenuItem_MiddlePanel();
                
                clearTextBoxes();
                SDaycomboBox.SelectedIndex = 0;
                EDaycomboBox.SelectedIndex = 0;
                SMonthcomboBox.SelectedIndex = 0;
                EMonthcomboBox.SelectedIndex = 0;
                SYearcomboBox.SelectedIndex = 0;
                EYearcomboBox.SelectedIndex = 0;
                HourComboBox.SelectedIndex = 0;
                MinutesComboBox.SelectedIndex = 0;
            }
        }


        public DateTime convertDate(String year,String month,String day,String hour,String minutes)
        {
            DateTime sDate = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day),
                Convert.ToInt32(hour), Convert.ToInt32(minutes),0);
            return sDate;
        }

        public void createEventCon(String eventTitle,int eventVenue,int eventOwner,DateTime start, DateTime end, int eventCategory, String EventTags,double ticketPrice, String desc)
        {
            MySqlConnection con;

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand cmd = con.CreateCommand(); ;

                String query = "INSERT INTO event(title,ownerID,venueID,categoryID,startingDate," +
                    "endingDate,description,tags,ticketprice) VALUES(@title,@ownerID,@venueID,@categoryID,@startingDate," +
                    "@endingDate,@description,@tags,@ticketprice)";

                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@title", eventTitle);
                cmd.Parameters.AddWithValue("@ownerID", eventOwner);
                cmd.Parameters.AddWithValue("@venueID", eventVenue);
                cmd.Parameters.AddWithValue("@categoryID", eventCategory);
                cmd.Parameters.AddWithValue("@startingDate", start);
                cmd.Parameters.AddWithValue("@endingDate", end);
                cmd.Parameters.AddWithValue("@description", desc);
                cmd.Parameters.AddWithValue("@tags",EventTags);
                cmd.Parameters.AddWithValue("@ticketprice", ticketPrice);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                Console.WriteLine("Error Insert Statement");
            }
        }

        public int getOwnerId(String s)
        {
            MySqlConnection con;
            String ownerid = "0";

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select id from users where username='" + s + "'";


                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    ownerid = dataReader.GetString(0);
                }
                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }

            return Convert.ToInt32(ownerid);
        }

        public int getCategoryId(String s)
        {
            MySqlConnection con;
            String categoryid = "0";

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select id from categories where categories='" + s + "'";


                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    categoryid = dataReader.GetString(0);
                }
                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }

            return Convert.ToInt32(categoryid);
        }

        public int getVenueId(String s)
        {
            MySqlConnection con;
            String venueid="0";

            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String queryString = "Select id from venues where name='" +s+"'";
                

                command = new MySqlCommand(queryString, con);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    venueid = dataReader.GetString(0);
                }
                con.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }

            return Convert.ToInt32(venueid);
        }


    }
}
