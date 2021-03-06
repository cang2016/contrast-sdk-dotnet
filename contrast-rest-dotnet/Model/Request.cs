﻿/*
 * Copyright (c) 2015, Contrast Security, Inc.
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification, are
 * permitted provided that the following conditions are met:
 *
 * Redistributions of source code must retain the above copyright notice, this list of
 * conditions and the following disclaimer.
 *
 * Redistributions in binary form must reproduce the above copyright notice, this list of
 * conditions and the following disclaimer in the documentation and/or other materials
 * provided with the distribution.
 *
 * Neither the name of the Contrast Security, Inc. nor the names of its contributors may
 * be used to endorse or promote products derived from this software without specific
 * prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF
 * MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL
 * THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT
 * OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
 * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF
 * THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace contrast_rest_dotnet.Model
{
    /// <summary>
    /// An HTTP request associated with a trace.
    /// </summary>
    [DataContract]
    public class Request
    {
        /// <summary>
        /// Gets the protocol of the request.
        /// </summary>
        [DataMember(Name = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets the protocol version number.
        /// </summary>
        [DataMember(Name = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets the URI of the request.
        /// </summary>
        [DataMember(Name = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets the request query string.
        /// </summary>
        [DataMember(Name = "queryString")]
        public string QueryString { get; set; }

        /// <summary>
        /// Gets the HTTP method for the request.
        /// </summary>
        [DataMember(Name = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets the port the request used.
        /// </summary>
        [DataMember(Name = "port")]
        public int Port { get; set; }

        /// <summary>
        /// Gets a list of HTTP headers for the request.
        /// </summary>
        [DataMember(Name = "headers")]
        public List<Header> Headers { get; set; }

        /// <summary>
        /// Gets a list of parameters for the request.
        /// </summary>
        [DataMember(Name = "parameters")]
        public List<Parameter> Parameters { get; set; }

        /// <summary>
        /// Gets a list of Contrast REST endpoint URLs for this request.
        /// </summary>
        [DataMember(Name = "links")]
        public List<Link> Links { get; set; }
    }
}
