using System;
using PiControllerLib.CamControl;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Services.CamControl
{
    public class CamControlService
    {
        public CamManager CameraManager = new CamManager();

        public CamControlService()
        {

        }
    }
}