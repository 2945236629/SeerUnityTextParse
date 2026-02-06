using System;

namespace core.config
{
	// Token: 0x02001EAF RID: 7855
	public class MintmarkElevare : XlsConfigBase<MintmarkElevare, IMintmarkElevareInfo>
	{
		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x0600E9C4 RID: 59844 RVA: 0x004037D5 File Offset: 0x004019D5
		public override string fileName
		{
			get
			{
				return "mintmarkElevare";
			}
		}

		// Token: 0x0600E9C5 RID: 59845 RVA: 0x004037DC File Offset: 0x004019DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMintmarkElevareInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMintmarkElevareInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E9C6 RID: 59846 RVA: 0x00403830 File Offset: 0x00401A30
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
