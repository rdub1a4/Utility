using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PerfTest
{
    public class Test
    {
        public SqlDatabase DB = null;
        private int ThreadsInUse = 0;
        private Object thisLock = new Object();

        public int TotalIterations = 5000;
        public int MaxThreads = 1000;
        public int TotalThreadsCreated = 0;
        public int ThreadCreationWaitTimeMs = 0;

        public void Start()
        {
            DB = new SqlDatabase("Data Source=devoltp01.og.com;Initial Catalog=GlobalCatalog;Connect Timeout=120;Trusted_Connection=True;");
            Console.WriteLine("Created Database");

            lock (thisLock)
            {
                DateTime start = DateTime.UtcNow;

                 Console.WriteLine($"Starting {TotalIterations} calls");

                for (int x = 0; x < TotalIterations; x++)
                {

                    //Process(new object());
                    if (ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessWithAdo)))
                    {
                        ThreadsInUse += 1;
                        TotalThreadsCreated++;
                    }
                }
                   
                
                while(ThreadsInUse > 0)
                {
                    //Console.WriteLine($"Waiting for {ThreadsInUse} to complete");
                    //Thread.Sleep(1000);
                }
                DateTime end = DateTime.UtcNow;

                Console.WriteLine($"Completed {TotalIterations} calls in {(end - start).TotalMilliseconds} ms");
            }
        }

        public void StartCustomThreads()
        {
            DB = new SqlDatabase("Data Source=devoltp01.og.com;Initial Catalog=GlobalCatalog;Connect Timeout=120;Trusted_Connection=True;");
            Console.WriteLine("Created Database");

            DateTime start = DateTime.UtcNow;

            
                Console.WriteLine($"Starting {TotalIterations} calls with {MaxThreads} max threads");

                while(TotalThreadsCreated < TotalIterations)
                {
                    if (ThreadsInUse < MaxThreads)
                    {
                        Thread t = new Thread(new ThreadStart(Process));
                        t.Start();
                        ThreadsInUse = ThreadsInUse + 1;
                        TotalThreadsCreated++;
                    }
                    Thread.Sleep(ThreadCreationWaitTimeMs);
                }
                
            
            while (ThreadsInUse > 0)
            {
                Console.WriteLine($"Waiting for {ThreadsInUse} to complete");
                Thread.Sleep(1000);
            }
            DateTime end = DateTime.UtcNow;

            Console.WriteLine($"Completed {TotalThreadsCreated} calls in {(end - start).TotalMilliseconds} ms");

        }

        public void Process()
        {
            try
            {
                DateTime start = DateTime.UtcNow;
                SqlDatabase db = DB;
                
                //SqlDatabase db = new SqlDatabase("Data Source=devoltp01.og.com;Initial Catalog=GlobalCatalog;Connect Timeout=120;Trusted_Connection=True;");
                using (DbCommand dbc = DB.GetSqlStringCommand("WAITFOR DELAY '00:00:01' SELECT @test0 as BLAHBLAH"))
                {
                    dbc.CommandTimeout = 10000;
                    for (int j = 0; j < 50; j++)
                    {
                        db.AddInParameter(dbc, $"test{j.ToString()}", System.Data.SqlDbType.VarChar, "result");
                    }
                    db.ExecuteDataSet(dbc);
                }

                DateTime end = DateTime.UtcNow;
                Console.WriteLine($"Finished thread {Thread.CurrentThread.ManagedThreadId} in {(end - start).TotalMilliseconds} ms");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error in Thread {Thread.CurrentThread.ManagedThreadId}: {ex.ToString()}");
            }
            finally
            {
                lock (thisLock)
                {
                    ThreadsInUse = ThreadsInUse - 1;
                }
            }
        }


        


        public void ProcessWithAdo(object state)
        {
            try
            {
                DateTime start = DateTime.UtcNow;
                using (SqlConnection connection = new SqlConnection("Data Source=devoltp01.og.com;Initial Catalog=GlobalCatalog;Connect Timeout=120;Trusted_Connection=True;"))
                {
                    

                //SqlDatabase db = new SqlDatabase("Data Source=devoltp01.og.com;Initial Catalog=GlobalCatalog;Connect Timeout=120;Trusted_Connection=True;");
                    using (SqlCommand command = new SqlCommand("WAITFOR DELAY '00:00:01' SELECT @test0 as BLAHBLAH", connection))
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
                DateTime end = DateTime.UtcNow;
                Console.WriteLine($"Finished thread {Thread.CurrentThread.ManagedThreadId} in {(end - start).TotalMilliseconds} ms");
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
                }
            }
        }

        public void ProcessSimulated()
        {
            try
            {
                DateTime start = DateTime.UtcNow;
                Console.WriteLine($"Starting thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
                DateTime end = DateTime.UtcNow;
                Console.WriteLine($"Finished thread {Thread.CurrentThread.ManagedThreadId} in {(end - start).TotalMilliseconds} ms");
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
                }
            }
        }

    }
}
