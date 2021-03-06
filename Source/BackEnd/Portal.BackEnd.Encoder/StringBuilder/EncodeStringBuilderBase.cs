﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using Portal.Domain.BackendContext.Entity.Base;

namespace Portal.BackEnd.Encoder.StringBuilder
{
    public abstract class EncodeStringBuilderBase
    {
        private readonly IEncodeData _encodeData;

        protected EncodeStringBuilderBase(IEncodeData encodeData)
        {
            _encodeData = encodeData;
        }

        public string GetContentType()
        {
            return _encodeData.ContentType;
        }
    }
}