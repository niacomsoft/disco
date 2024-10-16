/* ********************************************************************************************************************************************************** *\
 * COPYRIGHT © 2006 - 2024 WANG YUCAI. ALL RIGHTS RESERVED.                                                                                                   *
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                                                         *
\* ********************************************************************************************************************************************************** */

namespace Disco.Logging
{
  using Microsoft.Extensions.Logging;

  internal static partial class InternalLoggingExtensions
  {
#if DEBUG
    private const LogLevel DefaultLogLevel = LogLevel.Debug;
#else
    private const LogLevel DefaultLogLevel = LogLevel.Information;
#endif
  }
}