using dotSwitcher.Data;

namespace dotSwitcher.UI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.buttonCancelSettings = new System.Windows.Forms.Button();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.checkBoxTrayIcon = new System.Windows.Forms.CheckBox();
            this.checkBoxAutorun = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGithub = new System.Windows.Forms.Button();
            this.textBoxSwitchLayoutHotkey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSwitchHotkey = new System.Windows.Forms.TextBox();
            this.textBoxConvertHotkey = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxSmartSelection = new System.Windows.Forms.CheckBox();
            this.checkBoxReplace = new System.Windows.Forms.CheckBox();
            this.checkBoxReplaceEnter = new System.Windows.Forms.CheckBox();
            this.checkBoxReplaceSpace = new System.Windows.Forms.CheckBox();
            this.replacementOptionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddReplacement = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxReplaceHotkey = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelSettings
            // 
            this.buttonCancelSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelSettings.Location = new System.Drawing.Point(284, 239);
            this.buttonCancelSettings.Name = "buttonCancelSettings";
            this.buttonCancelSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelSettings.TabIndex = 17;
            this.buttonCancelSettings.Text = "Cancel";
            this.buttonCancelSettings.UseVisualStyleBackColor = true;
            this.buttonCancelSettings.Click += new System.EventHandler(this.buttonCancelSettings_Click);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(203, 239);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSettings.TabIndex = 15;
            this.buttonSaveSettings.Text = "Apply";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(32, 239);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Exit program";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // checkBoxTrayIcon
            // 
            this.checkBoxTrayIcon.AutoSize = true;
            this.checkBoxTrayIcon.Location = new System.Drawing.Point(12, 45);
            this.checkBoxTrayIcon.Name = "checkBoxTrayIcon";
            this.checkBoxTrayIcon.Size = new System.Drawing.Size(96, 17);
            this.checkBoxTrayIcon.TabIndex = 20;
            this.checkBoxTrayIcon.Text = "Show tray icon";
            this.checkBoxTrayIcon.UseVisualStyleBackColor = true;
            this.checkBoxTrayIcon.CheckedChanged += new System.EventHandler(this.checkBoxTrayIcon_CheckedChanged);
            // 
            // checkBoxAutorun
            // 
            this.checkBoxAutorun.AutoSize = true;
            this.checkBoxAutorun.Location = new System.Drawing.Point(12, 22);
            this.checkBoxAutorun.Name = "checkBoxAutorun";
            this.checkBoxAutorun.Size = new System.Drawing.Size(145, 17);
            this.checkBoxAutorun.TabIndex = 19;
            this.checkBoxAutorun.Text = "Start on Windows startup";
            this.checkBoxAutorun.UseVisualStyleBackColor = true;
            this.checkBoxAutorun.CheckedChanged += new System.EventHandler(this.checkBoxAutorun_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Convert-selection:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Convert-last-word:";
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(11, 170);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(47, 20);
            this.textBoxDelay.TabIndex = 25;
            this.textBoxDelay.TextChanged += new System.EventHandler(this.textBoxDelay_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Delay before switching:";
            // 
            // buttonGithub
            // 
            this.buttonGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGithub.Image = global::dotSwitcher.Properties.Resources.github;
            this.buttonGithub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGithub.Location = new System.Drawing.Point(11, 197);
            this.buttonGithub.Name = "buttonGithub";
            this.buttonGithub.Size = new System.Drawing.Size(114, 23);
            this.buttonGithub.TabIndex = 28;
            this.buttonGithub.Text = "Report an issue";
            this.buttonGithub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGithub.UseVisualStyleBackColor = true;
            this.buttonGithub.Click += new System.EventHandler(this.buttonGithub_Click);
            // 
            // textBoxSwitchLayoutHotkey
            // 
            this.textBoxSwitchLayoutHotkey.Location = new System.Drawing.Point(7, 164);
            this.textBoxSwitchLayoutHotkey.Name = "textBoxSwitchLayoutHotkey";
            this.textBoxSwitchLayoutHotkey.Size = new System.Drawing.Size(169, 20);
            this.textBoxSwitchLayoutHotkey.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Switch keyboard layout:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxReplaceHotkey);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSwitchLayoutHotkey);
            this.groupBox1.Controls.Add(this.textBoxSwitchHotkey);
            this.groupBox1.Controls.Add(this.textBoxConvertHotkey);
            this.groupBox1.Location = new System.Drawing.Point(178, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 208);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotkeys";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "?";
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            this.label5.MouseHover += new System.EventHandler(this.label5_MouseHover);
            // 
            // textBoxSwitchHotkey
            // 
            this.textBoxSwitchHotkey.Location = new System.Drawing.Point(7, 38);
            this.textBoxSwitchHotkey.Name = "textBoxSwitchHotkey";
            this.textBoxSwitchHotkey.Size = new System.Drawing.Size(169, 20);
            this.textBoxSwitchHotkey.TabIndex = 21;
            // 
            // textBoxConvertHotkey
            // 
            this.textBoxConvertHotkey.Location = new System.Drawing.Point(7, 77);
            this.textBoxConvertHotkey.Name = "textBoxConvertHotkey";
            this.textBoxConvertHotkey.Size = new System.Drawing.Size(169, 20);
            this.textBoxConvertHotkey.TabIndex = 24;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // checkBoxSmartSelection
            // 
            this.checkBoxSmartSelection.AutoSize = true;
            this.checkBoxSmartSelection.Checked = true;
            this.checkBoxSmartSelection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSmartSelection.Location = new System.Drawing.Point(11, 131);
            this.checkBoxSmartSelection.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSmartSelection.Name = "checkBoxSmartSelection";
            this.checkBoxSmartSelection.Size = new System.Drawing.Size(157, 17);
            this.checkBoxSmartSelection.TabIndex = 33;
            this.checkBoxSmartSelection.Text = "Use smart convert selection";
            this.checkBoxSmartSelection.UseVisualStyleBackColor = true;
            this.checkBoxSmartSelection.CheckedChanged += new System.EventHandler(this.smartSelection_CheckedChanged);
            // 
            // checkBoxReplace
            // 
            this.checkBoxReplace.AutoSize = true;
            this.checkBoxReplace.Location = new System.Drawing.Point(12, 68);
            this.checkBoxReplace.Name = "checkBoxReplace";
            this.checkBoxReplace.Size = new System.Drawing.Size(91, 17);
            this.checkBoxReplace.TabIndex = 34;
            this.checkBoxReplace.Text = "Auto-Replace";
            this.checkBoxReplace.UseVisualStyleBackColor = true;
            this.checkBoxReplace.CheckedChanged += new System.EventHandler(this.checkBoxReplace_CheckedChanged);
            // 
            // checkBoxReplaceEnter
            // 
            this.checkBoxReplaceEnter.AutoSize = true;
            this.checkBoxReplaceEnter.Location = new System.Drawing.Point(29, 89);
            this.checkBoxReplaceEnter.Name = "checkBoxReplaceEnter";
            this.checkBoxReplaceEnter.Size = new System.Drawing.Size(109, 17);
            this.checkBoxReplaceEnter.TabIndex = 35;
            this.checkBoxReplaceEnter.Text = "Replace on Enter";
            this.checkBoxReplaceEnter.UseVisualStyleBackColor = true;
            this.checkBoxReplaceEnter.CheckedChanged += new System.EventHandler(this.checkBoxReplaceEnter_CheckedChanged);
            // 
            // checkBoxReplaceSpace
            // 
            this.checkBoxReplaceSpace.AutoSize = true;
            this.checkBoxReplaceSpace.Location = new System.Drawing.Point(29, 109);
            this.checkBoxReplaceSpace.Name = "checkBoxReplaceSpace";
            this.checkBoxReplaceSpace.Size = new System.Drawing.Size(115, 17);
            this.checkBoxReplaceSpace.TabIndex = 36;
            this.checkBoxReplaceSpace.Text = "Replace on Space";
            this.checkBoxReplaceSpace.UseVisualStyleBackColor = true;
            this.checkBoxReplaceSpace.CheckedChanged += new System.EventHandler(this.checkBoxReplaceSpace_CheckedChanged);
            // 
            // replacementOptionsPanel
            // 
            this.replacementOptionsPanel.AutoScroll = true;
            this.replacementOptionsPanel.AutoSize = true;
            this.replacementOptionsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.replacementOptionsPanel.Location = new System.Drawing.Point(381, 34);
            this.replacementOptionsPanel.MaximumSize = new System.Drawing.Size(303, 198);
            this.replacementOptionsPanel.Name = "replacementOptionsPanel";
            this.replacementOptionsPanel.Size = new System.Drawing.Size(303, 198);
            this.replacementOptionsPanel.TabIndex = 37;
            this.replacementOptionsPanel.WrapContents = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddReplacement);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(379, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 259);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Replacement pairs";
            // 
            // buttonAddReplacement
            // 
            this.buttonAddReplacement.Location = new System.Drawing.Point(6, 228);
            this.buttonAddReplacement.Name = "buttonAddReplacement";
            this.buttonAddReplacement.Size = new System.Drawing.Size(62, 24);
            this.buttonAddReplacement.TabIndex = 39;
            this.buttonAddReplacement.Text = "Add";
            this.buttonAddReplacement.UseVisualStyleBackColor = true;
            this.buttonAddReplacement.Click += new System.EventHandler(this.buttonAddReplacement_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "?";
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Replace-last-word";
            // 
            // textBoxReplaceHotkey
            // 
            this.textBoxReplaceHotkey.Location = new System.Drawing.Point(7, 119);
            this.textBoxReplaceHotkey.Name = "textBoxReplaceHotkey";
            this.textBoxReplaceHotkey.Size = new System.Drawing.Size(169, 20);
            this.textBoxReplaceHotkey.TabIndex = 33;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonSaveSettings;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelSettings;
            this.ClientSize = new System.Drawing.Size(696, 281);
            this.Controls.Add(this.replacementOptionsPanel);
            this.Controls.Add(this.checkBoxReplaceSpace);
            this.Controls.Add(this.checkBoxReplaceEnter);
            this.Controls.Add(this.checkBoxReplace);
            this.Controls.Add(this.checkBoxSmartSelection);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGithub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDelay);
            this.Controls.Add(this.checkBoxTrayIcon);
            this.Controls.Add(this.checkBoxAutorun);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.buttonCancelSettings);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "dotSwitcher Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxReplaceHotkey;

        private System.Windows.Forms.Button buttonAddReplacement;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.FlowLayoutPanel replacementOptionsPanel;

        private System.Windows.Forms.CheckBox checkBoxReplace;
        private System.Windows.Forms.CheckBox checkBoxReplaceEnter;
        private System.Windows.Forms.CheckBox checkBoxReplaceSpace;

        #endregion

        private System.Windows.Forms.Button buttonCancelSettings;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.CheckBox checkBoxTrayIcon;
        private System.Windows.Forms.CheckBox checkBoxAutorun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGithub;
        private System.Windows.Forms.TextBox textBoxSwitchLayoutHotkey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxSwitchHotkey;
        private System.Windows.Forms.TextBox textBoxConvertHotkey;
        private System.Windows.Forms.CheckBox checkBoxSmartSelection;
    }
}