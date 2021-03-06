﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using System.Web.Http;
using Asp.Infrastructure.MessageHandlers;

namespace MiddleEnd.Api
{
    public static class WebApiConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.MessageHandlers.Add(new MethodOverrideHandler());
        }
    }
}