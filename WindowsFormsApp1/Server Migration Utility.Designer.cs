namespace WindowsFormsApp1
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
            this.Help_Button = new System.Windows.Forms.Button();
            this.Copy_Button = new System.Windows.Forms.Button();
            this.Location_Copy_From = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Location_Copy_To = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MoveClientSettingsXml = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MoveSecurityXml = new System.Windows.Forms.CheckBox();
            this.MoveAdminClientSettingsXml = new System.Windows.Forms.CheckBox();
            this.MergeResultsMove = new System.Windows.Forms.CheckBox();
            this.LicenseKeyMove = new System.Windows.Forms.CheckBox();
            this.MoveFRFolder = new System.Windows.Forms.CheckBox();
            this.MoveORIs = new System.Windows.Forms.CheckBox();
            this.MoveFDIDs = new System.Windows.Forms.CheckBox();
            this.MoveFileStorage = new System.Windows.Forms.CheckBox();
            this.ORIStateCode = new System.Windows.Forms.TextBox();
            this.FDIDStateCode = new System.Windows.Forms.TextBox();
            this.MovePrePlan = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Help_Button
            // 
            this.Help_Button.Location = new System.Drawing.Point(438, 12);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(75, 23);
            this.Help_Button.TabIndex = 17;
            this.Help_Button.Text = "Help";
            this.Help_Button.UseVisualStyleBackColor = true;
            this.Help_Button.Click += new System.EventHandler(this.Help_Button_Click);
            // 
            // Copy_Button
            // 
            this.Copy_Button.Location = new System.Drawing.Point(438, 229);
            this.Copy_Button.Name = "Copy_Button";
            this.Copy_Button.Size = new System.Drawing.Size(75, 23);
            this.Copy_Button.TabIndex = 7;
            this.Copy_Button.Text = "Copy";
            this.Copy_Button.UseVisualStyleBackColor = true;
            this.Copy_Button.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // Location_Copy_From
            // 
            this.Location_Copy_From.Location = new System.Drawing.Point(253, 58);
            this.Location_Copy_From.Name = "Location_Copy_From";
            this.Location_Copy_From.Size = new System.Drawing.Size(238, 20);
            this.Location_Copy_From.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Network Path to the C:\\ Drive on the old mobile server";
            // 
            // Location_Copy_To
            // 
            this.Location_Copy_To.Location = new System.Drawing.Point(253, 97);
            this.Location_Copy_To.Name = "Location_Copy_To";
            this.Location_Copy_To.Size = new System.Drawing.Size(238, 20);
            this.Location_Copy_To.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(253, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Drive Letter of the Mobile Server .exe";
            // 
            // MoveClientSettingsXml
            // 
            this.MoveClientSettingsXml.AutoSize = true;
            this.MoveClientSettingsXml.Checked = true;
            this.MoveClientSettingsXml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MoveClientSettingsXml.Location = new System.Drawing.Point(12, 20);
            this.MoveClientSettingsXml.Name = "MoveClientSettingsXml";
            this.MoveClientSettingsXml.Size = new System.Drawing.Size(138, 17);
            this.MoveClientSettingsXml.TabIndex = 9;
            this.MoveClientSettingsXml.Text = "Move ClientSettings.xml";
            this.MoveClientSettingsXml.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Item checklist";
            // 
            // MoveSecurityXml
            // 
            this.MoveSecurityXml.AutoSize = true;
            this.MoveSecurityXml.Checked = true;
            this.MoveSecurityXml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MoveSecurityXml.Location = new System.Drawing.Point(12, 66);
            this.MoveSecurityXml.Name = "MoveSecurityXml";
            this.MoveSecurityXml.Size = new System.Drawing.Size(112, 17);
            this.MoveSecurityXml.TabIndex = 11;
            this.MoveSecurityXml.Text = "Move Security.xml";
            this.MoveSecurityXml.UseVisualStyleBackColor = true;
            // 
            // MoveAdminClientSettingsXml
            // 
            this.MoveAdminClientSettingsXml.AutoSize = true;
            this.MoveAdminClientSettingsXml.Checked = true;
            this.MoveAdminClientSettingsXml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MoveAdminClientSettingsXml.Location = new System.Drawing.Point(12, 43);
            this.MoveAdminClientSettingsXml.Name = "MoveAdminClientSettingsXml";
            this.MoveAdminClientSettingsXml.Size = new System.Drawing.Size(196, 17);
            this.MoveAdminClientSettingsXml.TabIndex = 10;
            this.MoveAdminClientSettingsXml.Text = "Move Form Admin ClientSettings.xml";
            this.MoveAdminClientSettingsXml.UseVisualStyleBackColor = true;
            // 
            // MergeResultsMove
            // 
            this.MergeResultsMove.AutoSize = true;
            this.MergeResultsMove.Checked = true;
            this.MergeResultsMove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MergeResultsMove.Location = new System.Drawing.Point(13, 89);
            this.MergeResultsMove.Name = "MergeResultsMove";
            this.MergeResultsMove.Size = new System.Drawing.Size(121, 17);
            this.MergeResultsMove.TabIndex = 12;
            this.MergeResultsMove.Text = "Move MergeResults";
            this.MergeResultsMove.UseVisualStyleBackColor = true;
            // 
            // LicenseKeyMove
            // 
            this.LicenseKeyMove.AutoSize = true;
            this.LicenseKeyMove.Checked = true;
            this.LicenseKeyMove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LicenseKeyMove.Location = new System.Drawing.Point(13, 113);
            this.LicenseKeyMove.Name = "LicenseKeyMove";
            this.LicenseKeyMove.Size = new System.Drawing.Size(146, 17);
            this.LicenseKeyMove.TabIndex = 13;
            this.LicenseKeyMove.Text = "Move License Key Folder";
            this.LicenseKeyMove.UseVisualStyleBackColor = true;
            // 
            // MoveFRFolder
            // 
            this.MoveFRFolder.AutoSize = true;
            this.MoveFRFolder.Checked = true;
            this.MoveFRFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MoveFRFolder.Location = new System.Drawing.Point(12, 137);
            this.MoveFRFolder.Name = "MoveFRFolder";
            this.MoveFRFolder.Size = new System.Drawing.Size(184, 17);
            this.MoveFRFolder.TabIndex = 14;
            this.MoveFRFolder.Text = "Move Field Reporting Hold Folder";
            this.MoveFRFolder.UseVisualStyleBackColor = true;
            // 
            // MoveORIs
            // 
            this.MoveORIs.AutoSize = true;
            this.MoveORIs.Checked = true;
            this.MoveORIs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MoveORIs.Location = new System.Drawing.Point(12, 161);
            this.MoveORIs.Name = "MoveORIs";
            this.MoveORIs.Size = new System.Drawing.Size(110, 17);
            this.MoveORIs.TabIndex = 15;
            this.MoveORIs.Text = "Move All LE ORIs";
            this.MoveORIs.UseVisualStyleBackColor = true;
            // 
            // MoveFDIDs
            // 
            this.MoveFDIDs.AutoSize = true;
            this.MoveFDIDs.Checked = true;
            this.MoveFDIDs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MoveFDIDs.Location = new System.Drawing.Point(12, 185);
            this.MoveFDIDs.Name = "MoveFDIDs";
            this.MoveFDIDs.Size = new System.Drawing.Size(120, 17);
            this.MoveFDIDs.TabIndex = 16;
            this.MoveFDIDs.Text = "Move All Fire FDIDs";
            this.MoveFDIDs.UseVisualStyleBackColor = true;
            // 
            // MoveFileStorage
            // 
            this.MoveFileStorage.AutoSize = true;
            this.MoveFileStorage.Checked = true;
            this.MoveFileStorage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MoveFileStorage.Location = new System.Drawing.Point(12, 235);
            this.MoveFileStorage.Name = "MoveFileStorage";
            this.MoveFileStorage.Size = new System.Drawing.Size(112, 17);
            this.MoveFileStorage.TabIndex = 17;
            this.MoveFileStorage.Text = "Move File Storage";
            this.MoveFileStorage.UseVisualStyleBackColor = true;
            // 
            // ORIStateCode
            // 
            this.ORIStateCode.Location = new System.Drawing.Point(129, 159);
            this.ORIStateCode.Name = "ORIStateCode";
            this.ORIStateCode.Size = new System.Drawing.Size(30, 20);
            this.ORIStateCode.TabIndex = 7;
            this.ORIStateCode.TabStop = false;
            this.ORIStateCode.Text = "*";
            this.ORIStateCode.Visible = false;
            // 
            // FDIDStateCode
            // 
            this.FDIDStateCode.Location = new System.Drawing.Point(129, 186);
            this.FDIDStateCode.Name = "FDIDStateCode";
            this.FDIDStateCode.Size = new System.Drawing.Size(30, 20);
            this.FDIDStateCode.TabIndex = 8;
            this.FDIDStateCode.TabStop = false;
            this.FDIDStateCode.Text = "*";
            this.FDIDStateCode.Visible = false;
            // 
            // MovePrePlan
            // 
            this.MovePrePlan.AutoSize = true;
            this.MovePrePlan.Checked = true;
            this.MovePrePlan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MovePrePlan.Location = new System.Drawing.Point(12, 212);
            this.MovePrePlan.Name = "MovePrePlan";
            this.MovePrePlan.Size = new System.Drawing.Size(135, 17);
            this.MovePrePlan.TabIndex = 93;
            this.MovePrePlan.Text = "Move Mobile Pre Plans";
            this.MovePrePlan.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 257);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(514, 22);
            this.statusStrip1.TabIndex = 94;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 279);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MovePrePlan);
            this.Controls.Add(this.FDIDStateCode);
            this.Controls.Add(this.ORIStateCode);
            this.Controls.Add(this.MoveFileStorage);
            this.Controls.Add(this.MoveFDIDs);
            this.Controls.Add(this.MoveORIs);
            this.Controls.Add(this.MoveFRFolder);
            this.Controls.Add(this.LicenseKeyMove);
            this.Controls.Add(this.MergeResultsMove);
            this.Controls.Add(this.MoveAdminClientSettingsXml);
            this.Controls.Add(this.MoveSecurityXml);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MoveClientSettingsXml);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Location_Copy_To);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Location_Copy_From);
            this.Controls.Add(this.Copy_Button);
            this.Controls.Add(this.Help_Button);
            this.Name = "Form1";
            this.Text = "Server Migration Utility 1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Help_Button;
        private System.Windows.Forms.Button Copy_Button;
        private System.Windows.Forms.TextBox Location_Copy_From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Location_Copy_To;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox MoveClientSettingsXml;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox MoveSecurityXml;
        private System.Windows.Forms.CheckBox MoveAdminClientSettingsXml;
        private System.Windows.Forms.CheckBox MergeResultsMove;
        private System.Windows.Forms.CheckBox LicenseKeyMove;
        private System.Windows.Forms.CheckBox MoveFRFolder;
        private System.Windows.Forms.CheckBox MoveORIs;
        private System.Windows.Forms.CheckBox MoveFDIDs;
        private System.Windows.Forms.CheckBox MoveFileStorage;
        private System.Windows.Forms.TextBox ORIStateCode;
        private System.Windows.Forms.TextBox FDIDStateCode;
        private System.Windows.Forms.CheckBox MovePrePlan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

