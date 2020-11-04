﻿using System;

namespace Avalonia.Controls.Automation
{
    public class ElementNotEnabledException : Exception
    {
        public ElementNotEnabledException() : base("Element not enabled.") { }
        public ElementNotEnabledException(string message) : base(message) { }
    }
}
