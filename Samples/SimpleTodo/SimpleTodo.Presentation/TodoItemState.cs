﻿// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

namespace Charites.Windows.Samples.SimpleTodo.Presentation
{
    [Flags]
    public enum TodoItemState
    {
        Active = 1,
        Completed = 2,
        All = Active | Completed
    }
}
