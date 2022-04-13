using System;
using System.Windows.Forms;

namespace NEYTI
{
    class QuickScan : Scan
    {
        private static int ScannedFast
        {
            get { return _scannedFast; } //determines how many files were scanned by the fast scanner, function, triggers on change
            set
            {
                _scannedFast = value;
                MainRef.lblScannedQuickSum.Invoke((new MethodInvoker(delegate { MainRef.lblScannedQuickSum.Text = value + @"/" + _overallFast; })));
            }
        }
        private static int _scannedFast; //determines how many files were scanned by the fast scanner, var
        private static int _filesCountFast; //temp filescount, used only in CountFiles. "overall" is used in other places. I don't remember why, but, I guess, there's a reason for this
        private static int _overallFast;
        protected override void OnCount()
        {
            _filesCountFast++; //increase the temp filescount with every file
            _overallFast = _filesCountFast;  //as we just changed the temp overall files count, we have to set it to the global files count

            MainRef.lblScannedQuickSum.Invoke( //change the count label
                new MethodInvoker(delegate { MainRef.lblScannedQuickSum.Text = ScannedFast + @"/" + _overallFast; }));
        }
        protected override void ScanWork()
        {
            if (_scanningWorker.CancellationPending) return;
            TreeScan(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
            if (_scanningWorker.CancellationPending) return;
            TreeScan(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            if (_scanningWorker.CancellationPending) return;
            TreeScan(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            if (_scanningWorker.CancellationPending) return;
            TreeScan(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache));
        }
        protected override void CountWork()
        {
            CountFiles(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
            CountFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            CountFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            //CountFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
            //TODO you are supposed to scan autorun.
            CountFiles(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache));
        }
        protected override void HandleErrorDetection(Exception e)
        {
            
        }
    }
}
