namespace WinFormsMulitThreadingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHello = new Button();
            btnThread = new Button();
            btnTrhead = new Button();
            btnTask = new Button();
            btnTaskAwait = new Button();
            btnTaskResult = new Button();
            callMicroservice = new Button();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.Location = new Point(449, 103);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(162, 64);
            btnHello.TabIndex = 0;
            btnHello.Text = "Hello";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            // 
            // btnThread
            // 
            btnThread.Location = new Point(229, 103);
            btnThread.Name = "btnThread";
            btnThread.Size = new Size(214, 64);
            btnThread.TabIndex = 1;
            btnThread.Text = "Print";
            btnThread.UseVisualStyleBackColor = true;
            btnThread.Click += btnThread_Click;
            // 
            // btnTrhead
            // 
            btnTrhead.Location = new Point(202, 184);
            btnTrhead.Name = "btnTrhead";
            btnTrhead.Size = new Size(214, 64);
            btnTrhead.TabIndex = 2;
            btnTrhead.Text = "PrintThread";
            btnTrhead.UseVisualStyleBackColor = true;
            btnTrhead.Click += btnTrhead_Click;
            // 
            // btnTask
            // 
            btnTask.Location = new Point(438, 184);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(214, 64);
            btnTask.TabIndex = 3;
            btnTask.Text = "PrintTask";
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += btnTask_Click;
            // 
            // btnTaskAwait
            // 
            btnTaskAwait.Location = new Point(216, 279);
            btnTaskAwait.Name = "btnTaskAwait";
            btnTaskAwait.Size = new Size(214, 64);
            btnTaskAwait.TabIndex = 4;
            btnTaskAwait.Text = "PrintTaskAwait";
            btnTaskAwait.UseVisualStyleBackColor = true;
            btnTaskAwait.Click += btnTaskAwait_Click;
            // 
            // btnTaskResult
            // 
            btnTaskResult.Location = new Point(449, 279);
            btnTaskResult.Name = "btnTaskResult";
            btnTaskResult.Size = new Size(214, 64);
            btnTaskResult.TabIndex = 5;
            btnTaskResult.Text = "PrintTaskResult";
            btnTaskResult.UseVisualStyleBackColor = true;
            btnTaskResult.Click += btnTaskResult_Click;
            // 
            // callMicroservice
            // 
            callMicroservice.Location = new Point(663, 68);
            callMicroservice.Name = "callMicroservice";
            callMicroservice.Size = new Size(168, 54);
            callMicroservice.TabIndex = 6;
            callMicroservice.Text = "callMicroservice";
            callMicroservice.UseVisualStyleBackColor = true;
            callMicroservice.Click += callMicroservice_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 450);
            Controls.Add(callMicroservice);
            Controls.Add(btnTaskResult);
            Controls.Add(btnTaskAwait);
            Controls.Add(btnTask);
            Controls.Add(btnTrhead);
            Controls.Add(btnThread);
            Controls.Add(btnHello);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHello;
        private Button btnThread;
        private Button btnTrhead;
        private Button btnTask;
        private Button btnTaskAwait;
        private Button btnTaskResult;
        private Button callMicroservice;
    }
}
