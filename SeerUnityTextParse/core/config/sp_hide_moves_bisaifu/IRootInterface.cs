using System;

namespace core.config.sp_hide_moves_bisaifu
{
    // Token: 0x02001F0E RID: 7950
    public class IRootInterface : ConfigBase<IRootInterface>
    {
        // Token: 0x17001C1F RID: 7199
        // (get) Token: 0x0600F0E6 RID: 61670 RVA: 0x003F43FB File Offset: 0x003F25FB
        public override string fileName
        {
            get
            {
                return "sp_hide_moves_bisaifu";
            }
        }

        // Token: 0x17001C20 RID: 7200
        // (get) Token: 0x0600F0E7 RID: 61671 RVA: 0x003F4402 File Offset: 0x003F2602
        // (set) Token: 0x0600F0E8 RID: 61672 RVA: 0x003F440A File Offset: 0x003F260A
        public IConfig config { get; set; }

        // Token: 0x0600F0E9 RID: 61673 RVA: 0x003F4413 File Offset: 0x003F2613
        public void Parse(byte[] bytes, ref int byteIndex)
        {
            if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
            {
                this.config = new IConfig();
                this.config.Parse(bytes, ref byteIndex);
            }
        }

        // Token: 0x0600F0EA RID: 61674 RVA: 0x003F4438 File Offset: 0x003F2638
        public override void Parse(byte[] bytes)
        {
            int num = 0;
            this.Parse(bytes, ref num);
        }
    }
}
