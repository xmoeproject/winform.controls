﻿#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2010
//
//     COPYRIGHT (C) 2010, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

namespace System
{
    /// <summary>
    /// 
    /// </summary>
    public static class Guard
    {
        /// <summary>
        /// 确保参数值不是NULL且不为空字符串
        /// </summary>
        /// <param name="argumentValue"></param>
        /// <param name="argumentName"></param>
        public static void ArgumentNotNullOrEmptyString(string argumentValue, string argumentName)
        {
            ArgumentNotNull(argumentValue, argumentName);

            if (argumentValue.Length == 0)
            {
                throw new ArgumentException("String Cannot Be Empty", argumentName);
            }
        }

        /// <summary>
        /// 确保参数值不为NULL
        /// </summary>
        /// <param name="argumentValue"></param>
        /// <param name="argumentName"></param>
        public static void ArgumentNotNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argumentName"></param>
        /// <param name="message"></param>
        public static void ArgumentOutOfRangeException<T>(string argumentName, T argumentValue, Func<T, bool> callback)
        {
            if (callback(argumentValue))
            {
                throw new ArgumentOutOfRangeException(argumentName);
            }
        }

        /// <summary>
        /// 对执行的操作是否容错
        /// </summary>
        /// <param name="skipException"></param>
        /// <param name="callback"></param>
        public static void SkipException(bool skipException, CallbackVoidHandler callback)
        {
            if (skipException)
            {
                try
                {
                    callback();
                }
                catch
                {
                }
            }
            else
            {
                callback();
            }
        }
    }
}