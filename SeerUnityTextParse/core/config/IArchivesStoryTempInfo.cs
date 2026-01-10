using System;

namespace core.config
{
	// Token: 0x02001C54 RID: 7252
	public class IArchivesStoryTempInfo : IConfigItem
	{
		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x0600D382 RID: 54146 RVA: 0x003C839C File Offset: 0x003C659C
		// (set) Token: 0x0600D383 RID: 54147 RVA: 0x003C83A4 File Offset: 0x003C65A4
		public string classname { get; set; }

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x0600D384 RID: 54148 RVA: 0x003C83AD File Offset: 0x003C65AD
		// (set) Token: 0x0600D385 RID: 54149 RVA: 0x003C83B5 File Offset: 0x003C65B5
		public string monname { get; set; }

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x0600D386 RID: 54150 RVA: 0x003C83BE File Offset: 0x003C65BE
		// (set) Token: 0x0600D387 RID: 54151 RVA: 0x003C83C6 File Offset: 0x003C65C6
		public string txt { get; set; }

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x0600D388 RID: 54152 RVA: 0x003C83CF File Offset: 0x003C65CF
		// (set) Token: 0x0600D389 RID: 54153 RVA: 0x003C83D7 File Offset: 0x003C65D7
		public int[] samemonid { get; set; }

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x0600D38A RID: 54154 RVA: 0x003C83E0 File Offset: 0x003C65E0
		// (set) Token: 0x0600D38B RID: 54155 RVA: 0x003C83E8 File Offset: 0x003C65E8
		public int classid { get; set; }

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x0600D38C RID: 54156 RVA: 0x003C83F1 File Offset: 0x003C65F1
		// (set) Token: 0x0600D38D RID: 54157 RVA: 0x003C83F9 File Offset: 0x003C65F9
		public int id { get; set; }

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x0600D38E RID: 54158 RVA: 0x003C8402 File Offset: 0x003C6602
		// (set) Token: 0x0600D38F RID: 54159 RVA: 0x003C840A File Offset: 0x003C660A
		public int isrec { get; set; }

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x0600D390 RID: 54160 RVA: 0x003C8413 File Offset: 0x003C6613
		// (set) Token: 0x0600D391 RID: 54161 RVA: 0x003C841B File Offset: 0x003C661B
		public int monid { get; set; }

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x0600D392 RID: 54162 RVA: 0x003C8424 File Offset: 0x003C6624
		// (set) Token: 0x0600D393 RID: 54163 RVA: 0x003C842C File Offset: 0x003C662C
		public int storyid { get; set; }

		// Token: 0x0600D394 RID: 54164 RVA: 0x003C8438 File Offset: 0x003C6638
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.classid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.classname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isrec = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.samemonid = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.samemonid[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.storyid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.txt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
