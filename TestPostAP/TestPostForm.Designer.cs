namespace TestPostAP
{
    partial class TestPostForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabActionControl = new DevExpress.XtraTab.XtraTabControl();
            this.RequestTab = new DevExpress.XtraTab.XtraTabPage();
            this.meReq = new DevExpress.XtraEditors.MemoEdit();
            this.ResponseTab = new DevExpress.XtraTab.XtraTabPage();
            this.meRepo = new DevExpress.XtraEditors.MemoEdit();
            this.txtURL = new DevExpress.XtraEditors.TextEdit();
            this.btnPost = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabActionControl)).BeginInit();
            this.tabActionControl.SuspendLayout();
            this.RequestTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meReq.Properties)).BeginInit();
            this.ResponseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meRepo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtURL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tabActionControl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(728, 308);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tabActionControl
            // 
            this.tabActionControl.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabActionControl.Location = new System.Drawing.Point(3, 3);
            this.tabActionControl.Name = "tabActionControl";
            this.tabActionControl.SelectedTabPage = this.RequestTab;
            this.tabActionControl.Size = new System.Drawing.Size(714, 300);
            this.tabActionControl.TabIndex = 4;
            this.tabActionControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.RequestTab,
            this.ResponseTab});
            // 
            // RequestTab
            // 
            this.RequestTab.Controls.Add(this.meReq);
            this.RequestTab.Name = "RequestTab";
            this.RequestTab.Size = new System.Drawing.Size(708, 271);
            this.RequestTab.Text = "RequestTab";
            // 
            // meReq
            // 
            this.meReq.Location = new System.Drawing.Point(3, 3);
            this.meReq.Name = "meReq";
            this.meReq.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meReq.Properties.Appearance.Options.UseFont = true;
            this.meReq.Properties.NullValuePrompt = "請輸入ReqeustBody 目前只提供json格式";
            this.meReq.Properties.NullValuePromptShowForEmptyValue = true;
            this.meReq.Properties.ShowNullValuePromptWhenFocused = true;
            this.meReq.Size = new System.Drawing.Size(702, 265);
            this.meReq.TabIndex = 4;
            // 
            // ResponseTab
            // 
            this.ResponseTab.Controls.Add(this.meRepo);
            this.ResponseTab.Name = "ResponseTab";
            this.ResponseTab.Size = new System.Drawing.Size(708, 271);
            this.ResponseTab.Text = "ResponseTab";
            // 
            // meRepo
            // 
            this.meRepo.Location = new System.Drawing.Point(4, 4);
            this.meRepo.Name = "meRepo";
            this.meRepo.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meRepo.Properties.Appearance.Options.UseFont = true;
            this.meRepo.Properties.NullValuePrompt = "Post回來的資料會顯示於此處";
            this.meRepo.Size = new System.Drawing.Size(701, 264);
            this.meRepo.TabIndex = 0;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Properties.Appearance.Options.UseFont = true;
            this.txtURL.Size = new System.Drawing.Size(636, 26);
            this.txtURL.TabIndex = 4;
            // 
            // btnPost
            // 
            this.btnPost.Appearance.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Appearance.Options.UseFont = true;
            this.btnPost.Location = new System.Drawing.Point(654, 12);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(86, 26);
            this.btnPost.TabIndex = 5;
            this.btnPost.Text = "Go!Post";
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // TestPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(746, 361);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TestPostForm";
            this.Text = "TestPostForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabActionControl)).EndInit();
            this.tabActionControl.ResumeLayout(false);
            this.RequestTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meReq.Properties)).EndInit();
            this.ResponseTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meRepo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtURL.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraTab.XtraTabControl tabActionControl;
        private DevExpress.XtraTab.XtraTabPage RequestTab;
        private DevExpress.XtraEditors.MemoEdit meReq;
        private DevExpress.XtraTab.XtraTabPage ResponseTab;
        private DevExpress.XtraEditors.MemoEdit meRepo;
        private DevExpress.XtraEditors.TextEdit txtURL;
        private DevExpress.XtraEditors.SimpleButton btnPost;
    }
}

