namespace Count_Vowels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbox_StringList = new System.Windows.Forms.TextBox();
            this.btn_Count = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_TextInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_StringList
            // 
            this.txtbox_StringList.Location = new System.Drawing.Point(12, 37);
            this.txtbox_StringList.Multiline = true;
            this.txtbox_StringList.Name = "txtbox_StringList";
            this.txtbox_StringList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_StringList.Size = new System.Drawing.Size(262, 100);
            this.txtbox_StringList.TabIndex = 0;
            // 
            // btn_Count
            // 
            this.btn_Count.Location = new System.Drawing.Point(84, 186);
            this.btn_Count.Name = "btn_Count";
            this.btn_Count.Size = new System.Drawing.Size(116, 43);
            this.btn_Count.TabIndex = 1;
            this.btn_Count.Text = "Count Vowels";
            this.btn_Count.UseVisualStyleBackColor = true;
            this.btn_Count.Click += new System.EventHandler(this.btn_Count_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Clear.Location = new System.Drawing.Point(207, 143);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(67, 23);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "Clear Text";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_TextInfo
            // 
            this.lbl_TextInfo.AutoSize = true;
            this.lbl_TextInfo.Location = new System.Drawing.Point(9, 21);
            this.lbl_TextInfo.Name = "lbl_TextInfo";
            this.lbl_TextInfo.Size = new System.Drawing.Size(108, 13);
            this.lbl_TextInfo.TabIndex = 3;
            this.lbl_TextInfo.Text = "Enter your text here...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 241);
            this.Controls.Add(this.lbl_TextInfo);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Count);
            this.Controls.Add(this.txtbox_StringList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vowel Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_StringList;
        private System.Windows.Forms.Button btn_Count;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_TextInfo;
    }
}

