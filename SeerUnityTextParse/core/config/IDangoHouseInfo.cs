using System;

namespace core.config
{
	// Token: 0x02001DFD RID: 7677
	public class IDangoHouseInfo : IConfigItem
	{
		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x0600E02A RID: 57386 RVA: 0x003E87B4 File Offset: 0x003E69B4
		// (set) Token: 0x0600E02B RID: 57387 RVA: 0x003E87BC File Offset: 0x003E69BC
		public string name { get; set; }

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x0600E02C RID: 57388 RVA: 0x003E87C5 File Offset: 0x003E69C5
		// (set) Token: 0x0600E02D RID: 57389 RVA: 0x003E87CD File Offset: 0x003E69CD
		public int id { get; set; }

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x0600E02E RID: 57390 RVA: 0x003E87D6 File Offset: 0x003E69D6
		// (set) Token: 0x0600E02F RID: 57391 RVA: 0x003E87DE File Offset: 0x003E69DE
		public int limitCost { get; set; }

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x0600E030 RID: 57392 RVA: 0x003E87E7 File Offset: 0x003E69E7
		// (set) Token: 0x0600E031 RID: 57393 RVA: 0x003E87EF File Offset: 0x003E69EF
		public int roomID { get; set; }

		// Token: 0x0600E032 RID: 57394 RVA: 0x003E87F8 File Offset: 0x003E69F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limitCost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.roomID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
