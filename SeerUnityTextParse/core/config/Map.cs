

// GameLogic, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// core.config.Map
using core.config;

public class Map : XlsConfigBase<Map, IMapInfo>
{
    public override string fileName => "map";

    public void Parse(byte[] bytes, ref int byteIndex)
    {
        if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
        {
            int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            data = new IMapInfo[num];
            for (int i = 0; i < num; i++)
            {
                data[i] = new IMapInfo();
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
