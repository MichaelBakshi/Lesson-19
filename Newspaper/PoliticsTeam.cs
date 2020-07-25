using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public class PoliticsTeam:Newsteam
    {
        internal void CreateStory(Story story)
        {
            Console.WriteLine(story);
        }

        internal override void AddStyle()
        {

        }
    }
}
