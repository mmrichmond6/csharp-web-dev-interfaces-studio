using System;
namespace SpinningDiscs
{
    public class CD : AbstractBaseDisc, IOpticalDisc
    {
        

        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public override string MediaName { get; set; }
        public override int StorageCapacity { get; set; }
        public override string MediaContents { get; set; }
        public override string MediaDiscType { get; set; }

        public CD(string name, int capacity, string contents, string discType) : base(name, capacity, contents, discType)
        {
        }


    }
}
