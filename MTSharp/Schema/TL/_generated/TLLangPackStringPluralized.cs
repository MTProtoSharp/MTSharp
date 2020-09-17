using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x6c47ac9f)]
    public class TLLangPackStringPluralized : TLAbsLangPackString
    {
        public override uint Constructor
        {
            get
            {
                return 0x6c47ac9f;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Key { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.Null)]
        public string ZeroValue { get; set; }
        [MTParameter(Order = 3, FromFlag = 1, FlagType = FlagType.Null)]
        public string OneValue { get; set; }
        [MTParameter(Order = 4, FromFlag = 2, FlagType = FlagType.Null)]
        public string TwoValue { get; set; }
        [MTParameter(Order = 5, FromFlag = 3, FlagType = FlagType.Null)]
        public string FewValue { get; set; }
        [MTParameter(Order = 6, FromFlag = 4, FlagType = FlagType.Null)]
        public string ManyValue { get; set; }
        [MTParameter(Order = 7)]
        public string OtherValue { get; set; }


    }
}
