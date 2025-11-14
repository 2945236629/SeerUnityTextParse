using System;

namespace core.config
{
	// Token: 0x02001F14 RID: 7956
	public class SixthousandReturnSign : XlsConfigBase<SixthousandReturnSign, ISixthousandReturnSignInfo>
	{
		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x0600EBB2 RID: 60338 RVA: 0x003F6EAD File Offset: 0x003F50AD
		public override string fileName
		{
			get
			{
				return "sixthousandReturnSign";
			}
		}

		// Token: 0x0600EBB3 RID: 60339 RVA: 0x003F6EB4 File Offset: 0x003F50B4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISixthousandReturnSignInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISixthousandReturnSignInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EBB4 RID: 60340 RVA: 0x003F6F08 File Offset: 0x003F5108
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
