namespace SwiftKeysWindowsCSharp
{
    partial class FootKeys
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FootKeys));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.option1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.option2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartBluetoothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartAndroidAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "FootKeys is currently running!";
            this.notifyIcon1.BalloonTipTitle = "FootKeys";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SwiftKeys/FootKeys";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option1ToolStripMenuItem,
            this.option2ToolStripMenuItem,
            this.closeApplicationToolStripMenuItem,
            this.restartBluetoothToolStripMenuItem,
            this.restartAndroidAppToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(333, 242);
            // 
            // option1ToolStripMenuItem
            // 
            this.option1ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.option1ToolStripMenuItem.Name = "option1ToolStripMenuItem";
            this.option1ToolStripMenuItem.Size = new System.Drawing.Size(332, 42);
            this.option1ToolStripMenuItem.Text = "Show Predictions";
            this.option1ToolStripMenuItem.Click += new System.EventHandler(this.option1ToolStripMenuItem_Click);
            // 
            // option2ToolStripMenuItem
            // 
            this.option2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.option2ToolStripMenuItem.Name = "option2ToolStripMenuItem";
            this.option2ToolStripMenuItem.Size = new System.Drawing.Size(332, 42);
            this.option2ToolStripMenuItem.Text = "Show Controller";
            this.option2ToolStripMenuItem.Click += new System.EventHandler(this.option2ToolStripMeduItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(332, 42);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplication);
            // 
            // restartBluetoothToolStripMenuItem
            // 
            this.restartBluetoothToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.restartBluetoothToolStripMenuItem.Name = "restartBluetoothToolStripMenuItem";
            this.restartBluetoothToolStripMenuItem.Size = new System.Drawing.Size(332, 42);
            this.restartBluetoothToolStripMenuItem.Text = "Restart Bluetooth";
            this.restartBluetoothToolStripMenuItem.Click += new System.EventHandler(this.restartBlueTooth);
            // 
            // restartAndroidAppToolStripMenuItem
            // 
            this.restartAndroidAppToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.restartAndroidAppToolStripMenuItem.Name = "restartAndroidAppToolStripMenuItem";
            this.restartAndroidAppToolStripMenuItem.Size = new System.Drawing.Size(332, 42);
            this.restartAndroidAppToolStripMenuItem.Text = "Restart Android App";
            this.restartAndroidAppToolStripMenuItem.Click += new System.EventHandler(this.restartAndroidApp);
            // 
            // FootKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 392);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FootKeys";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize_1);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem option1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem option2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartBluetoothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartAndroidAppToolStripMenuItem;
    }
}

