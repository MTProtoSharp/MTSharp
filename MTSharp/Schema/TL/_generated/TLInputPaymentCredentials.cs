using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x3417d728)]
    public class TLInputPaymentCredentials : TLAbsInputPaymentCredentials
    {
        public override uint Constructor
        {
            get
            {
                return 0x3417d728;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Save { get; set; }
        [MTParameter(Order = 2)]
        public MTSharp.Schema.TL.TLDataJSON Data { get; set; }


    }
}
