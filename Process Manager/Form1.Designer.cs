namespace Process_Manager
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
            this.lstProcess = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.txtProcesses = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstProcess
            // 
            this.lstProcess.FormattingEnabled = true;
            this.lstProcess.Location = new System.Drawing.Point(12, 12);
            this.lstProcess.Name = "lstProcess";
            this.lstProcess.Size = new System.Drawing.Size(298, 433);
            this.lstProcess.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(324, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(324, 53);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(95, 23);
            this.btnKill.TabIndex = 2;
            this.btnKill.Text = "Kill Process";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // txtProcesses
            // 
            this.txtProcesses.AutoSize = true;
            this.txtProcesses.Location = new System.Drawing.Point(316, 426);
            this.txtProcesses.Name = "txtProcesses";
            this.txtProcesses.Size = new System.Drawing.Size(97, 13);
            this.txtProcesses.TabIndex = 3;
            this.txtProcesses.Text = "Processes running:";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(356, 81);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(0, 13);
            this.v.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 457);
            this.Controls.Add(this.v);
            this.Controls.Add(this.txtProcesses);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lstProcess);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProcess;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Label txtProcesses;
        private System.Windows.Forms.Label v;
    }
}

