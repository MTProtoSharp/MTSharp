using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xeeca5ce3)]
    public class TLLangPackLanguage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xeeca5ce3;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Official { get; set; }
        [MTParameter(Order = 2, FromFlag = 2, FlagType = FlagType.True)]
        public bool Rtl { get; set; }
        [MTParameter(Order = 3, FromFlag = 3, FlagType = FlagType.True)]
        public bool Beta { get; set; }
        [MTParameter(Order = 4)]
        public string Name { get; set; }
        [MTParameter(Order = 5)]
        public string NativeName { get; set; }
        [MTParameter(Order = 6)]
        public string LangCode { get; set; }
        [MTParameter(Order = 7, FromFlag = 1, FlagType = FlagType.Null)]
        public string BaseLangCode { get; set; }
        [MTParameter(Order = 8)]
        public string PluralCode { get; set; }
        [MTParameter(Order = 9)]
        public int StringsCount { get; set; }
        [MTParameter(Order = 10)]
        public int TranslatedCount { get; set; }
        [MTParameter(Order = 11)]
        public string TranslationsUrl { get; set; }


    }
}
