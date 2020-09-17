using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x1d2652ee)]
    public class TLFinishTakeoutSession : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1d2652ee;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Success { get; set; }


    }
}