using System;

namespace core.config
{
	// Token: 0x02001DE0 RID: 7648
	public class InsectFormation : XlsConfigBase<InsectFormation, IInsectFormationInfo>
	{
		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x0600E2A9 RID: 58025 RVA: 0x003E8EB3 File Offset: 0x003E70B3
		public override string fileName
		{
			get
			{
				return "insectFormation";
			}
		}

		// Token: 0x0600E2AA RID: 58026 RVA: 0x003E8EBC File Offset: 0x003E70BC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IInsectFormationInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IInsectFormationInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E2AB RID: 58027 RVA: 0x003E8F10 File Offset: 0x003E7110
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
