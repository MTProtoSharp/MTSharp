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

namespace MTSharp.Schema.TL
{
    [MTObject(0x88bf9319)]
    public class TLInputBotInlineResult : TLAbsInputBotInlineResult
    {
        public override uint Constructor
        {
            get
            {
                return 0x88bf9319;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public string Id { get; set; }
		[MTParameter(Order = 2)]
		public string Type { get; set; }
		[MTParameter(Order = 3, FlagBitId=1, FlagType= FlagType.Null)]
		public string Title { get; set; }
		[MTParameter(Order = 4, FlagBitId=2, FlagType= FlagType.Null)]
		public string Description { get; set; }
		[MTParameter(Order = 5, FlagBitId=3, FlagType= FlagType.Null)]
		public string Url { get; set; }
		[MTParameter(Order = 6, FlagBitId=4, FlagType= FlagType.Null)]
		public MTSharp.Schema.TL.TLInputWebDocument Thumb { get; set; }
		[MTParameter(Order = 7, FlagBitId=5, FlagType= FlagType.Null)]
		public MTSharp.Schema.TL.TLInputWebDocument Content { get; set; }
		[MTParameter(Order = 8)]
		public TLAbsInputBotInlineMessage SendMessage { get; set; }


    }
}
