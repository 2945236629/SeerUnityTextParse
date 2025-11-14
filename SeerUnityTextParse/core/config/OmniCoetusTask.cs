using System;

namespace core.config
{
	// Token: 0x02001E96 RID: 7830
	public class OmniCoetusTask : XlsConfigBase<OmniCoetusTask, IOmniCoetusTaskInfo>
	{
		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x0600E654 RID: 58964 RVA: 0x003F0335 File Offset: 0x003EE535
		public override string fileName
		{
			get
			{
				return "omniCoetus_task";
			}
		}

		// Token: 0x0600E655 RID: 58965 RVA: 0x003F033C File Offset: 0x003EE53C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IOmniCoetusTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IOmniCoetusTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E656 RID: 58966 RVA: 0x003F0390 File Offset: 0x003EE590
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
