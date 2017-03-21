using System;

using UIKit;
using firstApp.ViewModel;
using MvvmCross.iOS.Views;
using System.Drawing;
using MvvmCross.Binding.BindingContext;

namespace firstApp.iOS.Views

{
	public partial class TipView : MvxViewController
	{
		public TipView(IntPtr handle) : base(handle)
		{
		}

		//public TipView(string viewName) : base(viewName, null)
		//{
		//	// this is a constructor
		//}

		public TipViewModel TipViewModel
		{
			get
			{
				return ViewModel as TipViewModel;
			}
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			setNavigationItem();
			addGesture();
			this.CreateBinding(titleLabel).To((TipViewModel vm) => vm.Tip).Apply();
			this.CreateBinding(textFieldOne).To((TipViewModel vm) => vm.SubTotal).Apply();
			this.CreateBinding(generisitySliderBar).To((TipViewModel vm) => vm.Generosity).Apply();
		}

		/// <summary>
		/// NavigatonItem--setting
		/// </summary>
		public void setNavigationItem()
		{
			var image = UIImage.FromBundle("btn_menu_schedule.png");
			var backButton = UIButton.FromType(UIButtonType.Custom);
			backButton.SetBackgroundImage(image, UIControlState.Normal);
			backButton.Frame = new RectangleF(0, 0, 40, 40);
			backButton.TouchUpInside += (sender, args) =>
			{
				Console.WriteLine("11111");
			};

			NavigationItem.LeftBarButtonItem = new UIBarButtonItem(backButton);
		}

		public void addGesture()
		{
			this.View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
			{
				View.ResignFirstResponder();
			}));
		}


	}
}

