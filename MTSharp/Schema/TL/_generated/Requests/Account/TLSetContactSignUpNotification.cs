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
    [MTObject(0xcff43f61)]
    public class TLSetContactSignUpNotification : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcff43f61;
            }
        }

		[MTParameter(Order = 0)]
		public bool Silent { get; set; }


    }
}
