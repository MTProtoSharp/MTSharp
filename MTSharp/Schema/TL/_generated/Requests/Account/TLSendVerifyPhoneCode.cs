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
    [MTObject(0xa5a356f9)]
    public class TLSendVerifyPhoneCode : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa5a356f9;
            }
        }

		[MTParameter(Order = 0)]
		public string PhoneNumber { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLCodeSettings Settings { get; set; }


    }
}
