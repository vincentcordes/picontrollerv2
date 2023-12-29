using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Threading;
using Unosquare.RaspberryIO.Camera;

namespace PiControllerLib.CamControl
{
    public class CamManager
    {

        private CameraController CamController = new CameraController();
        public byte[] ImageAsBytes {get; private set;}  
        public CameraStillSettings StillSettings {get;set;} = new CameraStillSettings();
/*         public decimal ROIX {get;set;}
        public decimal ROIY {get;set;}
        public decimal ROIW {get;set;}
        public decimal ROIH {get;set;} */
        public long CaptureTime {get; private set;}
        public string ImageString = "";

        public CamManager()
        {
/*             ROIX = StillSettings.CaptureSensorRoi.X;
            ROIY = StillSettings.CaptureSensorRoi.Y;
            ROIW = StillSettings.CaptureSensorRoi.W;
            ROIH = StillSettings.CaptureSensorRoi.H; */
        }

        public async Task TakeImage()
        {
            try
            {
                if(!CamController.IsBusy)
                {
                    var sw = new Stopwatch();
                    /* StillSettings.CaptureSensorRoi = new CameraRect(){X = ROIX, Y=ROIY, W=ROIW, H=ROIH}; */
                    sw.Start();
                    ImageAsBytes = await CamController.CaptureImageAsync(StillSettings);
                    if(ImageAsBytes != null)
                    {
                        string imgString = Convert.ToBase64String(ImageAsBytes);
                        ImageString = String.Format("data:image/Bmp;base64,{0}", imgString);
                    }
                    sw.Stop();
                    CaptureTime = sw.ElapsedMilliseconds;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SaveImage()
        {
            try
            {
                using(Image img = Image.FromStream(new MemoryStream(ImageAsBytes)))
                {
                    var imageName = "temp";
                    img.Save($"wwwroot/images/{imageName}.png", ImageFormat.Png);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SetDefaults()
        {
            StillSettings = new CameraStillSettings();
        }
    }

}