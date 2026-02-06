using System;

namespace core.config
{
	// Token: 0x02001E2F RID: 7727
	public class DragonboatExploratioLevel : XlsConfigBase<DragonboatExploratioLevel, IDragonboatExploratioLevelInfo>
	{
		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x0600E48C RID: 58508 RVA: 0x003FCF26 File Offset: 0x003FB126
		public override string fileName
		{
			get
			{
				return "dragonboatExploratioLevel";
			}
		}

		// Token: 0x0600E48D RID: 58509 RVA: 0x003FCF30 File Offset: 0x003FB130
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDragonboatExploratioLevelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDragonboatExploratioLevelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E48E RID: 58510 RVA: 0x003FCF84 File Offset: 0x003FB184
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
