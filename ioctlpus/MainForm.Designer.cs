namespace ioctlpus
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
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPanes = new System.Windows.Forms.TableLayoutPanel();
            this.gbRightPane = new System.Windows.Forms.GroupBox();
            this.hbOutput = new Be.Windows.Forms.HexBox();
            this.gbLeftPane = new System.Windows.Forms.GroupBox();
            this.hbInput = new Be.Windows.Forms.HexBox();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.pnlReqParams = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnlPanes = new System.Windows.Forms.Panel();
            this.pnlLeftPanePrePost = new System.Windows.Forms.Panel();
            this.rbLeftPanePostCall = new System.Windows.Forms.RadioButton();
            this.rbLeftPanePreCall = new System.Windows.Forms.RadioButton();
            this.pnlRightPanePrePost = new System.Windows.Forms.Panel();
            this.rbRightPanePostCall = new System.Windows.Forms.RadioButton();
            this.rbRightPanePreCall = new System.Windows.Forms.RadioButton();
            this.pnlLeftPaneView = new System.Windows.Forms.Panel();
            this.rbLeftPaneStringsView = new System.Windows.Forms.RadioButton();
            this.rbLeftPaneStructEdit = new System.Windows.Forms.RadioButton();
            this.rbLeftPaneStructView = new System.Windows.Forms.RadioButton();
            this.rbLeftPaneHexView = new System.Windows.Forms.RadioButton();
            this.pnlRightPaneView = new System.Windows.Forms.Panel();
            this.rbRightPaneStringsView = new System.Windows.Forms.RadioButton();
            this.rbRightPaneStuctEdit = new System.Windows.Forms.RadioButton();
            this.rbRightPaneStructView = new System.Windows.Forms.RadioButton();
            this.rbRightPaneHexView = new System.Windows.Forms.RadioButton();
            this.pnlRightPaneInOut = new System.Windows.Forms.Panel();
            this.rbRightPaneOut = new System.Windows.Forms.RadioButton();
            this.rbRightPaneIn = new System.Windows.Forms.RadioButton();
            this.pnlLeftPaneInOut = new System.Windows.Forms.Panel();
            this.rbLeftPaneOut = new System.Windows.Forms.RadioButton();
            this.rbLeftPaneIn = new System.Windows.Forms.RadioButton();
            this.lblRightPane = new System.Windows.Forms.Label();
            this.lblLeftPane = new System.Windows.Forms.Label();
            this.lblOutputSize = new System.Windows.Forms.Label();
            this.nudOutputSize = new System.Windows.Forms.NumericUpDown();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.nudRepeat = new System.Windows.Forms.NumericUpDown();
            this.lblInputSize = new System.Windows.Forms.Label();
            this.lblIOCTLCode = new System.Windows.Forms.Label();
            this.tbIOCTL = new System.Windows.Forms.TextBox();
            this.tbDevicePath = new System.Windows.Forms.TextBox();
            this.lblDevPath = new System.Windows.Forms.Label();
            this.nudInputSize = new System.Windows.Forms.NumericUpDown();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbRequestHistory = new System.Windows.Forms.GroupBox();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.tbFilters = new System.Windows.Forms.TextBox();
            this.btnStarRequest = new System.Windows.Forms.Button();
            this.btnDeleteRequest = new System.Windows.Forms.Button();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.tlvRequestHistory = new BrightIdeasSoftware.TreeListView();
            this.olvColumnRequest = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnRetVal = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnBytesReturned = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpPanes.SuspendLayout();
            this.gbRightPane.SuspendLayout();
            this.gbLeftPane.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.pnlReqParams.SuspendLayout();
            this.pnlPanes.SuspendLayout();
            this.pnlLeftPanePrePost.SuspendLayout();
            this.pnlRightPanePrePost.SuspendLayout();
            this.pnlLeftPaneView.SuspendLayout();
            this.pnlRightPaneView.SuspendLayout();
            this.pnlRightPaneInOut.SuspendLayout();
            this.pnlLeftPaneInOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputSize)).BeginInit();
            this.gbRequestHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlvRequestHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpPanes, 0, 1);
            this.tlpMain.Controls.Add(this.tlpTop, 0, 0);
            this.tlpMain.Controls.Add(this.gbRequestHistory, 0, 2);
            this.tlpMain.Location = new System.Drawing.Point(12, 12);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.Size = new System.Drawing.Size(780, 537);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpPanes
            // 
            this.tlpPanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPanes.ColumnCount = 2;
            this.tlpPanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanes.Controls.Add(this.gbRightPane, 1, 0);
            this.tlpPanes.Controls.Add(this.gbLeftPane, 0, 0);
            this.tlpPanes.Location = new System.Drawing.Point(3, 93);
            this.tlpPanes.Name = "tlpPanes";
            this.tlpPanes.RowCount = 1;
            this.tlpPanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tlpPanes.Size = new System.Drawing.Size(774, 262);
            this.tlpPanes.TabIndex = 0;
            // 
            // gbRightPane
            // 
            this.gbRightPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRightPane.Controls.Add(this.hbOutput);
            this.gbRightPane.Location = new System.Drawing.Point(390, 3);
            this.gbRightPane.Name = "gbRightPane";
            this.gbRightPane.Size = new System.Drawing.Size(381, 256);
            this.gbRightPane.TabIndex = 1;
            this.gbRightPane.TabStop = false;
            this.gbRightPane.Text = "Output Buffer";
            // 
            // hbOutput
            // 
            this.hbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hbOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hbOutput.InfoForeColor = System.Drawing.Color.Empty;
            this.hbOutput.Location = new System.Drawing.Point(6, 19);
            this.hbOutput.Name = "hbOutput";
            this.hbOutput.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbOutput.Size = new System.Drawing.Size(369, 231);
            this.hbOutput.TabIndex = 0;
            // 
            // gbLeftPane
            // 
            this.gbLeftPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLeftPane.Controls.Add(this.hbInput);
            this.gbLeftPane.Location = new System.Drawing.Point(3, 3);
            this.gbLeftPane.Name = "gbLeftPane";
            this.gbLeftPane.Size = new System.Drawing.Size(381, 256);
            this.gbLeftPane.TabIndex = 0;
            this.gbLeftPane.TabStop = false;
            this.gbLeftPane.Text = "Input Buffer";
            // 
            // hbInput
            // 
            this.hbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hbInput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hbInput.InfoForeColor = System.Drawing.Color.Empty;
            this.hbInput.Location = new System.Drawing.Point(6, 19);
            this.hbInput.Name = "hbInput";
            this.hbInput.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbInput.Size = new System.Drawing.Size(369, 231);
            this.hbInput.TabIndex = 0;
            // 
            // tlpTop
            // 
            this.tlpTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTop.ColumnCount = 1;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.Controls.Add(this.pnlReqParams, 0, 0);
            this.tlpTop.Location = new System.Drawing.Point(3, 3);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.Size = new System.Drawing.Size(774, 84);
            this.tlpTop.TabIndex = 2;
            // 
            // pnlReqParams
            // 
            this.pnlReqParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReqParams.Controls.Add(this.btnSettings);
            this.pnlReqParams.Controls.Add(this.btnAbout);
            this.pnlReqParams.Controls.Add(this.pnlPanes);
            this.pnlReqParams.Controls.Add(this.lblOutputSize);
            this.pnlReqParams.Controls.Add(this.nudOutputSize);
            this.pnlReqParams.Controls.Add(this.lblRepeat);
            this.pnlReqParams.Controls.Add(this.nudRepeat);
            this.pnlReqParams.Controls.Add(this.lblInputSize);
            this.pnlReqParams.Controls.Add(this.lblIOCTLCode);
            this.pnlReqParams.Controls.Add(this.tbIOCTL);
            this.pnlReqParams.Controls.Add(this.tbDevicePath);
            this.pnlReqParams.Controls.Add(this.lblDevPath);
            this.pnlReqParams.Controls.Add(this.nudInputSize);
            this.pnlReqParams.Controls.Add(this.btnSend);
            this.pnlReqParams.Location = new System.Drawing.Point(3, 3);
            this.pnlReqParams.Name = "pnlReqParams";
            this.pnlReqParams.Size = new System.Drawing.Size(768, 78);
            this.pnlReqParams.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Enabled = false;
            this.btnSettings.Image = global::ioctlpus.Properties.Resources.cog;
            this.btnSettings.Location = new System.Drawing.Point(736, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(32, 32);
            this.btnSettings.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnSettings, "Options");
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Image = global::ioctlpus.Properties.Resources.help;
            this.btnAbout.Location = new System.Drawing.Point(736, 43);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(32, 32);
            this.btnAbout.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnAbout, "About");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnlPanes
            // 
            this.pnlPanes.Controls.Add(this.pnlLeftPanePrePost);
            this.pnlPanes.Controls.Add(this.pnlRightPanePrePost);
            this.pnlPanes.Controls.Add(this.pnlLeftPaneView);
            this.pnlPanes.Controls.Add(this.pnlRightPaneView);
            this.pnlPanes.Controls.Add(this.pnlRightPaneInOut);
            this.pnlPanes.Controls.Add(this.pnlLeftPaneInOut);
            this.pnlPanes.Controls.Add(this.lblRightPane);
            this.pnlPanes.Controls.Add(this.lblLeftPane);
            this.pnlPanes.Location = new System.Drawing.Point(386, 0);
            this.pnlPanes.Name = "pnlPanes";
            this.pnlPanes.Size = new System.Drawing.Size(331, 78);
            this.pnlPanes.TabIndex = 11;
            // 
            // pnlLeftPanePrePost
            // 
            this.pnlLeftPanePrePost.Controls.Add(this.rbLeftPanePostCall);
            this.pnlLeftPanePrePost.Controls.Add(this.rbLeftPanePreCall);
            this.pnlLeftPanePrePost.Location = new System.Drawing.Point(136, 4);
            this.pnlLeftPanePrePost.Name = "pnlLeftPanePrePost";
            this.pnlLeftPanePrePost.Size = new System.Drawing.Size(63, 32);
            this.pnlLeftPanePrePost.TabIndex = 27;
            // 
            // rbLeftPanePostCall
            // 
            this.rbLeftPanePostCall.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLeftPanePostCall.Enabled = false;
            this.rbLeftPanePostCall.Image = global::ioctlpus.Properties.Resources.control_end_blue;
            this.rbLeftPanePostCall.Location = new System.Drawing.Point(31, 0);
            this.rbLeftPanePostCall.Name = "rbLeftPanePostCall";
            this.rbLeftPanePostCall.Size = new System.Drawing.Size(32, 32);
            this.rbLeftPanePostCall.TabIndex = 1;
            this.toolTip.SetToolTip(this.rbLeftPanePostCall, "Post-Call");
            this.rbLeftPanePostCall.UseVisualStyleBackColor = true;
            // 
            // rbLeftPanePreCall
            // 
            this.rbLeftPanePreCall.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLeftPanePreCall.Checked = true;
            this.rbLeftPanePreCall.Image = global::ioctlpus.Properties.Resources.control_start_blue;
            this.rbLeftPanePreCall.Location = new System.Drawing.Point(0, 0);
            this.rbLeftPanePreCall.Name = "rbLeftPanePreCall";
            this.rbLeftPanePreCall.Size = new System.Drawing.Size(32, 32);
            this.rbLeftPanePreCall.TabIndex = 0;
            this.rbLeftPanePreCall.TabStop = true;
            this.toolTip.SetToolTip(this.rbLeftPanePreCall, "Pre-Call");
            this.rbLeftPanePreCall.UseVisualStyleBackColor = true;
            // 
            // pnlRightPanePrePost
            // 
            this.pnlRightPanePrePost.Controls.Add(this.rbRightPanePostCall);
            this.pnlRightPanePrePost.Controls.Add(this.rbRightPanePreCall);
            this.pnlRightPanePrePost.Location = new System.Drawing.Point(136, 42);
            this.pnlRightPanePrePost.Name = "pnlRightPanePrePost";
            this.pnlRightPanePrePost.Size = new System.Drawing.Size(63, 32);
            this.pnlRightPanePrePost.TabIndex = 26;
            // 
            // rbRightPanePostCall
            // 
            this.rbRightPanePostCall.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRightPanePostCall.Checked = true;
            this.rbRightPanePostCall.Image = global::ioctlpus.Properties.Resources.control_end_blue;
            this.rbRightPanePostCall.Location = new System.Drawing.Point(31, 0);
            this.rbRightPanePostCall.Name = "rbRightPanePostCall";
            this.rbRightPanePostCall.Size = new System.Drawing.Size(32, 32);
            this.rbRightPanePostCall.TabIndex = 1;
            this.rbRightPanePostCall.TabStop = true;
            this.toolTip.SetToolTip(this.rbRightPanePostCall, "Post-Call");
            this.rbRightPanePostCall.UseVisualStyleBackColor = true;
            // 
            // rbRightPanePreCall
            // 
            this.rbRightPanePreCall.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRightPanePreCall.Enabled = false;
            this.rbRightPanePreCall.Image = global::ioctlpus.Properties.Resources.control_start_blue;
            this.rbRightPanePreCall.Location = new System.Drawing.Point(0, 0);
            this.rbRightPanePreCall.Name = "rbRightPanePreCall";
            this.rbRightPanePreCall.Size = new System.Drawing.Size(32, 32);
            this.rbRightPanePreCall.TabIndex = 0;
            this.toolTip.SetToolTip(this.rbRightPanePreCall, "Pre-Call");
            this.rbRightPanePreCall.UseVisualStyleBackColor = true;
            // 
            // pnlLeftPaneView
            // 
            this.pnlLeftPaneView.Controls.Add(this.rbLeftPaneStringsView);
            this.pnlLeftPaneView.Controls.Add(this.rbLeftPaneStructEdit);
            this.pnlLeftPaneView.Controls.Add(this.rbLeftPaneStructView);
            this.pnlLeftPaneView.Controls.Add(this.rbLeftPaneHexView);
            this.pnlLeftPaneView.Location = new System.Drawing.Point(205, 4);
            this.pnlLeftPaneView.Name = "pnlLeftPaneView";
            this.pnlLeftPaneView.Size = new System.Drawing.Size(125, 32);
            this.pnlLeftPaneView.TabIndex = 25;
            // 
            // rbLeftPaneStringsView
            // 
            this.rbLeftPaneStringsView.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLeftPaneStringsView.Enabled = false;
            this.rbLeftPaneStringsView.Image = global::ioctlpus.Properties.Resources.application_view_list;
            this.rbLeftPaneStringsView.Location = new System.Drawing.Point(31, 0);
            this.rbLeftPaneStringsView.Name = "rbLeftPaneStringsView";
            this.rbLeftPaneStringsView.Size = new System.Drawing.Size(32, 32);
            this.rbLeftPaneStringsView.TabIndex = 2;
            this.toolTip.SetToolTip(this.rbLeftPaneStringsView, "Strings View");
            this.rbLeftPaneStringsView.UseVisualStyleBackColor = true;
            // 
            // rbLeftPaneStructEdit
            // 
            this.rbLeftPaneStructEdit.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLeftPaneStructEdit.Enabled = false;
            this.rbLeftPaneStructEdit.Image = global::ioctlpus.Properties.Resources.application_edit;
            this.rbLeftPaneStructEdit.Location = new System.Drawing.Point(93, 0);
            this.rbLeftPaneStructEdit.Name = "rbLeftPaneStructEdit";
            this.rbLeftPaneStructEdit.Size = new System.Drawing.Size(32, 32);
            this.rbLeftPaneStructEdit.TabIndex = 0;
            this.toolTip.SetToolTip(this.rbLeftPaneStructEdit, "Struct Editor");
            this.rbLeftPaneStructEdit.UseVisualStyleBackColor = true;
            // 
            // rbLeftPaneStructView
            // 
            this.rbLeftPaneStructView.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLeftPaneStructView.Enabled = false;
            this.rbLeftPaneStructView.Image = global::ioctlpus.Properties.Resources.application_side_tree;
            this.rbLeftPaneStructView.Location = new System.Drawing.Point(62, 0);
            this.rbLeftPaneStructView.Name = "rbLeftPaneStructView";
            this.rbLeftPaneStructView.Size = new System.Drawing.Size(32, 32);
            this.rbLeftPaneStructView.TabIndex = 3;
            this.toolTip.SetToolTip(this.rbLeftPaneStructView, "Struct View");
            this.rbLeftPaneStructView.UseVisualStyleBackColor = true;
            // 
            // rbLeftPaneHexView
            // 
            this.rbLeftPaneHexView.AccessibleDescription = "test";
            this.rbLeftPaneHexView.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLeftPaneHexView.Checked = true;
            this.rbLeftPaneHexView.Image = global::ioctlpus.Properties.Resources.application_view_columns;
            this.rbLeftPaneHexView.Location = new System.Drawing.Point(0, 0);
            this.rbLeftPaneHexView.Name = "rbLeftPaneHexView";
            this.rbLeftPaneHexView.Size = new System.Drawing.Size(32, 32);
            this.rbLeftPaneHexView.TabIndex = 1;
            this.rbLeftPaneHexView.TabStop = true;
            this.toolTip.SetToolTip(this.rbLeftPaneHexView, "Hex View");
            this.rbLeftPaneHexView.UseVisualStyleBackColor = true;
            // 
            // pnlRightPaneView
            // 
            this.pnlRightPaneView.Controls.Add(this.rbRightPaneStringsView);
            this.pnlRightPaneView.Controls.Add(this.rbRightPaneStuctEdit);
            this.pnlRightPaneView.Controls.Add(this.rbRightPaneStructView);
            this.pnlRightPaneView.Controls.Add(this.rbRightPaneHexView);
            this.pnlRightPaneView.Location = new System.Drawing.Point(205, 42);
            this.pnlRightPaneView.Name = "pnlRightPaneView";
            this.pnlRightPaneView.Size = new System.Drawing.Size(125, 32);
            this.pnlRightPaneView.TabIndex = 24;
            // 
            // rbRightPaneStringsView
            // 
            this.rbRightPaneStringsView.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRightPaneStringsView.Enabled = false;
            this.rbRightPaneStringsView.Image = global::ioctlpus.Properties.Resources.application_view_list;
            this.rbRightPaneStringsView.Location = new System.Drawing.Point(31, 0);
            this.rbRightPaneStringsView.Name = "rbRightPaneStringsView";
            this.rbRightPaneStringsView.Size = new System.Drawing.Size(32, 32);
            this.rbRightPaneStringsView.TabIndex = 1;
            this.toolTip.SetToolTip(this.rbRightPaneStringsView, "Strings View");
            this.rbRightPaneStringsView.UseVisualStyleBackColor = true;
            // 
            // rbRightPaneStuctEdit
            // 
            this.rbRightPaneStuctEdit.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRightPaneStuctEdit.Enabled = false;
            this.rbRightPaneStuctEdit.Image = global::ioctlpus.Properties.Resources.application_edit;
            this.rbRightPaneStuctEdit.Location = new System.Drawing.Point(93, 0);
            this.rbRightPaneStuctEdit.Name = "rbRightPaneStuctEdit";
            this.rbRightPaneStuctEdit.Size = new System.Drawing.Size(32, 32);
            this.rbRightPaneStuctEdit.TabIndex = 3;
            this.toolTip.SetToolTip(this.rbRightPaneStuctEdit, "Struct Editor");
            this.rbRightPaneStuctEdit.UseVisualStyleBackColor = true;
            // 
            // rbRightPaneStructView
            // 
            this.rbRightPaneStructView.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRightPaneStructView.Enabled = false;
            this.rbRightPaneStructView.Image = global::ioctlpus.Properties.Resources.application_side_tree;
            this.rbRightPaneStructView.Location = new System.Drawing.Point(62, 0);
            this.rbRightPaneStructView.Name = "rbRightPaneStructView";
            this.rbRightPaneStructView.Size = new System.Drawing.Size(32, 32);
            this.rbRightPaneStructView.TabIndex = 2;
            this.toolTip.SetToolTip(this.rbRightPaneStructView, "Struct View");
            this.rbRightPaneStructView.UseVisualStyleBackColor = true;
            // 
            // rbRightPaneHexView
            // 
            this.rbRightPaneHexView.AccessibleDescription = "";
            this.rbRightPaneHexView.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRightPaneHexView.Checked = true;
            this.rbRightPaneHexView.Image = global::ioctlpus.Properties.Resources.application_view_columns;
            this.rbRightPaneHexView.Location = new System.Drawing.Point(0, 0);
            this.rbRightPaneHexView.Name = "rbRightPaneHexView";
            this.rbRightPaneHexView.Size = new System.Drawing.Size(32, 32);
            this.rbRightPaneHexView.TabIndex = 0;
            this.rbRightPaneHexView.TabStop = true;
            this.toolTip.SetToolTip(this.rbRightPaneHexView, "Hex View");
            this.rbRightPaneHexView.UseVisualStyleBackColor = true;
            // 
            // pnlRightPaneInOut
            // 
            this.pnlRightPaneInOut.Controls.Add(this.rbRightPaneOut);
            this.pnlRightPaneInOut.Controls.Add(this.rbRightPaneIn);
            this.pnlRightPaneInOut.Location = new System.Drawing.Point(67, 42);
            this.pnlRightPaneInOut.Name = "pnlRightPaneInOut";
            this.pnlRightPaneInOut.Size = new System.Drawing.Size(63, 32);
            this.pnlRightPaneInOut.TabIndex = 23;
            // 
            // rbRightPaneOut
            // 
            this.rbRightPaneOut.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRightPaneOut.Checked = true;
            this.rbRightPaneOut.Image = global::ioctlpus.Properties.Resources.arrow_out;
            this.rbRightPaneOut.Location = new System.Drawing.Point(31, 0);
            this.rbRightPaneOut.Name = "rbRightPaneOut";
            this.rbRightPaneOut.Size = new System.Drawing.Size(32, 32);
            this.rbRightPaneOut.TabIndex = 1;
            this.rbRightPaneOut.TabStop = true;
            this.toolTip.SetToolTip(this.rbRightPaneOut, "Output Buffer");
            this.rbRightPaneOut.UseVisualStyleBackColor = true;
            // 
            // rbRightPaneIn
            // 
            this.rbRightPaneIn.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRightPaneIn.Enabled = false;
            this.rbRightPaneIn.Image = global::ioctlpus.Properties.Resources.arrow_in;
            this.rbRightPaneIn.Location = new System.Drawing.Point(0, 0);
            this.rbRightPaneIn.Name = "rbRightPaneIn";
            this.rbRightPaneIn.Size = new System.Drawing.Size(32, 32);
            this.rbRightPaneIn.TabIndex = 0;
            this.toolTip.SetToolTip(this.rbRightPaneIn, "Input Buffer");
            this.rbRightPaneIn.UseVisualStyleBackColor = true;
            // 
            // pnlLeftPaneInOut
            // 
            this.pnlLeftPaneInOut.Controls.Add(this.rbLeftPaneOut);
            this.pnlLeftPaneInOut.Controls.Add(this.rbLeftPaneIn);
            this.pnlLeftPaneInOut.Location = new System.Drawing.Point(67, 4);
            this.pnlLeftPaneInOut.Name = "pnlLeftPaneInOut";
            this.pnlLeftPaneInOut.Size = new System.Drawing.Size(63, 32);
            this.pnlLeftPaneInOut.TabIndex = 22;
            // 
            // rbLeftPaneOut
            // 
            this.rbLeftPaneOut.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLeftPaneOut.Enabled = false;
            this.rbLeftPaneOut.Image = global::ioctlpus.Properties.Resources.arrow_out;
            this.rbLeftPaneOut.Location = new System.Drawing.Point(31, 0);
            this.rbLeftPaneOut.Name = "rbLeftPaneOut";
            this.rbLeftPaneOut.Size = new System.Drawing.Size(32, 32);
            this.rbLeftPaneOut.TabIndex = 1;
            this.toolTip.SetToolTip(this.rbLeftPaneOut, "Output Buffer");
            this.rbLeftPaneOut.UseVisualStyleBackColor = true;
            // 
            // rbLeftPaneIn
            // 
            this.rbLeftPaneIn.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLeftPaneIn.Checked = true;
            this.rbLeftPaneIn.Image = global::ioctlpus.Properties.Resources.arrow_in;
            this.rbLeftPaneIn.Location = new System.Drawing.Point(0, 0);
            this.rbLeftPaneIn.Name = "rbLeftPaneIn";
            this.rbLeftPaneIn.Size = new System.Drawing.Size(32, 32);
            this.rbLeftPaneIn.TabIndex = 0;
            this.rbLeftPaneIn.TabStop = true;
            this.toolTip.SetToolTip(this.rbLeftPaneIn, "Input Buffer");
            this.rbLeftPaneIn.UseVisualStyleBackColor = true;
            // 
            // lblRightPane
            // 
            this.lblRightPane.AutoSize = true;
            this.lblRightPane.Location = new System.Drawing.Point(5, 51);
            this.lblRightPane.Name = "lblRightPane";
            this.lblRightPane.Size = new System.Drawing.Size(63, 13);
            this.lblRightPane.TabIndex = 12;
            this.lblRightPane.Text = "Right Pane:";
            this.lblRightPane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLeftPane
            // 
            this.lblLeftPane.AutoSize = true;
            this.lblLeftPane.Location = new System.Drawing.Point(5, 14);
            this.lblLeftPane.Name = "lblLeftPane";
            this.lblLeftPane.Size = new System.Drawing.Size(56, 13);
            this.lblLeftPane.TabIndex = 7;
            this.lblLeftPane.Text = "Left Pane:";
            this.lblLeftPane.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutputSize
            // 
            this.lblOutputSize.AutoSize = true;
            this.lblOutputSize.Location = new System.Drawing.Point(244, 53);
            this.lblOutputSize.Name = "lblOutputSize";
            this.lblOutputSize.Size = new System.Drawing.Size(65, 13);
            this.lblOutputSize.TabIndex = 10;
            this.lblOutputSize.Text = "Output Size:";
            // 
            // nudOutputSize
            // 
            this.nudOutputSize.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOutputSize.Hexadecimal = true;
            this.nudOutputSize.Location = new System.Drawing.Point(315, 52);
            this.nudOutputSize.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.nudOutputSize.Name = "nudOutputSize";
            this.nudOutputSize.Size = new System.Drawing.Size(65, 20);
            this.nudOutputSize.TabIndex = 5;
            this.nudOutputSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Location = new System.Drawing.Point(279, 30);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(45, 13);
            this.lblRepeat.TabIndex = 8;
            this.lblRepeat.Text = "Repeat:";
            // 
            // nudRepeat
            // 
            this.nudRepeat.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRepeat.Location = new System.Drawing.Point(330, 28);
            this.nudRepeat.Name = "nudRepeat";
            this.nudRepeat.Size = new System.Drawing.Size(50, 20);
            this.nudRepeat.TabIndex = 3;
            // 
            // lblInputSize
            // 
            this.lblInputSize.AutoSize = true;
            this.lblInputSize.Location = new System.Drawing.Point(123, 52);
            this.lblInputSize.Name = "lblInputSize";
            this.lblInputSize.Size = new System.Drawing.Size(57, 13);
            this.lblInputSize.TabIndex = 6;
            this.lblInputSize.Text = "Input Size:";
            // 
            // lblIOCTLCode
            // 
            this.lblIOCTLCode.AutoSize = true;
            this.lblIOCTLCode.Location = new System.Drawing.Point(111, 30);
            this.lblIOCTLCode.Name = "lblIOCTLCode";
            this.lblIOCTLCode.Size = new System.Drawing.Size(69, 13);
            this.lblIOCTLCode.TabIndex = 5;
            this.lblIOCTLCode.Text = "IOCTL Code:";
            // 
            // tbIOCTL
            // 
            this.tbIOCTL.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIOCTL.Location = new System.Drawing.Point(181, 27);
            this.tbIOCTL.Name = "tbIOCTL";
            this.tbIOCTL.Size = new System.Drawing.Size(90, 20);
            this.tbIOCTL.TabIndex = 2;
            this.tbIOCTL.TextChanged += new System.EventHandler(this.tbIOCTL_TextChanged);
            // 
            // tbDevicePath
            // 
            this.tbDevicePath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDevicePath.Location = new System.Drawing.Point(181, 4);
            this.tbDevicePath.Name = "tbDevicePath";
            this.tbDevicePath.Size = new System.Drawing.Size(199, 20);
            this.tbDevicePath.TabIndex = 1;
            this.tbDevicePath.TextChanged += new System.EventHandler(this.tbDevicePath_TextChanged);
            // 
            // lblDevPath
            // 
            this.lblDevPath.AutoSize = true;
            this.lblDevPath.Location = new System.Drawing.Point(110, 7);
            this.lblDevPath.Name = "lblDevPath";
            this.lblDevPath.Size = new System.Drawing.Size(70, 13);
            this.lblDevPath.TabIndex = 2;
            this.lblDevPath.Text = "Path / GUID:";
            // 
            // nudInputSize
            // 
            this.nudInputSize.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInputSize.Hexadecimal = true;
            this.nudInputSize.Location = new System.Drawing.Point(181, 51);
            this.nudInputSize.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.nudInputSize.Name = "nudInputSize";
            this.nudInputSize.Size = new System.Drawing.Size(57, 20);
            this.nudInputSize.TabIndex = 4;
            this.nudInputSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Image = global::ioctlpus.Properties.Resources.lightning;
            this.btnSend.Location = new System.Drawing.Point(0, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(105, 78);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "&Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbRequestHistory
            // 
            this.gbRequestHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRequestHistory.Controls.Add(this.btnSaveDB);
            this.gbRequestHistory.Controls.Add(this.tbFilters);
            this.gbRequestHistory.Controls.Add(this.btnStarRequest);
            this.gbRequestHistory.Controls.Add(this.btnDeleteRequest);
            this.gbRequestHistory.Controls.Add(this.btnOpenDB);
            this.gbRequestHistory.Controls.Add(this.tlvRequestHistory);
            this.gbRequestHistory.Location = new System.Drawing.Point(3, 361);
            this.gbRequestHistory.Name = "gbRequestHistory";
            this.gbRequestHistory.Size = new System.Drawing.Size(774, 173);
            this.gbRequestHistory.TabIndex = 3;
            this.gbRequestHistory.TabStop = false;
            this.gbRequestHistory.Text = "Request History";
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDB.Enabled = false;
            this.btnSaveDB.Image = global::ioctlpus.Properties.Resources.database_save;
            this.btnSaveDB.Location = new System.Drawing.Point(736, 57);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(32, 32);
            this.btnSaveDB.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnSaveDB, "Save Database");
            this.btnSaveDB.UseVisualStyleBackColor = true;
            // 
            // tbFilters
            // 
            this.tbFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilters.Enabled = false;
            this.tbFilters.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilters.Location = new System.Drawing.Point(6, 144);
            this.tbFilters.Name = "tbFilters";
            this.tbFilters.Size = new System.Drawing.Size(724, 20);
            this.tbFilters.TabIndex = 1;
            this.tbFilters.TextChanged += new System.EventHandler(this.tbFilters_TextChanged);
            // 
            // btnStarRequest
            // 
            this.btnStarRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStarRequest.Image = global::ioctlpus.Properties.Resources.star;
            this.btnStarRequest.Location = new System.Drawing.Point(736, 95);
            this.btnStarRequest.Name = "btnStarRequest";
            this.btnStarRequest.Size = new System.Drawing.Size(32, 32);
            this.btnStarRequest.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnStarRequest, "Star Request");
            this.btnStarRequest.UseVisualStyleBackColor = true;
            this.btnStarRequest.Click += new System.EventHandler(this.btnStarRequest_Click);
            // 
            // btnDeleteRequest
            // 
            this.btnDeleteRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRequest.Enabled = false;
            this.btnDeleteRequest.Image = global::ioctlpus.Properties.Resources.delete;
            this.btnDeleteRequest.Location = new System.Drawing.Point(736, 133);
            this.btnDeleteRequest.Name = "btnDeleteRequest";
            this.btnDeleteRequest.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteRequest.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnDeleteRequest, "Remove Request");
            this.btnDeleteRequest.UseVisualStyleBackColor = true;
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDB.Enabled = false;
            this.btnOpenDB.Image = global::ioctlpus.Properties.Resources.database_add;
            this.btnOpenDB.Location = new System.Drawing.Point(736, 19);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(32, 32);
            this.btnOpenDB.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnOpenDB, "Load Database");
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // tlvRequestHistory
            // 
            this.tlvRequestHistory.AllColumns.Add(this.olvColumnRequest);
            this.tlvRequestHistory.AllColumns.Add(this.olvColumnRetVal);
            this.tlvRequestHistory.AllColumns.Add(this.olvColumnBytesReturned);
            this.tlvRequestHistory.AllColumns.Add(this.olvColumnTime);
            this.tlvRequestHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlvRequestHistory.CellEditUseWholeCell = false;
            this.tlvRequestHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnRequest,
            this.olvColumnRetVal,
            this.olvColumnBytesReturned,
            this.olvColumnTime});
            this.tlvRequestHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlvRequestHistory.Location = new System.Drawing.Point(6, 19);
            this.tlvRequestHistory.Name = "tlvRequestHistory";
            this.tlvRequestHistory.ShowGroups = false;
            this.tlvRequestHistory.Size = new System.Drawing.Size(724, 119);
            this.tlvRequestHistory.TabIndex = 0;
            this.tlvRequestHistory.UseCompatibleStateImageBehavior = false;
            this.tlvRequestHistory.View = System.Windows.Forms.View.Details;
            this.tlvRequestHistory.VirtualMode = true;
            // 
            // olvColumnRequest
            // 
            this.olvColumnRequest.AspectName = "RequestName";
            this.olvColumnRequest.MinimumWidth = 230;
            this.olvColumnRequest.Text = "Request";
            this.olvColumnRequest.Width = 230;
            // 
            // olvColumnRetVal
            // 
            this.olvColumnRetVal.AspectName = "ReturnValueString";
            this.olvColumnRetVal.IsEditable = false;
            this.olvColumnRetVal.MinimumWidth = 260;
            this.olvColumnRetVal.Text = "Return Value";
            this.olvColumnRetVal.Width = 260;
            // 
            // olvColumnBytesReturned
            // 
            this.olvColumnBytesReturned.AspectName = "BytesReturned";
            this.olvColumnBytesReturned.IsEditable = false;
            this.olvColumnBytesReturned.MinimumWidth = 90;
            this.olvColumnBytesReturned.Text = "Bytes Returned";
            this.olvColumnBytesReturned.Width = 90;
            // 
            // olvColumnTime
            // 
            this.olvColumnTime.AspectName = "Timestamp";
            this.olvColumnTime.FillsFreeSpace = true;
            this.olvColumnTime.IsEditable = false;
            this.olvColumnTime.Text = "Time";
            this.olvColumnTime.Width = 80;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 250;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.tlpMain);
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ioctlpus";
            this.tlpMain.ResumeLayout(false);
            this.tlpPanes.ResumeLayout(false);
            this.gbRightPane.ResumeLayout(false);
            this.gbLeftPane.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.pnlReqParams.ResumeLayout(false);
            this.pnlReqParams.PerformLayout();
            this.pnlPanes.ResumeLayout(false);
            this.pnlPanes.PerformLayout();
            this.pnlLeftPanePrePost.ResumeLayout(false);
            this.pnlRightPanePrePost.ResumeLayout(false);
            this.pnlLeftPaneView.ResumeLayout(false);
            this.pnlRightPaneView.ResumeLayout(false);
            this.pnlRightPaneInOut.ResumeLayout(false);
            this.pnlLeftPaneInOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputSize)).EndInit();
            this.gbRequestHistory.ResumeLayout(false);
            this.gbRequestHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlvRequestHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpPanes;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private Be.Windows.Forms.HexBox hbInput;
        private Be.Windows.Forms.HexBox hbOutput;
        private System.Windows.Forms.Panel pnlReqParams;
        private System.Windows.Forms.Label lblIOCTLCode;
        private System.Windows.Forms.TextBox tbIOCTL;
        private System.Windows.Forms.TextBox tbDevicePath;
        private System.Windows.Forms.Label lblDevPath;
        private System.Windows.Forms.NumericUpDown nudInputSize;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblInputSize;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.NumericUpDown nudRepeat;
        private System.Windows.Forms.Label lblOutputSize;
        private System.Windows.Forms.NumericUpDown nudOutputSize;
        private System.Windows.Forms.GroupBox gbLeftPane;
        private System.Windows.Forms.GroupBox gbRightPane;
        private System.Windows.Forms.GroupBox gbRequestHistory;
        private System.Windows.Forms.Button btnStarRequest;
        private System.Windows.Forms.Button btnDeleteRequest;
        private System.Windows.Forms.Button btnOpenDB;
        private BrightIdeasSoftware.TreeListView tlvRequestHistory;
        private BrightIdeasSoftware.OLVColumn olvColumnRequest;
        private BrightIdeasSoftware.OLVColumn olvColumnTime;
        private BrightIdeasSoftware.OLVColumn olvColumnRetVal;
        private BrightIdeasSoftware.OLVColumn olvColumnBytesReturned;
        private System.Windows.Forms.TextBox tbFilters;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.Panel pnlPanes;
        private System.Windows.Forms.Panel pnlLeftPaneInOut;
        private System.Windows.Forms.RadioButton rbLeftPaneOut;
        private System.Windows.Forms.RadioButton rbLeftPaneIn;
        private System.Windows.Forms.Label lblRightPane;
        private System.Windows.Forms.Label lblLeftPane;
        private System.Windows.Forms.Panel pnlRightPaneView;
        private System.Windows.Forms.RadioButton rbRightPaneStuctEdit;
        private System.Windows.Forms.RadioButton rbRightPaneStructView;
        private System.Windows.Forms.RadioButton rbRightPaneHexView;
        private System.Windows.Forms.Panel pnlRightPaneInOut;
        private System.Windows.Forms.RadioButton rbRightPaneOut;
        private System.Windows.Forms.RadioButton rbRightPaneIn;
        private System.Windows.Forms.Panel pnlLeftPaneView;
        private System.Windows.Forms.RadioButton rbLeftPaneStructEdit;
        private System.Windows.Forms.RadioButton rbLeftPaneStructView;
        private System.Windows.Forms.RadioButton rbLeftPaneHexView;
        private System.Windows.Forms.Panel pnlLeftPanePrePost;
        private System.Windows.Forms.RadioButton rbLeftPanePostCall;
        private System.Windows.Forms.RadioButton rbLeftPanePreCall;
        private System.Windows.Forms.Panel pnlRightPanePrePost;
        private System.Windows.Forms.RadioButton rbRightPanePostCall;
        private System.Windows.Forms.RadioButton rbRightPanePreCall;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RadioButton rbLeftPaneStringsView;
        private System.Windows.Forms.RadioButton rbRightPaneStringsView;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSettings;
    }
}

