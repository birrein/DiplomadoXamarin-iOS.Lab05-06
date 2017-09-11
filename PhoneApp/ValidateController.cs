// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace PhoneApp
{
	public partial class ValidateController : UIViewController
	{
		public ValidateController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

			ValidateButton.TouchUpInside += async (object sender, EventArgs e) =>
            {
                var Client = new SALLab06.ServiceClient();
                string email = EmailTextField.Text;
                string password = PasswordTextField.Text;

                var Result = await Client.ValidateAsync(email, password, this);
                var Alert = UIAlertController.Create("Resultado",
                                                     $"{Result.Status}\n{Result.FullName}\n{Result.Token}",
                                                    UIAlertControllerStyle.Alert);
                Alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
                PresentViewController(Alert, true, null);
            };
        }
	}
}
