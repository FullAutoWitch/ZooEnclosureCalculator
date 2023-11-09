using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BirdEnclosure
    {
        public bool Wire { get; set; }
        public bool Wall { get; set; }
        public double LandArea { get; set; }
        public double PondArea { get; set; }
        public double LandLenght { get; set; }
        public double LandWidth { get; set; }
        public double PondLenght { get; set; }
        public double PondWidth { get; set; }
        public double Temperature { get; set; }

        public BirdEnclosure(bool wire, bool wall, double landLenght, double landWidth, double pondLenght, double pondWidth, double temperature  = 0) 
        {
            Wire = wire;
            Wall = wall;
            LandArea = landWidth * landLenght;
            PondArea = pondWidth * pondLenght;
            LandLenght = landLenght;
            LandWidth = landWidth;
            PondLenght = pondLenght;
            PondWidth = pondWidth;
            Temperature = temperature;

    }  
    }

    interface Area
    {
        double area();
    }

    public class DuckArea : BirdEnclosure, Area
    {
        public DuckArea(bool wire, bool wall, double landLenght, double landWidth, double pondLenght, double pondWidth, double temperature = 0) : base(wire, wall, landLenght, landWidth, pondLenght, pondWidth, temperature)
        {
        }

        public double area()
        {
            return (LandLenght * LandWidth) + (PondLenght * PondWidth);
        }
    }

    public class PenguinArea : BirdEnclosure, Area
    {
        public PenguinArea(bool wire, bool wall, double landLenght, double landWidth, double pondLenght, double pondWidth, double temperature = 0) : base(wire, wall, landLenght, landWidth, pondLenght, pondWidth, temperature)
        {
        }

        public double area()
        {
            return (LandLenght * LandWidth) + (PondLenght * PondWidth);
        }
    }

    public class KiwiArea : BirdEnclosure, Area
    {
        public KiwiArea(bool wire, bool wall, double landLenght, double landWidth, double pondLenght, double pondWidth, double temperature = 0) : base(wire, wall, landLenght, landWidth, pondLenght, pondWidth, temperature)
        {
        }

        public double area()
        {
            return (LandLenght * LandWidth) + (PondLenght * PondWidth);
        }
    }
}
