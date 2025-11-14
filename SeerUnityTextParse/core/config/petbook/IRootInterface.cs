using System;

namespace core.config.petbook
{
	// Token: 0x02002063 RID: 8291
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x0600F8E2 RID: 63714 RVA: 0x0040F039 File Offset: 0x0040D239
		public override string fileName
		{
			get
			{
				return "petbook";
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x0600F8E3 RID: 63715 RVA: 0x0040F040 File Offset: 0x0040D240
		// (set) Token: 0x0600F8E4 RID: 63716 RVA: 0x0040F048 File Offset: 0x0040D248
		public IRoot root { get; set; }

		// Token: 0x0600F8E5 RID: 63717 RVA: 0x0040F051 File Offset: 0x0040D251
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F8E6 RID: 63718 RVA: 0x0040F074 File Offset: 0x0040D274
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
