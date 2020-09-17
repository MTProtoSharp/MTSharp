using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xabe9affe)]
    public class TLMessageActionBotAllowed : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xabe9affe;
            }
        }

        [MTParameter(Order = 0)]
        public string Domain { get; set; }


    }
}
