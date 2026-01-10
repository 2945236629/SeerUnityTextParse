using System;

namespace core.config
{
	// Token: 0x02001CB9 RID: 7353
	public class CivilizationGameHreoSkill : XlsConfigBase<CivilizationGameHreoSkill, ICivilizationGameHreoSkillInfo>
	{
		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x0600D828 RID: 55336 RVA: 0x003CDBEC File Offset: 0x003CBDEC
		public override string fileName
		{
			get
			{
				return "civilizationGameHreoSkill";
			}
		}

		// Token: 0x0600D829 RID: 55337 RVA: 0x003CDBF4 File Offset: 0x003CBDF4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICivilizationGameHreoSkillInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICivilizationGameHreoSkillInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D82A RID: 55338 RVA: 0x003CDC48 File Offset: 0x003CBE48
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
