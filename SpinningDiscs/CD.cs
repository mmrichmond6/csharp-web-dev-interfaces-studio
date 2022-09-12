using System;
namespace SpinningDiscs
{
    public class CD : AbstractBaseDisc
    {


        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 


        public override string MediaName { get; set; }
        public override string MediaContents { get; set; }

        private const string mediaDiscType = "CD";

        public override string MediaDiscType { get { return mediaDiscType; } }

        private const int storageCapacity = 700;
        public override int StorageCapacity { get { return storageCapacity; } }

        private const int spinRateMin = 200;
        public override int SpinRateMin { get { return spinRateMin; } }

        private const int spinRateMax = 500;

        
        public override int SpinRateMax { get { return spinRateMax; } }

        public CD(string name, string contents) : base(name, contents)
        {
        }


    }
}
