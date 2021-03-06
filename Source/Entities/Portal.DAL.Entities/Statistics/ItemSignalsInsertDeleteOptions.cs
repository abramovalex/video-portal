﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using System;

namespace Portal.DAL.Entities.Statistics
{
    public class ItemSignalsInsertDeleteOptions
    {
        public string ItemId { get; set; }

        public SignalType Signal { get; set; }

        public string UserId { get; set; }

        public DateTime DateTime { get; set; }
    }
}