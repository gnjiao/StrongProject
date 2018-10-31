﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace StrongProject
{
    class adtIO3224
    {
        [DllImport("adtIO3224.dll")]
        public static extern Int32 adtIO3224_initial();
        /************************************************
        功能：初始化运动控制卡
        (1)返回值>0时，表示adt-IO3224卡的数量。如果为3，则下面的可用卡号可通过拨码开关设置；
        (2)返回值=0时，说明没有安装adt-IO3224卡；
        (3)返回值<0时，-1 表示没有安装端口驱动程序，
                       -2 表示PCI桥存在故障。
                       -3 表示拨码开关设置存在重复。
        ************************************************/

        [DllImport("adtIO3224.dll")]
        public static extern Int32 adtIO3224_get_lib_version(Int32 cardno);
        /************************************************
        功能：获取当前库版本号
        返回值为库版本的版本号;-1:卡号错误
        ************************************************/

        [DllImport("adtIO3224.dll")]
        public static extern float adtIO3224_get_hardware_ver(Int32 cardno);
        /**************功能：获取当前硬件版本**************
        返回值为硬件版本号;-1:卡号错误
        ************************************************/

        [DllImport("adtIO3224.dll")]
        public static extern Int32 adtIO3224_get_card_index();
        /************************************************
        功能：获取当前所有可用卡的拨码开关号，通过位数表示
        比如：只有1张卡，拨码开关设置为1，则返回值为1
	            有2张卡，按照靠近CPU的顺序,拨码开关依次设置为1,2,返回值为21;
		        有3张卡，按照靠近CPU的顺序,拨码开关设置为3,1,2,则返回值为213;
        返回值：可用卡的拨码开关号;-1:卡号错误
        ************************************************/

        //-------------------------------------------------//
        //               开关量输入输出类                  //
        //-------------------------------------------------//
        [DllImport("adtIO3224.dll")]
        public static extern Int32 adtIO3224_read_bit(Int32 cardno, Int32 number);
        /*********************************************************
        功能：读取单个输入点
        参数：
            cardno	    卡号
            number      输入点(0-32)
        返回值			0：低电平			1：高电平      -1：错误
        *********************************************************/

        [DllImport("adtIO3224.dll")]
        public static extern Int32 adtIO3224_write_bit(Int32 cardno, Int32 number, Int32 value);
        /********************************************************
        功能：写单个输出
        参数：
            cardno	    卡号
            number      输出点(0-24)
            value       0: 低电平           1: 高电平
        返回值			0：正确				1：错误
        *********************************************************/

        [DllImport("adtIO3224.dll")]
        public static extern Int32 adtIO3224_get_out(Int32 cardno, Int32 number);
        /**********************************
        功能:获取输出状态
        参数:
	        cardno       卡号
	        number       端口号(0-24)
        返回值:获取端口的当前状态,0: 低电平 1: 高电平 -1表示参数错误    
         ************************************************/

        [DllImport("adtIO3224.dll")]
        public static extern Int32 adtIO3224_read_in(Int32 cardno,out Int32 value);
        /*********************************************************
        功能：读取所有32个输入点
        参数：
	        cardno	    卡号
	        value       存储32个输入点状态值，通过二进制32位上的0,1表示:0表示低电平,1表示高电平
        返回值			0：正确				1：错误
        *********************************************************/

        [DllImport("adtIO3224.dll")]
        public static extern Int32 adtIO3224_read_out(Int32 cardno,out Int32 value);
        /*********************************************************
        功能：读取所有24个输出点
        参数：
	        cardno	    卡号
	        value       24个输入点状态值，通过二进制低24位的0,1表示:0表示输出为低电平,1表示输出为高电平
        返回值			0：正确				1：错误
        *********************************************************/

        [DllImport("adtIO3224.dll")]
        public static extern Int32 adtIO3224_write_out(Int32 cardno,out Int32 value);
        /*********************************************************
        功能：写所有24个输出点
        参数：
	        cardno	    卡号
	        value       24个输入点状态值，通过二进制低24位的0,1表示:0表示写低电平,1表示写高电平
        返回值			0：正确				1：错误
        *********************************************************/

    }
}