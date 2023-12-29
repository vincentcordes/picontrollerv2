using System;
using PiControllerLib.PinControl;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Services.PinControl
{
    public class PinControlService
    {
        public PinManager Manager {get;}

        public PinControlService()
        {
            Manager = new PinManager();
        }

        public async Task<List<Pin>> GetPins()
        {
            return await Task.FromResult(Manager.Pins);// Select(pin => pin)).ToList();
        }
        public async Task<Pin> GetPin(int pinNumber)
        {
            return await Task.FromResult(Manager.Pins.FirstOrDefault(pin => pin.PinNumber == pinNumber));
        }
    }
}
