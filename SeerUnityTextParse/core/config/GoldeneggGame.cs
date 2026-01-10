using System;

namespace core.config
{
	// Token: 0x02001D33 RID: 7475
	public class GoldeneggGame : XlsConfigBase<GoldeneggGame, IGoldeneggGameInfo>
	{
		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x0600DCF6 RID: 56566 RVA: 0x003D39D7 File Offset: 0x003D1BD7
		public override string fileName
		{
			get
			{
				return "goldeneggGame";
			}
		}

		// Token: 0x0600DCF7 RID: 56567 RVA: 0x003D39E0 File Offset: 0x003D1BE0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IGoldeneggGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IGoldeneggGameInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DCF8 RID: 56568 RVA: 0x003D3A34 File Offset: 0x003D1C34
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
