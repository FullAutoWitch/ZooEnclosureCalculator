using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.BirdType;

namespace WindowsFormsApp1
{
    public class Duck : FlyingSwimmingBird
    {
        public Duck()
        {
            BirdType = "Duck";
        }
    }
}
