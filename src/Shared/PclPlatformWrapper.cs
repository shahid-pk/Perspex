// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using System.Reflection;
using System.Resources;
using Perspex.Platform;

class PclPlatformWrapper : IPclPlatformWrapper
{
    public Assembly[] GetLoadedAssemblies() => AppDomain.CurrentDomain.GetAssemblies();
}