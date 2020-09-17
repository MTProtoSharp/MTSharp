using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xad01d61d)]
    public class TLAuthorization : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xad01d61d;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Current { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool OfficialApp { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.True)]
        public bool PasswordPending { get; set; }
        [MTParameter(Order = 4)]
        public long Hash { get; set; }
        [MTParameter(Order = 5)]
        public string DeviceModel { get; set; }
        [MTParameter(Order = 6)]
        public string Platform { get; set; }
        [MTParameter(Order = 7)]
        public string SystemVersion { get; set; }
        [MTParameter(Order = 8)]
        public int ApiId { get; set; }
        [MTParameter(Order = 9)]
        public string AppName { get; set; }
        [MTParameter(Order = 10)]
        public string AppVersion { get; set; }
        [MTParameter(Order = 11)]
        public int DateCreated { get; set; }
        [MTParameter(Order = 12)]
        public int DateActive { get; set; }
        [MTParameter(Order = 13)]
        public string Ip { get; set; }
        [MTParameter(Order = 14)]
        public string Country { get; set; }
        [MTParameter(Order = 15)]
        public string Region { get; set; }


    }
}
