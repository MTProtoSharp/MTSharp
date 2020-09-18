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
    [MTObject(0xca05d50e)]
    public class TLInputPaymentCredentialsAndroidPay : TLAbsInputPaymentCredentials
    {
        public override uint Constructor
        {
            get
            {
                return 0xca05d50e;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.TLDataJSON PaymentToken { get; set; }
		[MTParameter(Order = 1)]
		public string GoogleTransactionId { get; set; }


    }
}
