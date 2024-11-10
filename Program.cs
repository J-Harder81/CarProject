using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("4S3BMHB68B3286050", "Honda", "Civic");
            car1.Drive(250);
            car1.Display();

            Car car2 = new Car("1G1YZ23J9P5800001", "Ford", "Mustang", 10000);
            car1.Drive(150);
            car2.Display();
        }
    }
}
