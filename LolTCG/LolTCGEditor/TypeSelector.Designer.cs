namespace LolTCGEditor
{
    partial class TypeSelector
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
            this.championButton = new System.Windows.Forms.Button();
            this.minionButton = new System.Windows.Forms.Button();
            this.structureButton = new System.Windows.Forms.Button();
            this.leaderButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // championButton
            // 
            this.championButton.Location = new System.Drawing.Point(15, 38);
            this.championButton.Name = "championButton";
            this.championButton.Size = new System.Drawing.Size(114, 49);
            this.championButton.TabIndex = 0;
            this.championButton.Text = "Champion";
            this.championButton.UseVisualStyleBackColor = true;
            this.championButton.Click += new System.EventHandler(this.championButton_Click);
            // 
            // minionButton
            // 
            this.minionButton.Location = new System.Drawing.Point(135, 38);
            this.minionButton.Name = "minionButton";
            this.minionButton.Size = new System.Drawing.Size(114, 49);
            this.minionButton.TabIndex = 1;
            this.minionButton.Text = "Minion";
            this.minionButton.UseVisualStyleBackColor = true;
            this.minionButton.Click += new System.EventHandler(this.minionButton_Click);
            // 
            // structureButton
            // 
            this.structureButton.Location = new System.Drawing.Point(15, 93);
            this.structureButton.Name = "structureButton";
            this.structureButton.Size = new System.Drawing.Size(114, 49);
            this.structureButton.TabIndex = 2;
            this.structureButton.Text = "Structure";
            this.structureButton.UseVisualStyleBackColor = true;
            this.structureButton.Click += new System.EventHandler(this.structureButton_Click);
            // 
            // leaderButton
            // 
            this.leaderButton.Location = new System.Drawing.Point(135, 93);
            this.leaderButton.Name = "leaderButton";
            this.leaderButton.Size = new System.Drawing.Size(114, 49);
            this.leaderButton.TabIndex = 3;
            this.leaderButton.Text = "Leader";
            this.leaderButton.UseVisualStyleBackColor = true;
            this.leaderButton.Click += new System.EventHandler(this.leaderButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(174, 233);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 24);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select type of new card";
            // 
            // TypeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.leaderButton);
            this.Controls.Add(this.structureButton);
            this.Controls.Add(this.minionButton);
            this.Controls.Add(this.championButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TypeSelector";
            this.Text = "TypeSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button championButton;
        private System.Windows.Forms.Button minionButton;
        private System.Windows.Forms.Button structureButton;
        private System.Windows.Forms.Button leaderButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
    }
}