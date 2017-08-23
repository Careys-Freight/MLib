﻿using Doc.DocManager.Interfaces;
using System.Collections.Generic;

namespace Doc.DocManager
{

    internal class FileFilterEntries : IFileFilterEntries
    {
        #region fields
        private readonly List<IFileFilterEntry> mEntries;
        #endregion fields

        #region contructors
        /// <summary>
        /// Class constructor
        /// </summary>
        public FileFilterEntries(IList<IFileFilterEntry> entries)
        {
            this.mEntries = new List<Interfaces.IFileFilterEntry>(entries);
        }
        #endregion contructors

        #region properties
        #endregion properties

        #region methods
        /// <summary>
        /// Gets a string that can be used as filter selection in a file open dialog.
        /// </summary>
        /// <returns></returns>
        public string GetFilterString()
        {
            string s = string.Empty;
            string d = string.Empty;
            foreach (var item in this.mEntries)
            {
                s = s + d + item.FileFilter;
                d = "|";
            }

            return s;
        }
/***
        /// <summary>
        /// Gets the file open delegate method for an index
        /// into the current array of file filter patterns.
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public FileOpenDelegate GetFileOpenMethod(int idx)
        {
            return this.mEntries[idx].FileOpenMethod;
        }
***/
        #endregion methods
    }
}
