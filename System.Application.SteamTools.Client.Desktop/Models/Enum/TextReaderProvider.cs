﻿namespace System.Application.Models
{
    /// <summary>
    /// 文本阅读器提供商
    /// </summary>
    public enum TextReaderProvider
    {
        /// <summary>
        /// 系统默认，例如 Win 上的记事本
        /// </summary>
        Notepad,

        /// <summary>
        /// Notepad++
        /// </summary>
        NotepadPlusPlus,

        /// <summary>
        /// Visual Studio Code
        /// </summary>
        VSCode,
    }
}