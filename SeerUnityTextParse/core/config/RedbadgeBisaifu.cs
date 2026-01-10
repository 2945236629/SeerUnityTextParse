

// GameLogic, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// core.config.RedbadgeBisaifu
using core.config;

public class RedbadgeBisaifu : XlsConfigBase<RedbadgeBisaifu, IRedbadgeBisaifuInfo>
{
    public override string fileName => "redbadge_bisaifu";

    public void Parse(byte[] bytes, ref int byteIndex)
    {
        if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
        {
            int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            data = new IRedbadgeBisaifuInfo[num];
            for (int i = 0; i < num; i++)
            {
                data[i] = new IRedbadgeBisaifuInfo();
                data[i].Parse(bytes, ref byteIndex);
            }
        }
    }

    public override void Parse(byte[] bytes)
    {
        int byteIndex = 0;
        Parse(bytes, ref byteIndex);
    }
}
