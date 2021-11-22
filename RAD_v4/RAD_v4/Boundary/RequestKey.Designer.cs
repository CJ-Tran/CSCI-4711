
namespace RAD_v4
{
    partial class RequestKey
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
            this.RqstKeyLbl = new System.Windows.Forms.Label();
            this.KeysLbl = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.KeyList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RqstKeyLbl
            // 
            this.RqstKeyLbl.AutoSize = true;
            this.RqstKeyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RqstKeyLbl.Location = new System.Drawing.Point(53, 35);
            this.RqstKeyLbl.Name = "RqstKeyLbl";
            this.RqstKeyLbl.Size = new System.Drawing.Size(163, 31);
            this.RqstKeyLbl.TabIndex = 0;
            this.RqstKeyLbl.Text = "RequestKey";
            // 
            // KeysLbl
            // 
            this.KeysLbl.AutoSize = true;
            this.KeysLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeysLbl.Location = new System.Drawing.Point(54, 88);
            this.KeysLbl.Name = "KeysLbl";
            this.KeysLbl.Size = new System.Drawing.Size(72, 29);
            this.KeysLbl.TabIndex = 1;
            this.KeysLbl.Text = "Keys:";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(59, 306);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(97, 39);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(289, 306);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(97, 39);
            this.SubmitBtn.TabIndex = 5;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // KeyList
            // 
            this.KeyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyList.FormattingEnabled = true;
            this.KeyList.ItemHeight = 20;
            this.KeyList.Location = new System.Drawing.Point(59, 132);
            this.KeyList.Name = "KeyList";
            this.KeyList.Size = new System.Drawing.Size(157, 84);
            this.KeyList.TabIndex = 6;
            this.KeyList.SelectedIndexChanged += new System.EventHandler(this.KeyList_SelectedIndexChanged_1);
            // 
            // RequestKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 391);
            this.Controls.Add(this.KeyList);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.KeysLbl);
            this.Controls.Add(this.RqstKeyLbl);
            this.Name = "RequestKey";
            this.Text = "MMenu";
            this.Load += new System.EventHandler(this.RequestKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RqstKeyLbl;
        private System.Windows.Forms.Label KeysLbl;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.ListBox KeyList;
    }
}