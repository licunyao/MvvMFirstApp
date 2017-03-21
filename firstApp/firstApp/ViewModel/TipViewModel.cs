using firstApp.Services;
using MvvmCross.Core.ViewModels;

namespace firstApp.ViewModel
{
	public class TipViewModel : MvxViewModel
	{
		/// <summary>
		/// ViewModel:继承与MvxViewModel
		/// 这个ViewModel中有3个被扩展过的属性SubTotal、Generosity、Tip。
		///	当他们被修改的时候会调用RaisePropertyChanged函数来通知其他的对象他们的属性被修改过了。
		///	且当SubTotal和Generosity被修改时会重新计算小费。
		/// </summary>
		private readonly ICalculation _calculation;
		private double _subTotal;
		private int _generosity;
		private double _tip;



		public TipViewModel(ICalculation calculation)
		{
			_calculation = calculation;
		}

		/// <summary>
		/// 重写Start方法，赋初始值；
		/// </summary>
		public override void Start()
		{
			_subTotal = 100;
			_generosity = 10;
			Recalculate();
			base.Start();
		}
		public double SubTotal
		{
			get { return _subTotal; }
			set
			{
				_subTotal = value;
				RaisePropertyChanged(() => SubTotal);
				Recalculate();
			}
		}

		public int Generosity
		{
			get { return _generosity; }
			set
			{
				_generosity = value;
				RaisePropertyChanged(() => Generosity);
				Recalculate();
			}
		}

		public double Tip
		{
			get { return _tip; }
			private set
			{
				_tip = value;
				RaisePropertyChanged(() => Tip);
			}
		}

		private void Recalculate()
		{
			Tip = _calculation.TipAmount(SubTotal, Generosity);
		}
	}
}
