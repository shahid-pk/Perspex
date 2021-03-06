﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using Perspex.Interactivity;

namespace Perspex.Input
{
    public class KeyEventArgs : RoutedEventArgs
    {
        public IKeyboardDevice Device { get; set; }

        public Key Key { get; set; }

        public ModifierKeys Modifiers { get; set; }
    }
}
