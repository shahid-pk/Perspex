﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using Perspex.Controls.Mixins;

namespace Perspex.Controls
{
    /// <summary>
    /// A selectable item in a <see cref="ListBox"/>.
    /// </summary>
    public class ListBoxItem : ContentControl, ISelectable
    {
        /// <summary>
        /// Defines the <see cref="IsSelected"/> property.
        /// </summary>
        public static readonly PerspexProperty<bool> IsSelectedProperty =
            PerspexProperty.Register<ListBoxItem, bool>(nameof(IsSelected));

        /// <summary>
        /// Initializes static members of the <see cref="ListBoxItem"/> class.
        /// </summary>
        static ListBoxItem()
        {
            SelectableMixin.Attach<ListBoxItem>(IsSelectedProperty);
            FocusableProperty.OverrideDefaultValue<ListBoxItem>(true);
        }

        /// <summary>
        /// Gets or sets the selection state of the item.
        /// </summary>
        public bool IsSelected
        {
            get { return GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }
    }
}
