using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCShop.Models
{
    public class Repository
    {
        private static List<Bag> bags = new List<Bag>();
        public Repository()
        {
            bags.Add(new Bag
             {
                 Name = "Bag",
                 ImgUrl = "https://m.media-amazon.com/images/I/81oUvlsYcnL._SL1500_.jpg",
                 Export = "China",
                 Discription = "Bag classical",
                 Price = "1000"
             });
        }

        public static List<Bag> GetRep()
        {
            return bags;
        }

        public static IEnumerable<Bag> Responses
        {
            get { return bags; }
        }
        public static void AddResponse(Bag response)
        {
            bags.Add(response);
        }
    }
}
