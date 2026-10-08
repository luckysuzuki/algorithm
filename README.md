# C# 算法练习

每道题一个文件夹，文件夹内只保留 `Program.cs`。使用 .NET 10 的单文件应用，不需要 `.sln`、`.csproj`、Worker、配置文件或第三方包。

```text
algorithm/
├── .vscode/
│   ├── settings.json   # C# 单文件识别
│   └── tasks.json      # 所有题目共用的编译、运行任务
├── 1_TwoSum/
│   └── Program.cs
└── README.md
```

## 创建下一道题

在 VS Code 中打开整个 `D:\algorithm` 文件夹。在集成终端执行：

```powershell
Copy-Item -LiteralPath .\1_TwoSum -Destination .\2_AddTwoNumbers -Recurse
```

目标文件夹应使用一个尚未存在的新名称。复制后打开新题目的 `Program.cs`，修改测试输入、方法调用和 `Solution` 类。

也可以在 VS Code 资源管理器里复制、粘贴 `1_TwoSum` 文件夹，再重命名。不需要运行 `dotnet new`；它会创建传统项目。

从零开始时，新建文件夹和 `Program.cs`，写入：

```csharp
#:property PublishAot=false

using System;

new Solution().Solve();

public class Solution
{
    public void Solve()
    {
        Console.WriteLine("在这里写算法和测试");
    }
}
```

第一行关闭 AOT 发布选项，避免普通刷题也需要还原额外的 AOT 工具包；日常编译运行不需要 AOT。

## 在 VS Code 编译和运行

本机已安装 .NET 10 SDK、C# 和 C# Dev Kit 扩展。打开 `D:\algorithm`，让根目录的 `.vscode` 配置生效。如果此前已经打开过旧项目，可在命令面板执行 `Developer: Reload Window` 刷新识别。

1. 打开要运行的 `Program.cs`，按 `Ctrl+S` 保存，保持这个文件为当前编辑器。
2. **只编译**：按 `Ctrl+Shift+B`，使用默认任务 `C#: Build current file`。
3. **编译并运行**：按 `Ctrl+Shift+P`，执行 `Tasks: Run Task`（任务: 运行任务），选择 `C#: Run current file`。
4. 结果显示在集成终端；`Console.ReadLine()` 也在这个终端输入。运行会自动编译，无需先执行第 2 步。

如果快捷键被其他扩展修改，可通过命令面板执行 `Tasks: Run Build Task`（任务: 运行生成任务）来编译。

任务使用当前文件路径，因此以后添加的题目无需修改配置。运行任务前要选中 `.cs` 文件，不要停留在 README 或 JSON 文件。

也可以直接在 VS Code 集成终端运行：

```powershell
# 在 D:\algorithm 下执行：只编译
dotnet build .\1_TwoSum\Program.cs

# 自动编译并运行
dotnet run --file .\1_TwoSum\Program.cs
```

Two Sum 示例的预期输出是 `[0, 1]`。文件上半部分是本地测试入口，下半部分是 `Solution` 类；提交到 LeetCode 时通常只提交 `Solution` 类，不提交本地测试入口或 `#:property` 指令。

编译产物由 SDK 放在系统临时目录中，不会在每道题目录生成 `bin`、`obj`。可以用 `dotnet clean .\1_TwoSum\Program.cs` 清理这道题的编译产物。

## 以后需要传统项目时

如果希望改用传统项目结构，最小的普通控制台项目只需要 `Program.cs` 和一个 `.csproj`，用 `dotnet new console -n MyExercise` 创建。单文件模式更适合当前每道题独立运行的用法。

官方说明：[.NET 单文件应用](https://learn.microsoft.com/en-us/dotnet/core/sdk/file-based-apps)。
