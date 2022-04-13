using NEYTI.Forms.PopUpForm;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

namespace NEYTI
{
    internal class Scan
    {
        public static PopUpQuickScan MainRef;
        public static CultureInfo CurrentCultureInfo;

        private readonly BackgroundWorker _filesCountingWorker = new BackgroundWorker();
        protected readonly BackgroundWorker _scanningWorker = new BackgroundWorker();
        protected virtual void AfterAbortActions() { }
        public void EnableEverything()
        {
            //PopUpQuickScan.btnScan.Invoke(new MethodInvoker(delegate { btnScan.Enabled = true; }));
        }
        public void Start()
        {
            _filesCountingWorker.RunWorkerAsync();
            _scanningWorker.RunWorkerAsync();
        }

        protected virtual void CountWork() { } //Should be overridden in a subclass
        protected virtual void ScanWork() { }
        public void InitializeWorkers()
        {
            _filesCountingWorker.WorkerSupportsCancellation = true;
            _filesCountingWorker.DoWork += (sender, args) =>
            {
                if (_filesCountingWorker.CancellationPending) return;
                CountWork();
            };

            _filesCountingWorker.RunWorkerCompleted += (sender, args) =>
            {
                //AfterAbort();
                if (args.Error != null) // if an exception occurred during DoWork,
                    System.Windows.MessageBox.Show(args.Error.ToString()); //TODO Proper logging
            };

            _scanningWorker.WorkerSupportsCancellation = true;
            _scanningWorker.DoWork += (sender, args) =>
            {
                if (_scanningWorker.CancellationPending) return;
                ScanWork();
            };

            _scanningWorker.RunWorkerCompleted += (sender, args) =>
            {
                if (args.Error != null) // if an exception occurred during DoWork,
                    System.Windows.MessageBox.Show(args.Error.ToString()); //TODO Proper logging 2
            };
        }
        protected virtual void OnCount() { } //Should be overridden in a subclass
        protected void CountFiles(string dir2)
        {
            try
            {
                foreach (string file in Directory.GetFiles(dir2)) //gets all files from the folder
                {
                    if (_filesCountingWorker.CancellationPending) return;
                    OnCount();
                }
            }
            catch
            { /*return;*/ } //TODO proper handling

            try
            {
                foreach (string dir in Directory.GetDirectories(dir2)) //gets all folders from the folder and does the same for all of them
                {
                    if (_scanningWorker.CancellationPending) return;
                    CountFiles(dir);
                }
            }
            catch
            { /*return;*/ } //TODO proper handling 2
        }
        private static void SetThreadsCulture(Thread thread)
        {
            try
            {
                thread.CurrentCulture = CurrentCultureInfo;
                thread.CurrentUICulture = CurrentCultureInfo;
            }
            catch
            { /* ignored */ } //TODO handlers
        }

        protected virtual void HandleVirusDetection(string filePath) { } //Should be overridden in a subclass
        protected virtual void HandleSuspDetection(string filePath) { }
        protected virtual void HandleOKDetection(string filePath) { }
        protected virtual void HandleErrorDetection(Exception e) { }
        protected void TreeScan(string folder) //wheretopass determines where should LogIt(whichlog,text,whichscan) pass it. 
        {                                                     //Wheretopass determines which scan is used. See more at the LogIt definition.
            SetThreadsCulture(Thread.CurrentThread);
            try
            {
                foreach (string path in Directory.GetFiles(folder)) //gets all files' filenames from the folder
                {
                    if (_scanningWorker.CancellationPending) return;
                    string temphash = MainRef.GetSHA1(path);
                    if (MainRef.Hashes.Contains(temphash)) //checks if this hash exists, should be probably replaced, too slow
                    {
                        HandleVirusDetection(path);
                    }
                    else
                    {
                        if (MainRef.SuspHashes.Contains(temphash)) //checks if this hash exists, should be probably replaced, too slow
                        {
                            HandleSuspDetection(path);
                        }
                        else
                        {
                            if (_scanningWorker.CancellationPending) return;
                            HandleOKDetection(path);
                        }
                    }
                }
            }
            catch (ThreadAbortException) //we don't want an "thread terminated" exception to log (coz we do it by ourselves) so we check for that
            { return; }
            catch (Exception e)
            {
                HandleErrorDetection(e);
            }

            try
            {
                foreach (string dir in Directory.GetDirectories(folder)) //gets all folders from the folder and does the same for all of them
                {
                    if (_scanningWorker.CancellationPending) return;
                    TreeScan(dir);
                }
            }
            catch (ThreadAbortException) { /* we don't want an "thread terminated" exception to log (coz we do it by ourselves) so we check for that */ }
            catch (Exception e)
            {
                HandleErrorDetection(e);
            }
        }
    }
}
