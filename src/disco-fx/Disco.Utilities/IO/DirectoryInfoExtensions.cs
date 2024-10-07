/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.IO
{
  using Disco.Diagnostics;
  using Disco.Resources;

  using System;
  using System.IO;
  using System.Security;

  /// <summary>
  ///   为 <see cref="DirectoryInfo" /> 类型提供了扩展方法。
  /// </summary>
  public static class DirectoryInfoExtensions
  {
    #region Methods

    /// <summary>
    ///   组合 <paramref name="me" /> 和 <paramref name="folders" /> 为一个全新的路径。
    /// </summary>
    /// <param name="me">
    ///   路径信息。
    /// </param>
    /// <param name="folders">
    ///   文件夹名称数组。
    /// </param>
    /// <returns>
    ///   新的路径信息。
    /// </returns>
    /// <exception cref="PathTooLongException">
    ///   当初始化 <see cref="DirectoryInfo" /> 类的新实例时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="SecurityException">
    ///   当初始化 <see cref="DirectoryInfo" /> 类的新实例时，可能引发此类型的异常。
    /// </exception>
    public static DirectoryInfo CombineDirectory(this DirectoryInfo me, params string[] folders)
    {
      var dir = me.FullName;
      if (folders.HasItems())
      {
        foreach (var folder in folders)
        {
          dir = Path.Combine(dir, folder);
        }
      }
      return new DirectoryInfo(dir);
    }

    /// <summary>
    ///   组合 <paramref name="me" /> 和 <paramref name="fileName" /> 为一个文件信息。
    /// </summary>
    /// <param name="me">
    ///   路径信息。
    /// </param>
    /// <param name="fileName">
    ///   文件名称。
    /// </param>
    /// <returns>
    ///   文件信息。
    /// </returns>
    /// <exception cref="SecurityException">
    ///   当初始化 <see cref="FileInfo" /> 类的新实例时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="UnauthorizedAccessException">
    ///   当初始化 <see cref="FileInfo" /> 类的新实例时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="PathTooLongException">
    ///   当初始化 <see cref="FileInfo" /> 类的新实例时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="NotSupportedException">
    ///   当初始化 <see cref="FileInfo" /> 类的新实例时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="ArgumentException">
    ///   当字符串 <paramref name="fileName" /> 等于 <see langword="null" />、 <see cref="string.Empty" /> 或空格符时，将引发此类型的异常。
    /// </exception>
    // ExceptionAdjustment: M:System.String.Format(System.String,System.Object) -T:System.FormatException
    public static FileInfo CombineFile(this DirectoryInfo me, string fileName)
    {
      ExceptionHelper.ThrowIf<ArgumentException>(string.IsNullOrWhiteSpace(fileName), string.Format(Strings.ArgumentException_empty_or_whitespace, nameof(fileName)), nameof(fileName));
      return new FileInfo(Path.Combine(me.FullName, fileName));
    }

    /// <summary>
    ///   确保路径 <paramref name="me" /> 存在。
    ///   <para> 当路径 <paramref name="me" /> 不存在时，将自动创建。 </para>
    /// </summary>
    /// <param name="me">
    ///   需要校验的路径。
    /// </param>
    /// <returns>
    ///   当前的路径 <paramref name="me" />。
    /// </returns>
    /// <exception cref="IOException">
    ///   当调用 <c> <paramref name="me" />.Refresh() </c> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="SecurityException">
    ///   当访问 <c> <paramref name="me" />.FullName </c> 属性时，可能引发此类型的异常。
    /// </exception>
    public static DirectoryInfo EnsureDirectoryExists(this DirectoryInfo me)
    {
      me.Refresh();
      if (Doctor.DebugIf(!me.Exists, $"[{nameof(DirectoryInfoExtensions)}]: The path \"{me.FullName}\" does not exist, and the application is automatically created."))
      {
        me.Create();
        me.Refresh();
      }
      return me;
    }

    #endregion Methods
  }
}