using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Payments
{
    [MTObject(0xd1451883)]
    public class TLValidatedRequestedInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd1451883;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.Null)]
        public string Id { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.Null)]
        public TLVector<MTSharp.Schema.TL.TLShippingOption> ShippingOptions { get; set; }


    }
}