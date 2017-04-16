using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
class Cars
{
    public Tuple<string,List<Brand>> GetTheCars()
    {
        List<Brand> list = new List<Brand>()
        {
            new Brand()
            {
                Name = "Audi",
                Model = "A4"
            },
            new Brand()
            {
                Name = "Mitsubishi",
                Model = "Lancer"
            },
            new Brand()
            {
                Name = "Mazda",
                Model = "RX-8"
            }
        };
        return new Tuple<string, List<Brand>>("Passenger car", list);
    }
}
}
