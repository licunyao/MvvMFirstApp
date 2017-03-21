using System;
using firstApp.Services;
using firstApp.ViewModel;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace firstApp
{
	public class App : MvxApplication
	{
		public App()
		{
			/// <summary>
			/// 通常起名：App，继承与MvxApplication类
			/// 接口和实现的登记。
			/// </summary>
			Mvx.RegisterType<ICalculation, Calculation>();
			/// <summary>
			/// 程序一开始启动的View
			/// </summary>
			Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());
		}
	}
}
