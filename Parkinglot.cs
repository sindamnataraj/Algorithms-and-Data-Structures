using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepPhase3
{
    public abstract class Vehicle {

    }

    public class Car : Vehicle {
       //car - normal
    }

    public class Motorcycle : Vehicle {
        //motor - small
    }

    public class Bus : Vehicle {
        //bus -- compact
    }

    public class Parkinglot
    {
        private static int NORMAL_SPOTS_COUNT = 10;
        private static int COMPACT_SPOTS_COUNT = 10;
        private static int SMALL_SPOTS_COUNT = 10;
        
        public class ParkingSpot {
            public bool IsOccupied;
            public int SpotNumber;
            public ParkingSpot(int Number)
            {
                IsOccupied = false;
                SpotNumber = Number;
            }

            public void Park()
            {
                IsOccupied = true;
            }

            public void UnPark()
            {
                IsOccupied = false;
            }
        }

        public class NormalSpot : ParkingSpot {

            public NormalSpot(int Number): base(Number)
            {

            }
        }
        public class CompactSpot : ParkingSpot {
            public CompactSpot(int Number):base(Number)
            {

            }
        }
        public class smallSpot : ParkingSpot {
            public smallSpot(int Number):base(Number)
            {
            }
        }
        
        private List<NormalSpot> nSpots;
        private List<CompactSpot> cSpots;
        private List<smallSpot> sSpots;

        public Parkinglot()
        {
                
        }

        private void CreateSlots()
        {
            nSpots = new List<NormalSpot>(NORMAL_SPOTS_COUNT);
            for (int i = 0; i < nSpots.Count; i++)
            {
                //nSpots[i] = new NormalSpot();
                nSpots.Add(new NormalSpot(i + 1));
            }

            cSpots = new List<CompactSpot>(COMPACT_SPOTS_COUNT);
            
            for (int i = 0; i < cSpots.Count; i++)
            {
                cSpots.Add(new CompactSpot(i + 1));
            }

            sSpots = new List<smallSpot>(SMALL_SPOTS_COUNT);

            for (int i = 0; i < sSpots.Count; i++)
            {
                sSpots.Add(new smallSpot(i + 1));
            }

        }


    }
}
