using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public class Newspaper
    {
        private Story[] stories;
        private float price;

        public Newspaper(Story[] stories, float price)
        {
            this.stories = stories;
            this.price = price;
        }

        public Story[] GetStories()
        {
            return stories;
        }

        public void SetStories(Story[]stories)
        {

        }

        public float GetPrice()
        {
            return price;
        }

        public void SetPrice(float price)
        {
            if (price>0)
            {
                this.price = price;
            }
        }

        public string ToString()
        {
            string result = $"[Price:]:{ price}, ";
            foreach (var story in stories)
            {
                result += story.GetTitle() + " "+ story.GetBody() + ", ";
            }
            return result;
            //return $"[Newspaper]:{stories}, [Price:]:{price}";
        }
    }
}
