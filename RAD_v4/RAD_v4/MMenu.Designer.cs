
namespace RAD_v4
{
    partial class MMenu
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
            this.KeysList = new System.Windows.Forms.CheckedListBox();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
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
            // KeysList
            // 
            this.KeysList.CheckOnClick = true;
            this.KeysList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeysList.FormattingEnabled = true;
            this.KeysList.Items.AddRange(new object[] {
            "Room1",
            "Room2",
            "Room3",
            "Room4",
            "Room5",
            "Room6"});
            this.KeysList.Location = new System.Drawing.Point(59, 132);
            this.KeysList.Name = "KeysList";
            this.KeysList.Size = new System.Drawing.Size(157, 88);
            this.KeysList.Sorted = true;
            this.KeysList.TabIndex = 3;
            this.KeysList.SelectedIndexChanged += new System.EventHandler(this.KeysList_SelectedIndexChanged);
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
            // 
            // MMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 391);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.KeysList);
            this.Controls.Add(this.KeysLbl);
            this.Controls.Add(this.RqstKeyLbl);
            this.Name = "MMenu";
            this.Text = "MMenu";
            this.Load += new System.EventHandler(this.MMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RqstKeyLbl;
        private System.Windows.Forms.Label KeysLbl;
        private System.Windows.Forms.CheckedListBox KeysList;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button SubmitBtn;
    }
}