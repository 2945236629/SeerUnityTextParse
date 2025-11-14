using System;

namespace core.config
{
	// Token: 0x02001E06 RID: 7686
	public class DangoTask : XlsConfigBase<DangoTask, IDangoTaskInfo>
	{
		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x0600E08E RID: 57486 RVA: 0x003E8EB5 File Offset: 0x003E70B5
		public override string fileName
		{
			get
			{
				return "dangoTask";
			}
		}

		// Token: 0x0600E08F RID: 57487 RVA: 0x003E8EBC File Offset: 0x003E70BC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDangoTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDangoTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E090 RID: 57488 RVA: 0x003E8F10 File Offset: 0x003E7110
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
