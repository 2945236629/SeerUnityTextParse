using System;

namespace core.config
{
	// Token: 0x02001ECC RID: 7884
	public class PvpQuiztask : XlsConfigBase<PvpQuiztask, IPvpQuiztaskInfo>
	{
		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x0600E886 RID: 59526 RVA: 0x003F2DCD File Offset: 0x003F0FCD
		public override string fileName
		{
			get
			{
				return "pvp_quiztask";
			}
		}

		// Token: 0x0600E887 RID: 59527 RVA: 0x003F2DD4 File Offset: 0x003F0FD4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpQuiztaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpQuiztaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E888 RID: 59528 RVA: 0x003F2E28 File Offset: 0x003F1028
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
