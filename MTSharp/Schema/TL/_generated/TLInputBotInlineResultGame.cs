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
    [MTObject(0x4fa417f2)]
    public class TLInputBotInlineResultGame : TLAbsInputBotInlineResult
    {
        public override uint Constructor
        {
            get
            {
                return 0x4fa417f2;
            }
        }

		[MTParameter(Order = 0)]
		public string Id { get; set; }
		[MTParameter(Order = 1)]
		public string ShortName { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsInputBotInlineMessage SendMessage { get; set; }


    }
}
