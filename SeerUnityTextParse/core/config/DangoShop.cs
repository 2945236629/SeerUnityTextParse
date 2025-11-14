using System;

namespace core.config
{
	// Token: 0x02001E00 RID: 7680
	public class DangoShop : XlsConfigBase<DangoShop, IDangoShopInfo>
	{
		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x0600E050 RID: 57424 RVA: 0x003E8A58 File Offset: 0x003E6C58
		public override string fileName
		{
			get
			{
				return "dangoShop";
			}
		}

		// Token: 0x0600E051 RID: 57425 RVA: 0x003E8A60 File Offset: 0x003E6C60
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDangoShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDangoShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E052 RID: 57426 RVA: 0x003E8AB4 File Offset: 0x003E6CB4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
