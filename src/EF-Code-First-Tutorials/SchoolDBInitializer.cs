using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Tutorials
{
    public class SchoolDBInitializer : DropCreateDatabaseAlways<SchoolDBContext>
    {
        protected override void Seed(SchoolDBContext context)
        {
            IList<Standard> defaultStandards = new List<Standard>();
            defaultStandards.Add(new Standard() { StandardName = "Standard 1", Description = "First standard" });
            defaultStandards.Add(new Standard() { StandardName = "Standard 2", Description = "Second standard" });
            defaultStandards.Add(new Standard() { StandardName = "Standard 3", Description = "Third standard" });

            foreach (var std in defaultStandards)
            {
                context.Standards.Add(std);
            }

            base.Seed(context);
        }
    }
}
