using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace Ticker
{
    public class Tick : BackgroundWorker
    {
        //.NET hIgh speed timer
        Stopwatch sw = new Stopwatch();
        //State of the high speed events
        public bool Ticking { get; private set; }
        //Number of ticks per microsecond (varies by CPU)
        public readonly long TicksPerMicrosecond = Stopwatch.Frequency / 1000000L;
        //Used to time the events, default 100 microseconds
        long ticksToCount = 100L * Stopwatch.Frequency / 1000000L;
        public long TicksToCount
        {
            get { return ticksToCount; }
        }
        //Default to 100 microsecond events, good for most small routines
        long microseconds = 100L;
        //Set or get the number of microseconds for each event
        public long Microseconds
        {
            get { return Microseconds; }
            set
            {
                microseconds = value;
                ticksToCount = value * TicksPerMicrosecond;
            }
        }

        //Do the microsecond timing
        private void RunStopwatch(object sender, DoWorkEventArgs e)
        {
            //For calculating timing difference
            long nextTrigger;
            //Store difference between ticks (waits while > 0)
            long diff;
            //Toggles from 1 to 0 and sent back via ProgressChanaged
            int tick=1;   
            //Start the stopwatch
            sw.Start();
            //Store the state
            Ticking = sw.IsRunning;
            while(Ticking)
            {
                //Get interval to wait
                nextTrigger = sw.ElapsedTicks + ticksToCount;
                do
                {
                    //Don't cause a wasteful tight CPU loop
                    Thread.Sleep(0);
                    //See if interval has passed
                    diff = nextTrigger - sw.ElapsedTicks;
                } while (diff > 0);
                //Interval passed, tell UI
                ((BackgroundWorker)sender).ReportProgress(tick);
                //Toggle reported int, indicates work
                tick = (tick==0) ? 1 : 0;
            }
            //Stop and reset the stopwatch
            sw.Stop();
            sw.Reset();
        }

        //Use the constructor to setup the BackgroundWorker
        public Tick(ProgressChangedEventHandler CallOnTick)
        {
            WorkerReportsProgress = true;
            ProgressChanged += CallOnTick;
            DoWork += RunStopwatch;
        }
        //Start the high speed events
        public void Start()
        {
            if (IsBusy != true)
            {
                RunWorkerAsync();
            }
        }
        //Stop the high speed events
        public void Stop()
        {
            Ticking = false;
        }
    }
}
