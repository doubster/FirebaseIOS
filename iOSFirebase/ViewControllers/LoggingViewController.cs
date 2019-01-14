using System;
using Foundation;
using UIKit;

namespace iOSFirebase
{
    public partial class LoggingViewController : UIViewController
    {
        public LoggingViewController(IntPtr handle) : base(handle)
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

        partial void LogInfoCommand(UIButton sender)
        {

            var keys = new[] { new NSString("username"), new NSString("email") };
            var values = new NSObject[] { new NSString(UserNameTextField.Text), new NSString(EmailUITextField.Text) };

            var dict = new NSDictionary<NSString, NSObject>(keys, values);

            Firebase.Analytics.Analytics.LogEvent(new NSString("Logging"), dict);

            ToastIOS.Toast.MakeText("Logging Sent").Show();
        }
    }
}

