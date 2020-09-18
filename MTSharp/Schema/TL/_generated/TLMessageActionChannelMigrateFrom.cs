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
    [MTObject(0xb055eaee)]
    public class TLMessageActionChannelMigrateFrom : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xb055eaee;
            }
        }

		[MTParameter(Order = 0)]
		public string Title { get; set; }
		[MTParameter(Order = 1)]
		public int ChatId { get; set; }


    }
}
