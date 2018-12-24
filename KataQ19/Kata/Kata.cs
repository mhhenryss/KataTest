using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Step
    {
        private string orientation = "";
        private int times = 0;

        public Step(string _orientation, int _times)
        {
            orientation = _orientation;
            times = _times;
        }

        public string Orientation
        {
            get { return orientation; }
        }

        public int Times
        {
            get { return times; }
            set { times = value; }
        }
    }

    public class Kata
    {
        List<Step> Steps = new List<Step>();

        int stairNow = -1;
        int stairLast = -1;
        int firstFloor = -1;
        public string[] escape(int[,] carpark)
        {
            // Code here
            if (carpark.GetLength(0) == 0)
                return new string[] { "" };

            GetStart(carpark);
            stairNow = stairLast;

            for (int floor = firstFloor; floor < carpark.GetLength(0) - 1; floor++)
            {
                stairNow = GetStair(carpark, floor);
                MoveToStair(stairNow, stairLast);
                MoveDown();
                stairLast = stairNow;
            }
            MoveToEnd(carpark, stairNow);

            return ConverToResult();
        }
        
        private string[] ConverToResult()
        {
            string[] result = new string[Steps.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Steps[i].Orientation + Steps[i].Times;
            }
            return result;
        }

        private void GetStart(int[,] carpark)
        {
            for(int i = carpark.GetLength(0) - 1; i >= 0; i--)
                for(int j = 0; j < carpark.GetLength(1); j++)
                    if(carpark[i, j] == 2)
                    {
                        firstFloor = i;
                        stairLast = j;
                        i = -1;
                        break;
                    }                       
        }

        private int GetStair(int[,] carpark, int floor)
        {
            for (int i = 0; i < carpark.GetLength(1); i++)
                if (carpark[floor, i] == 1)
                    return i;
            return -1;
        }


        private void MoveToStair(int stairNow, int stairLast)
        {
            if (stairLast > stairNow)
                Steps.Add(new Step("L", (stairLast - stairNow)));
            else if (stairLast < stairNow)
                Steps.Add(new Step("R", (stairNow - stairLast)));
        }

        private void MoveDown()
        {
            if (Steps[Steps.Count - 1].Orientation == "D")
                Steps[Steps.Count - 1].Times += 1;
            else
                Steps.Add(new Step("D", 1));
        }

        private void MoveToEnd(int[,] carpark, int stairNow)
        {
            if (carpark.GetLength(1) - 1 > stairNow)
                Steps.Add(new Step("R", (carpark.GetLength(1) - stairNow - 1)));
        }
    }
}
