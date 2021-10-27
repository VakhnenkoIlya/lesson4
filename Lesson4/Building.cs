using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Building
    {
        private readonly int number;
        private int height;
        private int floorCount;
        private int apartamentCount;
        private int entranceCount;
        private int nextNumber = 1;
        void CreateNumber()
        {
            nextNumber++;
        }

        public Building()
        {
            number = nextNumber;
            CreateNumber();
        }

        public int GetNumber()
        {
            return number;
        }
        public int GetHeight()
        {
            return height;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetFloorCount()
        {
            return floorCount;
        }

        public void SetFloorCount(int floorCount)
        {
            this.floorCount = floorCount;
        }
        public int GetApartamentCount()
        {
            return apartamentCount;
        }

        public void SetApartamentCount(int apartamentCount)
        {
            this.apartamentCount = apartamentCount;
        }
        public int GetEntanceCount()
        {
            return entranceCount;
        }

        public void SetEntranceCount(int entranceCount)
        {
            this.entranceCount = entranceCount;
        }
        public double CalculationOfFloorHeight(int height, int floorCount)
        {
            double a = height;
            double b = floorCount;
           return a/b;
        }
        public int CalculationApartamentInEntrance(int apartamentCount, int entranceCount)
        {
            return apartamentCount / entranceCount;
        }
        public int CalculationApartamentInFloor(int floorCount, int apartamentInEntrance)
        {
            return apartamentInEntrance/ floorCount; 
        }
    }
}
