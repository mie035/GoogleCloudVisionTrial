namespace GoogleCloudVisionTrial
{
    partial class Mainform
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDetect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRef = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.tbxDetected = new System.Windows.Forms.TextBox();
            this.pictDetect = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictDetect)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(794, 415);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(203, 57);
            this.btnDetect.TabIndex = 0;
            this.btnDetect.Text = "DETECT";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRef);
            this.panel1.Controls.Add(this.lblOutput);
            this.panel1.Controls.Add(this.lblInput);
            this.panel1.Controls.Add(this.tbxDetected);
            this.panel1.Controls.Add(this.pictDetect);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 397);
            this.panel1.TabIndex = 1;
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(68, 9);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(29, 23);
            this.btnRef.TabIndex = 4;
            this.btnRef.Text = "...";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(477, 13);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(60, 15);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "RESULT";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(13, 13);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(49, 15);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "INPUT";
            // 
            // tbxDetected
            // 
            this.tbxDetected.Location = new System.Drawing.Point(480, 40);
            this.tbxDetected.Multiline = true;
            this.tbxDetected.Name = "tbxDetected";
            this.tbxDetected.Size = new System.Drawing.Size(468, 338);
            this.tbxDetected.TabIndex = 1;
            // 
            // pictDetect
            // 
            this.pictDetect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictDetect.Location = new System.Drawing.Point(16, 40);
            this.pictDetect.Name = "pictDetect";
            this.pictDetect.Size = new System.Drawing.Size(420, 338);
            this.pictDetect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictDetect.TabIndex = 0;
            this.pictDetect.TabStop = false;
            this.pictDetect.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictDetect_DragDrop);
            this.pictDetect.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictDetect_DragEnter);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDetect);
            this.Name = "Mainform";
            this.Text = "Google Cloud Vision Trial";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictDetect_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictDetect_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictDetect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox tbxDetected;
        private System.Windows.Forms.PictureBox pictDetect;
        private System.Windows.Forms.Button btnRef;
    }
}

