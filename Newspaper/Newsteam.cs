using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public abstract class Newsteam
    {
        protected Story story;

        internal  void CreateStory()
        {
            this.story = new Story("Goal", "Our team winned");

        }

        internal Story GetStory()
        {
            return story;
        }

        internal virtual void AddStyle()
        {
            story.SetStyle("default");
        }


        public override string ToString()
        {
            return $"[story]:{story}";
        }



    }

    
}
