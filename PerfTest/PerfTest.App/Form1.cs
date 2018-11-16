using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace PerfTest.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if(System.Configuration.ConfigurationManager.ConnectionStrings["Default"] != null && !String.IsNullOrWhiteSpace(System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                txtConnectionString.Text = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            }
        }



        private async void btStart_Click(object sender, EventArgs e)
        {
            txtConnectionString.ReadOnly = true;
            txtIterations.ReadOnly = true;
            txtMaxThreads.ReadOnly = true;
            txtThreadCreationWaitTimeMs.ReadOnly = true;
            btStart.Enabled = false;
            btStop.Enabled = true;

            txtEndTime.Text = "";
            txtStartTime.Text = "";
            txtAverageThreadTime.Text = "";
            txtShortestThreadTime.Text = "";
            txtLongestThreadTime.Text = "";
            txtMedianThreadTime.Text = "";

            txtIterationsCompleted.Text = "";
            txtTotalThreadsCreated.Text = "";
            lblRate.Text = "";

            TotalThreadsCreated = 0;
            CompletedIterations = 0;
            ThreadDurations = new List<int>();
            
            shouldRun = true;

            if(!System.IO.File.Exists("perf_log.txt"))
            {
                System.IO.File.AppendAllText("perf_log.txt", "Date,Machine,Iterations,Max Threads,Iterations Completed,Delay Seconds,Delays Per Thread,Thread Creation Wait Ms,Rate,Avg Thread Time,Median Thread Time,Start,End,Duration\r\n");
            }

            await RunTestAsync();
        }

        private bool shouldRun = false;

        private void btStop_Click(object sender, EventArgs e)
        {
            End();
        }

        private void End()
        {
            endTime = DateTime.Now;
            txtEndTime.Text = endTime.ToString();
            txtConnectionString.ReadOnly = false;
            txtIterations.ReadOnly = false;
            txtMaxThreads.ReadOnly = false;
            txtThreadCreationWaitTimeMs.ReadOnly = false;

            txtCurrentThreadCount.Text = "";
            

            btStop.Enabled = false;
            btStart.Enabled = true;

            shouldRun = false;

            txtLongestThreadTime.Text = ThreadDurations.Max().ToString();
            txtShortestThreadTime.Text = ThreadDurations.Min().ToString();
            txtAverageThreadTime.Text = ThreadDurations.Average().ToString();
            txtMedianThreadTime.Text = GetMedian(ThreadDurations).ToString();

            System.IO.File.AppendAllText("perf_log.txt", $"{DateTime.Now.ToString()},{Environment.MachineName},{txtIterations.Text},{txtMaxThreads.Text},{txtIterationsCompleted.Text},{txtDelayTimeSeconds.Text},{txtSimulatedDelaysPerThread.Text},{txtThreadCreationWaitTimeMs.Text},{lblRate.Text},{txtAverageThreadTime.Text},{txtMedianThreadTime.Text},{txtStartTime.Text},{txtEndTime.Text},{txtDurationMs.Text}\r\n");
        }

        private int GetMedian(List<int> ints)
        {
            int numberCount = ints.Count;
            int halfIndex = numberCount / 2;
            var sortedNumbers = ints.OrderBy(n => n);

            double median;
            if ((numberCount % 2) == 0)
            {
                median = ((sortedNumbers.ElementAt(halfIndex) +
                    sortedNumbers.ElementAt((halfIndex - 1))) / 2);
            }
            else
            {
                median = sortedNumbers.ElementAt(halfIndex);
            }
            return (int) median;
        }

        private int ThreadsInUse = 0;
        private Object thisLock = new Object();
        public int CompletedIterations = 0;
        public int TotalThreadsCreated = 0;
        private DateTime startTime;
        private DateTime? endTime = null;
        private List<int> ThreadDurations = null;

        private async Task RunTestAsync()
        {
            int totalIterations = Convert.ToInt32(txtIterations.Text);
            int maxThreads = Convert.ToInt32(txtMaxThreads.Text);
            int threadCreationWaitTimeMs = Convert.ToInt32(txtThreadCreationWaitTimeMs.Text);

            startTime = DateTime.UtcNow;

            while (TotalThreadsCreated < totalIterations && shouldRun)
            {
                UpdateUi();
                if (ThreadsInUse < maxThreads)
                {
                    Thread t = new Thread(new ThreadStart(ProcessWithAdo));
                    t.Start();
                    ThreadsInUse = ThreadsInUse + 1;
                    TotalThreadsCreated++;
                }
                Thread.Sleep(threadCreationWaitTimeMs);
            }


            while (ThreadsInUse > 0)
            {
                UpdateUi();
                Thread.Sleep(500);
            }

            UpdateUi();

            End();

            
        }

        private void UpdateUi()
        {
            int durationMs = (int)(DateTime.UtcNow - startTime).TotalMilliseconds;

            txtStartTime.Text = startTime.ToLocalTime().ToString();
            txtTotalThreadsCreated.Text = TotalThreadsCreated.ToString();
            txtDurationMs.Text = durationMs.ToString();
            txtCurrentThreadCount.Text = ThreadsInUse.ToString();
            txtIterationsCompleted.Text = CompletedIterations.ToString();
            
            if (durationMs > 0 && CompletedIterations > 0)
            {
                int totalSeconds = durationMs / 1000;
                if (totalSeconds > 0)
                {
                    int secondRate = CompletedIterations / totalSeconds;
                    lblRate.Text = (secondRate * 60).ToString() + " per min";
                }
            }
            if (!String.IsNullOrWhiteSpace(txtIterations.Text))
            {
                progressBar1.Value = (int)((Convert.ToDecimal(CompletedIterations) / Convert.ToDecimal(txtIterations.Text)) * 100);
            }

            Application.DoEvents();
        }

        public void ProcessWithAdo()
        {
            DateTime? start = null;
            DateTime? end = null;
            try
            {
                int delayTimeSeconds = Convert.ToInt32(txtDelayTimeSeconds.Text);
                if (delayTimeSeconds > 59)
                {
                    txtDelayTimeSeconds.Text = "59";
                    delayTimeSeconds = 59;
                }
                int delays = Convert.ToInt32(txtSimulatedDelaysPerThread.Text);
                int ops = Convert.ToInt32(txtOpsPerThread.Text);

                start = DateTime.UtcNow;
                if (!String.IsNullOrWhiteSpace(txtConnectionString.Text))
                {
                    for (int i = 0; i < delays; i++)
                    {
                        using (SqlConnection connection = new SqlConnection(txtConnectionString.Text))
                        {


                            //SqlDatabase db = new SqlDatabase("Data Source=devoltp01.og.com;Initial Catalog=GlobalCatalog;Connect Timeout=120;Trusted_Connection=True;");
                            using (SqlCommand command = new SqlCommand("WAITFOR DELAY '00:00:" + delayTimeSeconds.ToString("D2") + "' SELECT @test0 as BLAHBLAH", connection))
                            {
                                command.CommandTimeout = 10000;
                                for (int j = 0; j < 50; j++)
                                {
                                    command.Parameters.AddWithValue($"test{j.ToString()}", "result");
                                }
                                connection.Open();
                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataSet ds = new DataSet();
                                    adapter.Fill(ds);
                                }
                            }
                        }
                    }
                }

                for(int i = 0; i < ops; i++)
                {
                    string test = ops.ToString();
                    test = null;
                }

                end = DateTime.UtcNow;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Thread {Thread.CurrentThread.ManagedThreadId}: {ex.ToString()}");
            }
            finally
            {
                lock (thisLock)
                {
                    ThreadsInUse = ThreadsInUse - 1;
                    CompletedIterations++;
                    if(start.HasValue && end.HasValue)
                    {
                        ThreadDurations.Add((int)(end.Value - start.Value).TotalMilliseconds);
                    }
                }
            }
        }

        public void ProcessSimulated()
        {
            try
            {
                int delayTimeSeconds = Convert.ToInt32(txtDelayTimeSeconds.Text);
                
                DateTime start = DateTime.UtcNow;
                Thread.Sleep(delayTimeSeconds * 1000);
                DateTime end = DateTime.UtcNow;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                lock (thisLock)
                {
                    ThreadsInUse = ThreadsInUse - 1;
                    CompletedIterations++;
                }
            }
        }
    }
}
