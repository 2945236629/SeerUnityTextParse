using System;

namespace core.config
{
	// Token: 0x02001E68 RID: 7784
	public class ISunmoonStageInfo : IConfigItem
	{
		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x0600EA52 RID: 59986 RVA: 0x003E4488 File Offset: 0x003E2688
		// (set) Token: 0x0600EA53 RID: 59987 RVA: 0x003E4490 File Offset: 0x003E2690
		public string career { get; set; }

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x0600EA54 RID: 59988 RVA: 0x003E4499 File Offset: 0x003E2699
		// (set) Token: 0x0600EA55 RID: 59989 RVA: 0x003E44A1 File Offset: 0x003E26A1
		public string openx { get; set; }

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x0600EA56 RID: 59990 RVA: 0x003E44AA File Offset: 0x003E26AA
		// (set) Token: 0x0600EA57 RID: 59991 RVA: 0x003E44B2 File Offset: 0x003E26B2
		public int id { get; set; }

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x0600EA58 RID: 59992 RVA: 0x003E44BB File Offset: 0x003E26BB
		// (set) Token: 0x0600EA59 RID: 59993 RVA: 0x003E44C3 File Offset: 0x003E26C3
		public int initial { get; set; }

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x0600EA5A RID: 59994 RVA: 0x003E44CC File Offset: 0x003E26CC
		// (set) Token: 0x0600EA5B RID: 59995 RVA: 0x003E44D4 File Offset: 0x003E26D4
		public int stageid { get; set; }

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x0600EA5C RID: 59996 RVA: 0x003E44DD File Offset: 0x003E26DD
		// (set) Token: 0x0600EA5D RID: 59997 RVA: 0x003E44E5 File Offset: 0x003E26E5
		public int stagetype { get; set; }

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x0600EA5E RID: 59998 RVA: 0x003E44EE File Offset: 0x003E26EE
		// (set) Token: 0x0600EA5F RID: 59999 RVA: 0x003E44F6 File Offset: 0x003E26F6
		public int times { get; set; }

		// Token: 0x0600EA60 RID: 60000 RVA: 0x003E4500 File Offset: 0x003E2700
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.career = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.initial = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.openx = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stageid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stagetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.times = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
