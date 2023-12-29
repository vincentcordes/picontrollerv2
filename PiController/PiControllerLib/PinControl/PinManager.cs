using System;
using System.Collections.Generic;
using Unosquare.WiringPi;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Abstractions;

namespace PiControllerLib.PinControl
{
    public class PinManager
    {
        public List<Pin> Pins {get;private set;} = new List<Pin>();
        
        public PinManager()
        {
			Pi.Init<BootstrapWiringPi>();
            BuildPins();
        }

        ~PinManager()
        {
        }
 
        private void BuildPins()
        {
            for(int i = 1; i < 41; i++)
            {
                switch(i)
                {
                    case 1:
                        Pins.Add(new Pin(i, -1, ePinType.Power));
                        break;
                    case 2:
                        Pins.Add(new Pin(i, -1, ePinType.Power));
                        break;
                    case 3:
                        Pins.Add(new Pin(i, 2, ePinType.GPIO));
                        break;
                    case 4:
                        Pins.Add(new Pin(i, -1, ePinType.Power));
                        break;
                    case 5:
                        Pins.Add(new Pin(i, 3, ePinType.GPIO));
                        break;
                    case 6:
                        Pins.Add(new Pin(i, -1, ePinType.Ground));
                        break;
                    case 7:
                        Pins.Add(new Pin(i, 4, ePinType.GPIO));
                        break;
                    case 8:
                        Pins.Add(new Pin(i, 14, ePinType.GPIO));
                        break;
                    case 9:
                        Pins.Add(new Pin(i, -1, ePinType.Ground));
                        break;
                    case 10:
                        Pins.Add(new Pin(i, 15, ePinType.GPIO));
                        break;
                    case 11:
                        Pins.Add(new Pin(i, 17, ePinType.GPIO));
                        break;
                    case 12:
                        Pins.Add(new Pin(i, 18, ePinType.GPIO));
                        break;
                    case 13:
                        Pins.Add(new Pin(i, 27, ePinType.GPIO));
                        break;
                    case 14:
                        Pins.Add(new Pin(i, -1, ePinType.Ground));
                        break;
                    case 15:
                        Pins.Add(new Pin(i, 22, ePinType.GPIO));
                        break;
                    case 16:
                        Pins.Add(new Pin(i, 23, ePinType.GPIO));
                        break;
                    case 17:
                        Pins.Add(new Pin(i, -1, ePinType.Power));
                        break;
                    case 18:
                        Pins.Add(new Pin(i, 24, ePinType.GPIO));
                        break;
                    case 19:
                        Pins.Add(new Pin(i, 10, ePinType.GPIO));
                        break;
                    case 20:
                        Pins.Add(new Pin(i, -1, ePinType.Ground));
                        break;
                    case 21:
                        Pins.Add(new Pin(i, 9, ePinType.GPIO));
                        break;                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
                    case 22:
                        Pins.Add(new Pin(i, 25, ePinType.GPIO));
                        break;
                    case 23:
                        Pins.Add(new Pin(i, 11, ePinType.GPIO));
                        break;
                    case 24:
                        Pins.Add(new Pin(i, 8, ePinType.GPIO));
                        break;
                    case 25:
                        Pins.Add(new Pin(i, -1, ePinType.Ground));
                        break;
                    case 26:
                        Pins.Add(new Pin(i, 7, ePinType.GPIO));
                        break;
                    case 27:
                        Pins.Add(new Pin(i, 0, ePinType.GPIO));
                        break;
                    case 28:
                        Pins.Add(new Pin(i, 1, ePinType.GPIO));
                        break;
                    case 29:
                        Pins.Add(new Pin(i, 5, ePinType.GPIO));
                        break;
                    case 30:
                        Pins.Add(new Pin(i, -1, ePinType.Ground));
                        break;
                    case 31:
                        Pins.Add(new Pin(i, 6, ePinType.GPIO));
                        break;
                    case 32:
                        Pins.Add(new Pin(i, 12, ePinType.GPIO));
                        break;
                    case 33:
                        Pins.Add(new Pin(i, 13, ePinType.GPIO));
                        break;
                    case 34:
                        Pins.Add(new Pin(i, -1, ePinType.Ground));
                        break;
                    case 35:
                        Pins.Add(new Pin(i, 19, ePinType.GPIO));
                        break;
                    case 36:
                        Pins.Add(new Pin(i, 16, ePinType.GPIO));
                        break;
                    case 37:
                        Pins.Add(new Pin(i, 26, ePinType.GPIO));
                        break;
                    case 38:
                        Pins.Add(new Pin(i, 20, ePinType.GPIO));
                        break;
                    case 39:
                        Pins.Add(new Pin(i, -1, ePinType.Ground));
                        break;
                    case 40:
                        Pins.Add(new Pin(i, 21, ePinType.GPIO));
                        break;                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
                    default:
                        break;
                }
            }
        }
    }
}
