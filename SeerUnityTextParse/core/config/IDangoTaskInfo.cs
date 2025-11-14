using System;

namespace core.config
{
	// Token: 0x02001E07 RID: 7687
	public class IDangoTaskInfo : IConfigItem
	{
		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x0600E092 RID: 57490 RVA: 0x003E8F30 File Offset: 0x003E7130
		// (set) Token: 0x0600E093 RID: 57491 RVA: 0x003E8F38 File Offset: 0x003E7138
		public string describe { get; set; }

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x0600E094 RID: 57492 RVA: 0x003E8F41 File Offset: 0x003E7141
		// (set) Token: 0x0600E095 RID: 57493 RVA: 0x003E8F49 File Offset: 0x003E7149
		public string planet { get; set; }

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x0600E096 RID: 57494 RVA: 0x003E8F52 File Offset: 0x003E7152
		// (set) Token: 0x0600E097 RID: 57495 RVA: 0x003E8F5A File Offset: 0x003E715A
		public string taskSkin { get; set; }

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x0600E098 RID: 57496 RVA: 0x003E8F63 File Offset: 0x003E7163
		// (set) Token: 0x0600E099 RID: 57497 RVA: 0x003E8F6B File Offset: 0x003E716B
		public string title { get; set; }

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x0600E09A RID: 57498 RVA: 0x003E8F74 File Offset: 0x003E7174
		// (set) Token: 0x0600E09B RID: 57499 RVA: 0x003E8F7C File Offset: 0x003E717C
		public int id { get; set; }

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x0600E09C RID: 57500 RVA: 0x003E8F85 File Offset: 0x003E7185
		// (set) Token: 0x0600E09D RID: 57501 RVA: 0x003E8F8D File Offset: 0x003E718D
		public int limit { get; set; }

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x0600E09E RID: 57502 RVA: 0x003E8F96 File Offset: 0x003E7196
		// (set) Token: 0x0600E09F RID: 57503 RVA: 0x003E8F9E File Offset: 0x003E719E
		public int NewMsglogId { get; set; }

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x0600E0A0 RID: 57504 RVA: 0x003E8FA7 File Offset: 0x003E71A7
		// (set) Token: 0x0600E0A1 RID: 57505 RVA: 0x003E8FAF File Offset: 0x003E71AF
		public int rewardinfo { get; set; }

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x0600E0A2 RID: 57506 RVA: 0x003E8FB8 File Offset: 0x003E71B8
		// (set) Token: 0x0600E0A3 RID: 57507 RVA: 0x003E8FC0 File Offset: 0x003E71C0
		public int taskTeam { get; set; }

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x0600E0A4 RID: 57508 RVA: 0x003E8FC9 File Offset: 0x003E71C9
		// (set) Token: 0x0600E0A5 RID: 57509 RVA: 0x003E8FD1 File Offset: 0x003E71D1
		public int tasktype { get; set; }

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x0600E0A6 RID: 57510 RVA: 0x003E8FDA File Offset: 0x003E71DA
		// (set) Token: 0x0600E0A7 RID: 57511 RVA: 0x003E8FE2 File Offset: 0x003E71E2
		public int time { get; set; }

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x0600E0A8 RID: 57512 RVA: 0x003E8FEB File Offset: 0x003E71EB
		// (set) Token: 0x0600E0A9 RID: 57513 RVA: 0x003E8FF3 File Offset: 0x003E71F3
		public int value { get; set; }

		// Token: 0x0600E0AA RID: 57514 RVA: 0x003E8FFC File Offset: 0x003E71FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.NewMsglogId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.planet = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.taskSkin = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.taskTeam = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
