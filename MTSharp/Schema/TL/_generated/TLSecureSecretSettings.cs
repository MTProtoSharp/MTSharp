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
    [MTObject(0x1527bcac)]
    public class TLSecureSecretSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1527bcac;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsSecurePasswordKdfAlgo SecureAlgo { get; set; }
		[MTParameter(Order = 1)]
		public byte[] SecureSecret { get; set; }
		[MTParameter(Order = 2)]
		public long SecureSecretId { get; set; }


    }
}
