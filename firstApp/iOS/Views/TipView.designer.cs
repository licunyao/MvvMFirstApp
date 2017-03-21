// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace firstApp.iOS.Views
{
	[Register ("TipView")]
	partial class TipView
	{
		[Outlet]
		UIKit.UISlider generisitySliderBar { get; set; }

		[Outlet]
		UIKit.UITextField textFieldOne { get; set; }

		[Outlet]
		UIKit.UILabel titleLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (textFieldOne != null) {
				textFieldOne.Dispose ();
				textFieldOne = null;
			}

			if (titleLabel != null) {
				titleLabel.Dispose ();
				titleLabel = null;
			}

			if (generisitySliderBar != null) {
				generisitySliderBar.Dispose ();
				generisitySliderBar = null;
			}
		}
	}
}
