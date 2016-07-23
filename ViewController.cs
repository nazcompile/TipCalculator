using System;

using UIKit;

namespace TipCalculator {
	public partial class ViewController : UIViewController {
		protected ViewController(IntPtr handle) : base(handle) {
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad() {
			base.ViewDidLoad();
			this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("background.png"));
			this.textFieldBillTotal.BackgroundColor = UIColor.Clear;

			var doneBarButton = new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate {
				this.textFieldBillTotal.ResignFirstResponder();
			});

			var keyboardToolbar = new UIToolbar();
			keyboardToolbar.SizeToFit();
			keyboardToolbar.Items = new UIBarButtonItem[] { doneBarButton };

			this.textFieldBillTotal.InputAccessoryView = keyboardToolbar;

		}

		private void removeTextFieldKeyboard(UITextField textField) {
			textField.ResignFirstResponder();
		}

		public override void DidReceiveMemoryWarning() {
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}



	}
}

