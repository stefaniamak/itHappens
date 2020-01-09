using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itHappends;
using itHappens.UIs.Common;

namespace itHappens.Classes
{
    class madeForYouCarousel
    {
        List <CategoryGroupBox> GroupBox;
        madeForYouCarousel(bool logged)
        
        {
            if (logged)
                LoggedInUser(10);
            else
                LoggedOutUser(10);
        }

        private void LoggedInUser(int size)
        {
            for (int i = 0; i < size; i++)
            {
                GroupBox.Add(new CategoryGroupBox());
            }
        }
        private void LoggedOutUser(int size)
        {
               
            Db_connector.Readrows(Db_connector.Categories(size),new int[] {0} );
            for (int i=0; i < size; i++)
            {
               GroupBox.Add( new CategoryGroupBox());
            }
            
        }



        /* public void FrequentTags()
         {
             return Query(@"SELECT * FROM event WHERE startingDate < @Date AND endingDate  > @Date ",
                                    new string[,] { { "@Date", Utility.DateToText(DateTime.Now) } });
           /*  SELECT`column`,
     COUNT(`column`) AS `value_occurrence` 
     FROM `my_table`
     GROUP BY `column`
     ORDER BY `value_occurrence` DESC
     LIMIT 1;

         }*/
    }
}
