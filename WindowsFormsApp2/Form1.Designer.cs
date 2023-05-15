namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oKCount = new System.Windows.Forms.TextBox();
            this.btnOKplus = new System.Windows.Forms.Button();
            this.dataInsertBox = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngCount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNGplus = new System.Windows.Forms.Button();
            this.btnUpperOK = new System.Windows.Forms.Button();
            this.BtnInitialize = new System.Windows.Forms.Button();
            this.BtnLowerNG = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.compare = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelOK = new System.Windows.Forms.Label();
            this.labelNG = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalCount = new System.Windows.Forms.TextBox();
            this.totalPercent = new System.Windows.Forms.TextBox();
            this.ngPercent = new System.Windows.Forms.TextBox();
            this.okPercent = new System.Windows.Forms.TextBox();
            this.totalPercentChange = new System.Windows.Forms.TextBox();
            this.lowerNGPercent = new System.Windows.Forms.TextBox();
            this.upperOKPercent = new System.Windows.Forms.TextBox();
            this.totalCountChange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalChange = new System.Windows.Forms.Label();
            this.labelLowerNG = new System.Windows.Forms.Label();
            this.labelUpperOK = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lowerNGCount = new System.Windows.Forms.TextBox();
            this.upperOKCount = new System.Windows.Forms.TextBox();
            this.fileNameBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelForDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.selectedFolderPath = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.idBox = new System.Windows.Forms.TextBox();
            this.numBoxright = new System.Windows.Forms.TextBox();
            this.numBoxForCompare = new System.Windows.Forms.TextBox();
            this.labelForIdBox = new System.Windows.Forms.Label();
            this.labelForNumBoxright = new System.Windows.Forms.Label();
            this.labelForNumBoxUnderID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.boxForAppendtoFile = new System.Windows.Forms.TextBox();
            this.boxFordataView = new System.Windows.Forms.ListBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // oKCount
            // 
            this.oKCount.Location = new System.Drawing.Point(326, 156);
            this.oKCount.Name = "oKCount";
            this.oKCount.Size = new System.Drawing.Size(67, 21);
            this.oKCount.TabIndex = 2;
            this.oKCount.Text = "4";
            this.oKCount.Click += new System.EventHandler(this.addButton_Click);
            this.oKCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOKplus
            // 
            this.btnOKplus.Location = new System.Drawing.Point(614, 163);
            this.btnOKplus.Name = "btnOKplus";
            this.btnOKplus.Size = new System.Drawing.Size(88, 23);
            this.btnOKplus.TabIndex = 3;
            this.btnOKplus.Text = "OK +";
            this.btnOKplus.UseVisualStyleBackColor = true;
            this.btnOKplus.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataInsertBox
            // 
            this.dataInsertBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.id});
            this.dataInsertBox.GridLines = true;
            this.dataInsertBox.HideSelection = false;
            this.dataInsertBox.Location = new System.Drawing.Point(18, 179);
            this.dataInsertBox.Name = "dataInsertBox";
            this.dataInsertBox.Size = new System.Drawing.Size(227, 271);
            this.dataInsertBox.TabIndex = 5;
            this.dataInsertBox.UseCompatibleStateImageBehavior = false;
            this.dataInsertBox.View = System.Windows.Forms.View.Details;
            // 
            // number
            // 
            this.number.Text = "넘버";
            this.number.Width = 108;
            // 
            // id
            // 
            this.id.Text = "아이디";
            this.id.Width = 123;
            // 
            // ngCount
            // 
            this.ngCount.Location = new System.Drawing.Point(420, 156);
            this.ngCount.Name = "ngCount";
            this.ngCount.Size = new System.Drawing.Size(65, 21);
            this.ngCount.TabIndex = 6;
            this.ngCount.Text = "2";
            this.ngCount.TextChanged += new System.EventHandler(this.ngCount_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(614, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "추가버튼";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOKplus_Click);
            // 
            // btnNGplus
            // 
            this.btnNGplus.Location = new System.Drawing.Point(614, 192);
            this.btnNGplus.Name = "btnNGplus";
            this.btnNGplus.Size = new System.Drawing.Size(88, 23);
            this.btnNGplus.TabIndex = 8;
            this.btnNGplus.Text = "NG +";
            this.btnNGplus.UseVisualStyleBackColor = true;
            this.btnNGplus.Click += new System.EventHandler(this.btnNGplus_Click);
            // 
            // btnUpperOK
            // 
            this.btnUpperOK.Location = new System.Drawing.Point(614, 227);
            this.btnUpperOK.Name = "btnUpperOK";
            this.btnUpperOK.Size = new System.Drawing.Size(88, 23);
            this.btnUpperOK.TabIndex = 9;
            this.btnUpperOK.Text = "Upper OK +";
            this.btnUpperOK.UseVisualStyleBackColor = true;
            this.btnUpperOK.Click += new System.EventHandler(this.btnUpperOK_Click);
            // 
            // BtnInitialize
            // 
            this.BtnInitialize.Location = new System.Drawing.Point(614, 292);
            this.BtnInitialize.Name = "BtnInitialize";
            this.BtnInitialize.Size = new System.Drawing.Size(88, 23);
            this.BtnInitialize.TabIndex = 9;
            this.BtnInitialize.Text = "초기화";
            this.BtnInitialize.UseVisualStyleBackColor = true;
            this.BtnInitialize.Click += new System.EventHandler(this.BtnInitialize_Click);
            // 
            // BtnLowerNG
            // 
            this.BtnLowerNG.Location = new System.Drawing.Point(614, 256);
            this.BtnLowerNG.Name = "BtnLowerNG";
            this.BtnLowerNG.Size = new System.Drawing.Size(88, 23);
            this.BtnLowerNG.TabIndex = 9;
            this.BtnLowerNG.Text = "Lower NG +";
            this.BtnLowerNG.UseVisualStyleBackColor = true;
            this.BtnLowerNG.Click += new System.EventHandler(this.BtnLowerNG_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(614, 341);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(88, 23);
            this.insert.TabIndex = 9;
            this.insert.Text = "입력";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // compare
            // 
            this.compare.Location = new System.Drawing.Point(614, 370);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(88, 23);
            this.compare.TabIndex = 9;
            this.compare.Text = "비교";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Click += new System.EventHandler(this.compare_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(614, 414);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(88, 23);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "취소";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(490, 414);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(88, 23);
            this.apply.TabIndex = 9;
            this.apply.Text = "확인";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.button9_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(267, 126);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(25, 12);
            this.labelInfo.TabIndex = 10;
            this.labelInfo.Text = "Info";
            // 
            // labelOK
            // 
            this.labelOK.AutoSize = true;
            this.labelOK.Location = new System.Drawing.Point(324, 126);
            this.labelOK.Name = "labelOK";
            this.labelOK.Size = new System.Drawing.Size(22, 12);
            this.labelOK.TabIndex = 11;
            this.labelOK.Text = "OK";
            // 
            // labelNG
            // 
            this.labelNG.AutoSize = true;
            this.labelNG.Location = new System.Drawing.Point(418, 126);
            this.labelNG.Name = "labelNG";
            this.labelNG.Size = new System.Drawing.Size(23, 12);
            this.labelNG.TabIndex = 12;
            this.labelNG.Text = "NG";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(511, 126);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(45, 12);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "TOTAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "COUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "%";
            // 
            // totalCount
            // 
            this.totalCount.Location = new System.Drawing.Point(513, 156);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(65, 21);
            this.totalCount.TabIndex = 16;
            this.totalCount.Text = "6";
            this.totalCount.TextChanged += new System.EventHandler(this.totalCount_TextChanged);
            // 
            // totalPercent
            // 
            this.totalPercent.Location = new System.Drawing.Point(513, 201);
            this.totalPercent.Name = "totalPercent";
            this.totalPercent.Size = new System.Drawing.Size(65, 21);
            this.totalPercent.TabIndex = 19;
            this.totalPercent.Text = "100";
            // 
            // ngPercent
            // 
            this.ngPercent.Location = new System.Drawing.Point(420, 201);
            this.ngPercent.Name = "ngPercent";
            this.ngPercent.Size = new System.Drawing.Size(65, 21);
            this.ngPercent.TabIndex = 18;
            this.ngPercent.Text = "33.33";
            // 
            // okPercent
            // 
            this.okPercent.Location = new System.Drawing.Point(326, 201);
            this.okPercent.Name = "okPercent";
            this.okPercent.Size = new System.Drawing.Size(67, 21);
            this.okPercent.TabIndex = 17;
            this.okPercent.Text = "66.66";
            // 
            // totalPercentChange
            // 
            this.totalPercentChange.Location = new System.Drawing.Point(513, 327);
            this.totalPercentChange.Name = "totalPercentChange";
            this.totalPercentChange.Size = new System.Drawing.Size(65, 21);
            this.totalPercentChange.TabIndex = 31;
            this.totalPercentChange.Text = "0";
            // 
            // lowerNGPercent
            // 
            this.lowerNGPercent.Location = new System.Drawing.Point(420, 327);
            this.lowerNGPercent.Name = "lowerNGPercent";
            this.lowerNGPercent.Size = new System.Drawing.Size(65, 21);
            this.lowerNGPercent.TabIndex = 30;
            this.lowerNGPercent.Text = "0";
            // 
            // upperOKPercent
            // 
            this.upperOKPercent.Location = new System.Drawing.Point(326, 327);
            this.upperOKPercent.Name = "upperOKPercent";
            this.upperOKPercent.Size = new System.Drawing.Size(67, 21);
            this.upperOKPercent.TabIndex = 29;
            this.upperOKPercent.Text = "0";
            // 
            // totalCountChange
            // 
            this.totalCountChange.Location = new System.Drawing.Point(513, 282);
            this.totalCountChange.Name = "totalCountChange";
            this.totalCountChange.Size = new System.Drawing.Size(65, 21);
            this.totalCountChange.TabIndex = 28;
            this.totalCountChange.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "COUNT";
            // 
            // labelTotalChange
            // 
            this.labelTotalChange.AutoSize = true;
            this.labelTotalChange.Location = new System.Drawing.Point(511, 252);
            this.labelTotalChange.Name = "labelTotalChange";
            this.labelTotalChange.Size = new System.Drawing.Size(45, 12);
            this.labelTotalChange.TabIndex = 25;
            this.labelTotalChange.Text = "TOTAL";
            // 
            // labelLowerNG
            // 
            this.labelLowerNG.AutoSize = true;
            this.labelLowerNG.Location = new System.Drawing.Point(418, 252);
            this.labelLowerNG.Name = "labelLowerNG";
            this.labelLowerNG.Size = new System.Drawing.Size(62, 12);
            this.labelLowerNG.TabIndex = 24;
            this.labelLowerNG.Text = "Lower NG";
            // 
            // labelUpperOK
            // 
            this.labelUpperOK.AutoSize = true;
            this.labelUpperOK.Location = new System.Drawing.Point(324, 252);
            this.labelUpperOK.Name = "labelUpperOK";
            this.labelUpperOK.Size = new System.Drawing.Size(59, 12);
            this.labelUpperOK.TabIndex = 23;
            this.labelUpperOK.Text = "Upper OK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "Info";
            // 
            // lowerNGCount
            // 
            this.lowerNGCount.Location = new System.Drawing.Point(420, 282);
            this.lowerNGCount.Name = "lowerNGCount";
            this.lowerNGCount.Size = new System.Drawing.Size(65, 21);
            this.lowerNGCount.TabIndex = 21;
            this.lowerNGCount.Text = "0";
            // 
            // upperOKCount
            // 
            this.upperOKCount.Location = new System.Drawing.Point(326, 282);
            this.upperOKCount.Name = "upperOKCount";
            this.upperOKCount.Size = new System.Drawing.Size(67, 21);
            this.upperOKCount.TabIndex = 20;
            this.upperOKCount.Text = "0";
            // 
            // fileNameBox
            // 
            this.fileNameBox.FormattingEnabled = true;
            this.fileNameBox.Location = new System.Drawing.Point(269, 50);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(109, 20);
            this.fileNameBox.TabIndex = 32;
            this.fileNameBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // labelForDateTime
            // 
            this.labelForDateTime.AutoSize = true;
            this.labelForDateTime.Location = new System.Drawing.Point(270, 94);
            this.labelForDateTime.Name = "labelForDateTime";
            this.labelForDateTime.Size = new System.Drawing.Size(0, 12);
            this.labelForDateTime.TabIndex = 33;
            this.labelForDateTime.Click += new System.EventHandler(this.labelForDateTime_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // selectedFolderPath
            // 
            this.selectedFolderPath.Enabled = false;
            this.selectedFolderPath.Location = new System.Drawing.Point(269, 12);
            this.selectedFolderPath.Name = "selectedFolderPath";
            this.selectedFolderPath.Size = new System.Drawing.Size(305, 21);
            this.selectedFolderPath.TabIndex = 35;
            this.selectedFolderPath.TextChanged += new System.EventHandler(this.selectedFolderPath_TextChanged);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(614, 10);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(88, 23);
            this.btnSelectFolder.TabIndex = 36;
            this.btnSelectFolder.Text = "폴더선택";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectfile_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(311, 370);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(65, 21);
            this.idBox.TabIndex = 37;
            this.idBox.Text = "0";
            // 
            // numBoxright
            // 
            this.numBoxright.Location = new System.Drawing.Point(473, 370);
            this.numBoxright.Name = "numBoxright";
            this.numBoxright.Size = new System.Drawing.Size(65, 21);
            this.numBoxright.TabIndex = 38;
            this.numBoxright.Text = "0";
            // 
            // numBoxForCompare
            // 
            this.numBoxForCompare.Location = new System.Drawing.Point(311, 414);
            this.numBoxForCompare.Name = "numBoxForCompare";
            this.numBoxForCompare.Size = new System.Drawing.Size(65, 21);
            this.numBoxForCompare.TabIndex = 39;
            this.numBoxForCompare.Text = "0";
            this.numBoxForCompare.TextChanged += new System.EventHandler(this.numBoxForCompare_TextChanged);
            // 
            // labelForIdBox
            // 
            this.labelForIdBox.AutoSize = true;
            this.labelForIdBox.Location = new System.Drawing.Point(267, 373);
            this.labelForIdBox.Name = "labelForIdBox";
            this.labelForIdBox.Size = new System.Drawing.Size(16, 12);
            this.labelForIdBox.TabIndex = 40;
            this.labelForIdBox.Text = "ID";
            // 
            // labelForNumBoxright
            // 
            this.labelForNumBoxright.AutoSize = true;
            this.labelForNumBoxright.Location = new System.Drawing.Point(409, 373);
            this.labelForNumBoxright.Name = "labelForNumBoxright";
            this.labelForNumBoxright.Size = new System.Drawing.Size(33, 12);
            this.labelForNumBoxright.TabIndex = 41;
            this.labelForNumBoxright.Text = "NUM";
            // 
            // labelForNumBoxUnderID
            // 
            this.labelForNumBoxUnderID.AutoSize = true;
            this.labelForNumBoxUnderID.Location = new System.Drawing.Point(267, 419);
            this.labelForNumBoxUnderID.Name = "labelForNumBoxUnderID";
            this.labelForNumBoxUnderID.Size = new System.Drawing.Size(33, 12);
            this.labelForNumBoxUnderID.TabIndex = 42;
            this.labelForNumBoxUnderID.Text = "NUM";
            // 
            // boxForAppendtoFile
            // 
            this.boxForAppendtoFile.Location = new System.Drawing.Point(474, 49);
            this.boxForAppendtoFile.Name = "boxForAppendtoFile";
            this.boxForAppendtoFile.Size = new System.Drawing.Size(100, 21);
            this.boxForAppendtoFile.TabIndex = 43;
            // 
            // boxFordataView
            // 
            this.boxFordataView.FormattingEnabled = true;
            this.boxFordataView.ItemHeight = 12;
            this.boxFordataView.Location = new System.Drawing.Point(18, 12);
            this.boxFordataView.Name = "boxFordataView";
            this.boxFordataView.Size = new System.Drawing.Size(227, 148);
            this.boxFordataView.TabIndex = 44;
            this.boxFordataView.SelectedIndexChanged += new System.EventHandler(this.boxFordataView_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 462);
            this.Controls.Add(this.boxFordataView);
            this.Controls.Add(this.boxForAppendtoFile);
            this.Controls.Add(this.labelForNumBoxUnderID);
            this.Controls.Add(this.labelForNumBoxright);
            this.Controls.Add(this.labelForIdBox);
            this.Controls.Add(this.numBoxForCompare);
            this.Controls.Add(this.numBoxright);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.selectedFolderPath);
            this.Controls.Add(this.labelForDateTime);
            this.Controls.Add(this.fileNameBox);
            this.Controls.Add(this.totalPercentChange);
            this.Controls.Add(this.lowerNGPercent);
            this.Controls.Add(this.upperOKPercent);
            this.Controls.Add(this.totalCountChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTotalChange);
            this.Controls.Add(this.labelLowerNG);
            this.Controls.Add(this.labelUpperOK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lowerNGCount);
            this.Controls.Add(this.upperOKCount);
            this.Controls.Add(this.totalPercent);
            this.Controls.Add(this.ngPercent);
            this.Controls.Add(this.okPercent);
            this.Controls.Add(this.totalCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelNG);
            this.Controls.Add(this.labelOK);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.BtnLowerNG);
            this.Controls.Add(this.BtnInitialize);
            this.Controls.Add(this.btnUpperOK);
            this.Controls.Add(this.btnNGplus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ngCount);
            this.Controls.Add(this.dataInsertBox);
            this.Controls.Add(this.btnOKplus);
            this.Controls.Add(this.oKCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox oKCount;
        private System.Windows.Forms.Button btnOKplus;
        private System.Windows.Forms.ListView dataInsertBox;
        private System.Windows.Forms.TextBox ngCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNGplus;
        private System.Windows.Forms.Button btnUpperOK;
        private System.Windows.Forms.Button BtnInitialize;
        private System.Windows.Forms.Button BtnLowerNG;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button compare;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelOK;
        private System.Windows.Forms.Label labelNG;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalCount;
        private System.Windows.Forms.TextBox totalPercent;
        private System.Windows.Forms.TextBox ngPercent;
        private System.Windows.Forms.TextBox okPercent;
        private System.Windows.Forms.TextBox totalPercentChange;
        private System.Windows.Forms.TextBox lowerNGPercent;
        private System.Windows.Forms.TextBox upperOKPercent;
        private System.Windows.Forms.TextBox totalCountChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalChange;
        private System.Windows.Forms.Label labelLowerNG;
        private System.Windows.Forms.Label labelUpperOK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lowerNGCount;
        private System.Windows.Forms.TextBox upperOKCount;
        private System.Windows.Forms.ComboBox fileNameBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelForDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox selectedFolderPath;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox numBoxright;
        private System.Windows.Forms.TextBox numBoxForCompare;
        private System.Windows.Forms.Label labelForIdBox;
        private System.Windows.Forms.Label labelForNumBoxright;
        private System.Windows.Forms.Label labelForNumBoxUnderID;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader id;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox boxForAppendtoFile;
        private System.Windows.Forms.ListBox boxFordataView;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

