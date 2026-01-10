

// GameLogic, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// core.config.Chapter
using core.config;

public class Chapter : XlsConfigBase<Chapter, IChapterInfo>
{
    public override string fileName => "chapter";

    public void Parse(byte[] bytes, ref int byteIndex)
    {
        if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
        {
            int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
            data = new IChapterInfo[num];
            for (int i = 0; i < num; i++)
            {
                data[i] = new IChapterInfo();
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
