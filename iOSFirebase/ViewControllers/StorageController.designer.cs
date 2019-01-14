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

namespace iOSFirebase.ViewControllers
{
    [Register ("StorageController")]
    partial class StorageController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton FileChooseButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField imageTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel titleLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton UploadImageButton { get; set; }

        [Action ("FileChooseButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void FileChooseButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("UploadImageButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UploadImageButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (FileChooseButton != null) {
                FileChooseButton.Dispose ();
                FileChooseButton = null;
            }

            if (imageTitle != null) {
                imageTitle.Dispose ();
                imageTitle = null;
            }

            if (imageView != null) {
                imageView.Dispose ();
                imageView = null;
            }

            if (titleLabel != null) {
                titleLabel.Dispose ();
                titleLabel = null;
            }

            if (UploadImageButton != null) {
                UploadImageButton.Dispose ();
                UploadImageButton = null;
            }
        }
    }
}