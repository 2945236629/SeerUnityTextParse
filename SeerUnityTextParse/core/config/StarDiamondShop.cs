using System;

namespace core.config
{
	// Token: 0x02001F28 RID: 7976
	public class StarDiamondShop : XlsConfigBase<StarDiamondShop, IStarDiamondShopInfo>
	{
		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x0600EC7E RID: 60542 RVA: 0x003F7E9A File Offset: 0x003F609A
		public override string fileName
		{
			get
			{
				return "StarDiamondShop";
			}
		}

		// Token: 0x0600EC7F RID: 60543 RVA: 0x003F7EA4 File Offset: 0x003F60A4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStarDiamondShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStarDiamondShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EC80 RID: 60544 RVA: 0x003F7EF8 File Offset: 0x003F60F8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
