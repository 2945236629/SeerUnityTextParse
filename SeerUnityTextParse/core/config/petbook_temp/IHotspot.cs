using System;

namespace core.config.petbook_temp
{
	// Token: 0x02002046 RID: 8262
	public class IHotspot
	{
		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x0600F7E8 RID: 63464 RVA: 0x0040DC13 File Offset: 0x0040BE13
		// (set) Token: 0x0600F7E9 RID: 63465 RVA: 0x0040DC1B File Offset: 0x0040BE1B
		public IItem item { get; set; }

		// Token: 0x0600F7EA RID: 63466 RVA: 0x0040DC24 File Offset: 0x0040BE24
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
