using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class AbstractBaseDisc
    {
        public abstract string MediaName { get; set;  }
        public abstract int StorageCapacity { get; set; }
        public abstract string MediaContents { get; set; }
        public abstract string MediaDiscType { get; set; }

        public AbstractBaseDisc(string name, int capacity, string contents, string discType)
        {
            MediaName = name;
            StorageCapacity = capacity;
            MediaContents = contents;
            MediaDiscType = discType;
        }
    }
}
