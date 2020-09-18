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
    [MTObject(0xa676a322)]
    public class TLInputMessageID : TLAbsInputMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0xa676a322;
            }
        }

		[MTParameter(Order = 0)]
		public int Id { get; set; }


    }
}
