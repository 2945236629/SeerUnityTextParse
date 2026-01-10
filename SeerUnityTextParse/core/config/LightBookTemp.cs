using System;

namespace core.config
{
	// Token: 0x02001D4F RID: 7503
	public class LightBookTemp : XlsConfigBase<LightBookTemp, ILightBookTempInfo>
	{
		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x0600DDF6 RID: 56822 RVA: 0x003D4E27 File Offset: 0x003D3027
		public override string fileName
		{
			get
			{
				return "light_book_temp";
			}
		}

		// Token: 0x0600DDF7 RID: 56823 RVA: 0x003D4E30 File Offset: 0x003D3030
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILightBookTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILightBookTempInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DDF8 RID: 56824 RVA: 0x003D4E84 File Offset: 0x003D3084
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
