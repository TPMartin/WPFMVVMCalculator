using Caliburn.Micro;

namespace Calculator.ViewModels
{
    public class ShellViewModel : Screen
    {
        private long _currentValue;
        private string _actionToPerform;
        private long _prevValue;

        public ShellViewModel()
        {
            PrevValue = 0;
            CurrentValue = 0;
            ActionToPerform = "";
        }
        public long CurrentValue
        {
            get
            {
                return _currentValue;
            }
            set
            {
                _currentValue = value;
                NotifyOfPropertyChange(() => CurrentValue);
            }
        }
        public long PrevValue
        {
            get
            {
                return _prevValue;
            }
            set
            {
                _prevValue = value;
                NotifyOfPropertyChange(() => PrevValue);
            }
        }
        public string ActionToPerform
        {
            get
            {
                return _actionToPerform;
            }
            set
            {
                _actionToPerform = value;
                NotifyOfPropertyChange(() => ActionToPerform);
            }
        }
        public void NumberPressed(int number)
        {
            CurrentValue = (CurrentValue * 10) + number;
        }
        public void One()
        {
            NumberPressed(1);
        }
        public void Two()
        {
            NumberPressed(2);
        }
        public void Three()
        {
            NumberPressed(3);
        }
        public void Four()
        {
            NumberPressed(4);
        }
        public void Five()
        {
            NumberPressed(5);
        }
        public void Six()
        {
            NumberPressed(6);
        }
        public void Seven()
        { 
            NumberPressed(7);
        }
        public void Eight()
        {
            NumberPressed(8);
        }
        public void Nine()
        {
            NumberPressed(9);
        }
        public void Zero()
        {
            NumberPressed(0);
        }
        public void Add()
        {
            ActionToPerform = "+";
            PrevValue = CurrentValue;
            CurrentValue = 0;
        }
        public void Subtract()
        {
            ActionToPerform = "-";
            PrevValue = CurrentValue;
            CurrentValue = 0;
        }
        public void Multiply()
        {
            ActionToPerform = "*";
            PrevValue = CurrentValue;
            CurrentValue = 0;
        }
        public void Divide()
        {
            ActionToPerform = "/";
            PrevValue = CurrentValue;
            CurrentValue = 0;
        }
        public void Calculate()
        {
            switch (ActionToPerform)
            {
                case "+":
                    CurrentValue = PrevValue + CurrentValue;
                    break;
                case "-":
                    CurrentValue = PrevValue - CurrentValue;
                    break;
                case "*":
                    CurrentValue = PrevValue * CurrentValue;
                    break;
                case "/":
                    CurrentValue = PrevValue / CurrentValue;
                    break;
                default:
                    break;
            }
            PrevValue = 0;
            ActionToPerform = "";
        }
        public void Clear()
        {
            CurrentValue = 0;
            PrevValue = 0;
            ActionToPerform = "";
        }
        public void ClearEntry()
        {
            CurrentValue = 0;
        }
        public void BackButton()
        {
            CurrentValue /= 10; 
        }
        public void PlusMinus()
        {
            CurrentValue *= -1;
        }
    }
}
