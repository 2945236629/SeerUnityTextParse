using System;

namespace core.config
{
	// Token: 0x02001E77 RID: 7799
	public class IndianaSpirit : XlsConfigBase<IndianaSpirit, IIndianaSpiritInfo>
	{
		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x0600E77E RID: 59262 RVA: 0x00400A43 File Offset: 0x003FEC43
		public override string fileName
		{
			get
			{
				return "IndianaSpirit";
			}
		}

		// Token: 0x0600E77F RID: 59263 RVA: 0x00400A4C File Offset: 0x003FEC4C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IIndianaSpiritInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IIndianaSpiritInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E780 RID: 59264 RVA: 0x00400AA0 File Offset: 0x003FECA0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
