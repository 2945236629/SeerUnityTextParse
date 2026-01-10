using System;

namespace core.config
{
	// Token: 0x02001E4E RID: 7758
	public class IStory1020Info : IConfigItem
	{
		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x0600E91A RID: 59674 RVA: 0x003E2DCC File Offset: 0x003E0FCC
		// (set) Token: 0x0600E91B RID: 59675 RVA: 0x003E2DD4 File Offset: 0x003E0FD4
		public string param1 { get; set; }

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x0600E91C RID: 59676 RVA: 0x003E2DDD File Offset: 0x003E0FDD
		// (set) Token: 0x0600E91D RID: 59677 RVA: 0x003E2DE5 File Offset: 0x003E0FE5
		public string param2 { get; set; }

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x0600E91E RID: 59678 RVA: 0x003E2DEE File Offset: 0x003E0FEE
		// (set) Token: 0x0600E91F RID: 59679 RVA: 0x003E2DF6 File Offset: 0x003E0FF6
		public string param3 { get; set; }

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x0600E920 RID: 59680 RVA: 0x003E2DFF File Offset: 0x003E0FFF
		// (set) Token: 0x0600E921 RID: 59681 RVA: 0x003E2E07 File Offset: 0x003E1007
		public string param4 { get; set; }

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x0600E922 RID: 59682 RVA: 0x003E2E10 File Offset: 0x003E1010
		// (set) Token: 0x0600E923 RID: 59683 RVA: 0x003E2E18 File Offset: 0x003E1018
		public string param5 { get; set; }

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x0600E924 RID: 59684 RVA: 0x003E2E21 File Offset: 0x003E1021
		// (set) Token: 0x0600E925 RID: 59685 RVA: 0x003E2E29 File Offset: 0x003E1029
		public float control { get; set; }

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x0600E926 RID: 59686 RVA: 0x003E2E32 File Offset: 0x003E1032
		// (set) Token: 0x0600E927 RID: 59687 RVA: 0x003E2E3A File Offset: 0x003E103A
		public int id { get; set; }

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x0600E928 RID: 59688 RVA: 0x003E2E43 File Offset: 0x003E1043
		// (set) Token: 0x0600E929 RID: 59689 RVA: 0x003E2E4B File Offset: 0x003E104B
		public int logic { get; set; }

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x0600E92A RID: 59690 RVA: 0x003E2E54 File Offset: 0x003E1054
		// (set) Token: 0x0600E92B RID: 59691 RVA: 0x003E2E5C File Offset: 0x003E105C
		public int next { get; set; }

		// Token: 0x0600E92C RID: 59692 RVA: 0x003E2E68 File Offset: 0x003E1068
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.control = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.logic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.next = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
