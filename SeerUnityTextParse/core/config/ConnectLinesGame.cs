using System;

namespace core.config
{
	// Token: 0x02001CC1 RID: 7361
	public class ConnectLinesGame : XlsConfigBase<ConnectLinesGame, IConnectLinesGameInfo>
	{
		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x0600D8A0 RID: 55456 RVA: 0x003CE4C3 File Offset: 0x003CC6C3
		public override string fileName
		{
			get
			{
				return "connectLinesGame";
			}
		}

		// Token: 0x0600D8A1 RID: 55457 RVA: 0x003CE4CC File Offset: 0x003CC6CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IConnectLinesGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IConnectLinesGameInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D8A2 RID: 55458 RVA: 0x003CE520 File Offset: 0x003CC720
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
