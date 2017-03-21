# MvvMFirstApp
MvvMCross——Xamarin
firstApp
1. mvvmcross应用的一般结构：
2. 一个共享的“核心”便携式类库（PCL）项目
3. 包含尽可能多的代码：模型、视图模型、服务、转换器等
4. 每个平台一个UI项目
5. 每个包含该平台的引导和视图特定代码

1. 接口ICalculation用来抽象计算小费的逻辑。
2. Calculation来实现接口的方法

一：继承关系
1. ViewModel都需要继承自MvxViewModel
2. App:MvxApplication
3. TipView : MvxViewController
4. Setup : MvxIosSetup
5. AppDelegate : MvxApplicationDelegate


* 他通常会待在在PCL项目的根目录下。
* 他继承自MvxApplication。
* 一般来说他的名字就叫App。
* 他的主要功能是：
    * 为IoC容器注册接口以及相应的实现。
    * 设置App启动后第一个界面对应的的ViewModel。
    * 为整个App提供ViewModel的定位器（Locator）。
    * 定位器作用是通过ViewModel的Type以及以下参数来生成对应的ViewModel。通常情况下我们用默认的就行了。

