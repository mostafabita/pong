namespace Pong
{
    partial class Main
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
            this.changeLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermediateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLevelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(7, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(150, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // changeLevelToolStripMenuItem
            // 
            this.changeLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.beginnerToolStripMenuItem,
            this.intermediateToolStripMenuItem,
            this.advancedToolStripMenuItem});
            this.changeLevelToolStripMenuItem.Name = "changeLevelToolStripMenuItem";
            this.changeLevelToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.changeLevelToolStripMenuItem.Text = "Menu";
            // 
            // beginnerToolStripMenuItem
            // 
            this.beginnerToolStripMenuItem.Name = "beginnerToolStripMenuItem";
            this.beginnerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.beginnerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.beginnerToolStripMenuItem.Text = "Beginner";
            this.beginnerToolStripMenuItem.Click += new System.EventHandler(this.changeLevelToolStripMenuItem_Click);
            // 
            // intermediateToolStripMenuItem
            // 
            this.intermediateToolStripMenuItem.Name = "intermediateToolStripMenuItem";
            this.intermediateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.intermediateToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.intermediateToolStripMenuItem.Text = "Intermediate";
            this.intermediateToolStripMenuItem.Click += new System.EventHandler(this.changeLevelToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.advancedToolStripMenuItem.Text = "Advanced";
            this.advancedToolStripMenuItem.Click += new System.EventHandler(this.changeLevelToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 186);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermediateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

