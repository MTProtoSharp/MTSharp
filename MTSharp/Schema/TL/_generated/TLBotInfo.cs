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
    [MTObject(0x98e81d3a)]
    public class TLBotInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x98e81d3a;
            }
        }

		[MTParameter(Order = 0)]
		public int UserId { get; set; }
		[MTParameter(Order = 1)]
		public string Description { get; set; }
		[MTParameter(Order = 2)]
		public TLVector<MTSharp.Schema.TL.TLBotCommand> Commands { get; set; }


    }
}
