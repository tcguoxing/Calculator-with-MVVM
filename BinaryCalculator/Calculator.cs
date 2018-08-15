using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    class Calculator
    {
        double nowNumber = 0;
        double lastNumber = 0;

        public void AddNum()
        {
            nowNumber = nowNumber + lastNumber;
        }

        public void MinusNum()
        {
            nowNumber = nowNumber - lastNumber;
        }

        public double NowNumber
        {
            get { return nowNumber; }
            set { nowNumber = value; }
        }

        public double LastNumber
        {
            get { return lastNumber; }
            set { lastNumber = value; }
        }

        internal void MultiNum()
        {
            nowNumber = nowNumber * lastNumber;
        }

        internal void DivideNum()
        {
            nowNumber = lastNumber / nowNumber;
        }
    }
}