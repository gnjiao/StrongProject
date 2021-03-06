using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading; 
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading; 
using System.Windows.Forms;
namespace StrongProject
{public  class totalRest:workBase
{	/// <summary>
	///  work
	/// </summary>
 	public Work tag_Work;
	/// <summary>
	/// 线程
	/// </summary>
	public Thread tag_workThread;
	/// <summary>
	
	/// <summary>
	/// 构造函数
	/// </summary>
	/// <param name="ConstructCreate"></param>
	/// <returns></returns>
	public totalRest(Work _Work) 
 	{
 		tag_Work = _Work;
	    tag_stationName ="总复位";
	   tag_isRestStation =1;
	 }
	/// <summary>
	/// 启动函数，主要是线程启动
	/// </summary>
	/// <param name="start"></param>
	/// <returns></returns>
	public bool StartThread()
	{
		if (tag_workThread != null)
		{
			tag_workThread.Abort();
		}
		tag_workThread = new Thread(new ParameterizedThreadStart(workThread));
		tag_manual.tag_stepName = 0;
		tag_workThread.Start();
		tag_workThread.IsBackground = true;
		return true;
	}
	/// <summary>
	/// 退出函数，调用本函数，流程推出
	/// </summary>
	/// <param name="exit"></param>
	/// <returns></returns>
	public bool exit()
	{
		tag_manual.tag_stepName = 100000;
		tag_isWork = 0;
		return true;
	}
	/// <summary>
	/// 工位开始，第0步嵌入的代码，返回0 表示成功
	/// </summary>
	/// <param name="Step0"></param>
	/// <returns></returns>
	public short Step0(object o)
	{

		tag_isWork = 1;;
		return 0;
	}
	/// <summary>
	/// 检查载具上是否有物料，第1步嵌入的代码，返回0 表示成功
	/// </summary>
	/// <param name="Step1"></param>
	/// <returns></returns>
	public short Step1(object o)
	{

		return 0;
	}
	/// <summary>
	/// Z轴复位，第2步嵌入的代码，返回0 表示成功
	/// </summary>
	/// <param name="Step2"></param>
	/// <returns></returns>
	public short Step2(object o)
	{

		return 0;
	}
	/// <summary>
	/// X,Y1,Y2复位，第3步嵌入的代码，返回0 表示成功
	/// </summary>
	/// <param name="Step3"></param>
	/// <returns></returns>
	public short Step3(object o)
	{

		return 0;
	}
	/// <summary>
	/// 气缸前后复位，第4步嵌入的代码，返回0 表示成功
	/// </summary>
	/// <param name="Step4"></param>
	/// <returns></returns>
	public short Step4(object o)
	{

		return 0;
	}
	/// <summary>
	/// 等待气缸前后复位OK，第5步嵌入的代码，返回0 表示成功
	/// </summary>
	/// <param name="Step5"></param>
	/// <returns></returns>
	public short Step5(object o)
	{

		return 0;
	}
	/// <summary>
	/// 气缸上升复位，第6步嵌入的代码，返回0 表示成功
	/// </summary>
	/// <param name="Step6"></param>
	/// <returns></returns>
	public short Step6(object o)
	{

		return 0;
	}
	/// <summary>
	/// 等待气缸上升复位OK，第7步嵌入的代码，返回0 表示成功
	/// </summary>
	/// <param name="Step7"></param>
	/// <returns></returns>
	public short Step7(object o)
	{

		return 0;
	}
	/// <summary>
	/// 待作业员按启动按钮松开气缸，第8步嵌入的代码，返回0 表示成功
	/// </summary>
	/// <param name="Step8"></param>
	/// <returns></returns>
	public short Step8(object o)
	{

		return 0;
	}
	/// <summary>
	/// 气缸原点感应，第9步嵌入的代码，返回0 表示成功
	/// </summary>
	/// <param name="Step9"></param>
	/// <returns></returns>
	public short Step9(object o)
	{

		return 0;
	}
	/// <summary>
	/// 初始化函数，初始化流程嵌入的代码，返回0 表示成功
	/// </summary>
	/// <param name="init"></param>
	/// <returns></returns>
	public short Init()
	{
		PointAggregate _Step0 = pointMotion.FindPoint(tag_stationName, "工位开始",0);
		if (_Step0  == null)
		{
			return -1;
		}
		_Step0 .tag_BeginFun = Step0 ;
		PointAggregate _Step1 = pointMotion.FindPoint(tag_stationName, "检查载具上是否有物料",1);
		if (_Step1  == null)
		{
			return -1;
		}
		_Step1 .tag_BeginFun = Step1 ;
		PointAggregate _Step2 = pointMotion.FindPoint(tag_stationName, "Z轴复位",2);
		if (_Step2  == null)
		{
			return -1;
		}
		_Step2 .tag_BeginFun = Step2 ;
		PointAggregate _Step3 = pointMotion.FindPoint(tag_stationName, "X,Y1,Y2复位",3);
		if (_Step3  == null)
		{
			return -1;
		}
		_Step3 .tag_BeginFun = Step3 ;
		PointAggregate _Step4 = pointMotion.FindPoint(tag_stationName, "气缸前后复位",4);
		if (_Step4  == null)
		{
			return -1;
		}
		_Step4 .tag_BeginFun = Step4 ;
        /*PointAggregate _Step5 = pointMotion.FindPoint(tag_stationName, "等待气缸前后复位OK",5);
        if (_Step5  == null)
        {
            return -1;
        }
        _Step5 .tag_BeginFun = Step5 ;
        PointAggregate _Step6 = pointMotion.FindPoint(tag_stationName, "气缸上升复位",6);
        if (_Step6  == null)
        {
            return -1;
        }
        _Step6 .tag_BeginFun = Step6 ;
        PointAggregate _Step7 = pointMotion.FindPoint(tag_stationName, "等待气缸上升复位OK",7);
        if (_Step7  == null)
        {
            return -1;
        }
        _Step7 .tag_BeginFun = Step7 ;
    
        PointAggregate _Step8 = pointMotion.FindPoint(tag_stationName, "气缸原点感应",8);
        if (_Step8 == null)
		{
			return -1;
		}
        _Step8.tag_BeginFun = Step8;*/
		return 0;
	}
	/// <summary>
	/// 中断函数
	/// </summary>
	/// <param name="Suspend"></param>
	/// <returns></returns>
	public short Suspend(object o)
	{

		return 0;
	}
	/// <summary>
	/// 继续函数
	/// </summary>
	/// <param name="Continue"></param>
	/// <returns></returns>
	public short Continue(object o)
	{

		return 0;
	}
	/// <summary>
	/// 流程执行的函数 返回0 表示成功
	/// </summary>
	/// <param name="work"></param>
	/// <returns></returns>
	public short Start(object o)
	{
		short ret = 0;
		if (Init() == 0)
		{
		if (tag_manual.tag_step == 0)
		{
		ret = pointMotion.StationRun(tag_stationName, tag_manual);
 		tag_manual.tag_stepName = 0;
		}
		tag_isWork = -1;
		return ret;
		}
		else
		{
		return -1;
		}
		return  0;
	}
	/// <summary>
	/// 流程用线程执行执行的函数 无返回值
	/// </summary>
	/// <param name="workThreadCreate"></param>
	/// <returns></returns>
	public void workThread(object o)
	{	
		short ret = 0;
		if (Init() == 0)
		{
			if (tag_manual.tag_step == 0)
			{
				tag_isWork = pointMotion.StationRun(tag_stationName, tag_manual);
		tag_manual.tag_stepName = 0;
			}
		}
	}
}
}
