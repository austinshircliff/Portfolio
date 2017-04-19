using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class sortbycopyrightyear : IComparer<LibraryItem>
    {
        public int Compare(LibraryItem item1, LibraryItem item2)
        {
            // Implements correct handling of null values (in .NET, null less than anything)
            if (item1 == null && item2 == null) // Both null?
                return 0;

            if (item1 == null) // only t1 is null?
                return -1;

            if (item2 == null) // only t2 is null?
                return 1;

            return item2.CopyrightYear.CompareTo(item1.CopyrightYear);  // Reverses natural order of the copyright years

        }
    }
}
