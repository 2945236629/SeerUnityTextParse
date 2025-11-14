using System;

namespace core.config.petbook
{
	// Token: 0x0200205B RID: 8283
	public class IHotPet
	{
		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x0600F89C RID: 63644 RVA: 0x0040EA73 File Offset: 0x0040CC73
		// (set) Token: 0x0600F89D RID: 63645 RVA: 0x0040EA7B File Offset: 0x0040CC7B
		public IPetDataItem[] PetData { get; set; }

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x0600F89E RID: 63646 RVA: 0x0040EA84 File Offset: 0x0040CC84
		// (set) Token: 0x0600F89F RID: 63647 RVA: 0x0040EA8C File Offset: 0x0040CC8C
		public ITypeItem[] type { get; set; }

		// Token: 0x0600F8A0 RID: 63648 RVA: 0x0040EA98 File Offset: 0x0040CC98
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
