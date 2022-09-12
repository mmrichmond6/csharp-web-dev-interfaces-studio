using System;
namespace SpinningDiscs
{
    public class DVD : AbstractBaseDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public override string MediaName { get; set; }
        public override string MediaContents { get; set; }

        private const string mediaDiscType = "DVD";

        public override string MediaDiscType { get { return mediaDiscType; } }

        private const int storageCapacity = 4700;
        public override int StorageCapacity { get { return storageCapacity; } }

        private const int spinRateMin = 570;
        public override int SpinRateMin { get { return spinRateMin; } }

        private const int spinRateMax = 1600;


        public override int SpinRateMax { get { return spinRateMax; } }

        public DVD(string name, string contents) : base(name, contents)
        {
        }

    }
}
