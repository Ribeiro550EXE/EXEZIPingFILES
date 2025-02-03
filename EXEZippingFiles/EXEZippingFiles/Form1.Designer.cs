namespace EXEZippingFiles
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
            CHFolderBT = new Button();
            LBShowPath = new Label();
            LOGOPICTURE = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LOGOPICTURE).BeginInit();
            SuspendLayout();
            // 
            // CHFolderBT
            // 
            CHFolderBT.Location = new Point(51, 122);
            CHFolderBT.Name = "CHFolderBT";
            CHFolderBT.Size = new Size(117, 50);
            CHFolderBT.TabIndex = 0;
            CHFolderBT.Text = "...";
            CHFolderBT.UseVisualStyleBackColor = true;
            CHFolderBT.Click += CHFolderBT_Click;
            // 
            // LBShowPath
            // 
            LBShowPath.AutoSize = true;
            LBShowPath.Location = new Point(51, 73);
            LBShowPath.Name = "LBShowPath";
            LBShowPath.Size = new Size(24, 25);
            LBShowPath.TabIndex = 1;
            LBShowPath.Text = "...";
            // 
            // LOGOPICTURE
            // 
            LOGOPICTURE.Location = new Point(51, 230);
            LOGOPICTURE.Name = "LOGOPICTURE";
            LOGOPICTURE.Size = new Size(300, 300);
            LOGOPICTURE.TabIndex = 2;
            LOGOPICTURE.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 581);
            Controls.Add(LOGOPICTURE);
            Controls.Add(LBShowPath);
            Controls.Add(CHFolderBT);
            Name = "Form1";
            Text = "ExeZippingFiles";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)LOGOPICTURE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CHFolderBT;
        private Label LBShowPath;
        private PictureBox LOGOPICTURE;
    }
}
