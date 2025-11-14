using System;

namespace core.config.petbook_temp
{
	// Token: 0x02002045 RID: 8261
	public class IHotPet
	{
		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x0600F7E2 RID: 63458 RVA: 0x0040DB4F File Offset: 0x0040BD4F
		// (set) Token: 0x0600F7E3 RID: 63459 RVA: 0x0040DB57 File Offset: 0x0040BD57
		public IPetDataItem[] PetData { get; set; }

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x0600F7E4 RID: 63460 RVA: 0x0040DB60 File Offset: 0x0040BD60
		// (set) Token: 0x0600F7E5 RID: 63461 RVA: 0x0040DB68 File Offset: 0x0040BD68
		public ITypeItem[] type { get; set; }

		// Token: 0x0600F7E6 RID: 63462 RVA: 0x0040DB74 File Offset: 0x0040BD74
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
