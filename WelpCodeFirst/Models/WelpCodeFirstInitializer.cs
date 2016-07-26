using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelpCodeFirst.Models
{
    public class WelpCodeFirstInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WelpCodeFirstContext>
        
        //initializers can be used to seed the database. SEEDING means everytime model chagned the changes are made but then the
        //seed method is run to drop database, recreate it and put the new things (listed below) into the database.

        
    {
        protected override void Seed(WelpCodeFirstContext context)
        {
            context.Users.Add(new User() { UserName = "johndoe", Email = "johndoe@gmail.com", Password = "llama" });
            base.Seed(context);
        }
    }
}