namespace MovieLibrary.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.userBtnOne = new DevExpress.XtraEditors.SimpleButton();
            this.userBtnTwo = new DevExpress.XtraEditors.SimpleButton();
            this.userBtnFour = new DevExpress.XtraEditors.SimpleButton();
            this.userBtnThree = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // userBtnOne
            // 
            this.userBtnOne.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("userBtnOne.ImageOptions.Image")));
            this.userBtnOne.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.userBtnOne.Location = new System.Drawing.Point(30, 103);
            this.userBtnOne.Name = "userBtnOne";
            this.userBtnOne.Size = new System.Drawing.Size(139, 135);
            this.userBtnOne.TabIndex = 0;
            this.userBtnOne.Text = "User - 1";
            this.userBtnOne.Click += new System.EventHandler(this.userBtnOne_Click);
            // 
            // userBtnTwo
            // 
            this.userBtnTwo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("userBtnTwo.ImageOptions.Image")));
            this.userBtnTwo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.userBtnTwo.Location = new System.Drawing.Point(196, 103);
            this.userBtnTwo.Name = "userBtnTwo";
            this.userBtnTwo.Size = new System.Drawing.Size(139, 135);
            this.userBtnTwo.TabIndex = 1;
            this.userBtnTwo.Text = "User - 2";
            this.userBtnTwo.Click += new System.EventHandler(this.userBtnTwo_Click);
            // 
            // userBtnFour
            // 
            this.userBtnFour.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("userBtnFour.ImageOptions.Image")));
            this.userBtnFour.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.userBtnFour.Location = new System.Drawing.Point(527, 103);
            this.userBtnFour.Name = "userBtnFour";
            this.userBtnFour.Size = new System.Drawing.Size(139, 135);
            this.userBtnFour.TabIndex = 2;
            this.userBtnFour.Text = "User - 4";
            this.userBtnFour.Click += new System.EventHandler(this.userBtnFour_Click);
            // 
            // userBtnThree
            // 
            this.userBtnThree.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("userBtnThree.ImageOptions.Image")));
            this.userBtnThree.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.userBtnThree.Location = new System.Drawing.Point(361, 103);
            this.userBtnThree.Name = "userBtnThree";
            this.userBtnThree.Size = new System.Drawing.Size(139, 135);
            this.userBtnThree.TabIndex = 3;
            this.userBtnThree.Text = "User - 3";
            this.userBtnThree.Click += new System.EventHandler(this.userBtnThree_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(300, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 17);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Select A Pofile";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 306);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.userBtnThree);
            this.Controls.Add(this.userBtnFour);
            this.Controls.Add(this.userBtnTwo);
            this.Controls.Add(this.userBtnOne);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton userBtnOne;
        private DevExpress.XtraEditors.SimpleButton userBtnTwo;
        private DevExpress.XtraEditors.SimpleButton userBtnFour;
        private DevExpress.XtraEditors.SimpleButton userBtnThree;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}