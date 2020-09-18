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
    [MTObject(0x1b3faa88)]
    public class TLSendConfirmPhoneCode : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1b3faa88;
            }
        }

		[MTParameter(Order = 0)]
		public string Hash { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLCodeSettings Settings { get; set; }


    }
}
