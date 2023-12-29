using System;
using System.Threading.Tasks;
using System.Threading;
using Unosquare.WiringPi;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Abstractions;

namespace PiControllerLib.PinControl
{
    public class Pin
    {
        public delegate void ChangedNotification();
        public ChangedNotification Notify;
        public ePinType PinType {get;set;}
        public int PinNumber {get;}
        public int GPIONumber {get;}
        public IGpioPin PinRef => Pi.Gpio[GPIONumber];
        public eState PinState {get; private set;} 
        
        public GpioPinDriveMode PinMode => PinRef.PinMode;
        public int TimeHigh {get;set;} = 1000;
        public int TimeLow {get;set;} = 1000;
        public bool RepeatingToggle = false;
        public string PinFunction {get;} = "";
        public string InputValue => ReadState().ToString();
        private bool CallbackSet = false;

        public Pin(int pinNumber, int gpioNumber, ePinType pinType)
        {
            PinNumber = pinNumber;
            GPIONumber = gpioNumber;             
            PinType = pinType;
            PinFunction = SetPinFunction();

            try
            {
                if(pinType == ePinType.GPIO)
                {
                    if(GPIONumber == 14)
                        ;
                    else if(GPIONumber == 15)
                        ;
                    else
                        PinRef.PinMode = GpioPinDriveMode.Output;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        //Method used in class construction
        private string SetPinFunction()
        {
            string pinFunction = $"BCM {GPIONumber}";
            if(PinType == ePinType.Ground)
                pinFunction = "Ground";
            if(PinType == ePinType.Power)
                if(PinNumber == 1 || PinNumber == 17)
                    pinFunction = "Power 3.3v";
                else
                    pinFunction = "Power 5v";
            if(GPIONumber == 14)
                pinFunction = "TxD";
            if(GPIONumber == 15)
                pinFunction = "RxD";
            return pinFunction;
        }

        //Flip the state of a pin
        public void ChangeState()
        {
            try
            {
                //Prevent the case that this method would be called for
                //a pin that isn't GPIO
                if(PinType == ePinType.GPIO && 
                           !RepeatingToggle && 
                           PinMode == GpioPinDriveMode.Output)
                {    
                    if(PinState == eState.Low)
                    {
                        PinRef.Write(true);
                        PinState = ReadState();
                        Notify?.Invoke();
                    }
                    else
                    {
                        PinRef.Write(false);
                        PinState = ReadState();
                        Notify?.Invoke();
                    }
                }    
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public async Task RepeatingToggleState()
        {
            try
            {
                //if(RepeatingToggle)
                //    RepeatingToggle = false;
                //else
                //    RepeatingToggle = true;
                RepeatingToggle = !RepeatingToggle;
                await Task.Run(() => {
                    if(PinMode == GpioPinDriveMode.Output)
                    {
                        while(RepeatingToggle)
                        {
                            if(PinState == eState.High)
                            {
                                PinRef.Write(false);
                                PinState = ReadState();
                                Notify?.Invoke();
                                System.Threading.Thread.Sleep(TimeLow);
                            }
                            else
                            {
                                PinRef.Write(true);
                                PinState = ReadState();
                                Notify?.Invoke();                                
                                System.Threading.Thread.Sleep(TimeHigh);
                            }
                        }
                    }
                });
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SetPinMode(GpioPinDriveMode mode)
        {
            if(mode == GpioPinDriveMode.Input)
            {
                PinRef.PinMode = mode;
                if(!CallbackSet)
                    PinRef.RegisterInterruptCallback(EdgeDetection.FallingAndRisingEdge, StateChangedCallBack);
            }
            else
            {
                PinRef.PinMode =  mode;
                PinRef.RemoveInterruptCallback(EdgeDetection.FallingAndRisingEdge, StateChangedCallBack);
            }
        }

        public void TogglePinMode()
        {
            try
            {  
                if(PinRef.PinMode == GpioPinDriveMode.Input)
                {
                    //PinRef.RemoveInterruptCallback(EdgeDetection.FallingAndRisingEdge, StateChangedCallBack);
                    PinRef.PinMode = GpioPinDriveMode.Output;
                }
                else
                {
                    PinRef.PinMode = GpioPinDriveMode.Input;
                    if(!CallbackSet)
                    {    
                        PinRef.RegisterInterruptCallback(EdgeDetection.FallingAndRisingEdge, StateChangedCallBack);
                        CallbackSet = true;
                    } 
                }         
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
 
        private void StateChangedCallBack()
        {
            PinState = ReadState();
            Notify?.Invoke();
        }

        private eState ReadState()
        {
            var state = eState.Low;
            if(PinRef.Read())
                state = eState.High;
            return state;
        } 

    }

    public enum ePinType
    {
        Power,
        Ground,
        GPIO,
    }

    public enum eState
    {
        Low,
        High,
    }

/*     public enum ePinMode
    {
        Input,
        Output,
        SW_PWM,
        HW_PWM,
    } */
}
