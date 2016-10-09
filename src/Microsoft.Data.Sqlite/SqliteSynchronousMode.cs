// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Data.Sqlite
{
    /// <summary>
    /// Controls how aggressively SQLite will write data all the way out to physical storage.
    /// </summary>
    public enum SqliteSynchronousMode
    {
        /// <summary>
        /// SQLite continues without syncing as soon as it has handed data off to the operating system/
        /// </summary>
        Off,
        /// <summary>
        /// The SQLite database engine will still sync at the most critical moments, but less often than in FULL mode.
        /// </summary>
        Normal,
        /// <summary>
        /// The SQLite database engine will use the xSync method of the VFS to ensure that all content is safely written to the disk surface prior to continuing.
        /// </summary>
        Full,
        /// <summary>
        /// Like FULL with the addition that the directory containing a rollback journal is synced after that journal is unlinked to commit a transaction in DELETE mode.
        /// </summary>
        Extra
    }
}
