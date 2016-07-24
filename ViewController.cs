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

			updateTipPerentageValue(sliderTipPercentage);
			updateNumberOfPeopleValue(stepperNumberOfPeople);

			var doneBarButton = new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate {
				this.textFieldBillTotal.ResignFirstResponder();
			});

			var keyboardToolbar = new UIToolbar();
			keyboardToolbar.SizeToFit();
			keyboardToolbar.Items = new UIBarButtonItem[] { doneBarButton };

			this.textFieldBillTotal.BackgroundColor = UIColor.Clear;
			this.textFieldBillTotal.InputAccessoryView = keyboardToolbar;

		}

		private void removeTextFieldKeyboard(UITextField textField) {
			textField.ResignFirstResponder();
		}

		partial void updateNumberOfPeopleValue(UIStepper sender) {
			labelNumberOfPeople.Text = sender.Value.ToString();
		}

		partial void updateTipPerentageValue(UISlider sender) {
			int sliderValue = (int) sender.Value;
			labelTipPercentage.Text = sliderValue.ToString() + "%";
		}

		public override void DidReceiveMemoryWarning() {
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}



	}
}

