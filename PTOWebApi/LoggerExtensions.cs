////-----------------------------------------------------------------------
//// <copyright file="LoggerExtensions.cs" company="Accurate Technologies Inc.">
////      Copyright (c) 2017 by Accurate Technologies Inc.
////      All Rights Reserved.
////      All information contained herein is confidential and
////      proprietary property of Accurate Technologies Inc.
//// </copyright>
//// <author>kjohansson</author>
////-----------------------------------------------------------------------
//using Microsoft.Extensions.Logging;
//using System;
//using System.Security.Claims;

//namespace CalibrationRepository.Extensions
//{
//    public static class LoggerExtensions
//    {
//        /// <summary>
//        /// Formats and writes a critical log message.
//        /// </summary>
//        /// <param name="logger">The Microsoft.Extensions.Logging.ILogger to write to.</param>
//        /// <param name="user">The current user associated with the log.</param>
//        /// <param name="message">Format string of the log message.</param>
//        /// <param name="args">An object array that contains zero or more objects to format.</param>
//        public static void LogCritical(this ILogger logger, ClaimsPrincipal user, string message, params object[] args)
//        {
//            var auth0UserId = user.UserId();
//            if (string.IsNullOrEmpty(auth0UserId))
//            {
//                logger.LogCritical(message, args);
//            }
//            else
//            {
//                logger.LogCritical(new EventId(0, auth0UserId), message, args);
//            }
//        }

//        /// <summary>
//        /// Formats and writes a critical log message.
//        /// </summary>
//        /// <param name="logger">The Microsoft.Extensions.Logging.ILogger to write to.</param>
//        /// <param name="user">The current user associated with the log.</param>
//        /// <param name="exception">The exception to log.</param>
//        /// <param name="message">Format string of the log message.</param>
//        /// <param name="args">An object array that contains zero or more objects to format.</param>
//        public static void LogCritical(this ILogger logger, ClaimsPrincipal user, Exception exception, string message, params object[] args)
//        {
//            var auth0UserId = user.UserId();
//            if (string.IsNullOrEmpty(auth0UserId))
//            {
//                logger.LogCritical(default(EventId), exception, message, args);
//            }
//            else
//            {
//                logger.LogCritical(new EventId(0, auth0UserId), exception, message, args);
//            }
//        }

//        /// <summary>
//        /// Formats and writes a debug log message.
//        /// </summary>
//        /// <param name="logger">The Microsoft.Extensions.Logging.ILogger to write to.</param>
//        /// <param name="user">The current user associated with the log.</param>
//        /// <param name="message">Format string of the log message.</param>
//        /// <param name="args">An object array that contains zero or more objects to format.</param>
//        public static void LogDebug(this ILogger logger, ClaimsPrincipal user, string message, params object[] args)
//        {
//            var auth0UserId = user.UserId();
//            if (string.IsNullOrEmpty(auth0UserId))
//            {
//                logger.LogDebug(message, args);
//            }
//            else
//            {
//                logger.LogDebug(new EventId(0, auth0UserId), message, args);
//            }
//        }

//        /// <summary>
//        /// Formats and writes a debug log message.
//        /// </summary>
//        /// <param name="logger">The Microsoft.Extensions.Logging.ILogger to write to.</param>
//        /// <param name="user">The current user associated with the log.</param>
//        /// <param name="exception">The exception to log.</param>
//        /// <param name="message">Format string of the log message.</param>
//        /// <param name="args">An object array that contains zero or more objects to format.</param>
//        public static void LogDebug(this ILogger logger, ClaimsPrincipal user, Exception exception, string message, params object[] args)
//        {
//            var auth0UserId = user.UserId();
//            if (string.IsNullOrEmpty(auth0UserId))
//            {
//                logger.LogDebug(default(EventId), exception, message, args);
//            }
//            else
//            {
//                logger.LogDebug(new EventId(0, auth0UserId), exception, message, args);
//            }
//        }

//        /// <summary>
//        /// Formats and writes an error log message.
//        /// </summary>
//        /// <param name="logger">The Microsoft.Extensions.Logging.ILogger to write to.</param>
//        /// <param name="user">The current user associated with the log.</param>
//        /// <param name="message">Format string of the log message.</param>
//        /// <param name="args">An object array that contains zero or more objects to format.</param>
//        public static void LogError(this ILogger logger, ClaimsPrincipal user, string message, params object[] args)
//        {
//            var auth0UserId = user.UserId();
//            if (string.IsNullOrEmpty(auth0UserId))
//            {
//                logger.LogError(message, args);
//            }
//            else
//            {
//                logger.LogError(new EventId(0, auth0UserId), message, args);
//            }
//        }

//        /// <summary>
//        /// Formats and writes an error log message.
//        /// </summary>
//        /// <param name="logger">The Microsoft.Extensions.Logging.ILogger to write to.</param>
//        /// <param name="user">The current user associated with the log.</param>
//        /// <param name="exception">The exception to log.</param>
//        /// <param name="message">Format string of the log message.</param>
//        /// <param name="args">An object array that contains zero or more objects to format.</param>
//        public static void LogError(this ILogger logger, ClaimsPrincipal user, Exception exception, string message, params object[] args)
//        {
//            var auth0UserId = user.UserId();
//            if (string.IsNullOrEmpty(auth0UserId))
//            {
//                logger.LogError(default(EventId), exception, message, args);
//            }
//            else
//            {
//                logger.LogError(new EventId(0, auth0UserId), exception, message, args);
//            }
//        }

