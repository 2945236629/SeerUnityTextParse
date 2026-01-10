

// GameLogic, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// core.config.ActiveSortBisaifu
using core.config;

public class ActiveSortBisaifu : XlsConfigBase<ActiveSortBisaifu, IActiveSortBisaifuInfo>
{
    public override string fileName => "active_sort_bisaifu";

    public void Parse(byte[] bytes, ref int byteIndex)
    {
        if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
        {
            int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            data = new IActiveSortBisaifuInfo[num];
            for (int i = 0; i < num; i++)
            {
                data[i] = new IActiveSortBisaifuInfo();
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
