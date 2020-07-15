using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework.Fsm;
using GameFramework.Procedure;
using GameFramework;
using UnityGameFramework.Runtime;

namespace Tutorial
{
    public class ProcedureLaunch_example : ProcedureBase
    {
        //游戏初始化时执行。
        protected override void OnInit(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnInit(procedureOwner);
        }

        //每次进入这个流程时执行。
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);

            string welcomeMessage = Utility.Text.Format("Hello Game Framework {0}.", Version.GameFrameworkVersion);


            // 打印调试级别日志，用于记录调试类日志信息
            Log.Debug(welcomeMessage);

            // 打印信息级别日志，用于记录程序正常运行日志信息
            Log.Info(welcomeMessage);

            // 打印警告级别日志，建议在发生局部功能逻辑错误，但尚不会导致游戏崩溃或异常时使用
            Log.Warning(welcomeMessage);

            // 打印错误级别日志，建议在发生功能逻辑错误，但尚不会导致游戏崩溃或异常时使用
            Log.Error(welcomeMessage);

            // 打印严重错误级别日志，建议在发生严重错误，可能导致游戏崩溃或异常时使用，此时应尝试重启进程或重建游戏框架
            Log.Fatal(welcomeMessage);
        }

        //每次轮询执行。
        protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        }

        // 每次离开这个流程时执行。
        protected override void OnLeave(IFsm<IProcedureManager> procedureOwner, bool isShutdown)
        {
            base.OnLeave(procedureOwner, isShutdown);
        }

        // 游戏退出时执行。
        protected override void OnDestroy(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnDestroy(procedureOwner);
        }
    }
}

