using System;

namespace Projekt_6
{
    internal class TransactionInfo : Attribute
    {
        public string? Author { get; set; }
        public double Version { get; set; }

        public TransactionInfo(string? Author, double Version)
        {
            this.Author = Author;
            this.Version = Version;
        }
    }
}
