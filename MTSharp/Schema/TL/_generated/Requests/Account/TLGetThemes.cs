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

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x285946f8)]
    public class TLGetThemes : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x285946f8;
            }
        }

		[MTParameter(Order = 0)]
		public string Format { get; set; }
		[MTParameter(Order = 1)]
		public int Hash { get; set; }


    }
}
