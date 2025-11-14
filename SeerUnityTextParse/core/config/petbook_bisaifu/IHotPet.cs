using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02002050 RID: 8272
	public class IHotPet
	{
		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x0600F840 RID: 63552 RVA: 0x0040E2F3 File Offset: 0x0040C4F3
		// (set) Token: 0x0600F841 RID: 63553 RVA: 0x0040E2FB File Offset: 0x0040C4FB
		public IPetDataItem[] PetData { get; set; }

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x0600F842 RID: 63554 RVA: 0x0040E304 File Offset: 0x0040C504
		// (set) Token: 0x0600F843 RID: 63555 RVA: 0x0040E30C File Offset: 0x0040C50C
		public ITypeItem[] type { get; set; }

		// Token: 0x0600F844 RID: 63556 RVA: 0x0040E318 File Offset: 0x0040C518
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.PetData = new IPetDataItem[num];
				for (int i = 0; i < num; i++)
				{
					this.PetData[i] = new IPetDataItem();
					this.PetData[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.type = new ITypeItem[num2];
				for (int j = 0; j < num2; j++)
				{
					this.type[j] = new ITypeItem();
					this.type[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
