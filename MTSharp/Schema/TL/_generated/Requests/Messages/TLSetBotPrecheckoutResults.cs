using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTSharp;
using MTSharp.Attributes;
using MTSharp.Enums;
using MTSharp.Schema;
using MTSharp.Schema.TL;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x9c2dd95)]
    public class TLSetBotPrecheckoutResults : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9c2dd95;
            }
        }

		[MTParameter(Order = 0)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FromFlag=1, FlagType= FlagType.True)]
		public bool Success { get; set; }
		[MTParameter(Order = 2)]
		public long QueryId { get; set; }
		[MTParameter(Order = 3, FromFlag=0, FlagType= FlagType.Null)]
		public string Error { get; set; }


    }
}
