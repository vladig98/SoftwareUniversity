﻿using System;

namespace BashSoft.Exceptions
{
    public class DuplicateEntryInStructureException : Exception
    {
        private const string DuplicateEntry = "The {0} already exists in {1}.";

        public DuplicateEntryInStructureException(string message) : base(message)
        {

        }

        public DuplicateEntryInStructureException(string enetry, string stucture) : base(string.Format(DuplicateEntry, enetry, stucture))
        {

        }
    }
}
