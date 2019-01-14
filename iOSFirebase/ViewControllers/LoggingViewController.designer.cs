// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOSFirebase
{
    [Register ("LoggingViewController")]
    partial class LoggingViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField EmailUITextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LogButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField UserNameTextField { get; set; }

        [Action ("LogInfoCommand:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LogInfoCommand (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (EmailUITextField != null) {
                EmailUITextField.Dispose ();
                EmailUITextField = null;
            }

            if (LogButton != null) {
                LogButton.Dispose ();
                LogButton = null;
            }

            if (UserNameTextField != null) {
                UserNameTextField.Dispose ();
                UserNameTextField = null;
            }
        }
    }
}