namespace PerfTest.App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxThreads = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThreadCreationWaitTimeMs = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalThreadsCreated = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIterationsCompleted = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCurrentThreadCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDurationMs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDelayTimeSeconds = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSimulatedDelaysPerThread = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtShortestThreadTime = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLongestThreadTime = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAverageThreadTime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMedianThreadTime = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtOpsPerThread = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(74, 23);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(64, 22);
            this.txtIterations.TabIndex = 0;
            this.txtIterations.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iterations";
            // 
            // txtMaxThreads
            // 
            this.txtMaxThreads.Location = new System.Drawing.Point(340, 20);
            this.txtMaxThreads.Name = "txtMaxThreads";
            this.txtMaxThreads.Size = new System.Drawing.Size(71, 22);
            this.txtMaxThreads.TabIndex = 2;
            this.txtMaxThreads.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Concurrent Threads";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thread Creation Wait Time (ms)";
            // 
            // txtThreadCreationWaitTimeMs
            // 
            this.txtThreadCreationWaitTimeMs.Location = new System.Drawing.Point(656, 21);
            this.txtThreadCreationWaitTimeMs.Name = "txtThreadCreationWaitTimeMs";
            this.txtThreadCreationWaitTimeMs.Size = new System.Drawing.Size(70, 22);
            this.txtThreadCreationWaitTimeMs.TabIndex = 5;
            this.txtThreadCreationWaitTimeMs.Text = "10";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(115, 205);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(650, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Connection String";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(124, 81);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(614, 22);
            this.txtConnectionString.TabIndex = 8;
            this.txtConnectionString.Text = "Data Source=ryanw-zbook;Initial Catalog=sandbox;Connect Timeout=120;Trusted_Conne" +
    "ction=True;";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOpsPerThread);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtSimulatedDelaysPerThread);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtDelayTimeSeconds);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConnectionString);
            this.groupBox1.Controls.Add(this.txtIterations);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaxThreads);
            this.groupBox1.Controls.Add(this.txtThreadCreationWaitTimeMs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 115);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(284, 158);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 10;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(385, 158);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 11;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Progress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Threads Created";
            // 
            // txtTotalThreadsCreated
            // 
            this.txtTotalThreadsCreated.Location = new System.Drawing.Point(159, 251);
            this.txtTotalThreadsCreated.Name = "txtTotalThreadsCreated";
            this.txtTotalThreadsCreated.ReadOnly = true;
            this.txtTotalThreadsCreated.Size = new System.Drawing.Size(91, 22);
            this.txtTotalThreadsCreated.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Iterations Completed";
            // 
            // txtIterationsCompleted
            // 
            this.txtIterationsCompleted.Location = new System.Drawing.Point(418, 251);
            this.txtIterationsCompleted.Name = "txtIterationsCompleted";
            this.txtIterationsCompleted.ReadOnly = true;
            this.txtIterationsCompleted.Size = new System.Drawing.Size(100, 22);
            this.txtIterationsCompleted.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Current Thread Count";
            // 
            // txtCurrentThreadCount
            // 
            this.txtCurrentThreadCount.Location = new System.Drawing.Point(688, 250);
            this.txtCurrentThreadCount.Name = "txtCurrentThreadCount";
            this.txtCurrentThreadCount.ReadOnly = true;
            this.txtCurrentThreadCount.Size = new System.Drawing.Size(77, 22);
            this.txtCurrentThreadCount.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(431, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Duration (ms)";
            // 
            // txtDurationMs
            // 
            this.txtDurationMs.Location = new System.Drawing.Point(524, 301);
            this.txtDurationMs.Name = "txtDurationMs";
            this.txtDurationMs.ReadOnly = true;
            this.txtDurationMs.Size = new System.Drawing.Size(241, 22);
            this.txtDurationMs.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Start Time";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(159, 298);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.ReadOnly = true;
            this.txtStartTime.Size = new System.Drawing.Size(200, 22);
            this.txtStartTime.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "End Time";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(159, 332);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.ReadOnly = true;
            this.txtEndTime.Size = new System.Drawing.Size(200, 22);
            this.txtEndTime.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(464, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Rate";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(524, 337);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(0, 16);
            this.lblRate.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Simulated Delay Time (seconds)";
            // 
            // txtDelayTimeSeconds
            // 
            this.txtDelayTimeSeconds.Location = new System.Drawing.Point(219, 53);
            this.txtDelayTimeSeconds.Name = "txtDelayTimeSeconds";
            this.txtDelayTimeSeconds.Size = new System.Drawing.Size(29, 22);
            this.txtDelayTimeSeconds.TabIndex = 10;
            this.txtDelayTimeSeconds.Text = "2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(280, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "Simulated Delays Per Thread";
            // 
            // txtSimulatedDelaysPerThread
            // 
            this.txtSimulatedDelaysPerThread.Location = new System.Drawing.Point(471, 53);
            this.txtSimulatedDelaysPerThread.Name = "txtSimulatedDelaysPerThread";
            this.txtSimulatedDelaysPerThread.Size = new System.Drawing.Size(32, 22);
            this.txtSimulatedDelaysPerThread.TabIndex = 12;
            this.txtSimulatedDelaysPerThread.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 16);
            this.label15.TabIndex = 27;
            this.label15.Text = "Shortest Thread Time";
            // 
            // txtShortestThreadTime
            // 
            this.txtShortestThreadTime.Location = new System.Drawing.Point(173, 378);
            this.txtShortestThreadTime.Name = "txtShortestThreadTime";
            this.txtShortestThreadTime.ReadOnly = true;
            this.txtShortestThreadTime.Size = new System.Drawing.Size(100, 22);
            this.txtShortestThreadTime.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(307, 384);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 16);
            this.label16.TabIndex = 29;
            this.label16.Text = "Longest Thread Time";
            // 
            // txtLongestThreadTime
            // 
            this.txtLongestThreadTime.Location = new System.Drawing.Point(450, 378);
            this.txtLongestThreadTime.Name = "txtLongestThreadTime";
            this.txtLongestThreadTime.ReadOnly = true;
            this.txtLongestThreadTime.Size = new System.Drawing.Size(98, 22);
            this.txtLongestThreadTime.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 408);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 16);
            this.label17.TabIndex = 31;
            this.label17.Text = "Average Thread Time";
            // 
            // txtAverageThreadTime
            // 
            this.txtAverageThreadTime.Location = new System.Drawing.Point(173, 408);
            this.txtAverageThreadTime.Name = "txtAverageThreadTime";
            this.txtAverageThreadTime.ReadOnly = true;
            this.txtAverageThreadTime.Size = new System.Drawing.Size(100, 22);
            this.txtAverageThreadTime.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(310, 414);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 16);
            this.label18.TabIndex = 33;
            this.label18.Text = "Median Thread Time";
            // 
            // txtMedianThreadTime
            // 
            this.txtMedianThreadTime.Location = new System.Drawing.Point(448, 408);
            this.txtMedianThreadTime.Name = "txtMedianThreadTime";
            this.txtMedianThreadTime.ReadOnly = true;
            this.txtMedianThreadTime.Size = new System.Drawing.Size(100, 22);
            this.txtMedianThreadTime.TabIndex = 34;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(535, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 16);
            this.label19.TabIndex = 13;
            this.label19.Text = "Ops Per Thread";
            // 
            // txtOpsPerThread
            // 
            this.txtOpsPerThread.Location = new System.Drawing.Point(646, 53);
            this.txtOpsPerThread.Name = "txtOpsPerThread";
            this.txtOpsPerThread.Size = new System.Drawing.Size(80, 22);
            this.txtOpsPerThread.TabIndex = 14;
            this.txtOpsPerThread.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 452);
            this.Controls.Add(this.txtMedianThreadTime);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtAverageThreadTime);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtLongestThreadTime);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtShortestThreadTime);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDurationMs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCurrentThreadCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIterationsCompleted);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalThreadsCreated);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Thread Performance Tester";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxThreads;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThreadCreationWaitTimeMs;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalThreadsCreated;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIterationsCompleted;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCurrentThreadCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDurationMs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDelayTimeSeconds;
        private System.Windows.Forms.TextBox txtSimulatedDelaysPerThread;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtShortestThreadTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtLongestThreadTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAverageThreadTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMedianThreadTime;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtOpsPerThread;
    }
}

