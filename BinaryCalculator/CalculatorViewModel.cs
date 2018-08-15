using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private Calculator calculator = new Calculator();
        private DelegateCommand _btn1Command;
        private DelegateCommand _btn2Command;
        private DelegateCommand _btnAddCommand;
        private DelegateCommand _btnEqualCommand;
        private DelegateCommand _btnMinusCommand;
        private DelegateCommand _btnDivideCommand;
        private DelegateCommand _btnClearCommand;
        private DelegateCommand _btnMultiCommand;
        private DelegateCommand _btn3Command;
        private DelegateCommand _btn4Command;
        private DelegateCommand _btn5Command;
        private DelegateCommand _btn6Command;
        private DelegateCommand _btn7Command;
        private DelegateCommand _btn8Command;
        private DelegateCommand _btn9Command;
        private DelegateCommand _btn0Command;
        NumOperator lastOperate;

        public CalculatorViewModel()
        {
            _btn1Command = new DelegateCommand(Num1, () => { return true; });
            _btn2Command = new DelegateCommand(Num2, () => { return true; });
            _btn3Command = new DelegateCommand(Num3, () => { return true; });
            _btn4Command = new DelegateCommand(Num4, () => { return true; });
            _btn5Command = new DelegateCommand(Num5, () => { return true; });
            _btn6Command = new DelegateCommand(Num6, () => { return true; });
            _btn7Command = new DelegateCommand(Num7, () => { return true; });
            _btn8Command = new DelegateCommand(Num8, () => { return true; });
            _btn9Command = new DelegateCommand(Num9, () => { return true; });
            _btn0Command = new DelegateCommand(Num0, () => { return true; });
            _btnAddCommand = new DelegateCommand(AddNum, () => { return true; });
            _btnEqualCommand = new DelegateCommand(EqualNum, () => { return true; });
            _btnMinusCommand = new DelegateCommand(MinusNum, () => { return true; });
            _btnMultiCommand = new DelegateCommand(MultiNum, () => { return true; });
            _btnDivideCommand = new DelegateCommand(DevideNum, () => { return true; });
            _btnClearCommand = new DelegateCommand(ClearNum, () => { return true; });
        }

        public DelegateCommand btn1_Click => _btn1Command;

        public DelegateCommand btn2_Click => _btn2Command;

        public DelegateCommand btn3_Click => _btn3Command;

        public DelegateCommand btn4_Click => _btn4Command;

        public DelegateCommand btn5_Click => _btn5Command;

        public DelegateCommand btn6_Click => _btn6Command;

        public DelegateCommand btn7_Click => _btn7Command;

        public DelegateCommand btn8_Click => _btn8Command;

        public DelegateCommand btn9_Click => _btn9Command;

        public DelegateCommand btn0_Click => _btn0Command;

        public DelegateCommand btnAdd_Click => _btnAddCommand;

        public DelegateCommand btnMinus_Click => _btnMinusCommand;

        public DelegateCommand btnMulti_Click => _btnMultiCommand;

        public DelegateCommand btnDivide_Click => _btnDivideCommand;

        public DelegateCommand btnClear_Click => _btnClearCommand;

        public DelegateCommand btnEqual_Click => _btnEqualCommand;

        private void Num0()
        {
            if (NowResult.Length <= 9)
            {
                calculator.NowNumber = Convert.ToDouble(calculator.NowNumber.ToString() + 0.ToString());
            }
            RefreshScreen();
        }

        private void Num9()
        {
            if (NowResult.Length <= 9)
            {
                calculator.NowNumber = Convert.ToDouble(calculator.NowNumber.ToString() + 9.ToString());
            }
            RefreshScreen();
        }

        private void Num8()
        {
            if (NowResult.Length <= 9)
            {
                calculator.NowNumber = Convert.ToDouble(calculator.NowNumber.ToString() + 8.ToString());
            }
            RefreshScreen();
        }

        private void Num7()
        {
            if (NowResult.Length <= 9)
            {
                calculator.NowNumber = Convert.ToDouble(calculator.NowNumber.ToString() + 7.ToString());
            }
            RefreshScreen();
        }

        private void Num6()
        {
            if (NowResult.Length <= 9)
            {
                calculator.NowNumber = Convert.ToDouble(calculator.NowNumber.ToString() + 6.ToString());
            }
            RefreshScreen();
        }

        private void Num5()
        {
            if (NowResult.Length <= 9)
            {
                calculator.NowNumber = Convert.ToDouble(calculator.NowNumber.ToString() + 5.ToString());
            }
            RefreshScreen();
        }

        private void Num4()
        {
            if (NowResult.Length <= 9)
            {
                calculator.NowNumber = Convert.ToDouble(calculator.NowNumber.ToString() + 4.ToString());
            }
            RefreshScreen();
        }


        void Num1()
        {
            if (NowResult.Length <= 9)
            {
                calculator.NowNumber = Convert.ToDouble(calculator.NowNumber.ToString() + 1.ToString());
            }
            RefreshScreen();
        }

        void Num2()
        {
            if (NowResult.Length <= 9)
            {
                calculator.NowNumber = Convert.ToDouble(calculator.NowNumber.ToString() + 2.ToString());
            }
            RefreshScreen();
        }

        void Num3()
        {
            if (NowResult.Length <= 9)
            {
                calculator.NowNumber = Convert.ToDouble(calculator.NowNumber.ToString() + 3.ToString());
            }
            RefreshScreen();
        }

        void AddNum()
        {
            if (NowResult.Length <= 9)
            {
                lastOperate = NumOperator.AddNum;
                calculator.LastNumber = Convert.ToDouble(NowResult);
                calculator.NowNumber = 0;
            }
            RefreshScreen();
        }

        void MinusNum()
        {
            if (NowResult.Length <= 9)
            {
                lastOperate = NumOperator.MinusNum;
                calculator.LastNumber = Convert.ToDouble(NowResult);
            }
            RefreshScreen();
        }

        private void DevideNum()
        {
            if (NowResult.Length <= 9)
            {
                lastOperate = NumOperator.DivideNum;
                calculator.LastNumber = Convert.ToDouble(NowResult);
            }
            RefreshScreen();
        }

        private void MultiNum()
        {
            if (NowResult.Length <= 9)
            {
                lastOperate = NumOperator.MultiNum;
                calculator.LastNumber = Convert.ToDouble(NowResult);
            }
            RefreshScreen();
        }

        private void ClearNum()
        {
            calculator.NowNumber = 0D;
            calculator.LastNumber = 0D;
            RefreshScreen();
        }

        void EqualNum()
        {
            if (NowResult.Length <= 9)
            {
                calculator.NowNumber = Convert.ToDouble(NowResult);
                switch (lastOperate)
                {
                    case NumOperator.AddNum:
                        calculator.AddNum();
                        break;
                    case NumOperator.MinusNum:
                        calculator.MinusNum();
                        break;
                    case NumOperator.MultiNum:
                        calculator.MultiNum();
                        break;
                    case NumOperator.DivideNum:
                        calculator.DivideNum();
                        break;
                    default:
                        break;
                }
            }
            RefreshScreen();
        }

        private void RefreshScreen()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("NowResult"));
            }
        }

        public string NowResult
        {
            get
            {
                return (calculator.NowNumber > 10000000000 || calculator.NowNumber < -1000000000
                    ? "EEEEEEEEEEE"
                    : Math.Round(calculator.NowNumber, 3).ToString());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    enum NumOperator
    {
        AddNum,
        MinusNum,
        MultiNum,
        DivideNum
    }
}