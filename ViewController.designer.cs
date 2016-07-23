// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TipCalculator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelNumberOfPeople { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelTipPercentage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelTipTotalValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelTotalBillValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelTotalPerPersonValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider sliderTipPercentage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper stepperNumberOfPeople { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldBillTotal { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (labelNumberOfPeople != null) {
                labelNumberOfPeople.Dispose ();
                labelNumberOfPeople = null;
            }

            if (labelTipPercentage != null) {
                labelTipPercentage.Dispose ();
                labelTipPercentage = null;
            }

            if (labelTipTotalValue != null) {
                labelTipTotalValue.Dispose ();
                labelTipTotalValue = null;
            }

            if (labelTotalBillValue != null) {
                labelTotalBillValue.Dispose ();
                labelTotalBillValue = null;
            }

            if (labelTotalPerPersonValue != null) {
                labelTotalPerPersonValue.Dispose ();
                labelTotalPerPersonValue = null;
            }

            if (sliderTipPercentage != null) {
                sliderTipPercentage.Dispose ();
                sliderTipPercentage = null;
            }

            if (stepperNumberOfPeople != null) {
                stepperNumberOfPeople.Dispose ();
                stepperNumberOfPeople = null;
            }

            if (textFieldBillTotal != null) {
                textFieldBillTotal.Dispose ();
                textFieldBillTotal = null;
            }
        }
    }
}