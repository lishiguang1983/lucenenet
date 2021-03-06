﻿using Lucene.Net.Support;
using System.Globalization;

namespace Lucene.Net.QueryParsers.Flexible.Core.Parser
{
    /*
     * Licensed to the Apache Software Foundation (ASF) under one or more
     * contributor license agreements.  See the NOTICE file distributed with
     * this work for additional information regarding copyright ownership.
     * The ASF licenses this file to You under the Apache License, Version 2.0
     * (the "License"); you may not use this file except in compliance with
     * the License.  You may obtain a copy of the License at
     *
     *     http://www.apache.org/licenses/LICENSE-2.0
     *
     * Unless required by applicable law or agreed to in writing, software
     * distributed under the License is distributed on an "AS IS" BASIS,
     * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
     * See the License for the specific language governing permissions and
     * limitations under the License.
     */

    /// <summary>
    /// A parser needs to implement <see cref="IEscapeQuerySyntax"/> to allow the <see cref="Nodes.IQueryNode"/> 
    /// to escape the queries, when the ToQueryString method is called.
    /// </summary>
    public interface IEscapeQuerySyntax
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"> text to be escaped</param>
        /// <param name="locale">locale for the current query</param>
        /// <param name="type">select the type of escape operation to use</param>
        /// <returns>escaped text</returns>
        // LUCENENET specific overload for text as string
        string Escape(string text, CultureInfo locale, EscapeQuerySyntax.Type type);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"> text to be escaped</param>
        /// <param name="locale">locale for the current query</param>
        /// <param name="type">select the type of escape operation to use</param>
        /// <returns>escaped text</returns>
        ICharSequence Escape(ICharSequence text, CultureInfo locale, EscapeQuerySyntax.Type type);
    }

    /// <summary>
    /// LUCENENET specific static class for mimicking the syntax used for EscapeQuerySyntax.Type
    /// in Java, since interfaces cannot contain nested enums in .NET anyway.
    /// </summary>
    public static class EscapeQuerySyntax
    {
        /// <summary>
        /// Type of escaping: String for escaping syntax,
        /// NORMAL for escaping reserved words (like AND) in terms
        /// </summary>
        public enum Type
        {
            STRING,
            NORMAL
        }
    }
}
