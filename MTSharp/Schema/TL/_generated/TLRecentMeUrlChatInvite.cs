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
    [MTObject(0xeb49081d)]
    public class TLRecentMeUrlChatInvite : TLAbsRecentMeUrl
    {
        public override uint Constructor
        {
            get
            {
                return 0xeb49081d;
            }
        }

		[MTParameter(Order = 0)]
		public string Url { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsChatInvite ChatInvite { get; set; }


    }
}
