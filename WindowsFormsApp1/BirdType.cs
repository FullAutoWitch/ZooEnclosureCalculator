using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BirdType
    {
        public interface BirdFly
        {
            bool BirdCanFly();
        }

        public interface BirdSwim
        {
            bool BirdCanSwim();
        }

        public interface BirdRun
        {
            bool BirdCanRun();
        }

        public class Bird
        {
            public string BirdType { get; set; }
        }

        //Duck
        public class FlyingSwimmingBird : Bird, BirdFly, BirdSwim
        {
            public bool BirdCanFly()
            {
                return true;
            }

            public bool BirdCanSwim()
            {
                return true;
            }
        }

        //Penguin
        public class SwimmingBird : Bird, BirdSwim
        {
            public bool BirdCanSwim()
            {
                return true;
            }
        }
        
        //New Zealand Bird
        public class RunningSwimmingBird : Bird, BirdRun, BirdSwim
        {
            public bool BirdCanRun()
            {
                return true;
            }

            public bool BirdCanSwim()
            {
                return true;
            }
        }

    }
}
