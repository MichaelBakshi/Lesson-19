using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public class Story
    {
        private string title;
        private string body;
        private string visualStyle;

        public override string ToString()
        {
            return $"[title]:{title}";
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetBody()
        {
            return body;
        }

        public Story(string title, string body)
        {
            this.title = title;
            this.body = body;
        }

        public void SetStyle(string style)
        {
            this.visualStyle = style;
        }
    }
}
