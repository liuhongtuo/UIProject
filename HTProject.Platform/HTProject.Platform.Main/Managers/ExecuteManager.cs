using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HTProject.Platform.Main.Managers
{
    public class ExecuteManager
    {
        private static readonly ILog logger = LogManager.GetLog(typeof(ExecuteManager));
        private const string EntryFormat = "Enter {0} <======";
        private const string LeaveFormat = "Leave {0} ======>";
        private const string SucceedFormat = "{0} Succeed";
        private const string FailedFormat = "{0} Failed";

        public delegate void ExecuteAction(bool isEnable);
        public delegate void FinallyAction(bool hasError, string tipMessage);
        public static void ExecuteAsync(System.Action mainAction, string actionName = null, bool bShowToastMsg = true, bool isNeedValidate = false)
        {
            string title = $"{actionName ?? "Execute"} Failed";

            ThreadPool.QueueUserWorkItem(new WaitCallback(obj =>
            {
                bool hasError = true;
                try
                {
                    logger.Info(string.Format(EntryFormat, actionName));
                    mainAction?.Invoke();
                    hasError = false;
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }
                finally
                {
                    if (bShowToastMsg)
                    {
                        string message = hasError ? string.Format(FailedFormat, actionName) : string.Format(SucceedFormat, actionName);
                        //ToastMessageService.ShowMessage(message, hasError ? ToastMessageType.Error : ToastMessageType.Done);
                    }
                    logger.Info(string.Format(LeaveFormat, actionName));
                }
            }));
        }

        public static void ExecuteAsync(System.Action mainAction, FinallyAction finallyAction, string actionName = null, bool bShowToastMsg = true, bool isNeedValidate = false)
        {
            string title = $"{actionName ?? "Execute"} Failed";
            ThreadPool.QueueUserWorkItem(new WaitCallback(obj =>
            {
                bool hasError = true;
                try
                {
                    logger.Info(string.Format(EntryFormat, actionName));
                    mainAction?.Invoke();
                    hasError = false;
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                    //dialogManager.ShowError(ex.Message, title);
                }
                finally
                {
                    string message = hasError ? string.Format(FailedFormat, actionName) : string.Format(SucceedFormat, actionName);
                    finallyAction?.Invoke(hasError, message);
                    if (bShowToastMsg)
                    {
                        //ToastMessageService.ShowMessage(message, hasError ? ToastMessageType.Error : ToastMessageType.Done);
                    }
                    logger.Info(string.Format(LeaveFormat, actionName));
                }
            }));
        }

        public static void Execute(System.Action mainAction, string actionName = null, bool bShowToastMsg = true, bool isNeedValidate = false)
        {
            string title = $"{actionName ?? "Execute"} Failed";
            bool hasError = true;
            try
            {
                logger.Info(string.Format(EntryFormat, actionName));
                mainAction?.Invoke();
                hasError = false;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                //dialogManager.ShowError(ex.Message, title);
            }
            finally
            {
                if (bShowToastMsg)
                {
                    string message = hasError ? string.Format(FailedFormat, actionName) : string.Format(SucceedFormat, actionName);
                    //ToastMessageService.ShowMessage(message, hasError ? ToastMessageType.Error : ToastMessageType.Done);
                }
                logger.Info(string.Format(LeaveFormat, actionName));
            }
        }

        public static void Execute(System.Action mainAction, FinallyAction finallyAction, string actionName = null, bool bShowToastMsg = true, bool isNeedValidate = false)
        {
            string title = $"{actionName ?? "Execute"} Failed";
            bool hasError = true;
            try
            {
                logger.Info(string.Format(EntryFormat, actionName));
                mainAction?.Invoke();
                hasError = false;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                //dialogManager.ShowError(ex.Message, title);
            }
            finally
            {
                string message = hasError ? string.Format(FailedFormat, actionName) : string.Format(SucceedFormat, actionName);
                finallyAction?.Invoke(hasError, message);
                if (bShowToastMsg)
                {
                    //ToastMessageService.ShowMessage(message, hasError ? ToastMessageType.Error : ToastMessageType.Done);
                }
                logger.Info(string.Format(LeaveFormat, actionName));
            }
        }
    }
}
