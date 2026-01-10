

// GameLogic, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// core.config.NewMonsterLevel
using core.config;

public class NewMonsterLevel : XlsConfigBase<NewMonsterLevel, INewMonsterLevelInfo>
{
    public override string fileName => "new_monster_level";

    public void Parse(byte[] bytes, ref int byteIndex)
    {
        if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
        {
            int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            data = new INewMonsterLevelInfo[num];
            for (int i = 0; i < num; i++)
            {
                data[i] = new INewMonsterLevelInfo();
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
