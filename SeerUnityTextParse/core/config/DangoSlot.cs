using System;

namespace core.config
{
	// Token: 0x02001E02 RID: 7682
	public class DangoSlot : XlsConfigBase<DangoSlot, IDangoSlotInfo>
	{
		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x0600E072 RID: 57458 RVA: 0x003E8CAB File Offset: 0x003E6EAB
		public override string fileName
		{
			get
			{
				return "dangoSlot";
			}
		}

		// Token: 0x0600E073 RID: 57459 RVA: 0x003E8CB4 File Offset: 0x003E6EB4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDangoSlotInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDangoSlotInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E074 RID: 57460 RVA: 0x003E8D08 File Offset: 0x003E6F08
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
