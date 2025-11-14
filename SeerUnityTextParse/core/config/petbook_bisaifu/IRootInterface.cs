using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02002058 RID: 8280
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x0600F886 RID: 63622 RVA: 0x0040E8B9 File Offset: 0x0040CAB9
		public override string fileName
		{
			get
			{
				return "petbook_bisaifu";
			}
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x0600F887 RID: 63623 RVA: 0x0040E8C0 File Offset: 0x0040CAC0
		// (set) Token: 0x0600F888 RID: 63624 RVA: 0x0040E8C8 File Offset: 0x0040CAC8
		public IRoot root { get; set; }

		// Token: 0x0600F889 RID: 63625 RVA: 0x0040E8D1 File Offset: 0x0040CAD1
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F88A RID: 63626 RVA: 0x0040E8F4 File Offset: 0x0040CAF4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
