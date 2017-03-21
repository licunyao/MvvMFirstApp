using System;
using firstApp.iOS.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;

namespace firstApp.iOS
{
	public class Setup : MvxIosSetup
	{
		public Setup(MvxApplicationDelegate appDelegate, IMvxIosViewPresenter presenter)
			: base(appDelegate, presenter)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new App();
		}

		protected override MvvmCross.iOS.Views.IMvxIosViewsContainer CreateIosViewsContainer()
		{
			return new StoryboardViewsContainer("Main");
		}
	}
}