//        /// <summary>
//        /// Formats and writes an informational log message.
//        /// </summary>
//        /// <param name="logger">The Microsoft.Extensions.Logging.ILogger to write to.</param>
//        /// <param name="user">The current user associated with the log.</param>
//        /// <param name="message">Format string of the log message.</param>
//        /// <param name="args">An object array that contains zero or more objects to format.</param>
//        public static void LogInformation(this ILogger logger, ClaimsPrincipal user, string message, params object[] args)
//        {
//            var auth0UserId = user.UserId();
//            if (string.IsNullOrEmpty(auth0UserId))
//            {
//                logger.LogInformation(message, args);
//            }
//            else
//            {
//                logger.LogInformation(new EventId(0, auth0UserId), message, args);
//            }
//        }

//        /// <summary>
//        /// Formats and writes an informational log message.
//        /// </summary>
//        /// <param name="logger">The Microsoft.Extensions.Logging.ILogger to write to.</param>
//        /// <param name="user">The current user associated with the log.</param>
//        /// <param name="exception">The exception to log.</param>
//        /// <param name="message">Format string of the log message.</param>
//        /// <param name="args">An object array that contains zero or more objects to format.</param>
//        public static void LogInformation(this ILogger logger, ClaimsPrincipal user, Exception exception, string message, params object[] args)
//        {
//            var auth0UserId = user.UserId();
//            if (string.IsNullOrEmpty(auth0UserId))
//            {
//                logger.LogInformation(default(EventId), exception, message, args);
//            }
//            else
//            {
//                logger.LogInformation(new EventId(0, auth0UserId), exception, message, args);
//            }
//        }

//        /// <summary>
//        /// Formats and writes a trace log message.
//        /// </summary>
//        /// <param name="logger">The Microsoft.Extensions.Logging.ILogger to write to.</param>
//        /// <param name="user">The current user associated with the log.</param>
//        /// <param name="message">Format string of the log message.</param>
//        /// <param name="args">An object array that contains zero or more objects to format.</param>
//        public static void LogTrace(this ILogger logger, ClaimsPrincipal user, string message, params object[] args)
//        {
//            var auth0UserId = user.UserId();
//            if (string.IsNullOrEmpty(auth0UserId))
//            {
//                logger.LogTrace(message, args);
//            }
//            else
//            {
//                logger.LogTrace(new EventId(0, auth0UserId), message, args);
//            }
//        }

//        /// <summary>
//        /// Formats and writes a trace log message.
//        /// </summary>
//        /// <param name="logger">The Microsoft.Extensions.Logging.ILogger to write to.</param>
//        /// <param name="user">The current user associated with the log.</param>
//        /// <param name="exception">The exception to log.</param>
//        /// <param name="message">Format string of the log message.</param>
//        /// <param name="args">An object array that contains zero or more objects to format.</param>
//        public static void LogTrace(this ILogger logger, ClaimsPrincipal user, Exception exception, string message, params object[] args)
//        {
//            var auth0UserId = user.UserId();
//            if (string.IsNullOrEmpty(auth0UserId))
//            {
//                logger.LogTrace(default(EventId), exception, message, args);
//            }
//            else
//            {
//                logger.LogTrace(new EventId(0, auth0UserId), exception, message, args);
//            }
//        }

//        /// <summary>
//        /// Formats and writes a warning log message.
//        /// </summary>
//        /// <param name="logger">The Microsoft.Extensions.Logging.ILogger to write to.</param>
//        /// <param name="user">The current user associated with the log.</param>
//        /// <param name="message">Format string of the log message.</param>
//        /// <param name="args">An object array that contains zero or more objects to format.</param>
//        public static void LogWarning(this ILogger logger, ClaimsPrincipal user, string message, params object[] args)
//        {
//            var auth0UserId = user.UserId();
//            if (string.IsNullOrEmpty(auth0UserId))
//            {
//                logger.LogWarning(message, args);
//            }
//            else
//            {
//                logger.LogWarning(new EventId(0, auth0UserId), message, args);
//            }
//        }

//        /// <summary>
//        /// Formats and writes a warning log message.
//        /// </summary>
//        /// <param name="logger">The Microsoft.Extensions.Logging.ILogger to write to.</param>
//        /// <param name="user">The current user associated with the log.</param>
//        /// <param name="exception">The exception to log.</param>
//        /// <param name="message">Format string of the log message.</param>
//        /// <param name="args">An object array that contains zero or more objects to format.</param>
//        public static void LogWarning(this ILogger logger, ClaimsPrincipal user, Exception exception, string message, params object[] args)
//        {
//            var auth0UserId = user.UserId();
//            if (string.IsNullOrEmpty(auth0UserId))
//            {
//                logger.LogWarning(default(EventId), exception, message, args);
//            }
//            else
//            {
//                logger.LogWarning(new EventId(0, auth0UserId), exception, message, args);
//            }
//        }
//    }
//}