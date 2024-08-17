﻿using System.Text.RegularExpressions;

namespace Sheas_Cealer.Consts;

internal partial class MainConst : MainMultilangConst
{
    internal enum SettingsMode
    { BrowserPathMode, ExtraArgsMode };

    [GeneratedRegex(@"^(https?:\/\/)?[a-zA-Z0-9](-*[a-zA-Z0-9])*(\.[a-zA-Z0-9](-*[a-zA-Z0-9])*)*(:\d{1,5})?(\/[a-zA-Z0-9.\-_\~\!\$\&\'\(\)\*\+\,\;\=\:\@\%]*)*$")]
    internal static partial Regex UpstreamUrlRegex();

    [GeneratedRegex(@"^(--[a-z](-?[a-z])*(="".*"")?( --[a-z](-?[a-z])*(="".*"")?)*)?$")]
    internal static partial Regex ExtraArgsRegex();
}