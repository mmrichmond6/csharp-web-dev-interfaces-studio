using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class AbstractBaseDisc
    {
        public abstract string MediaName { get; set;  }
        
        public abstract string MediaContents { get; set; }

        public AbstractBaseDisc(string name, string contents)
        {
            MediaName = name;
            MediaContents = contents;
        }

        public abstract string MediaDiscType { get; }

        public abstract int StorageCapacity { get; }

        public abstract int SpinRateMin { get; }

        public abstract int SpinRateMax { get; }

        public void PrintMediaInfo()
        {
            Console.WriteLine($"This media is called '{MediaName}'." +
                $"\n{MediaName} holds {MediaContents} content." +
                $"\n{MediaName} has a storage capacity of:  {StorageCapacity} MB" +
                $"\n{MediaName}'s disc type is a {MediaDiscType}." +
                $"\n{MediaName}'s spin rate ranges from {SpinRateMin} to {SpinRateMax} rpm" +
                $"\n************************************");
        }
    }
}
