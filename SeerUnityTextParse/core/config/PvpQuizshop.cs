using System;

namespace core.config
{
	// Token: 0x02001ECA RID: 7882
	public class PvpQuizshop : XlsConfigBase<PvpQuizshop, IPvpQuizshopInfo>
	{
		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x0600E870 RID: 59504 RVA: 0x003F2C4B File Offset: 0x003F0E4B
		public override string fileName
		{
			get
			{
				return "pvp_quizshop";
			}
		}

		// Token: 0x0600E871 RID: 59505 RVA: 0x003F2C54 File Offset: 0x003F0E54
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpQuizshopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpQuizshopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E872 RID: 59506 RVA: 0x003F2CA8 File Offset: 0x003F0EA8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
