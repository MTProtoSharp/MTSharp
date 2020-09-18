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

namespace MTSharp.Schema.TL.Requests.Bots
{
    [MTObject(0xaa2769ed)]
    public class TLSendCustomRequest : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xaa2769ed;
            }
        }

		[MTParameter(Order = 0)]
		public string CustomMethod { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLDataJSON Params { get; set; }


    }
}
