/*
 * Copyright 2018 James Courtney
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace FlatSharpTests
{
    using FlatSharp;
    using FlatSharp.Attributes;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Tests default values on a table.
    /// </summary>
    [TestClass]
    public class FileIdentifierTests
    {
        private static byte[] EmptyTable =
        {
            8, 0, 0, 0,           // uoffset to the start of the table.
            97, 98, 99, 100,      // abcd file id
            252, 255, 255, 255,   // soffset_t to the vtable
            4, 0,                 // vtable size
            4, 0,                 // table length
        };

        [TestMethod]
        public void Write_FileIdentifier()
        {
            byte[] bytes = new byte[1024];
            int bytesWritten = FlatBufferSerializer.Default.Serialize<FileIdentifierTable>(new FileIdentifierTable(), bytes);

            Assert.AreEqual(16, bytesWritten);
            Assert.IsTrue(bytes.AsSpan().Slice(0, 16).SequenceEqual(EmptyTable));
        }

        [FlatBufferTable(FileIdentifier = "abcd")]
        public class FileIdentifierTable
        {
            [FlatBufferItem(0)]
            public virtual int Int { get; set; }
        }
    }
}
