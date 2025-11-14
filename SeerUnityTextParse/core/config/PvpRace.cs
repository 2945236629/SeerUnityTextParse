using System;

namespace core.config
{
	// Token: 0x02001ECE RID: 7886
	public class PvpRace : XlsConfigBase<PvpRace, IPvpRaceInfo>
	{
		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x0600E896 RID: 59542 RVA: 0x003F2F2F File Offset: 0x003F112F
		public override string fileName
		{
			get
			{
				return "pvp_race";
			}
		}

		// Token: 0x0600E897 RID: 59543 RVA: 0x003F2F38 File Offset: 0x003F1138
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpRaceInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpRaceInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E898 RID: 59544 RVA: 0x003F2F8C File Offset: 0x003F118C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
