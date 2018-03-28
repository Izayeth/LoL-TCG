namespace LolTCGEditor
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsEditor1 = new LolTCGEditor.CardsEditor();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(569, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCardsToolStripMenuItem,
            this.loadCardsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveCardsToolStripMenuItem
            // 
            this.saveCardsToolStripMenuItem.Name = "saveCardsToolStripMenuItem";
            this.saveCardsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveCardsToolStripMenuItem.Text = "Save Cards";
            this.saveCardsToolStripMenuItem.Click += new System.EventHandler(this.saveCardsToolStripMenuItem_Click);
            // 
            // loadCardsToolStripMenuItem
            // 
            this.loadCardsToolStripMenuItem.Name = "loadCardsToolStripMenuItem";
            this.loadCardsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadCardsToolStripMenuItem.Text = "Load Cards";
            this.loadCardsToolStripMenuItem.Click += new System.EventHandler(this.loadCardsToolStripMenuItem_Click);
            // 
            // cardsEditor1
            // 
            this.cardsEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardsEditor1.Location = new System.Drawing.Point(0, 24);
            this.cardsEditor1.Name = "cardsEditor1";
            this.cardsEditor1.Size = new System.Drawing.Size(569, 382);
            this.cardsEditor1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 428);
            this.Controls.Add(this.cardsEditor1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private CardsEditor cardsEditor1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCardsToolStripMenuItem;
    }
}

