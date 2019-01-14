using System;
using Firebase.Storage;
using Foundation;
using UIKit;

namespace iOSFirebase.ViewControllers
{
    public partial class StorageController : UIViewController
    {

        StorageReference storageReference;
        UIImagePickerController imagePicker;

        Firebase.Storage.Storage firebaseStorage;
        NSUrl imagePath;

        public StorageController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            firebaseStorage = Firebase.Storage.Storage.DefaultInstance;
            firebaseStorage.Init();

            storageReference = firebaseStorage.GetReferenceFromUrl("gs://kitchensinkios-77b5f.appspot.com/");



            imagePicker = new UIImagePickerController();

            imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
            imagePicker.MediaTypes = UIImagePickerController.AvailableMediaTypes(UIImagePickerControllerSourceType.PhotoLibrary);

            imagePicker.FinishedPickingMedia += Handle_FinishedPickingMedia;
            imagePicker.Canceled += Handle_Canceled;


            var auth = Firebase.Auth.Auth.DefaultInstance;

            Firebase.Auth.User user = auth.CurrentUser;

            var a = user.Email;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UploadImageButton_TouchUpInside(UIButton sender)
        {
            try
            {
                Random rnd = new Random();
                string imageName = string.IsNullOrWhiteSpace(imageTitle.Text) ? "Test" + rnd.Next(1000) : imageTitle.Text;
                StorageReference imagesRef = storageReference.GetChild("images/" + imageName + ".jpg");
                imagesRef.PutFile(imagePath, null, HandleStorageGetPutUpdateCompletionHandler);
            }
            catch (Exception ex)
            {
                ToastIOS.Toast.MakeText("Error " + ex.Message);
            }
        }

        void HandleStorageGetPutUpdateCompletionHandler(StorageMetadata metadata, NSError error)
        {
            if (error == null)
            {
                ToastIOS.Toast.MakeText("Upload Successful").Show();
                imageView.Image = null;
                imageTitle.Text = string.Empty;
            }
            else
            {
                ToastIOS.Toast.MakeText("Upload Failed").Show();
                Console.WriteLine("Error " + error.Description);
            }
        }

        #region ImagePicker

        partial void FileChooseButton_TouchUpInside(UIButton sender)
        {
            NavigationController.PresentModalViewController(imagePicker, true);
        }

        protected void Handle_FinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs e)
        {
            // determine what was selected, video or image
            bool isImage = false;
            switch (e.Info[UIImagePickerController.MediaType].ToString())
            {
                case "public.image":
                    Console.WriteLine("Image selected");
                    isImage = true;
                    break;
                case "public.video":
                    Console.WriteLine("Video selected");
                    break;
            }

            // get common info (shared between images and video)
            NSUrl referenceURL = e.Info[new NSString("UIImagePickerControllerImageURL")] as NSUrl;
            if (referenceURL != null)
                Console.WriteLine("Url:" + referenceURL.ToString());

            imagePath = referenceURL;

            // if it was an image, get the other image info
            if (isImage)
            {
                // get the original image
                UIImage originalImage = e.Info[UIImagePickerController.OriginalImage] as UIImage;
                if (originalImage != null)
                {
                    // do something with the image
                    Console.WriteLine("got the original image");
                    imageView.Image = originalImage; // display
                }
            }
            else
            { // if it's a video
              // get video url
                NSUrl mediaURL = e.Info[UIImagePickerController.MediaURL] as NSUrl;
                if (mediaURL != null)
                {
                    Console.WriteLine(mediaURL.ToString());
                }
            }
            // dismiss the picker
            imagePicker.DismissViewController(true, () => { }); //DismissModalViewControllerAnimated(true);
        }

        void Handle_Canceled(object sender, EventArgs e)
        {
            imagePicker.DismissViewController(true, () => { });
        }

        #endregion
    }
}

