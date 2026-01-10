using System;

namespace core.config
{
	// Token: 0x02001D0F RID: 7439
	public class EqualShareGameShow : XlsConfigBase<EqualShareGameShow, IEqualShareGameShowInfo>
	{
		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x0600DB7E RID: 56190 RVA: 0x003D1BA2 File Offset: 0x003CFDA2
		public override string fileName
		{
			get
			{
				return "equalShareGameShow";
			}
		}

		// Token: 0x0600DB7F RID: 56191 RVA: 0x003D1BAC File Offset: 0x003CFDAC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IEqualShareGameShowInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IEqualShareGameShowInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DB80 RID: 56192 RVA: 0x003D1C00 File Offset: 0x003CFE00
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
