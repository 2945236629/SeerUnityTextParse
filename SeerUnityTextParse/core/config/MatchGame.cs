using System;

namespace core.config
{
	// Token: 0x02001D6B RID: 7531
	public class MatchGame : XlsConfigBase<MatchGame, IMatchGameInfo>
	{
		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x0600DF38 RID: 57144 RVA: 0x003D67FE File Offset: 0x003D49FE
		public override string fileName
		{
			get
			{
				return "match_game";
			}
		}

		// Token: 0x0600DF39 RID: 57145 RVA: 0x003D6808 File Offset: 0x003D4A08
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMatchGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMatchGameInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DF3A RID: 57146 RVA: 0x003D685C File Offset: 0x003D4A5C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
