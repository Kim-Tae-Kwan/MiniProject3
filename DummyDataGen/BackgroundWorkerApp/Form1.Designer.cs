﻿namespace BackgroundWorkerApp
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnCancle = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.PgbTest = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnStart.Location = new System.Drawing.Point(98, 151);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(182, 70);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnCancle
            // 
            this.BtnCancle.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnCancle.Location = new System.Drawing.Point(286, 151);
            this.BtnCancle.Name = "BtnCancle";
            this.BtnCancle.Size = new System.Drawing.Size(182, 70);
            this.BtnCancle.TabIndex = 0;
            this.BtnCancle.Text = "Cancle";
            this.BtnCancle.UseVisualStyleBackColor = true;
            this.BtnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblResult.Location = new System.Drawing.Point(39, 26);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(103, 24);
            this.LblResult.TabIndex = 1;
            this.LblResult.Text = "LblResult";
            // 
            // PgbTest
            // 
            this.PgbTest.Location = new System.Drawing.Point(43, 69);
            this.PgbTest.Name = "PgbTest";
            this.PgbTest.Size = new System.Drawing.Size(500, 53);
            this.PgbTest.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 235);
            this.Controls.Add(this.PgbTest);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnCancle);
            this.Controls.Add(this.BtnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnCancle;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.ProgressBar PgbTest;
    }
}

