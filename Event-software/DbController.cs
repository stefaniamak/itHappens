using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Net;

namespace dbstuff
{
    public class DbController
    {

        private static DbConnector dbCon = new DbConnector();
        private string conStr = dbCon.GetConnectionString();

        //string conStr = "Server=127.0.0.1;Database=it_happens;Uid=root;Pwd=;";

        MySqlConnection con;

        public DbController()
        {
            try
            {
                con = new MySqlConnection(conStr);
                con.Open();

                var cmd = new MySqlCommand();
                cmd.Connection = con;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
        }

        //Check if Event doesn't exist
        public bool checkIfEventNotExists(string title)
        {
            //Query to check if record exists
            string s = @"SELECT COUNT(*) FROM event WHERE title = @eventTitle";
            var sCommand = new MySqlCommand(s, con);
            sCommand.Parameters.AddWithValue("@eventTitle", title);
            int records = (int)(long)sCommand.ExecuteScalar();

            //If record doesn't exist then add it
            if (records == 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Records Exists");
                return false;
            }

        }

        //Check if Venue doesn't exist
        public bool checkIfVenueNotExists(string nameOfVenue)
        {
            string venueName = nameOfVenue;
            //Query to check if record exists
            string s = @"SELECT COUNT(*) FROM venues WHERE name = @venue_Name";
            var sCommand = new MySqlCommand(s, con);
            sCommand.Parameters.AddWithValue("@venue_Name", venueName);
            int records = (int)(long)sCommand.ExecuteScalar();

            //If record doesn't exist then add it
            if (records == 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Records Exists");
                return false;
            }
        }

        //Check if Area doesn't exist
        public bool checkIfAreaNotExists(string addressArea)
        {

            //Query to check if record exists
            string s = @"SELECT COUNT(*) FROM area WHERE address = @Area_Address";
            var sCommand = new MySqlCommand(s, con);
            sCommand.Parameters.AddWithValue("@Area_Address", addressArea);
            int records = (int)(long)sCommand.ExecuteScalar();

            //If record doesn't exist then add it
            if (records == 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Records Exists");
                return false;
            }
        }

        //Check if Category doesn't exist
        public bool checkIfCategoryNotExists(string categoryName)
        {

            //Query to check if record exists
            string s = @"SELECT COUNT(*) FROM categories WHERE categories = @Category_name";
            var sCommand = new MySqlCommand(s, con);
            sCommand.Parameters.AddWithValue("@Category_name", categoryName);
            int records = (int)(long)sCommand.ExecuteScalar();

            //If record doesn't exist then add it
            if (records == 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Records Exists");
                return false;
            }
        }

        //Find the ID of an existing Area
        public long findAreaID(string address)
        {
            string s = @"SELECT id FROM area WHERE address = @Area_Address";
            var sCommand = new MySqlCommand(s, con);
            sCommand.Parameters.AddWithValue("@Area_Address", address);
            object tmp = sCommand.ExecuteScalar();
            Console.WriteLine(tmp);
            return (long)(int)sCommand.ExecuteScalar();
        }

        //Find the ID of an existing Venue
        public long findVenueID(string name)
        {
            string s = @"SELECT id FROM venues WHERE name = @venueName";
            var sCommand = new MySqlCommand(s, con);
            sCommand.Parameters.AddWithValue("@venueName", name);
            return (long)(int)sCommand.ExecuteScalar();
        }

        //Find the ID of an existing Category
        public long findCategoryID(string categoryName)
        {
            string s = @"SELECT id FROM categories WHERE categories = @categoryName";
            var sCommand = new MySqlCommand(s, con);
            sCommand.Parameters.AddWithValue("@categoryName", categoryName);
            return (long)(int)sCommand.ExecuteScalar();
        }

        public void addEventRecord(string title, long ownerID, long venueID, long categoryID, Nullable<DateTime> startingDate, Nullable<DateTime> endingDate, string description, double ticketprice, string image)
        {
            string s = @"insert into event (title, ownerID, venueID, categoryID, startingDate, endingDate, description, tags, ticketprice, image)
		                    values ( @title, @ownerID, @venueID, @categoryID, @startingDate, @endingDate, @description, @tags, @ticketPrice, @image)";
            var sCommand = new MySqlCommand(s, con);


            // Change the second parameter to the value you want to add (i.e. the Nodes from the response)

            sCommand.Parameters.AddWithValue("@title", title);
            sCommand.Parameters.AddWithValue("@ownerID", 1);
            sCommand.Parameters.AddWithValue("@venueID", venueID);
            sCommand.Parameters.AddWithValue("@categoryID", categoryID);
            sCommand.Parameters.AddWithValue("@startingDate", startingDate);
            sCommand.Parameters.AddWithValue("@endingDate", 0);
            sCommand.Parameters.AddWithValue("@description", description);
            sCommand.Parameters.AddWithValue("@tags", "");
            sCommand.Parameters.AddWithValue("@ticketprice", ticketprice);
            sCommand.Parameters.AddWithValue("@image", image);
            sCommand.ExecuteNonQuery();
        }

        public long addVenueRecord(long areaID, string name)
        {

            string s = @"insert into venues (accID, areaID , name, capacity)
		                    values (@accID, @areaID , @name, @capacity)";

            var sCommand = new MySqlCommand(s, con);


            sCommand.Parameters.AddWithValue("@accID", 1);
            sCommand.Parameters.AddWithValue("@areaID", areaID);
            sCommand.Parameters.AddWithValue("@name", name);
            sCommand.Parameters.AddWithValue("@capacity", 0);
            sCommand.ExecuteNonQuery();

            return sCommand.LastInsertedId;
        }

        public long addAreaRecord(string country, string city, string zip_code, string address)
        {
            string s = @"insert into area (continent, country, city, zip_code, address)
		                    values (@continent, @country, @city, @zip_code, @address)";

            var sCommand = new MySqlCommand(s, con);


            sCommand.Parameters.AddWithValue("@continent", "Europe");
            sCommand.Parameters.AddWithValue("@country", country);
            sCommand.Parameters.AddWithValue("@city", city);
            sCommand.Parameters.AddWithValue("@zip_code", zip_code);
            sCommand.Parameters.AddWithValue("@address", address);
            sCommand.ExecuteNonQuery();

            return sCommand.LastInsertedId;



        }

        public long addCategoryRecord(string categoryName)
        {
            string s = @"insert into categories (categories, parent)
		                    values (@Category_name, @parent)";

            var sCommand = new MySqlCommand(s, con);


            sCommand.Parameters.AddWithValue("@Category_name", categoryName);
            sCommand.Parameters.AddWithValue("@parent", 0);
            sCommand.ExecuteNonQuery();

            return sCommand.LastInsertedId;



        }

        public long addFollowing(int following_user_id, int followed_user_id)
        {
            string s = @"insert into following (following_user_id, followed_user_id)
		                    values (@followingID, @followedID)";

            var sCommand = new MySqlCommand(s, con);


            sCommand.Parameters.AddWithValue("(@followingID", following_user_id);
            sCommand.Parameters.AddWithValue("@followedID", followed_user_id);
            sCommand.ExecuteNonQuery();

            return sCommand.LastInsertedId;
        }

        public long removeFollowing(int following_user_ID, int followed_user_ID)
        {
            string s = @"delete from following WHERE (following_user_ID = @followingID AND followed_user_ID = @followedID)";

            var sCommand = new MySqlCommand(s, con);


            sCommand.Parameters.AddWithValue("(@followingID", following_user_ID);
            sCommand.Parameters.AddWithValue("@followedID", followed_user_ID);
            sCommand.ExecuteNonQuery();

            return sCommand.LastInsertedId;
        }

        public long createEventList(string listTitle, int userID)
        {
            string s = @"insert into event_list (title, creatorID)
		                    values (@title, @userID)";

            var sCommand = new MySqlCommand(s, con);


            sCommand.Parameters.AddWithValue("(@title", listTitle);
            sCommand.Parameters.AddWithValue("@creatorID", userID);
            sCommand.ExecuteNonQuery();

            return sCommand.LastInsertedId;
        }

        //Needs Testing
        public void addGoing(string eventID, int userID)
        {
            string s = @"insert into attendants (eventListID, eventID)
		                    values (@eventListId, @eventID)";
            long eventListID = getUsersEventList(userID, "Going");

            var sCommand = new MySqlCommand(s, con);
            sCommand.Parameters.AddWithValue("(@eventListID", eventListID);
            sCommand.Parameters.AddWithValue("@userID", userID);
            sCommand.ExecuteNonQuery();

        }

        //Needs Testing
        public void addInterested(string eventID, int userID)
        {
            string s = @"insert into attendants (eventListID, eventID)
		                    values (@eventListId, @eventID)";

            long eventListID = getUsersEventList(userID, "Interested");

            var sCommand = new MySqlCommand(s, con);
            sCommand.Parameters.AddWithValue("(@eventListID", eventListID);
            sCommand.Parameters.AddWithValue("@userID", userID);
            sCommand.ExecuteNonQuery();

        }

        //Needs Testing
        public long getUsersEventList(int userID, string title)
        {
            string s = @"SELECT id FROM event_list WHERE creatorID = @userID and title = @title";
            var sCommand = new MySqlCommand(s, con);
            sCommand.Parameters.AddWithValue("@userID", userID);
            sCommand.Parameters.AddWithValue("@title", title);
            object tmp = sCommand.ExecuteScalar();
            Console.WriteLine(tmp);
            return (long)(int)sCommand.ExecuteScalar();
        }

        // Use it to grab images e.x. ( var image = GetImageFromPicPath(imageUrl) )
        public static Image GetImageFromPath(string strUrl)
        {
            using (WebResponse wrFileResponse = WebRequest.Create(strUrl).GetResponse())
            using (Stream objWebStream = wrFileResponse.GetResponseStream())
            {
                MemoryStream ms = new MemoryStream();
                objWebStream.CopyTo(ms, 8192);
                return System.Drawing.Image.FromStream(ms);
            }
        }





        MySqlDataReader doit(string query)
        {

            return new MySqlCommand(query, con).ExecuteReader();
        }
    }


}
