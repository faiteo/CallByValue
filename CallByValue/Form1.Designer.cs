namespace CallByValue
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
            this.txtBoxEnterNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnMulitply = new System.Windows.Forms.Button();
            this.labelBeforeCall = new System.Windows.Forms.Label();
            this.labelAfterCall = new System.Windows.Forms.Label();
            this.lblB4Call = new System.Windows.Forms.Label();
            this.lblAfterCall = new System.Windows.Forms.Label();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxEnterNum
            // 
            this.txtBoxEnterNum.Location = new System.Drawing.Point(93, 18);
            this.txtBoxEnterNum.Name = "txtBoxEnterNum";
            this.txtBoxEnterNum.Size = new System.Drawing.Size(118, 20);
            this.txtBoxEnterNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a Number";
            // 
            // lblResult
            // 
            this.lblResult.AllowDrop = true;
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(217, 21);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // btnMulitply
            // 
            this.btnMulitply.Location = new System.Drawing.Point(93, 44);
            this.btnMulitply.Name = "btnMulitply";
            this.btnMulitply.Size = new System.Drawing.Size(118, 23);
            this.btnMulitply.TabIndex = 3;
            this.btnMulitply.Text = "Multiply Number By 5";
            this.btnMulitply.UseVisualStyleBackColor = true;
            this.btnMulitply.Click += new System.EventHandler(this.btnMulitply_Click);
            // 
            // labelBeforeCall
            // 
            this.labelBeforeCall.AutoSize = true;
            this.labelBeforeCall.Location = new System.Drawing.Point(12, 112);
            this.labelBeforeCall.Name = "labelBeforeCall";
            this.labelBeforeCall.Size = new System.Drawing.Size(154, 13);
            this.labelBeforeCall.TabIndex = 4;
            this.labelBeforeCall.Text = "Value Of Number Before Call = ";
            // 
            // labelAfterCall
            // 
            this.labelAfterCall.AutoSize = true;
            this.labelAfterCall.Location = new System.Drawing.Point(12, 137);
            this.labelAfterCall.Name = "labelAfterCall";
            this.labelAfterCall.Size = new System.Drawing.Size(142, 13);
            this.labelAfterCall.TabIndex = 5;
            this.labelAfterCall.Text = "Value Of Number After Call =";
            // 
            // lblB4Call
            // 
            this.lblB4Call.AutoSize = true;
            this.lblB4Call.Location = new System.Drawing.Point(160, 112);
            this.lblB4Call.Name = "lblB4Call";
            this.lblB4Call.Size = new System.Drawing.Size(35, 13);
            this.lblB4Call.TabIndex = 6;
            this.lblB4Call.Text = "label3";
            this.lblB4Call.Visible = false;
            // 
            // lblAfterCall
            // 
            this.lblAfterCall.AutoSize = true;
            this.lblAfterCall.Location = new System.Drawing.Point(160, 137);
            this.lblAfterCall.Name = "lblAfterCall";
            this.lblAfterCall.Size = new System.Drawing.Size(35, 13);
            this.lblAfterCall.TabIndex = 7;
            this.lblAfterCall.Text = "label4";
            this.lblAfterCall.Visible = false;
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(217, 195);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 23);
            this.btnResetForm.TabIndex = 8;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btn_ResetForm);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(255, 21);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(48, 13);
            this.lblRes.TabIndex = 9;
            this.lblRes.Text = "labelRes";
            this.lblRes.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 262);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.lblAfterCall);
            this.Controls.Add(this.lblB4Call);
            this.Controls.Add(this.labelAfterCall);
            this.Controls.Add(this.labelBeforeCall);
            this.Controls.Add(this.btnMulitply);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxEnterNum);
            this.Name = "Form1";
            this.Text = "Call By Value Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxEnterNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnMulitply;
        private System.Windows.Forms.Label labelBeforeCall;
        private System.Windows.Forms.Label labelAfterCall;
        private System.Windows.Forms.Label lblB4Call;
        private System.Windows.Forms.Label lblAfterCall;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label lblRes;
    }
}

