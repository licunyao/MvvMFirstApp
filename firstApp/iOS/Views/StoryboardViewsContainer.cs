using System;
using MvvmCross.iOS.Views;
using MvvmCross.Platform.Exceptions;
using UIKit;

namespace firstApp.iOS.Views
{
	public class StoryboardViewsContainer : MvxIosViewsContainer
	{
		const string ViewModelSuffix = "ViewModel";
		const string ControllerSuffix = "View";
		UIStoryboard _storyboard;

		public StoryboardViewsContainer(string storyboardName)
		{
			_storyboard = UIStoryboard.FromName(storyboardName, null);
		}

		public override IMvxIosView CreateView(MvvmCross.Core.ViewModels.MvxViewModelRequest request)
		{
			var view = CreateViewFromViewModelType(request.ViewModelType);
			if (view == null)
			{
				var viewType = GetViewType(request.ViewModelType);
				if (viewType == null)
					throw new MvxException("View Type not found for " + request.ViewModelType);

				view = CreateViewOfType(viewType, request);
			}
			view.Request = request;
			return view;
		}

		protected override IMvxIosView CreateViewOfType(Type viewType, MvvmCross.Core.ViewModels.MvxViewModelRequest request)
		{
			return CreateView(viewType.Name);
		}


		IMvxIosView CreateViewFromViewModelType(Type viewModelType)
		{
			var name = viewModelType.Name;
			if (name.EndsWith(ViewModelSuffix))
			{
				name = name.Substring(0, name.Length - ViewModelSuffix.Length) + ControllerSuffix;
			}
			return CreateView(name);
		}


		IMvxIosView CreateView(string viewName)
		{
			return (IMvxIosView)_storyboard.InstantiateViewController(viewName);
		}
	}
}
