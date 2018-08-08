using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Ticker;

namespace TickerDemo
{
    public partial class Form1 : Form
    {
        //The Dice
        Random Dice = new Random();
        //Store count of rolls
        long[] Rolls = { 0, 0, 0, 0, 0, 0 };
        //High speed ticker for the simulation
        Tick Ticker;

        public Form1()
        {
            InitializeComponent();
            Ticker = new Tick(ProcessTick);
        }

        void ProcessTick(object sender, ProgressChangedEventArgs e)
        {
            Rolls[Dice.Next(0, 6)]++;
        }

        long[] Values;  //store total value of each number
        long rolls;     //number of rolls
        long sum;       //sum of all rolls values
        double mean;    //mean roll
        //For roll rate
        DateTime Current=DateTime.MinValue;
        TimeSpan Diff;
        private void TmrScreenUpdate_Tick(object sender, EventArgs e)
        {
            //Update screen
            LblOneCount.Text = Rolls[0].ToString();
            LblTwoCount.Text = Rolls[1].ToString();
            LblThreeCount.Text = Rolls[2].ToString();
            LblFourCount.Text = Rolls[3].ToString();
            LblFiveCount.Text = Rolls[4].ToString();
            LblSixCount.Text = Rolls[5].ToString();
            //Total rolls
            rolls = Rolls.Sum();
            //For each number multiple by index for total number value rolled
            Values = Rolls.Select((rolls, index) => rolls * (index + 1)).ToArray();
            //Sum all values
            sum = Values.Sum();
            //Mean value
            mean = (double)sum / (double)rolls;
            //Calculate rolls per second
            if(Current==DateTime.MinValue && Ticker.Ticking)
                Current = DateTime.Now;
            //Update stats
            LblStats.Text = $"Total of all rolls={sum}";
            if (mean >= 0)
                LblStats.Text += $"\nMean roll={mean:N2}";
            if(rolls>0)
            {
                Diff = DateTime.Now - Current;
                LblStats.Text += $"\nRolls per second={rolls/Diff.TotalSeconds:N0}";
            }
        }

        //Start dice simulation
        private void ButStart_Click(object sender, EventArgs e)
        {
            Ticker.Start();
            TmrScreenUpdate.Enabled = true;
        }
        //Stop simulation
        private void ButStop_Click(object sender, EventArgs e)
        {
            TmrScreenUpdate.Enabled = false;
            Ticker.Stop();
        }
        //Reset dice rolls
        private void ButReset_Click(object sender, EventArgs e)
        {
            ButStop_Click(ButReset, e);
            for (int i = 0; i < 6; i++)
                Rolls[i] = 0;
            Current = DateTime.MinValue;
            TmrScreenUpdate_Tick(ButReset, e);
        }
    }
}
