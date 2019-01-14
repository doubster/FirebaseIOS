using System;

using UIKit;

namespace iOSFirebase.ViewControllers
{
    public partial class AuthenticationViewController : UIViewController
    {

        Firebase.Auth.Auth auth;


        public AuthenticationViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            auth = Firebase.Auth.Auth.DefaultInstance;

            Firebase.Auth.User user = auth.CurrentUser;

            if (user != null)
            {
                AuthenticationLoggedInUserDescription.Text = user.Email + " is currently logged in";
            }
            UpdateView(user);
        }

        void UpdateView(Firebase.Auth.User user)
        {

            bool isUserNull = user == null;

            LogoutButton.Hidden = isUserNull;
            AuthenticationLoggedInUserDescription.Text = isUserNull ? "Register here or Login with Email and Password" : user.Email + " is currently logged in";
            LoginButton.Hidden = !isUserNull;
            authenticationEmail.Hidden = !isUserNull;
            AuthenticationPassword.Hidden = !isUserNull;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void LoginButton_TouchUpInside(UIButton sender)
        {
            string email = authenticationEmail.Text;
            string password = AuthenticationPassword.Text;

            auth.SignIn(email, password, HandleLoginHandler);
        }

        partial void RegisterButton_TouchUpInside(UIButton sender)
        {

            string email = authenticationEmail.Text;
            string password = AuthenticationPassword.Text;

            auth.CreateUser(email, password, HandleRegisterResultHandler);
        }

        void HandleRegisterResultHandler(Firebase.Auth.User user, Foundation.NSError error)
        {
            if (user != null)
            {
                ToastIOS.Toast.MakeText("Registration Successful").Show();
            }
            else
            {
                ToastIOS.Toast.MakeText("Registration Failed").Show();
            }
        }

        void HandleLoginHandler(Firebase.Auth.User user, Foundation.NSError error)
        {
            if (user != null)
            {
                ToastIOS.Toast.MakeText("Login Successful").Show();
            }
            else
            {
                ToastIOS.Toast.MakeText("Login Failed").Show();
            }
            UpdateView(user);
        }

        partial void LogoutButton_TouchUpInside(UIButton sender)
        {
            Foundation.NSError error;
            auth.SignOut(out error);

            if (error != null)
            {
                ToastIOS.Toast.MakeText(error.Description).Show();
            }
            UpdateView(null);
        }
    }
}

