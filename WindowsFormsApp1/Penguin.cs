using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.BirdType;

namespace WindowsFormsApp1
{
    public class Penguin : SwimmingBird
    {
        public Penguin()
        {
            BirdType = "Penguin";
        }
    }
}
