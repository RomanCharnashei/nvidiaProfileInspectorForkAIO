namespace nspector
{
    partial class frmDrvSettings
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrvSettings));
            ilListView = new System.Windows.Forms.ImageList(components);
            pbMain = new System.Windows.Forms.ProgressBar();
            tsMain = new System.Windows.Forms.ToolStrip();
            tslProfiles = new System.Windows.Forms.ToolStripLabel();
            cbProfiles = new System.Windows.Forms.ToolStripComboBox();
            tsbModifiedProfiles = new System.Windows.Forms.ToolStripSplitButton();
            tsSep1 = new System.Windows.Forms.ToolStripSeparator();
            tsbRefreshProfile = new System.Windows.Forms.ToolStripButton();
            tsbRestoreProfile = new System.Windows.Forms.ToolStripButton();
            tsbCreateProfile = new System.Windows.Forms.ToolStripButton();
            tsbDeleteProfile = new System.Windows.Forms.ToolStripButton();
            tsSep2 = new System.Windows.Forms.ToolStripSeparator();
            tsbAddApplication = new System.Windows.Forms.ToolStripButton();
            tssbRemoveApplication = new System.Windows.Forms.ToolStripSplitButton();
            tsSep3 = new System.Windows.Forms.ToolStripSeparator();
            tsbExportProfiles = new System.Windows.Forms.ToolStripSplitButton();
            exportCurrentProfileOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportCurrentProfileIncludingPredefinedSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportUserdefinedProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportAllProfilesNVIDIATextFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsbImportProfiles = new System.Windows.Forms.ToolStripSplitButton();
            importProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            importAllProfilesNVIDIATextFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsSep4 = new System.Windows.Forms.ToolStripSeparator();
            tscbShowCustomSettingNamesOnly = new System.Windows.Forms.ToolStripButton();
            tsSep5 = new System.Windows.Forms.ToolStripSeparator();
            tscbShowScannedUnknownSettings = new System.Windows.Forms.ToolStripButton();
            tsbBitValueEditor = new System.Windows.Forms.ToolStripButton();
            tsSep6 = new System.Windows.Forms.ToolStripSeparator();
            tsbApplyProfile = new System.Windows.Forms.ToolStripButton();
            tslFilter = new System.Windows.Forms.ToolStripLabel();
            cbFilter = new System.Windows.Forms.ToolStripComboBox();
            tsSep7 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            btnResetValue = new System.Windows.Forms.Button();
            lblApplications = new System.Windows.Forms.Label();
            toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            ilCombo = new System.Windows.Forms.ImageList(components);
            cbValues = new System.Windows.Forms.ComboBox();
            lblWidth96 = new System.Windows.Forms.Label();
            lblWidth330 = new System.Windows.Forms.Label();
            lblWidth16 = new System.Windows.Forms.Label();
            lblWidth30 = new System.Windows.Forms.Label();
            lvSettings = new ListViewEx();
            chSettingID = new System.Windows.Forms.ColumnHeader();
            chSettingValue = new System.Windows.Forms.ColumnHeader();
            chSettingValueHex = new System.Windows.Forms.ColumnHeader();
            tbSettingDescription = new System.Windows.Forms.TextBox();
            pnlListview = new System.Windows.Forms.Panel();
            toolStripExportSettingsButton = new System.Windows.Forms.ToolStripButton();
            tsMain.SuspendLayout();
            pnlListview.SuspendLayout();
            SuspendLayout();
            // 
            // ilListView
            // 
            ilListView.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            ilListView.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ilListView.ImageStream");
            ilListView.TransparentColor = System.Drawing.Color.Transparent;
            ilListView.Images.SetKeyName(0, "0_gear2.png");
            ilListView.Images.SetKeyName(1, "1_gear2_2.png");
            ilListView.Images.SetKeyName(2, "4_gear_nv2.png");
            ilListView.Images.SetKeyName(3, "6_gear_inherit.png");
            // 
            // pbMain
            // 
            pbMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pbMain.Location = new System.Drawing.Point(14, 548);
            pbMain.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            pbMain.Name = "pbMain";
            pbMain.Size = new System.Drawing.Size(1189, 10);
            pbMain.TabIndex = 19;
            // 
            // tsMain
            // 
            tsMain.AllowMerge = false;
            tsMain.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tsMain.AutoSize = false;
            tsMain.BackgroundImage = Properties.Resources.transparent16;
            tsMain.CanOverflow = false;
            tsMain.Dock = System.Windows.Forms.DockStyle.None;
            tsMain.GripMargin = new System.Windows.Forms.Padding(0);
            tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tslProfiles, cbProfiles, tsbModifiedProfiles, tsSep1, tsbRefreshProfile, tsbRestoreProfile, tsbCreateProfile, tsbDeleteProfile, tsSep2, tsbAddApplication, tssbRemoveApplication, tsSep3, tsbExportProfiles, tsbImportProfiles, toolStripExportSettingsButton, tsSep4, tscbShowCustomSettingNamesOnly, tsSep5, tscbShowScannedUnknownSettings, tsbBitValueEditor, tsSep6, tsbApplyProfile, tslFilter, cbFilter, tsSep7 });
            tsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            tsMain.Location = new System.Drawing.Point(14, 5);
            tsMain.Name = "tsMain";
            tsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            tsMain.Size = new System.Drawing.Size(1189, 29);
            tsMain.TabIndex = 24;
            tsMain.Text = "toolStrip1";
            // 
            // tslProfiles
            // 
            tslProfiles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tslProfiles.Margin = new System.Windows.Forms.Padding(0, 5, 10, 2);
            tslProfiles.Name = "tslProfiles";
            tslProfiles.Size = new System.Drawing.Size(49, 22);
            tslProfiles.Text = "Profiles:";
            // 
            // cbProfiles
            // 
            cbProfiles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            cbProfiles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbProfiles.AutoSize = false;
            cbProfiles.DropDownWidth = 290;
            cbProfiles.Margin = new System.Windows.Forms.Padding(1);
            cbProfiles.MaxDropDownItems = 50;
            cbProfiles.Name = "cbProfiles";
            cbProfiles.Size = new System.Drawing.Size(338, 23);
            cbProfiles.SelectedIndexChanged += cbProfiles_SelectedIndexChanged;
            cbProfiles.TextChanged += cbProfiles_TextChanged;
            // 
            // tsbModifiedProfiles
            // 
            tsbModifiedProfiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbModifiedProfiles.Enabled = false;
            tsbModifiedProfiles.Image = Properties.Resources.home_sm;
            tsbModifiedProfiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbModifiedProfiles.Name = "tsbModifiedProfiles";
            tsbModifiedProfiles.Size = new System.Drawing.Size(36, 26);
            tsbModifiedProfiles.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            tsbModifiedProfiles.ToolTipText = "Back to global profile (Home) / User modified profiles";
            tsbModifiedProfiles.ButtonClick += tsbModifiedProfiles_ButtonClick;
            tsbModifiedProfiles.DropDownItemClicked += tsbModifiedProfiles_DropDownItemClicked;
            // 
            // tsSep1
            // 
            tsSep1.Name = "tsSep1";
            tsSep1.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbRefreshProfile
            // 
            tsbRefreshProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbRefreshProfile.Image = (System.Drawing.Image)resources.GetObject("tsbRefreshProfile.Image");
            tsbRefreshProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbRefreshProfile.Name = "tsbRefreshProfile";
            tsbRefreshProfile.Size = new System.Drawing.Size(24, 26);
            tsbRefreshProfile.Text = "Refresh current profile.";
            tsbRefreshProfile.Click += tsbRefreshProfile_Click;
            // 
            // tsbRestoreProfile
            // 
            tsbRestoreProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbRestoreProfile.Image = (System.Drawing.Image)resources.GetObject("tsbRestoreProfile.Image");
            tsbRestoreProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbRestoreProfile.Name = "tsbRestoreProfile";
            tsbRestoreProfile.Size = new System.Drawing.Size(24, 26);
            tsbRestoreProfile.Text = "Restore current profile to NVIDIA defaults.";
            tsbRestoreProfile.Click += tsbRestoreProfile_Click;
            // 
            // tsbCreateProfile
            // 
            tsbCreateProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbCreateProfile.Image = (System.Drawing.Image)resources.GetObject("tsbCreateProfile.Image");
            tsbCreateProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbCreateProfile.Name = "tsbCreateProfile";
            tsbCreateProfile.Size = new System.Drawing.Size(24, 26);
            tsbCreateProfile.Text = "Create new profile";
            tsbCreateProfile.Click += tsbCreateProfile_Click;
            // 
            // tsbDeleteProfile
            // 
            tsbDeleteProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbDeleteProfile.Image = Properties.Resources.ieframe_1_18212;
            tsbDeleteProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbDeleteProfile.Name = "tsbDeleteProfile";
            tsbDeleteProfile.Size = new System.Drawing.Size(24, 26);
            tsbDeleteProfile.Text = "Delete current Profile";
            tsbDeleteProfile.Click += tsbDeleteProfile_Click;
            // 
            // tsSep2
            // 
            tsSep2.Name = "tsSep2";
            tsSep2.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbAddApplication
            // 
            tsbAddApplication.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbAddApplication.Image = Properties.Resources.window_application_add;
            tsbAddApplication.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbAddApplication.Name = "tsbAddApplication";
            tsbAddApplication.Size = new System.Drawing.Size(24, 26);
            tsbAddApplication.Text = "Add application to current profile.";
            tsbAddApplication.Click += tsbAddApplication_Click;
            // 
            // tssbRemoveApplication
            // 
            tssbRemoveApplication.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tssbRemoveApplication.Image = Properties.Resources.window_application_delete;
            tssbRemoveApplication.ImageTransparentColor = System.Drawing.Color.Magenta;
            tssbRemoveApplication.Name = "tssbRemoveApplication";
            tssbRemoveApplication.Size = new System.Drawing.Size(36, 26);
            tssbRemoveApplication.Text = "Remove application from current profile";
            tssbRemoveApplication.DropDownItemClicked += tssbRemoveApplication_DropDownItemClicked;
            tssbRemoveApplication.Click += tssbRemoveApplication_Click;
            // 
            // tsSep3
            // 
            tsSep3.Name = "tsSep3";
            tsSep3.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbExportProfiles
            // 
            tsbExportProfiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbExportProfiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exportCurrentProfileOnlyToolStripMenuItem, exportCurrentProfileIncludingPredefinedSettingsToolStripMenuItem, exportUserdefinedProfilesToolStripMenuItem, exportAllProfilesNVIDIATextFormatToolStripMenuItem });
            tsbExportProfiles.Image = Properties.Resources.export1;
            tsbExportProfiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbExportProfiles.Name = "tsbExportProfiles";
            tsbExportProfiles.Size = new System.Drawing.Size(36, 26);
            tsbExportProfiles.Text = "Export user defined profiles";
            tsbExportProfiles.Click += tsbExportProfiles_Click;
            // 
            // exportCurrentProfileOnlyToolStripMenuItem
            // 
            exportCurrentProfileOnlyToolStripMenuItem.Name = "exportCurrentProfileOnlyToolStripMenuItem";
            exportCurrentProfileOnlyToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            exportCurrentProfileOnlyToolStripMenuItem.Text = "Export current profile only";
            exportCurrentProfileOnlyToolStripMenuItem.Click += exportCurrentProfileOnlyToolStripMenuItem_Click;
            // 
            // exportCurrentProfileIncludingPredefinedSettingsToolStripMenuItem
            // 
            exportCurrentProfileIncludingPredefinedSettingsToolStripMenuItem.Name = "exportCurrentProfileIncludingPredefinedSettingsToolStripMenuItem";
            exportCurrentProfileIncludingPredefinedSettingsToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            exportCurrentProfileIncludingPredefinedSettingsToolStripMenuItem.Text = "Export current profile including predefined settings";
            exportCurrentProfileIncludingPredefinedSettingsToolStripMenuItem.Click += exportCurrentProfileIncludingPredefinedSettingsToolStripMenuItem_Click;
            // 
            // exportUserdefinedProfilesToolStripMenuItem
            // 
            exportUserdefinedProfilesToolStripMenuItem.Name = "exportUserdefinedProfilesToolStripMenuItem";
            exportUserdefinedProfilesToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            exportUserdefinedProfilesToolStripMenuItem.Text = "Export all customized profiles";
            exportUserdefinedProfilesToolStripMenuItem.Click += exportUserdefinedProfilesToolStripMenuItem_Click;
            // 
            // exportAllProfilesNVIDIATextFormatToolStripMenuItem
            // 
            exportAllProfilesNVIDIATextFormatToolStripMenuItem.Name = "exportAllProfilesNVIDIATextFormatToolStripMenuItem";
            exportAllProfilesNVIDIATextFormatToolStripMenuItem.Size = new System.Drawing.Size(343, 22);
            exportAllProfilesNVIDIATextFormatToolStripMenuItem.Text = "Export all driver profiles (NVIDIA Text Format)";
            exportAllProfilesNVIDIATextFormatToolStripMenuItem.Click += exportAllProfilesNVIDIATextFormatToolStripMenuItem_Click;
            // 
            // tsbImportProfiles
            // 
            tsbImportProfiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbImportProfiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { importProfilesToolStripMenuItem, importAllProfilesNVIDIATextFormatToolStripMenuItem });
            tsbImportProfiles.Image = Properties.Resources.import1;
            tsbImportProfiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbImportProfiles.Name = "tsbImportProfiles";
            tsbImportProfiles.Size = new System.Drawing.Size(36, 26);
            tsbImportProfiles.Text = "Import user defined profiles";
            tsbImportProfiles.Click += tsbImportProfiles_Click;
            // 
            // importProfilesToolStripMenuItem
            // 
            importProfilesToolStripMenuItem.Name = "importProfilesToolStripMenuItem";
            importProfilesToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            importProfilesToolStripMenuItem.Text = "Import profile(s)";
            importProfilesToolStripMenuItem.Click += importProfilesToolStripMenuItem_Click;
            // 
            // importAllProfilesNVIDIATextFormatToolStripMenuItem
            // 
            importAllProfilesNVIDIATextFormatToolStripMenuItem.Name = "importAllProfilesNVIDIATextFormatToolStripMenuItem";
            importAllProfilesNVIDIATextFormatToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            importAllProfilesNVIDIATextFormatToolStripMenuItem.Text = "Import (replace) all driver profiles (NVIDIA Text Format)";
            importAllProfilesNVIDIATextFormatToolStripMenuItem.Click += importAllProfilesNVIDIATextFormatToolStripMenuItem_Click;
            // 
            // tsSep4
            // 
            tsSep4.Name = "tsSep4";
            tsSep4.Size = new System.Drawing.Size(6, 29);
            // 
            // tscbShowCustomSettingNamesOnly
            // 
            tscbShowCustomSettingNamesOnly.CheckOnClick = true;
            tscbShowCustomSettingNamesOnly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tscbShowCustomSettingNamesOnly.Image = Properties.Resources.filter_user;
            tscbShowCustomSettingNamesOnly.ImageTransparentColor = System.Drawing.Color.Magenta;
            tscbShowCustomSettingNamesOnly.Name = "tscbShowCustomSettingNamesOnly";
            tscbShowCustomSettingNamesOnly.Size = new System.Drawing.Size(24, 26);
            tscbShowCustomSettingNamesOnly.Text = "Show the settings and values from CustomSettingNames file only.";
            tscbShowCustomSettingNamesOnly.CheckedChanged += cbCustomSettingsOnly_CheckedChanged;
            // 
            // tsSep5
            // 
            tsSep5.Name = "tsSep5";
            tsSep5.Size = new System.Drawing.Size(6, 29);
            // 
            // tscbShowScannedUnknownSettings
            // 
            tscbShowScannedUnknownSettings.CheckOnClick = true;
            tscbShowScannedUnknownSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tscbShowScannedUnknownSettings.Enabled = false;
            tscbShowScannedUnknownSettings.Image = Properties.Resources.find_set2;
            tscbShowScannedUnknownSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            tscbShowScannedUnknownSettings.Name = "tscbShowScannedUnknownSettings";
            tscbShowScannedUnknownSettings.Size = new System.Drawing.Size(24, 26);
            tscbShowScannedUnknownSettings.Text = "Show unknown settings from NVIDIA predefined profiles";
            tscbShowScannedUnknownSettings.Click += tscbShowScannedUnknownSettings_Click;
            // 
            // tsbBitValueEditor
            // 
            tsbBitValueEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbBitValueEditor.Image = Properties.Resources.text_binary;
            tsbBitValueEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbBitValueEditor.Name = "tsbBitValueEditor";
            tsbBitValueEditor.Size = new System.Drawing.Size(24, 26);
            tsbBitValueEditor.Text = "Show bit value editor.";
            tsbBitValueEditor.Click += tsbBitValueEditor_Click;
            // 
            // tsSep6
            // 
            tsSep6.Name = "tsSep6";
            tsSep6.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbApplyProfile
            // 
            tsbApplyProfile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            tsbApplyProfile.Image = Properties.Resources.apply;
            tsbApplyProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbApplyProfile.Name = "tsbApplyProfile";
            tsbApplyProfile.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            tsbApplyProfile.Size = new System.Drawing.Size(109, 26);
            tsbApplyProfile.Text = "Apply changes";
            tsbApplyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            tsbApplyProfile.Click += tsbApplyProfile_Click;
            // 
            // tslFilter
            // 
            tslFilter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tslFilter.Margin = new System.Windows.Forms.Padding(0, 5, 10, 2);
            tslFilter.Name = "tslFilter";
            tslFilter.Size = new System.Drawing.Size(36, 22);
            tslFilter.Text = "Filter:";
            // 
            // cbFilter
            // 
            cbFilter.AutoSize = false;
            cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            cbFilter.DropDownWidth = 290;
            cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            cbFilter.Margin = new System.Windows.Forms.Padding(1);
            cbFilter.MaxDropDownItems = 50;
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new System.Drawing.Size(151, 172);
            cbFilter.KeyDown += cbFilter_KeyDown;
            cbFilter.TextChanged += cbFilter_TextChanged;
            // 
            // tsSep7
            // 
            tsSep7.Name = "tsSep7";
            tsSep7.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(23, 22);
            toolStripButton1.Text = "x";
            toolStripButton1.ToolTipText = "ExtractShit";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnResetValue
            // 
            btnResetValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnResetValue.Enabled = false;
            btnResetValue.Image = Properties.Resources.nv_btn;
            btnResetValue.Location = new System.Drawing.Point(1063, 202);
            btnResetValue.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            btnResetValue.Name = "btnResetValue";
            btnResetValue.Size = new System.Drawing.Size(29, 22);
            btnResetValue.TabIndex = 7;
            btnResetValue.UseVisualStyleBackColor = true;
            btnResetValue.Click += btnResetValue_Click;
            // 
            // lblApplications
            // 
            lblApplications.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblApplications.BackColor = System.Drawing.Color.FromArgb(118, 185, 0);
            lblApplications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblApplications.ForeColor = System.Drawing.Color.White;
            lblApplications.Location = new System.Drawing.Point(14, 37);
            lblApplications.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblApplications.Name = "lblApplications";
            lblApplications.Size = new System.Drawing.Size(1189, 20);
            lblApplications.TabIndex = 25;
            lblApplications.Text = "fsagame.exe, bond.exe, herozero.exe";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (System.Drawing.Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new System.Drawing.Size(23, 22);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new System.Drawing.Size(86, 22);
            toolStripLabel2.Text = "toolStripLabel2";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (System.Drawing.Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new System.Drawing.Size(23, 22);
            toolStripButton6.Text = "toolStripButton6";
            // 
            // ilCombo
            // 
            ilCombo.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            ilCombo.ImageSize = new System.Drawing.Size(16, 16);
            ilCombo.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cbValues
            // 
            cbValues.BackColor = System.Drawing.SystemColors.Window;
            cbValues.FormattingEnabled = true;
            cbValues.Location = new System.Drawing.Point(611, 202);
            cbValues.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            cbValues.Name = "cbValues";
            cbValues.Size = new System.Drawing.Size(83, 23);
            cbValues.TabIndex = 5;
            cbValues.Visible = false;
            cbValues.SelectedValueChanged += cbValues_SelectedValueChanged;
            cbValues.Leave += cbValues_Leave;
            // 
            // lblWidth96
            // 
            lblWidth96.Location = new System.Drawing.Point(90, 269);
            lblWidth96.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblWidth96.Name = "lblWidth96";
            lblWidth96.Size = new System.Drawing.Size(112, 21);
            lblWidth96.TabIndex = 77;
            lblWidth96.Text = "96";
            lblWidth96.Visible = false;
            // 
            // lblWidth330
            // 
            lblWidth330.Location = new System.Drawing.Point(90, 242);
            lblWidth330.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblWidth330.Name = "lblWidth330";
            lblWidth330.Size = new System.Drawing.Size(385, 25);
            lblWidth330.TabIndex = 78;
            lblWidth330.Text = "330 (Helper Labels for DPI Scaling)";
            lblWidth330.Visible = false;
            // 
            // lblWidth16
            // 
            lblWidth16.Location = new System.Drawing.Point(90, 310);
            lblWidth16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblWidth16.Name = "lblWidth16";
            lblWidth16.Size = new System.Drawing.Size(19, 21);
            lblWidth16.TabIndex = 79;
            lblWidth16.Text = "16";
            lblWidth16.Visible = false;
            // 
            // lblWidth30
            // 
            lblWidth30.Location = new System.Drawing.Point(90, 290);
            lblWidth30.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblWidth30.Name = "lblWidth30";
            lblWidth30.Size = new System.Drawing.Size(35, 21);
            lblWidth30.TabIndex = 80;
            lblWidth30.Text = "30";
            lblWidth30.Visible = false;
            // 
            // lvSettings
            // 
            lvSettings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chSettingID, chSettingValue, chSettingValueHex });
            lvSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            lvSettings.FullRowSelect = true;
            lvSettings.GridLines = true;
            lvSettings.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lvSettings.Location = new System.Drawing.Point(0, 0);
            lvSettings.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            lvSettings.MultiSelect = false;
            lvSettings.Name = "lvSettings";
            lvSettings.ShowItemToolTips = true;
            lvSettings.Size = new System.Drawing.Size(1189, 430);
            lvSettings.SmallImageList = ilListView;
            lvSettings.TabIndex = 2;
            lvSettings.UseCompatibleStateImageBehavior = false;
            lvSettings.View = System.Windows.Forms.View.Details;
            lvSettings.ColumnWidthChanging += lvSettings_ColumnWidthChanging;
            lvSettings.SelectedIndexChanged += lvSettings_SelectedIndexChanged;
            lvSettings.DoubleClick += lvSettings_DoubleClick;
            lvSettings.KeyDown += lvSettings_KeyDown;
            lvSettings.Resize += lvSettings_Resize;
            // 
            // chSettingID
            // 
            chSettingID.Text = "SettingID";
            chSettingID.Width = 330;
            // 
            // chSettingValue
            // 
            chSettingValue.Text = "SettingValue";
            chSettingValue.Width = 340;
            // 
            // chSettingValueHex
            // 
            chSettingValueHex.Text = "SettingValueHex";
            chSettingValueHex.Width = 96;
            // 
            // tbSettingDescription
            // 
            tbSettingDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            tbSettingDescription.Location = new System.Drawing.Point(0, 430);
            tbSettingDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbSettingDescription.Multiline = true;
            tbSettingDescription.Name = "tbSettingDescription";
            tbSettingDescription.ReadOnly = true;
            tbSettingDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            tbSettingDescription.Size = new System.Drawing.Size(1189, 50);
            tbSettingDescription.TabIndex = 81;
            tbSettingDescription.Visible = false;
            // 
            // pnlListview
            // 
            pnlListview.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlListview.Controls.Add(lvSettings);
            pnlListview.Controls.Add(tbSettingDescription);
            pnlListview.Location = new System.Drawing.Point(14, 60);
            pnlListview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlListview.Name = "pnlListview";
            pnlListview.Size = new System.Drawing.Size(1189, 480);
            pnlListview.TabIndex = 82;
            // 
            // toolStripExportSettingsButton
            // 
            toolStripExportSettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripExportSettingsButton.Image = (System.Drawing.Image)resources.GetObject("toolStripExportSettingsButton.Image");
            toolStripExportSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripExportSettingsButton.Name = "toolStripExportSettingsButton";
            toolStripExportSettingsButton.Size = new System.Drawing.Size(24, 26);
            toolStripExportSettingsButton.Text = "Export current profile all settings";
            toolStripExportSettingsButton.Click += toolStripExportSettingsButton_Click;
            // 
            // frmDrvSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1217, 568);
            Controls.Add(pnlListview);
            Controls.Add(lblWidth30);
            Controls.Add(lblWidth16);
            Controls.Add(lblWidth330);
            Controls.Add(lblWidth96);
            Controls.Add(lblApplications);
            Controls.Add(tsMain);
            Controls.Add(pbMain);
            Controls.Add(btnResetValue);
            Controls.Add(cbValues);
            Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            MinimumSize = new System.Drawing.Size(1233, 393);
            Name = "frmDrvSettings";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "nSpector - Driver Profile Settings";
            Activated += frmDrvSettings_Activated;
            FormClosed += frmDrvSettings_FormClosed;
            Load += frmDrvSettings_Load;
            Shown += frmDrvSettings_Shown;
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            pnlListview.ResumeLayout(false);
            pnlListview.PerformLayout();
            ResumeLayout(false);

        }

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

        #endregion

        private nspector.ListViewEx lvSettings;
        private System.Windows.Forms.ColumnHeader chSettingID;
        private System.Windows.Forms.ColumnHeader chSettingValue;
        private System.Windows.Forms.ColumnHeader chSettingValueHex;
        private System.Windows.Forms.ImageList ilListView;
        private System.Windows.Forms.ComboBox cbValues;
        private System.Windows.Forms.Button btnResetValue;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbRestoreProfile;
        private System.Windows.Forms.ToolStripButton tsbApplyProfile;
        private System.Windows.Forms.ToolStripButton tsbRefreshProfile;
        private System.Windows.Forms.ToolStripSeparator tsSep3;
        private System.Windows.Forms.ToolStripButton tsbBitValueEditor;
        private System.Windows.Forms.ToolStripSeparator tsSep6;
        private System.Windows.Forms.ToolStripButton tscbShowCustomSettingNamesOnly;
        private System.Windows.Forms.ToolStripSeparator tsSep5;
        private System.Windows.Forms.ToolStripButton tscbShowScannedUnknownSettings;
        private System.Windows.Forms.ToolStripLabel tslProfiles;
        private System.Windows.Forms.Label lblApplications;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator tsSep2;
        private System.Windows.Forms.ToolStripButton tsbDeleteProfile;
        private System.Windows.Forms.ToolStripButton tsbCreateProfile;
        private System.Windows.Forms.ToolStripButton tsbAddApplication;
        private System.Windows.Forms.ToolStripSplitButton tssbRemoveApplication;
        private System.Windows.Forms.ToolStripSeparator tsSep4;
        private System.Windows.Forms.ToolStripSplitButton tsbExportProfiles;
        private System.Windows.Forms.ToolStripMenuItem exportCurrentProfileOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportUserdefinedProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tsSep1;
        public System.Windows.Forms.ToolStripComboBox cbProfiles;
        private System.Windows.Forms.ToolStripSplitButton tsbModifiedProfiles;
        private System.Windows.Forms.ImageList ilCombo;
        private System.Windows.Forms.ToolStripMenuItem exportAllProfilesNVIDIATextFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton tsbImportProfiles;
        private System.Windows.Forms.ToolStripMenuItem importProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAllProfilesNVIDIATextFormatToolStripMenuItem;
        private System.Windows.Forms.Label lblWidth96;
        private System.Windows.Forms.Label lblWidth330;
        private System.Windows.Forms.Label lblWidth16;
        private System.Windows.Forms.Label lblWidth30;
        private System.Windows.Forms.ToolStripMenuItem exportCurrentProfileIncludingPredefinedSettingsToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSettingDescription;
        private System.Windows.Forms.Panel pnlListview;
        private System.Windows.Forms.ToolStripLabel tslFilter;
        public System.Windows.Forms.ToolStripComboBox cbFilter;
        private System.Windows.Forms.ToolStripSeparator tsSep7;
        private System.Windows.Forms.ToolStripButton toolStripExportSettingsButton;
    }
}
