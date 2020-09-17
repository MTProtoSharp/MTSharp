using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x53577479)]
    public class TLGetNotifyExceptions : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x53577479;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 1, FlagType = FlagType.True)]
        public bool CompareSound { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.Null)]
        public TLAbsInputNotifyPeer Peer { get; set; }


    }
}
