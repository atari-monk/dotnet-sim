namespace Sim.Core;

public interface IFilePath
{
    string FileFolderPath { get; }

    string FileName { get; }

    string FileExtension { get; }

    string FullPath { get; }
}