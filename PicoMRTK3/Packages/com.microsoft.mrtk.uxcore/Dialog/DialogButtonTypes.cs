﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;

namespace Microsoft.MixedReality.Toolkit.UX
{
    /// <summary>
    /// The style of button on a dialog.
    /// </summary>
    public enum DialogButtonType
    {
        None = 0,
        Close = 1,
        Confirm = 2,
        Cancel = 3,
        Accept = 4,
        Yes = 5,
        No = 6,
        OK = 7,
    }

    /// <summary>
    /// The style of button on a dialog.
    /// </summary>
    [Flags, Obsolete("Use DialogButtonType instead.")]
    public enum DialogButtonTypes
    {
        None = 0 << 0,
        Close = 1 << 0,
        Confirm = 1 << 1,
        Cancel = 1 << 2,
        Accept = 1 << 3,
        Yes = 1 << 4,
        No = 1 << 5,
        OK = 1 << 6,
    }
}
