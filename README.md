# 使用方式

## 1、用 [albi0](https://github.com/SeerAPI/albi0) 导出游戏的文本资源

参考代码（需要修改【输出目录】和【资源目录】）：

```python
import asyncio
import albi0
import os

async def main():
    # 使用上下文管理器自动管理资源
    async with albi0.session():
        # 1. 加载插件
        albi0.load_plugin('newseer')
        
        # 2. 清空输出目录
        output_dir = 'C:/Users/17542/Downloads/game/SeerSkin/TextAsset'
        if os.path.exists(output_dir):
            for root, dirs, files in os.walk(output_dir):
                for file in files:
                    os.remove(os.path.join(root, file))
        else:
            os.makedirs(output_dir)

        # 3. 提取资源
        for root, dirs, files in os.walk('C:/Software/Seer/Seer_Data/yoo/ConfigPackage'):
            for file in files:
                try:
                    await albi0.extract_assets(
                        'newseer',
                        os.path.join(root, file),
                        output_dir=output_dir,
                    )
                except Exception as e:
                    pass

asyncio.run(main())
```



## 2、用 Visual Studio 打开本项目

## 3、修改 Program.cs 中的资源路径和输出路径后运行