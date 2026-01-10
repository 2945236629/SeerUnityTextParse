using System;

namespace core.config.effectIcon
{
	// Token: 0x02002058 RID: 8280
	public class IRoot
    {
        public IEffectItem[] effect { get; set; }

        public void Parse(byte[] bytes, ref int byteIndex)
        {
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                effect = new IEffectItem[num];
                for (int i = 0; i < num; i++)
                {
                    effect[i] = new IEffectItem();
                    effect[i].Parse(bytes, ref byteIndex);
                }
            }
        }
    }
}
