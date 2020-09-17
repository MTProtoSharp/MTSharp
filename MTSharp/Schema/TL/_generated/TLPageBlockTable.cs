using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xbf4dea82)]
    public class TLPageBlockTable : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xbf4dea82;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Bordered { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool Striped { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsRichText Title { get; set; }
        [MTParameter(Order = 4)]
        public TLVector<MTSharp.Schema.TL.TLPageTableRow> Rows { get; set; }


    }
}