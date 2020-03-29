namespace TableTools
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mExcelPath = new System.Windows.Forms.TextBox();
            this.btnSelectExcelPath = new System.Windows.Forms.Button();
            this.btnSelectConfigPath = new System.Windows.Forms.Button();
            this.mConfigPath = new System.Windows.Forms.TextBox();
            this.btnSelectCodePath = new System.Windows.Forms.Button();
            this.mCodePath = new System.Windows.Forms.TextBox();
            this.isGenerateCode = new System.Windows.Forms.CheckBox();
            this.mCSharpCode = new System.Windows.Forms.RadioButton();
            this.mTsCode = new System.Windows.Forms.RadioButton();
            this.mJsCode = new System.Windows.Forms.RadioButton();
            this.mAsCode = new System.Windows.Forms.RadioButton();
            this.mCppCode = new System.Windows.Forms.RadioButton();
            this.isGenerateConfig = new System.Windows.Forms.CheckBox();
            this.mGenerateCodeTip = new System.Windows.Forms.ToolTip(this.components);
            this.mGenerateConfigTool = new System.Windows.Forms.ToolTip(this.components);
            this.btnStartGenerate = new System.Windows.Forms.Button();
            this.checkedListConfigFile = new System.Windows.Forms.CheckedListBox();
            this.btnSelectAllConfig = new System.Windows.Forms.Button();
            this.btnCancelAllConfig = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mClientConfig = new System.Windows.Forms.CheckBox();
            this.mServerConfig = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mServerDes = new System.Windows.Forms.ToolTip(this.components);
            this.mClientDes = new System.Windows.Forms.ToolTip(this.components);
            this.mScriptDes = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GenerateTableManager = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold);
            this.text.Location = new System.Drawing.Point(7, 34);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(151, 18);
            this.text.TabIndex = 1;
            this.text.Text = "选择配置表路径:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "导出配置路径:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "导出代码路径:";
            // 
            // mExcelPath
            // 
            this.mExcelPath.Location = new System.Drawing.Point(3, 57);
            this.mExcelPath.Name = "mExcelPath";
            this.mExcelPath.Size = new System.Drawing.Size(252, 21);
            this.mExcelPath.TabIndex = 4;
            // 
            // btnSelectExcelPath
            // 
            this.btnSelectExcelPath.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectExcelPath.Location = new System.Drawing.Point(83, 87);
            this.btnSelectExcelPath.Name = "btnSelectExcelPath";
            this.btnSelectExcelPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectExcelPath.TabIndex = 5;
            this.btnSelectExcelPath.Text = "选择";
            this.mClientDes.SetToolTip(this.btnSelectExcelPath, "配置的Excel表所处文件夹");
            this.btnSelectExcelPath.UseVisualStyleBackColor = true;
            this.btnSelectExcelPath.Click += new System.EventHandler(this.BtnSelectExcelPath_Click);
            // 
            // btnSelectConfigPath
            // 
            this.btnSelectConfigPath.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectConfigPath.Location = new System.Drawing.Point(85, 186);
            this.btnSelectConfigPath.Name = "btnSelectConfigPath";
            this.btnSelectConfigPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectConfigPath.TabIndex = 7;
            this.btnSelectConfigPath.Text = "选择";
            this.mClientDes.SetToolTip(this.btnSelectConfigPath, "导出的Json格式的配置文件路径");
            this.btnSelectConfigPath.UseVisualStyleBackColor = true;
            this.btnSelectConfigPath.Click += new System.EventHandler(this.BtnSelectConfigPath_Click);
            // 
            // mConfigPath
            // 
            this.mConfigPath.Location = new System.Drawing.Point(3, 159);
            this.mConfigPath.Name = "mConfigPath";
            this.mConfigPath.Size = new System.Drawing.Size(252, 21);
            this.mConfigPath.TabIndex = 6;
            // 
            // btnSelectCodePath
            // 
            this.btnSelectCodePath.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectCodePath.Location = new System.Drawing.Point(85, 287);
            this.btnSelectCodePath.Name = "btnSelectCodePath";
            this.btnSelectCodePath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCodePath.TabIndex = 9;
            this.btnSelectCodePath.Text = "选择";
            this.mClientDes.SetToolTip(this.btnSelectCodePath, "导出所勾选导出代码的路径");
            this.btnSelectCodePath.UseVisualStyleBackColor = true;
            this.btnSelectCodePath.Click += new System.EventHandler(this.BtnSelectCodePath_Click);
            // 
            // mCodePath
            // 
            this.mCodePath.Location = new System.Drawing.Point(3, 260);
            this.mCodePath.Name = "mCodePath";
            this.mCodePath.Size = new System.Drawing.Size(252, 21);
            this.mCodePath.TabIndex = 8;
            // 
            // isGenerateCode
            // 
            this.isGenerateCode.AutoSize = true;
            this.isGenerateCode.Location = new System.Drawing.Point(9, 22);
            this.isGenerateCode.Name = "isGenerateCode";
            this.isGenerateCode.Size = new System.Drawing.Size(72, 16);
            this.isGenerateCode.TabIndex = 10;
            this.isGenerateCode.Text = "生成代码";
            this.mGenerateCodeTip.SetToolTip(this.isGenerateCode, "勾选后将自动生成下方指定的代码代码");
            this.isGenerateCode.UseVisualStyleBackColor = true;
            this.isGenerateCode.CheckedChanged += new System.EventHandler(this.IsGenerateCode_CheckedChanged);
            // 
            // mCSharpCode
            // 
            this.mCSharpCode.AutoSize = true;
            this.mCSharpCode.Location = new System.Drawing.Point(9, 294);
            this.mCSharpCode.Name = "mCSharpCode";
            this.mCSharpCode.Size = new System.Drawing.Size(35, 16);
            this.mCSharpCode.TabIndex = 11;
            this.mCSharpCode.Text = "C#";
            this.mScriptDes.SetToolTip(this.mCSharpCode, "自动生成C#代码");
            this.mCSharpCode.UseVisualStyleBackColor = true;
            this.mCSharpCode.CheckedChanged += new System.EventHandler(this.MCSharpCode_CheckedChanged);
            // 
            // mTsCode
            // 
            this.mTsCode.AutoSize = true;
            this.mTsCode.Location = new System.Drawing.Point(9, 159);
            this.mTsCode.Name = "mTsCode";
            this.mTsCode.Size = new System.Drawing.Size(83, 16);
            this.mTsCode.TabIndex = 12;
            this.mTsCode.Text = "TypeScript";
            this.mScriptDes.SetToolTip(this.mTsCode, "自动生成TS代码");
            this.mTsCode.UseVisualStyleBackColor = true;
            this.mTsCode.CheckedChanged += new System.EventHandler(this.MTsCode_CheckedChanged);
            // 
            // mJsCode
            // 
            this.mJsCode.AutoSize = true;
            this.mJsCode.Location = new System.Drawing.Point(10, 191);
            this.mJsCode.Name = "mJsCode";
            this.mJsCode.Size = new System.Drawing.Size(83, 16);
            this.mJsCode.TabIndex = 13;
            this.mJsCode.Text = "JavaScript";
            this.mScriptDes.SetToolTip(this.mJsCode, "自动生成JS代码");
            this.mJsCode.UseVisualStyleBackColor = true;
            this.mJsCode.CheckedChanged += new System.EventHandler(this.MJsCode_CheckedChanged);
            // 
            // mAsCode
            // 
            this.mAsCode.AutoSize = true;
            this.mAsCode.Location = new System.Drawing.Point(10, 229);
            this.mAsCode.Name = "mAsCode";
            this.mAsCode.Size = new System.Drawing.Size(101, 16);
            this.mAsCode.TabIndex = 14;
            this.mAsCode.Text = "ActionScript3";
            this.mScriptDes.SetToolTip(this.mAsCode, "自动生成AS3代码");
            this.mAsCode.UseVisualStyleBackColor = true;
            this.mAsCode.CheckedChanged += new System.EventHandler(this.MAsCode_CheckedChanged);
            // 
            // mCppCode
            // 
            this.mCppCode.AutoSize = true;
            this.mCppCode.Location = new System.Drawing.Point(10, 260);
            this.mCppCode.Name = "mCppCode";
            this.mCppCode.Size = new System.Drawing.Size(41, 16);
            this.mCppCode.TabIndex = 15;
            this.mCppCode.Text = "C++";
            this.mScriptDes.SetToolTip(this.mCppCode, "自动生成C++代码");
            this.mCppCode.UseVisualStyleBackColor = true;
            this.mCppCode.CheckedChanged += new System.EventHandler(this.MCppCode_CheckedChanged);
            // 
            // isGenerateConfig
            // 
            this.isGenerateConfig.AutoSize = true;
            this.isGenerateConfig.Location = new System.Drawing.Point(9, 44);
            this.isGenerateConfig.Name = "isGenerateConfig";
            this.isGenerateConfig.Size = new System.Drawing.Size(72, 16);
            this.isGenerateConfig.TabIndex = 16;
            this.isGenerateConfig.Text = "生成配置";
            this.mGenerateCodeTip.SetToolTip(this.isGenerateConfig, "暂时只支持生成Json 格式的配置文件");
            this.isGenerateConfig.UseVisualStyleBackColor = true;
            this.isGenerateConfig.CheckedChanged += new System.EventHandler(this.IsGenerateConfig_CheckedChanged);
            // 
            // mGenerateCodeTip
            // 
            this.mGenerateCodeTip.IsBalloon = true;
            this.mGenerateCodeTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // mGenerateConfigTool
            // 
            this.mGenerateConfigTool.IsBalloon = true;
            this.mGenerateConfigTool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnStartGenerate
            // 
            this.btnStartGenerate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStartGenerate.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold);
            this.btnStartGenerate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStartGenerate.Location = new System.Drawing.Point(389, 459);
            this.btnStartGenerate.Name = "btnStartGenerate";
            this.btnStartGenerate.Size = new System.Drawing.Size(200, 55);
            this.btnStartGenerate.TabIndex = 19;
            this.btnStartGenerate.Text = "开始生成";
            this.btnStartGenerate.UseVisualStyleBackColor = false;
            this.btnStartGenerate.Click += new System.EventHandler(this.BtnStartGenerate_Click);
            // 
            // checkedListConfigFile
            // 
            this.checkedListConfigFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkedListConfigFile.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkedListConfigFile.FormattingEnabled = true;
            this.checkedListConfigFile.Location = new System.Drawing.Point(12, 46);
            this.checkedListConfigFile.Name = "checkedListConfigFile";
            this.checkedListConfigFile.Size = new System.Drawing.Size(255, 404);
            this.checkedListConfigFile.TabIndex = 4;
            // 
            // btnSelectAllConfig
            // 
            this.btnSelectAllConfig.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSelectAllConfig.Location = new System.Drawing.Point(12, 459);
            this.btnSelectAllConfig.Name = "btnSelectAllConfig";
            this.btnSelectAllConfig.Size = new System.Drawing.Size(95, 36);
            this.btnSelectAllConfig.TabIndex = 22;
            this.btnSelectAllConfig.Text = "全部选中";
            this.btnSelectAllConfig.UseVisualStyleBackColor = true;
            this.btnSelectAllConfig.Click += new System.EventHandler(this.BtnSelectAllConfig_Click);
            // 
            // btnCancelAllConfig
            // 
            this.btnCancelAllConfig.Location = new System.Drawing.Point(138, 459);
            this.btnCancelAllConfig.Name = "btnCancelAllConfig";
            this.btnCancelAllConfig.Size = new System.Drawing.Size(91, 36);
            this.btnCancelAllConfig.TabIndex = 23;
            this.btnCancelAllConfig.Text = "全部取消";
            this.btnCancelAllConfig.UseVisualStyleBackColor = true;
            this.btnCancelAllConfig.Click += new System.EventHandler(this.BtnCancelAllConfig_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(787, 49);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(250, 401);
            this.textBoxLog.TabIndex = 24;
            this.textBoxLog.Text = "输出信息:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 26F);
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 35);
            this.label4.TabIndex = 25;
            this.label4.Text = "数据源区";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 26F);
            this.label5.Location = new System.Drawing.Point(16, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 35);
            this.label5.TabIndex = 26;
            this.label5.Text = "说明区";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.1236F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.8764F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label18, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label19, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label17, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("宋体", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 546);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 194);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(831, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "注释说明2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(831, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "变量名称2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(831, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "变量2类型";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(831, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 17);
            this.label18.TabIndex = 7;
            this.label18.Text = "导出类型";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(831, 159);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 17);
            this.label20.TabIndex = 9;
            this.label20.Text = "数据2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(264, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "注释说明1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(264, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "变量名称1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(264, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "变量1类型";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(264, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "数据1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(264, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(554, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "导出类型（all-客户端和服务端 client-仅客户端 server-仅服务端） ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(213, 17);
            this.label21.TabIndex = 10;
            this.label21.Text = "表头第一行第一列必须是ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(246, 34);
            this.label22.TabIndex = 11;
            this.label22.Text = "第二行第一列这个必须是大写的“ID”";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 77);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(154, 17);
            this.label23.TabIndex = 12;
            this.label23.Text = "类型必须是int类型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 26F);
            this.label6.Location = new System.Drawing.Point(293, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 35);
            this.label6.TabIndex = 28;
            this.label6.Text = "配置区";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.mExcelPath);
            this.panel1.Controls.Add(this.text);
            this.panel1.Controls.Add(this.btnSelectExcelPath);
            this.panel1.Controls.Add(this.mConfigPath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSelectConfigPath);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mCodePath);
            this.panel1.Controls.Add(this.btnSelectCodePath);
            this.panel1.Location = new System.Drawing.Point(273, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 401);
            this.panel1.TabIndex = 29;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefresh.Font = new System.Drawing.Font("宋体", 17F);
            this.btnRefresh.Location = new System.Drawing.Point(62, 349);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 40);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "刷新";
            this.mClientDes.SetToolTip(this.btnRefresh, "任意路径或者数据源发生更改时都需要手动点一下这个刷新按钮");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.mClientConfig);
            this.panel2.Controls.Add(this.mServerConfig);
            this.panel2.Controls.Add(this.isGenerateCode);
            this.panel2.Controls.Add(this.isGenerateConfig);
            this.panel2.Controls.Add(this.mTsCode);
            this.panel2.Controls.Add(this.mJsCode);
            this.panel2.Controls.Add(this.mAsCode);
            this.panel2.Controls.Add(this.mCppCode);
            this.panel2.Controls.Add(this.mCSharpCode);
            this.panel2.Location = new System.Drawing.Point(559, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 401);
            this.panel2.TabIndex = 30;
            // 
            // mClientConfig
            // 
            this.mClientConfig.AutoSize = true;
            this.mClientConfig.Location = new System.Drawing.Point(10, 117);
            this.mClientConfig.Name = "mClientConfig";
            this.mClientConfig.Size = new System.Drawing.Size(60, 16);
            this.mClientConfig.TabIndex = 20;
            this.mClientConfig.Text = "客户端";
            this.mClientDes.SetToolTip(this.mClientConfig, "是否生成客户端的代码或配置");
            this.mClientConfig.UseVisualStyleBackColor = true;
            this.mClientConfig.CheckedChanged += new System.EventHandler(this.MClientConfig_CheckedChanged);
            // 
            // mServerConfig
            // 
            this.mServerConfig.AutoSize = true;
            this.mServerConfig.Location = new System.Drawing.Point(10, 94);
            this.mServerConfig.Name = "mServerConfig";
            this.mServerConfig.Size = new System.Drawing.Size(60, 16);
            this.mServerConfig.TabIndex = 19;
            this.mServerConfig.Text = "服务端";
            this.mServerDes.SetToolTip(this.mServerConfig, "是否生成服务端的代码或配置");
            this.mServerConfig.UseVisualStyleBackColor = true;
            this.mServerConfig.CheckedChanged += new System.EventHandler(this.MServerConfig_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 26F);
            this.label7.Location = new System.Drawing.Point(562, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 35);
            this.label7.TabIndex = 31;
            this.label7.Text = "代码区";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 26F);
            this.label8.Location = new System.Drawing.Point(781, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 35);
            this.label8.TabIndex = 32;
            this.label8.Text = "日志区";
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(19, 752);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(995, 76);
            this.label9.TabIndex = 33;
            this.label9.Text = "参数说明：1.int整形数据 2.float浮点型数据 3.string 字符串型数据 4.int[] 整型数组 5.float[]浮点型数组 6.string[" +
    "]字符串类型数组 7.bool型数据 配置0或1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(158, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "表结构设计";
            // 
            // GenerateTableManager
            // 
            this.GenerateTableManager.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.GenerateTableManager.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenerateTableManager.Location = new System.Drawing.Point(646, 459);
            this.GenerateTableManager.Name = "GenerateTableManager";
            this.GenerateTableManager.Size = new System.Drawing.Size(195, 55);
            this.GenerateTableManager.TabIndex = 35;
            this.GenerateTableManager.Text = "生成TableManager类";
            this.GenerateTableManager.UseVisualStyleBackColor = false;
            this.GenerateTableManager.Click += new System.EventHandler(this.GenerateTableManager_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1043, 830);
            this.Controls.Add(this.GenerateTableManager);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.btnCancelAllConfig);
            this.Controls.Add(this.btnSelectAllConfig);
            this.Controls.Add(this.checkedListConfigFile);
            this.Controls.Add(this.btnStartGenerate);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动导表工具";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mExcelPath;
        private System.Windows.Forms.Button btnSelectExcelPath;
        private System.Windows.Forms.Button btnSelectConfigPath;
        private System.Windows.Forms.TextBox mConfigPath;
        private System.Windows.Forms.Button btnSelectCodePath;
        private System.Windows.Forms.TextBox mCodePath;
        private System.Windows.Forms.CheckBox isGenerateCode;
        private System.Windows.Forms.RadioButton mCSharpCode;
        private System.Windows.Forms.RadioButton mTsCode;
        private System.Windows.Forms.RadioButton mJsCode;
        private System.Windows.Forms.RadioButton mAsCode;
        private System.Windows.Forms.RadioButton mCppCode;
        private System.Windows.Forms.CheckBox isGenerateConfig;
        private System.Windows.Forms.ToolTip mGenerateCodeTip;
        private System.Windows.Forms.ToolTip mGenerateConfigTool;
        private System.Windows.Forms.Button btnStartGenerate;
        private System.Windows.Forms.CheckedListBox checkedListConfigFile;
        private System.Windows.Forms.Button btnSelectAllConfig;
        private System.Windows.Forms.Button btnCancelAllConfig;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox mServerConfig;
        private System.Windows.Forms.CheckBox mClientConfig;
        private System.Windows.Forms.ToolTip mServerDes;
        private System.Windows.Forms.ToolTip mClientDes;
        private System.Windows.Forms.ToolTip mScriptDes;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button GenerateTableManager;
    }
}

