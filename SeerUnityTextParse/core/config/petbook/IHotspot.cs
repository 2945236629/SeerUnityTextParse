using System;

namespace core.config.petbook
{
	// Token: 0x0200205C RID: 8284
	public class IHotspot
	{
		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x0600F8A2 RID: 63650 RVA: 0x0040EB37 File Offset: 0x0040CD37
		// (set) Token: 0x0600F8A3 RID: 63651 RVA: 0x0040EB3F File Offset: 0x0040CD3F
		public IItem item { get; set; }

		// Token: 0x0600F8A4 RID: 63652 RVA: 0x0040EB48 File Offset: 0x0040CD48
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
