using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x6e6fe51c)]
    public class TLUpdateDialogPinned : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x6e6fe51c;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Pinned { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.Null)]
        public int? FolderId { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsDialogPeer Peer { get; set; }


    }
}