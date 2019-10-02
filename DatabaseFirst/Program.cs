using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var conext = new DatabaseFirstDemoEntities(); 
            var table = new table_1()
            {
                Body = "body",
                DatePublished = "ds",
                Title = "title",
                PostID= 1 

            };
            conext.table_1.Add(table);
            conext.SaveChanges(); 
        }
    }
}
