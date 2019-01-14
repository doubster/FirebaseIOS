using System;
using Firebase.CrashReporting;
using UIKit;

namespace iOSFirebase.ViewControllers
{
    public partial class CrashViewController : UIViewController
    {
        public CrashViewController(IntPtr handle) : base(handle)
        {
        }



        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.


        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


        partial void CrashApp(UIButton sender)
        {
            Random rnd = new Random();
            int errorNumber = rnd.Next(0, 5);
            try
            {
                switch (errorNumber)
                {
                    case 0:
                        throw new NotImplementedException(DateTime.Now.ToString());
                    case 1:
                        throw new NullReferenceException(DateTime.Now.ToString());
                    case 2:
                        throw new OutOfMemoryException(DateTime.Now.ToString());
                    case 3:
                        throw new NotFiniteNumberException(DateTime.Now.ToString());
                    case 4:
                        throw new TimeoutException(DateTime.Now.ToString());
                    case 5:
                        throw new OverflowException(DateTime.Now.ToString());
                }
            }
            catch (Exception ex)
            {
                Firebase.CrashReporting.CrashReporting.Log(ex.Message);
                ToastIOS.Toast.MakeText("Crash Report Sent" + ex.GetType().ToString()).Show();
            }
        }
    }
}

