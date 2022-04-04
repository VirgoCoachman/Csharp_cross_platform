using static System.Console;

object obj = 3;
int j = 4;

if (obj is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("obj is not an int so it can't multiply!");
}

string path = @"/home/virgocoachman/Documents/Workspace/Training/C#/Csharp_cross_platform/chapitre03-vscode/Exercice02";

Write("Press R for read-only or W for writeable : ");
ConsoleKeyInfo key = ReadKey();
WriteLine();

Stream? stream;

if (key.Key == ConsoleKey.R)
{
    stream = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Read);
}
else
{
    stream = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Write);
}

string message;

switch (stream)
{
    case FileStream writeableFile when stream.CanWrite:
        message = "The stream is a file that I can write to.";
        break;
    case FileStream readOnlyFile:
        message = "The stream is a read-only file.";
        break;
    case MemoryStream ms:
        message = "The stream is a memoy address.";
        break;
    default:
        message = "The stream is some other type.";
        break;
    case null:
        message = "The stream is null.";
    break;
}

WriteLine(message);

message = stream switch
{
    FileStream writeableFile when stream.CanWrite
        => "The stream is a file that I can write to.",
    FileStream readOnlyFile
        => "The stream is a read-only file.",
    MemoryStream ms 
        => "The stream is a memory address.",
    null
        => "The stream is null.",
    _
        => "The stream is some other type"
};

WriteLine(message);