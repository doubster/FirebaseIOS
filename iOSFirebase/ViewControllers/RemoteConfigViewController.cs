using System;
using Firebase.RemoteConfig;
using Foundation;
using UIKit;

namespace iOSFirebase.ViewControllers
{
    public partial class RemoteConfigViewController : UIViewController
    {
        RemoteConfig remoteConfig;
        NSDictionary defaultValues;

        public RemoteConfigViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            object[] values = { "Defaulf", 20 };
            object[] keys = { "remote_text", "from_zero_to" };
            defaultValues = NSDictionary.FromObjectsAndKeys(values, keys, keys.Length);


            remoteConfig = RemoteConfig.SharedInstance;

            remoteConfig.ConfigSettings = new RemoteConfigSettings(true);

            remoteConfig.SetDefaults("remoteConfigParameters.plist");

            remoteConfig.Fetch(10, HandleRemoteConfigFetchCompletionHandler);
        }

        void HandleRemoteConfigFetchCompletionHandler(RemoteConfigFetchStatus status, NSError error)
        {
            if (status == RemoteConfigFetchStatus.Success)
            {
                ToastIOS.Toast.MakeText("Success");

                remoteConfigText.Text = remoteConfig["remote_text"].StringValue;

                var activate_fetched = RemoteConfig.SharedInstance.ActivateFetched();

                if (remoteConfig.ActivateFetched())
                {
                    remoteConfigText.Text = remoteConfig["remote_text"].StringValue;
                }
            }
            else
            {
                ToastIOS.Toast.MakeText("Error " + error.Description);
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.


        }
    }
}

