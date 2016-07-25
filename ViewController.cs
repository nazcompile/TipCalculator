using System;

using UIKit;

namespace TipCalculator {
	public partial class ViewController : UIViewController {

		double billAmount;
		int numberOfPeople;
		float tipPercentage;

		protected ViewController(IntPtr handle) : base(handle) {
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad() {
			base.ViewDidLoad();
			this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("background.png"));

			Double.TryParse(this.textFieldBillTotal.Text, out billAmount);
			updateTipPerentageValue(sliderTipPercentage);
			updateNumberOfPeopleValue(stepperNumberOfPeople);

			var doneBarButton = new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate {
				this.textFieldBillTotal.ResignFirstResponder();
				Double.TryParse(this.textFieldBillTotal.Text, out billAmount);
				updateResultLabels();
			});

			var keyboardToolbar = new UIToolbar();
			keyboardToolbar.SizeToFit();
			keyboardToolbar.Items = new UIBarButtonItem[] { doneBarButton };

			this.textFieldBillTotal.BackgroundColor = UIColor.Clear;
			this.textFieldBillTotal.InputAccessoryView = keyboardToolbar;
		}

		partial void updateNumberOfPeopleValue(UIStepper sender) {
			labelNumberOfPeople.Text = sender.Value.ToString();
			numberOfPeople = (int)sender.Value;
			updateResultLabels();
		}

		partial void updateTipPerentageValue(UISlider sender) {
			tipPercentage = sender.Value;
			labelTipPercentage.Text = ((int) tipPercentage).ToString() + "%";
			updateResultLabels();
		}

		public void updateResultLabels() {
			double totalTip = Math.Round((tipPercentage / 100) * billAmount, 2);
			labelTipTotalValue.Text = totalTip.ToString();

			double totalBillAmount = totalTip + billAmount;
			labelTotalBillValue.Text = totalBillAmount.ToString();

			double billPerPerson = Math.Round(totalBillAmount / numberOfPeople, 2);
			labelTotalPerPersonValue.Text = billPerPerson.ToString();
		}

		public override void DidReceiveMemoryWarning() {
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}



	}
}

