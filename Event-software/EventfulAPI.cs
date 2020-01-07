using itHappends;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;

namespace eventful
{
    class EventfulAPI
    {
        string currentMonth = DateTime.Now.ToString("MMMM", CultureInfo.InvariantCulture);

        //Regex for price parsing
        private static readonly Regex rxNonDigits = new Regex(@"[^\d]+");

        public void GetXmlData(string userLocation, byte page_size, string month = "January" )
        {


            //Using Eventful api to get events around you in the current month

            //itHappens api appkey 
            string appKey = "NcFtfBNKsVVJGrwr";

            //get location from user 
            //string userLocation = "Greece";

            //counts of event results 
            //byte page_size = 5;

            //get name of the current month 
            //string month = DateTime.Now.ToString("MMMM", CultureInfo.InvariantCulture);

            //Eventful API url
            string url = "http://api.eventful.com/rest/events/search?app_key=";

            // QQ---Link for testing HTTP REQUESTS---http://api.eventful.com/rest/events/search?app_key=NcFtfBNKsVVJGrwr&location=Berlin&date=Future&sort_order=date&page_size=20&include=price

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url + appKey + "&location=" + userLocation + "&date=" + month + "&sort_order=date&page_size=" + page_size + "&include=price,categories");
            myRequest.Method = "GET";
            myRequest.ContentType = "text/xml;encoding=utf-8";
            WebResponse myResponse;
            myResponse = myRequest.GetResponse();
            XmlDocument myDoc = new XmlDocument();
            using (Stream responseStream = myResponse.GetResponseStream())
            {
                if (responseStream != null)
                    myDoc.Load(responseStream);
                XmlNodeList xmlNode;
                xmlNode = myDoc.GetElementsByTagName("event");
                for (int i = 0; i < xmlNode.Count; i++)
                {
                    // Name , Description, Foreign URL
                    string eventName = xmlNode[i].ChildNodes[0]?.InnerText.Trim();
                    string eventfulURL = xmlNode[i].ChildNodes[1]?.InnerText.Trim();
                    string eventDescription = xmlNode[i].ChildNodes[2]?.InnerText.Trim();


                    //Starting Time DateTime to Timestamp
                    Nullable<DateTime> startingTime;

                    if (string.IsNullOrEmpty(xmlNode[i].ChildNodes[3]?.InnerText.Trim()))
                    {
                        startingTime = null;
                    }
                    else
                    {

                        startingTime = DateTime.Parse(xmlNode[i].ChildNodes[3]?.InnerText.Trim(),
                    System.Globalization.CultureInfo.InvariantCulture);
                    }



                    //Ending time 

                    Nullable<DateTime> endingTime;

                    if (string.IsNullOrEmpty(xmlNode[i].ChildNodes[4]?.InnerText.Trim()))
                    {
                        endingTime = null;
                    }
                    else
                    {

                        endingTime = DateTime.Parse(xmlNode[i].ChildNodes[4]?.InnerText.Trim(),
                    System.Globalization.CultureInfo.InvariantCulture);
                    }




                    //Price
                    string price = xmlNode[i].ChildNodes[35]?.InnerText.Trim();
                    //Method for price parsing by removing any Letters and or other symbols
                    if (!string.IsNullOrEmpty(price))
                    {
                        price = rxNonDigits.Replace(price, "");
                    }
                    
                    double parsedPrice = (string.IsNullOrEmpty(price)) ? 0 : Double.Parse(price);
                        
                    //Venue Info
                    string venueId = xmlNode[i].ChildNodes[9]?.InnerText.Trim();
                    string venueEventfulUrl = xmlNode[i].ChildNodes[11]?.InnerText.Trim();
                    string venueName = xmlNode[i].ChildNodes[12]?.InnerText.Trim();
                    string venueAddress = xmlNode[i].ChildNodes[14]?.InnerText.Trim();

                    //Area Info

                    string countryName = xmlNode[i].ChildNodes[19]?.InnerText.Trim();
                    string cityName = xmlNode[i].ChildNodes[15]?.InnerText.Trim();
                    string regionName = xmlNode[i].ChildNodes[16]?.InnerText.Trim();
                    string zip_code = xmlNode[i].ChildNodes[18]?.InnerText.Trim();

                    //Image URL

                    //string imageURL = xmlNode[i].ChildNodes[38].HasChildNodes ? xmlNode[i].ChildNodes[38].ChildNodes[6].ChildNodes[0]?.InnerText.Trim() : "";
                    //Console.WriteLine(imageURL);

                    //Categories
                    string categoryName = xmlNode[i].ChildNodes[43].HasChildNodes ? xmlNode[i].ChildNodes[43].ChildNodes[0].ChildNodes[1]?.InnerText.Trim() : " ";
                    string categoryEventfulId = xmlNode[i].ChildNodes[43].HasChildNodes ? xmlNode[i].ChildNodes[43].ChildNodes[0].ChildNodes[0]?.InnerText.Trim() : " ";
                    categoryName = categoryName.Replace("&", "&amp;");


                    long areaID;
                    long venueID;
                    long categoryID;

                    //Save Data
                    Db_controller popdb = new Db_controller();

                    areaID = (popdb.checkIfAreaNotExists(venueAddress)) ? popdb.addAreaRecord(countryName, cityName, zip_code, venueAddress) : popdb.findAreaID(venueAddress);
                    venueID = (popdb.checkIfVenueNotExists(venueName)) ? popdb.addVenueRecord(areaID, venueName) : popdb.findVenueID(venueName);
                    categoryID = (popdb.checkIfCategoryNotExists(categoryEventfulId)) ? popdb.addCategoryRecord(categoryEventfulId) : popdb.findCategoryID(categoryEventfulId);

                    if (popdb.checkIfEventNotExists(eventName))
                    {
                        popdb.addEventRecord(eventName, 0, venueID, categoryID, startingTime, endingTime, eventDescription, parsedPrice);
                    }











                }

            }



        }
    }

}

