// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Data.Sqlite
{
    /// <summary>
    /// Controls how the journal file is stored and processed. 
    /// </summary>
    public enum SqliteJournalMode
    {
        /// <summary>
        /// This is default mode. Here at the conclusion of a transaction, the journal file is deleted.
        /// </summary>
        Delete,
        /// <summary>
        /// The journal file is truncated to a length of zero bytes.
        /// </summary>
        Truncate,
        /// <summary>
        /// The journal file is left in place, but the header is overwritten to indicate the journal is no longer valid.
        /// </summary>
        Perisist,
        /// <summary>
        /// The journal record is held in memory, rather than on disk.
        /// </summary>
        Memory,
        /// <summary>
        /// The original content is preserved in the database file and the changes are appended into a separate WAL file.
        /// https://www.sqlite.org/wal.html
        /// </summary>
        Wal,
        /// <summary>
        /// No journal record is kept.
        /// </summary>
        Off
    }
}
