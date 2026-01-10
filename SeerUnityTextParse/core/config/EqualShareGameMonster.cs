using System;

namespace core.config
{
	// Token: 0x02001D0D RID: 7437
	public class EqualShareGameMonster : XlsConfigBase<EqualShareGameMonster, IEqualShareGameMonsterInfo>
	{
		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x0600DB6E RID: 56174 RVA: 0x003D1A79 File Offset: 0x003CFC79
		public override string fileName
		{
			get
			{
				return "equalShareGameMonster";
			}
		}

		// Token: 0x0600DB6F RID: 56175 RVA: 0x003D1A80 File Offset: 0x003CFC80
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IEqualShareGameMonsterInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IEqualShareGameMonsterInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DB70 RID: 56176 RVA: 0x003D1AD4 File Offset: 0x003CFCD4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
