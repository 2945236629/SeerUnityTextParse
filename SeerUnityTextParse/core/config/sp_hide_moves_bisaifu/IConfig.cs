using System;

namespace core.config.sp_hide_moves_bisaifu
{
	// Token: 0x02001F15 RID: 7957
	public class IConfig
    {
        public ISpMovesItem[] ShowMoves { get; set; }

        public ISpMovesItem[] SpMoves { get; set; }

        // Token: 0x0600EE4A RID: 61002 RVA: 0x003F23BC File Offset: 0x003F05BC
        public void Parse(byte[] bytes, ref int byteIndex)
		{
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                ShowMoves = new ISpMovesItem[num];
                for (int i = 0; i < num; i++)
                {
                    ShowMoves[i] = new ISpMovesItem();
                    ShowMoves[i].Parse(bytes, ref byteIndex);
                }
            }
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
                SpMoves = new ISpMovesItem[num2];
                for (int j = 0; j < num2; j++)
                {
                    SpMoves[j] = new ISpMovesItem();
                    SpMoves[j].Parse(bytes, ref byteIndex);
                }
            }
        }
	}
}
