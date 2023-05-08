using System.ComponentModel;

namespace New_Hire_Installer.Common;

public class Worker : Main
{
    public delegate void WorkCompleteEventHandler(object sender, RunWorkerCompletedEventArgs e);

    private readonly BackgroundWorker _bw;

    public Worker(string installerPath, string folderPath) : base(installerPath, folderPath)
    {
        _bw = new BackgroundWorker
        {
            WorkerSupportsCancellation = true,
            WorkerReportsProgress = true
        };

        _bw.RunWorkerCompleted += BW_RunWorkerCompleted;
        _bw.DoWork += BW_DoWork;
        _bw.ProgressChanged += BW_ProgressChanged;
    }

    public event ProgressChangedEventHandler? ProgressChanged;

    public event WorkCompleteEventHandler? WorkComplete;

    protected void RaiseProgressChangedEvent(ProgressChangedEventArgs e) => ProgressChanged?.Invoke(this, e);

    protected void RaiseWorkCompleteEvent(RunWorkerCompletedEventArgs e) => WorkComplete?.Invoke(this, e);

    private void BW_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e) => RaiseWorkCompleteEvent(e);

    private void BW_ProgressChanged(object? sender, ProgressChangedEventArgs e) => RaiseProgressChangedEvent(e);

    public void Run() => _bw.RunWorkerAsync();

    private void BW_DoWork(object? sender, DoWorkEventArgs e)
    {
        CopyFoldersToC(_bw);


        MsiInstaller(_bw);
    }
}