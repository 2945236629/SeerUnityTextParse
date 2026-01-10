# 使用方式

## 1、用 [AssetStudio](https://github.com/wx11-00-1/AssetStudio_Tuanjie) 导出游戏的文本资源

## 2、用 Visual Studio 打开本项目

## 3、修改 Program.cs 中的资源路径和输出路径后运行

# 更新代码

```c#
string copyTo = "C:\\Users\\17542\\source\\repos\\SeerUnityTextParse\\SeerUnityTextParse\\core\\config";
string copyFrom = "C:\\Users\\17542\\Downloads\\game\\SeerGameLogic260109\\GameLogic\\core\\config"; // dnspy 反编译出来的项目。大部分可以直接用，解析出现异常的部分，可以单独改用 ilspy 反编译的代码

var newFiles = Directory.EnumerateFiles(copyFrom)
    .ToHashSet();
var oldFiles = Directory.EnumerateFiles(copyTo)
    .Select(Path.GetFileName)
    .ToHashSet();
foreach (var f in newFiles)
{
    var fileName = Path.GetFileName(f);
    if (!oldFiles.Contains(fileName))
    {
        File.Copy(f, Path.Combine(copyTo, fileName));
        Console.WriteLine(fileName);
    }
}
Console.WriteLine("----- Folder -----");

// 复制文件夹代码有点长，不如手动复制（反正很少有新文件夹）
var newFolders = Directory.EnumerateDirectories(copyFrom)
    .ToHashSet();
var oldFolders = Directory.EnumerateDirectories(copyTo)
    .Select(Path.GetFileName)
    .ToHashSet();
foreach (var f in newFolders)
{
    var folderName = Path.GetFileName(f);
    if (!oldFolders.Contains(folderName))
    {
        Console.WriteLine(folderName);
    }
}
Console.WriteLine("ok");
```

