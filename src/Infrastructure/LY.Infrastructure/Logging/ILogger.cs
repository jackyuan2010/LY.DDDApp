using System;
using System.Collections.Generic;
using System.Text;

namespace LY.Infrastructure.Logging
{
    public interface ILogger
    {
        /// <summary>
        /// Log debug message
        /// </summary>
        /// <param name="message">The debug message</param>
        /// <param name="args">the message argument values</param>
        void Debug(string message, params object[] args);

        /// <summary>
        /// Log debug message
        /// </summary>
        /// <param name="message">The message</param>
        /// <param name="exception">Exception to write in debug message</param>
        void Debug(Exception exception, string message, params object[] args);

        /// <summary>
        /// Log debug message 
        /// </summary>
        /// <param name="item">The item with information to write in debug</param>
        void Debug(object item);

        /// <summary>
        /// Log FATAL error
        /// </summary>
        /// <param name="message">The message of fatal error</param>
        /// <param name="args">The argument values of message</param>
        void Fatal(string message, params object[] args);

        /// <summary>
        /// log FATAL error
        /// </summary>
        /// <param name="message">The message of fatal error</param>
        /// <param name="exception">The exception to write in this fatal message</param>
        void Fatal(Exception exception, string message, params object[] args);

        /// <summary>
        /// Log message information 
        /// </summary>
        /// <param name="message">The information message to write</param>
        /// <param name="args">The arguments values</param>
        void Info(string message, params object[] args);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception">The exception to write in this info message</param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        void Info(Exception exception, string message, params object[] args);

        /// <summary>
        /// Log warning message
        /// </summary>
        /// <param name="message">The warning message to write</param>
        /// <param name="args">The argument values</param>
        void Warn(string message, params object[] args);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exception">The exception to write in this warn message</param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        void Warn(Exception exception, string message, params object[] args);

        /// <summary>
        /// Log error message
        /// </summary>
        /// <param name="message">The error message to write</param>
        /// <param name="args">The arguments values</param>
        void Error(string message, params object[] args);

        /// <summary>
        /// Log error message
        /// </summary>
        /// <param name="message">The error message to write</param>
        /// <param name="exception">The exception associated with this error</param>
        /// <param name="args">The arguments values</param>
        void Error(Exception exception, string message, params object[] args);

        /// <summary>
        /// 设置关闭接口
        /// </summary>
        /// <param name="disabled">是否关闭</param>
        void SetDisabled(bool disabled);

        /// <summary>
        /// 设置日志级别
        /// </summary>
        /// <param name="logLevel"></param>
        void SetLogLevel(LogLevel logLevel);

        /// <summary>
        /// 获得当前日志级别
        /// </summary>
        LogLevel LogLevel { get; }
    }
}
