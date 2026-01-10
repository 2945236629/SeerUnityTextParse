using System;

namespace core.config
{
	// Token: 0x02001CBB RID: 7355
	public class CivilizationGameSkill : XlsConfigBase<CivilizationGameSkill, ICivilizationGameSkillInfo>
	{
		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x0600D858 RID: 55384 RVA: 0x003CDF2E File Offset: 0x003CC12E
		public override string fileName
		{
			get
			{
				return "civilizationGameSkill";
			}
		}

		// Token: 0x0600D859 RID: 55385 RVA: 0x003CDF38 File Offset: 0x003CC138
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICivilizationGameSkillInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICivilizationGameSkillInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D85A RID: 55386 RVA: 0x003CDF8C File Offset: 0x003CC18C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
