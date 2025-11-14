using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02002051 RID: 8273
	public class IHotspot
	{
		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x0600F846 RID: 63558 RVA: 0x0040E3B7 File Offset: 0x0040C5B7
		// (set) Token: 0x0600F847 RID: 63559 RVA: 0x0040E3BF File Offset: 0x0040C5BF
		public IItem item { get; set; }

		// Token: 0x0600F848 RID: 63560 RVA: 0x0040E3C8 File Offset: 0x0040C5C8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.item = new IItem();
				this.item.Parse(bytes, ref byteIndex);
			}
		}
	}
}
