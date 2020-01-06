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

namespace itHappens.UIs.anna
{
    public partial class CreateEventPage : UserControl
    {
        public CreateEventPage()
        {
            InitializeComponent();
        }

        private void CreateEventPage_Load(object sender, EventArgs e)
        {
            fillVenues();
            fillTheDate();
            fillCategories();
            SDaycomboBox.SelectedIndex = 0;
            EDaycomboBox.SelectedIndex = 0;
            SMonthcomboBox.SelectedIndex = 0;
            EMonthcomboBox.SelectedIndex = 0;
            SYearcomboBox.SelectedIndex = 0;
            EYearcomboBox.SelectedIndex = 0;
            CategorycomboBox.Items.Insert(0, "Select");
            CategorycomboBox.SelectedIndex = 0;
            VenuecomboBox.Items.Insert(0, "Select");
            VenuecomboBox.SelectedIndex = 0;
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
            string conStr = "Server=127.0.0.1;Database=it_happens;Uid=root;Pwd=123456;";
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
            string conStr = "Server=127.0.0.1;Database=it_happens;Uid=root;Pwd=123456;";
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

        private void OwnerNameTextbox_Validated(object sender, EventArgs e)
        {
            if (!OwnerNameTextbox.Text.Equals(""))
            {
                if (IsAllLetters(OwnerNameTextbox.Text))
                {
                    OwnerValLabel.Text = "";
                }
                else
                {
                    OwnerValLabel.Text = "Write only letters";
                }

            }
            
        }

        private void OwnerNameTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (OwnerNameTextbox.Text.Equals(""))
            {
                OwnerValLabel.Text = "Owner Name is empty";
            }
            else
            {
                OwnerValLabel.Text = "";
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



        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
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

        private void CategorycomboBox_Validated(object sender, EventArgs e)
        {
            if (!CategorycomboBox.Text.Equals(""))
            {
                if (!Char.IsLetter(CategorycomboBox.Text[0]))
                {
                    CategoryValLabel.Text = "Must start with letter";
                }
            }
            else
            {
                CategoryValLabel.Text = "Category is empty";
            }
        }

        private void CategorycomboBox_Validating(object sender, CancelEventArgs e)
        {
            if (CategorycomboBox.Text.Equals(""))
            {
                CategoryValLabel.Text = "Category is empty";
            }
            else if (CategorycomboBox.Text.Equals("Select"))
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

        private void VenuecomboBox_Validated(object sender, EventArgs e)
        {
            if (!VenuecomboBox.Text.Equals(""))
            {
                if (!Char.IsLetter(VenuecomboBox.Text[0]))
                {
                    VenueValLabel.Text = "Must start with letter";
                }
            }
            else
            {
                VenueValLabel.Text = "Category is empty";
            }
        }

        private void VenuecomboBox_Validating(object sender, CancelEventArgs e)
        {
            if (VenuecomboBox.Text.Equals(""))
            {
                VenueValLabel.Text = "Category is empty";
            }
            else if (VenuecomboBox.Text.Equals("Select"))
            {
                VenueValLabel.Text = "Select a category";
            }
            else
            {
                VenueValLabel.Text = "";
            }
        }
    }
}
