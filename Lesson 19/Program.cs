using NewsCompany;
using Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_19
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Story politicStory = new Story("Politician", "Accused of corruption");
            Story gossipStory = new Story("Famous actor", "Got new role");
            Story healthStory = new Story("Smoking", "Is bad for health");

            /*PoliticsTeam firstPolitics = new PoliticsTeam();
            Healthteam firstHealth = new Healthteam();
            GossipTeam firstGossip = new GossipTeam();*/

            Story[] forTheFirstNewspaper = new Story[3];
            forTheFirstNewspaper[0] = politicStory;
            forTheFirstNewspaper[1] = healthStory;
            forTheFirstNewspaper[2] = gossipStory;

            Newspaper firstNewspaper = new Newspaper(forTheFirstNewspaper, 5.7f);
            Newspaper secondNewspaper = new Newspaper(forTheFirstNewspaper, 6.2f);

            Console.WriteLine(firstNewspaper.ToString());
            Console.WriteLine(secondNewspaper.ToString());

            Seller seller = new Seller();
            seller.SellNewspaper(firstNewspaper);
            seller.SellNewspaper(secondNewspaper);
            Console.WriteLine(seller.ToString());
        }
    }
}
