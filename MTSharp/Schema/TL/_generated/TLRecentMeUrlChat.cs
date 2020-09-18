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
    [MTObject(0xa01b22f9)]
    public class TLRecentMeUrlChat : TLAbsRecentMeUrl
    {
        public override uint Constructor
        {
            get
            {
                return 0xa01b22f9;
            }
        }

		[MTParameter(Order = 0)]
		public string Url { get; set; }
		[MTParameter(Order = 1)]
		public int ChatId { get; set; }


    }
}
