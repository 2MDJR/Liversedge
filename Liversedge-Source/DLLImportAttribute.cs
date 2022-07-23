using System;

namespace Liversedge
{
    internal class DLLImportAttribute : Attribute
    {
        private string v;
        private string entryPointNotFoundException;

        public DLLImportAttribute(string v, string EntryPointNotFoundException)
        {
            this.v = v;
            entryPointNotFoundException = EntryPointNotFoundException;
        }
    }
}