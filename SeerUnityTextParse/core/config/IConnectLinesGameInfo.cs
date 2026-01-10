using System;

namespace core.config
{
	// Token: 0x02001CC2 RID: 7362
	public class IConnectLinesGameInfo : IConfigItem
	{
		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x0600D8A4 RID: 55460 RVA: 0x003CE540 File Offset: 0x003CC740
		// (set) Token: 0x0600D8A5 RID: 55461 RVA: 0x003CE548 File Offset: 0x003CC748
		public string monster { get; set; }

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x0600D8A6 RID: 55462 RVA: 0x003CE551 File Offset: 0x003CC751
		// (set) Token: 0x0600D8A7 RID: 55463 RVA: 0x003CE559 File Offset: 0x003CC759
		public string name { get; set; }

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x0600D8A8 RID: 55464 RVA: 0x003CE562 File Offset: 0x003CC762
		// (set) Token: 0x0600D8A9 RID: 55465 RVA: 0x003CE56A File Offset: 0x003CC76A
		public int id { get; set; }

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x0600D8AA RID: 55466 RVA: 0x003CE573 File Offset: 0x003CC773
		// (set) Token: 0x0600D8AB RID: 55467 RVA: 0x003CE57B File Offset: 0x003CC77B
		public int opentime { get; set; }

		// Token: 0x0600D8AC RID: 55468 RVA: 0x003CE584 File Offset: 0x003CC784
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monster = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
