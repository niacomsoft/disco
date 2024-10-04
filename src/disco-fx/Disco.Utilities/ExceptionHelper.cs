/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco
{
  using Disco.Diagnostics;

  using System;
  using System.Reflection;
  using System.Runtime.InteropServices;

  /// <summary>
  ///   提供了异常相关的辅助静态 <see langword="static" /> 方法。
  /// </summary>
  public static class ExceptionHelper
  {
    #region Methods

    /// <summary>
    ///   创建 <typeparamref name="TException" /> 类型的异常对象实例。
    /// </summary>
    /// <typeparam name="TException">
    ///   派生自 <see cref="Exception" /> 的类型。
    /// </typeparam>
    /// <param name="args">
    ///   初始化 <typeparamref name="TException" /> 类的新实例所需的参数数组。
    /// </param>
    /// <returns>
    ///   <typeparamref name="TException" /> 类型的对象实例。
    /// </returns>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="TypeLoadException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="COMException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="MissingMethodException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="InvalidComObjectException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="TargetInvocationException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="MethodAccessException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="MemberAccessException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static TException CreateException<TException>(params object[] args) where TException : Exception
    {
      return Activator.CreateInstance(typeof(TException), args) as TException;
    }

    /// <summary>
    ///   当条件表达式 <paramref name="where" /> 等于 <see langword="false" /> 时，抛出一个 <typeparamref name="TException" /> 类型的异常。
    /// </summary>
    /// <typeparam name="TException">
    ///   派生自 <see cref="Exception" /> 的类型。
    /// </typeparam>
    /// <param name="where">
    ///   条件表达式。
    /// </param>
    /// <param name="args">
    ///   初始化 <typeparamref name="TException" /> 类的新实例所需的参数数组。
    /// </param>
    public static void ThrowElse<TException>(bool where, params object[] args) where TException : Exception
    {
      ThrowIf<TException>(!where, args);
    }

    /// <summary>
    ///   当条件表达式 <paramref name="where" /> 等于 <see langword="true" /> 时，抛出一个 <typeparamref name="TException" /> 类型的异常。
    /// </summary>
    /// <typeparam name="TException">
    ///   派生自 <see cref="Exception" /> 的类型。
    /// </typeparam>
    /// <param name="where">
    ///   条件表达式。
    /// </param>
    /// <param name="args">
    ///   初始化 <typeparamref name="TException" /> 类的新实例所需的参数数组。
    /// </param>
    public static void ThrowIf<TException>(bool where, params object[] args) where TException : Exception
    {
      if (Doctor.WarningIf(where, $"[ExceptionHelper]: The conditional expression \"where\" is equal to TRUE, will throw an exception of type \"{typeof(TException).FullName}\"."))
      {
        throw CreateException<TException>(args);
      }
    }

    #endregion Methods
  }
}