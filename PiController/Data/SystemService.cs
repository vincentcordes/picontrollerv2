using PiControllerLib.SystemControl;

namespace Services.SystemControl
{
    public class SystemControlService
    {
        public SystemManager SystemManager =  new SystemManager();// {get; private set;}
        public SystemControlService()
        {
            //SystemManager = new SystemManager();
        }
    }
}