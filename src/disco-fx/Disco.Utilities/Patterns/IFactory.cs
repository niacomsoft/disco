/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Patterns
{
  #region Interfaces

  /// <summary>
  ///   提供了工程模式的接口。
  /// </summary>
  /// <typeparam name="T">
  ///   实例类型。
  /// </typeparam>
  public interface IFactory<T> where T : class, new()
  {
    #region Methods

    /// <summary>
    ///   创建一个 <typeparamref name="T" /> 类型的对象实例。
    /// </summary>
    /// <returns>
    ///   <typeparamref name="T" /> 类型的对象实例。
    /// </returns>
    T CreateInstance();

    #endregion Methods
  }

  /// <summary>
  ///   提供了工程模式的接口。
  /// </summary>
  /// <typeparam name="T">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="TResult">
  ///   实例类型。
  /// </typeparam>
  public interface IFactory<T, TResult> where TResult : class
  {
    #region Methods

    /// <summary>
    ///   创建一个 <typeparamref name="TResult" /> 类型的对象实例。
    /// </summary>
    /// <param name="arg">
    ///   <typeparamref name="T" /> 类型的参数值。
    /// </param>
    /// <returns>
    ///   <typeparamref name="TResult" /> 类型的对象实例。
    /// </returns>
    TResult CreateInstance(T arg);

    #endregion Methods
  }

  /// <summary>
  ///   提供了工程模式的接口。
  /// </summary>
  /// <typeparam name="T1">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T2">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="TResult">
  ///   实例类型。
  /// </typeparam>
  public interface IFactory<T1, T2, TResult> where TResult : class
  {
    #region Methods

    /// <summary>
    ///   创建一个 <typeparamref name="TResult" /> 类型的对象实例。
    /// </summary>
    /// <param name="arg1">
    ///   <typeparamref name="T1" /> 类型的参数值。
    /// </param>
    /// <param name="arg2">
    ///   <typeparamref name="T2" /> 类型的参数值。
    /// </param>
    /// <returns>
    ///   <typeparamref name="TResult" /> 类型的对象实例。
    /// </returns>
    TResult CreateInstance(T1 arg1, T2 arg2);

    #endregion Methods
  }

  /// <summary>
  ///   提供了工程模式的接口。
  /// </summary>
  /// <typeparam name="T1">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T2">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T3">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="TResult">
  ///   实例类型。
  /// </typeparam>
  public interface IFactory<T1, T2, T3, TResult> where TResult : class
  {
    #region Methods

    /// <summary>
    ///   创建一个 <typeparamref name="TResult" /> 类型的对象实例。
    /// </summary>
    /// <param name="arg1">
    ///   <typeparamref name="T1" /> 类型的参数值。
    /// </param>
    /// <param name="arg2">
    ///   <typeparamref name="T2" /> 类型的参数值。
    /// </param>
    /// <param name="arg3">
    ///   <typeparamref name="T3" /> 类型的参数值。
    /// </param>
    /// <returns>
    ///   <typeparamref name="TResult" /> 类型的对象实例。
    /// </returns>
    TResult CreateInstance(T1 arg1, T2 arg2, T3 arg3);

    #endregion Methods
  }

  /// <summary>
  ///   提供了工程模式的接口。
  /// </summary>
  /// <typeparam name="T1">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T2">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T3">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T4">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="TResult">
  ///   实例类型。
  /// </typeparam>
  public interface IFactory<T1, T2, T3, T4, TResult> where TResult : class
  {
    #region Methods

    /// <summary>
    ///   创建一个 <typeparamref name="TResult" /> 类型的对象实例。
    /// </summary>
    /// <param name="arg1">
    ///   <typeparamref name="T1" /> 类型的参数值。
    /// </param>
    /// <param name="arg2">
    ///   <typeparamref name="T2" /> 类型的参数值。
    /// </param>
    /// <param name="arg3">
    ///   <typeparamref name="T3" /> 类型的参数值。
    /// </param>
    /// <param name="arg4">
    ///   <typeparamref name="T4" /> 类型的参数值。
    /// </param>
    /// <returns>
    ///   <typeparamref name="TResult" /> 类型的对象实例。
    /// </returns>
    TResult CreateInstance(T1 arg1, T2 arg2, T3 arg3, T4 arg4);

    #endregion Methods
  }

  /// <summary>
  ///   提供了工程模式的接口。
  /// </summary>
  /// <typeparam name="T1">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T2">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T3">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T4">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T5">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="TResult">
  ///   实例类型。
  /// </typeparam>
  public interface IFactory<T1, T2, T3, T4, T5, TResult> where TResult : class
  {
    #region Methods

    /// <summary>
    ///   创建一个 <typeparamref name="TResult" /> 类型的对象实例。
    /// </summary>
    /// <param name="arg1">
    ///   <typeparamref name="T1" /> 类型的参数值。
    /// </param>
    /// <param name="arg2">
    ///   <typeparamref name="T2" /> 类型的参数值。
    /// </param>
    /// <param name="arg3">
    ///   <typeparamref name="T3" /> 类型的参数值。
    /// </param>
    /// <param name="arg4">
    ///   <typeparamref name="T4" /> 类型的参数值。
    /// </param>
    /// <param name="arg5">
    ///   <typeparamref name="T5" /> 类型的参数值。
    /// </param>
    /// <returns>
    ///   <typeparamref name="TResult" /> 类型的对象实例。
    /// </returns>
    TResult CreateInstance(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

    #endregion Methods
  }

  /// <summary>
  ///   提供了工程模式的接口。
  /// </summary>
  /// <typeparam name="T1">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T2">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T3">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T4">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T5">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T6">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="TResult">
  ///   实例类型。
  /// </typeparam>
  public interface IFactory<T1, T2, T3, T4, T5, T6, TResult> where TResult : class
  {
    #region Methods

    /// <summary>
    ///   创建一个 <typeparamref name="TResult" /> 类型的对象实例。
    /// </summary>
    /// <param name="arg1">
    ///   <typeparamref name="T1" /> 类型的参数值。
    /// </param>
    /// <param name="arg2">
    ///   <typeparamref name="T2" /> 类型的参数值。
    /// </param>
    /// <param name="arg3">
    ///   <typeparamref name="T3" /> 类型的参数值。
    /// </param>
    /// <param name="arg4">
    ///   <typeparamref name="T4" /> 类型的参数值。
    /// </param>
    /// <param name="arg5">
    ///   <typeparamref name="T5" /> 类型的参数值。
    /// </param>
    /// <param name="arg6">
    ///   <typeparamref name="T6" /> 类型的参数值。
    /// </param>
    /// <returns>
    ///   <typeparamref name="TResult" /> 类型的对象实例。
    /// </returns>
    TResult CreateInstance(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

    #endregion Methods
  }

  /// <summary>
  ///   提供了工程模式的接口。
  /// </summary>
  /// <typeparam name="T1">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T2">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T3">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T4">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T5">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T6">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T7">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="TResult">
  ///   实例类型。
  /// </typeparam>
  public interface IFactory<T1, T2, T3, T4, T5, T6, T7, TResult> where TResult : class
  {
    #region Methods

    /// <summary>
    ///   创建一个 <typeparamref name="TResult" /> 类型的对象实例。
    /// </summary>
    /// <param name="arg1">
    ///   <typeparamref name="T1" /> 类型的参数值。
    /// </param>
    /// <param name="arg2">
    ///   <typeparamref name="T2" /> 类型的参数值。
    /// </param>
    /// <param name="arg3">
    ///   <typeparamref name="T3" /> 类型的参数值。
    /// </param>
    /// <param name="arg4">
    ///   <typeparamref name="T4" /> 类型的参数值。
    /// </param>
    /// <param name="arg5">
    ///   <typeparamref name="T5" /> 类型的参数值。
    /// </param>
    /// <param name="arg6">
    ///   <typeparamref name="T6" /> 类型的参数值。
    /// </param>
    /// <param name="arg7">
    ///   <typeparamref name="T7" /> 类型的参数值。
    /// </param>
    /// <returns>
    ///   <typeparamref name="TResult" /> 类型的对象实例。
    /// </returns>
    TResult CreateInstance(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

    #endregion Methods
  }

  /// <summary>
  ///   提供了工程模式的接口。
  /// </summary>
  /// <typeparam name="T1">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T2">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T3">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T4">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T5">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T6">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T7">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T8">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="TResult">
  ///   实例类型。
  /// </typeparam>
  public interface IFactory<T1, T2, T3, T4, T5, T6, T7, T8, TResult> where TResult : class
  {
    #region Methods

    /// <summary>
    ///   创建一个 <typeparamref name="TResult" /> 类型的对象实例。
    /// </summary>
    /// <param name="arg1">
    ///   <typeparamref name="T1" /> 类型的参数值。
    /// </param>
    /// <param name="arg2">
    ///   <typeparamref name="T2" /> 类型的参数值。
    /// </param>
    /// <param name="arg3">
    ///   <typeparamref name="T3" /> 类型的参数值。
    /// </param>
    /// <param name="arg4">
    ///   <typeparamref name="T4" /> 类型的参数值。
    /// </param>
    /// <param name="arg5">
    ///   <typeparamref name="T5" /> 类型的参数值。
    /// </param>
    /// <param name="arg6">
    ///   <typeparamref name="T6" /> 类型的参数值。
    /// </param>
    /// <param name="arg7">
    ///   <typeparamref name="T7" /> 类型的参数值。
    /// </param>
    /// <param name="arg8">
    ///   <typeparamref name="T8" /> 类型的参数值。
    /// </param>
    /// <returns>
    ///   <typeparamref name="TResult" /> 类型的对象实例。
    /// </returns>
    TResult CreateInstance(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

    #endregion Methods
  }

  /// <summary>
  ///   提供了工程模式的接口。
  /// </summary>
  /// <typeparam name="T1">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T2">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T3">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T4">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T5">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T6">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T7">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T8">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="T9">
  ///   初始化 <typeparamref name="TResult" /> 类的新实例所需的参数类型。
  /// </typeparam>
  /// <typeparam name="TResult">
  ///   实例类型。
  /// </typeparam>
  public interface IFactory<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> where TResult : class
  {
    #region Methods

    /// <summary>
    ///   创建一个 <typeparamref name="TResult" /> 类型的对象实例。
    /// </summary>
    /// <param name="arg1">
    ///   <typeparamref name="T1" /> 类型的参数值。
    /// </param>
    /// <param name="arg2">
    ///   <typeparamref name="T2" /> 类型的参数值。
    /// </param>
    /// <param name="arg3">
    ///   <typeparamref name="T3" /> 类型的参数值。
    /// </param>
    /// <param name="arg4">
    ///   <typeparamref name="T4" /> 类型的参数值。
    /// </param>
    /// <param name="arg5">
    ///   <typeparamref name="T5" /> 类型的参数值。
    /// </param>
    /// <param name="arg6">
    ///   <typeparamref name="T6" /> 类型的参数值。
    /// </param>
    /// <param name="arg7">
    ///   <typeparamref name="T7" /> 类型的参数值。
    /// </param>
    /// <param name="arg8">
    ///   <typeparamref name="T8" /> 类型的参数值。
    /// </param>
    /// <param name="arg9">
    ///   <typeparamref name="T9" /> 类型的参数值。
    /// </param>
    /// <returns>
    ///   <typeparamref name="TResult" /> 类型的对象实例。
    /// </returns>
    TResult CreateInstance(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);

    #endregion Methods
  }

  #endregion Interfaces
}