/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.IO
{
  using System;
  using System.IO;
  using System.Threading.Tasks;

  /// <summary>
  ///   为 <see cref="Stream" /> 类型提供了扩展方法。
  /// </summary>
  public static class StreamExtensions
  {
    #region Methods

    /// <summary>
    ///   清空流。
    /// </summary>
    /// <param name="me">
    ///   派生自 <see cref="Stream" /> 类型的对象实例。
    /// </param>
    /// <returns>
    ///   派生自 <see cref="Stream" /> 类型的对象实例 <paramref name="me" />。
    /// </returns>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Stream.SetLength(long)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="IOException">
    ///   当调用 <see cref="Stream.SetLength(long)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static Stream Clear(this Stream me)
    {
      if (me.Length.GreaterThan())
      {
        me.SetLength(0);
      }

      return me;
    }

    /// <summary>
    ///   (可等待的方法) 清空流。
    /// </summary>
    /// <param name="me">
    ///   派生自 <see cref="Stream" /> 类型的对象实例。
    /// </param>
    /// <returns>
    ///   派生自 <see cref="Stream" /> 类型的对象实例 <paramref name="me" />。
    /// </returns>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Stream.SetLength(long)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="IOException">
    ///   当调用 <see cref="Stream.SetLength(long)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static Task<Stream> ClearAsync(this Stream me)
    {
      var taskCompletionSource = new TaskCompletionSource<Stream>();

      try
      {
        taskCompletionSource.SetResult(me.Clear());
      }
      catch (Exception error)
      {
        taskCompletionSource.SetException(error);
      }

      return taskCompletionSource.Task;
    }

    #endregion Methods
  }
}