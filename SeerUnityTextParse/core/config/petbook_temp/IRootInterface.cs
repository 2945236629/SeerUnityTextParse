using System;

namespace core.config.petbook_temp
{
	// Token: 0x0200204D RID: 8269
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x0600F82A RID: 63530 RVA: 0x0040E139 File Offset: 0x0040C339
		public override string fileName
		{
			get
			{
				return "petbook_temp";
			}
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x0600F82B RID: 63531 RVA: 0x0040E140 File Offset: 0x0040C340
		// (set) Token: 0x0600F82C RID: 63532 RVA: 0x0040E148 File Offset: 0x0040C348
		public IRoot root { get; set; }

		// Token: 0x0600F82D RID: 63533 RVA: 0x0040E151 File Offset: 0x0040C351
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F82E RID: 63534 RVA: 0x0040E174 File Offset: 0x0040C374
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
