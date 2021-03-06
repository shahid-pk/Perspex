﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System.IO;
using Perspex.Platform;
using Splat;

namespace Perspex.Media.Imaging
{
    /// <summary>
    /// Holds a bitmap image.
    /// </summary>
    public class Bitmap : IBitmap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bitmap"/> class.
        /// </summary>
        /// <param name="fileName">The filename of the bitmap.</param>
        public Bitmap(string fileName)
        {
            IPlatformRenderInterface factory = Locator.Current.GetService<IPlatformRenderInterface>();
            PlatformImpl = factory.LoadBitmap(fileName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bitmap"/> class.
        /// </summary>
        /// <param name="stream">The stream to read the bitmap from.</param>
        public Bitmap(Stream stream)
        {
            IPlatformRenderInterface factory = Locator.Current.GetService<IPlatformRenderInterface>();
            PlatformImpl = factory.LoadBitmap(stream);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bitmap"/> class.
        /// </summary>
        /// <param name="width">The width of the bitmap, in pixels.</param>
        /// <param name="height">The height of the bitmap, in pixels.</param>
        public Bitmap(int width, int height)
        {
            IPlatformRenderInterface factory = Locator.Current.GetService<IPlatformRenderInterface>();
            PlatformImpl = factory.CreateBitmap(width, height);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bitmap"/> class.
        /// </summary>
        /// <param name="impl">A platform-specific bitmap implementation.</param>
        protected Bitmap(IBitmapImpl impl)
        {
            PlatformImpl = impl;
        }

        /// <summary>
        /// Gets the width of the bitmap, in pixels.
        /// </summary>
        public int PixelWidth => PlatformImpl.PixelWidth;

        /// <summary>
        /// Gets the height of the bitmap, in pixels.
        /// </summary>
        public int PixelHeight => PlatformImpl.PixelHeight;

        /// <summary>
        /// Gets the platform-specific bitmap implementation.
        /// </summary>
        public IBitmapImpl PlatformImpl
        {
            get; }

        /// <summary>
        /// Saves the bitmap to a file.
        /// </summary>
        /// <param name="fileName">The filename.</param>
        public void Save(string fileName)
        {
            PlatformImpl.Save(fileName);
        }
    }
}
