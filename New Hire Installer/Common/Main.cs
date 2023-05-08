using System.ComponentModel;
using System.Diagnostics;

namespace New_Hire_Installer.Common;

public class Main
{
    protected string InstallerPath { get; set; }
    protected string FolderPath { get; set; }

    protected Main(string installerPath, string folderPath)
    {
        InstallerPath = installerPath;
        FolderPath = folderPath;
    }

    protected void MsiInstaller(BackgroundWorker bw)
    {
        var msiFiles = Directory.GetFiles(InstallerPath, "*.msi");

        foreach (var installerProcess in msiFiles.Select(item => Process.Start(new ProcessStartInfo(item)
        { UseShellExecute = true, Arguments = "/quiet", WindowStyle = ProcessWindowStyle.Hidden })))
        {
            var installerName = Path.GetFileName(installerProcess.StartInfo.FileName);

            bw.ReportProgress(25, $"Installing {installerName}");

            while (!installerProcess.HasExited) installerProcess.WaitForExit();
        }
    }

    protected void CopyFoldersToC(BackgroundWorker bw)
    {
        bw.ReportProgress(10, "Copying folders to C:\\ Drive");

        var directory = new DirectoryInfo(FolderPath);
        const string destinationDir = "C:\\";


        foreach (var dir in Directory.GetDirectories(directory.FullName, "*", SearchOption.AllDirectories))
        {
            var dirToCreate = dir.Replace(directory.FullName, destinationDir);
            Directory.CreateDirectory(dirToCreate);
        }

        foreach (var newPath in Directory.GetFiles(directory.FullName, "*.*", SearchOption.AllDirectories))
            File.Copy(newPath, newPath.Replace(directory.FullName, destinationDir), true);
    }
}