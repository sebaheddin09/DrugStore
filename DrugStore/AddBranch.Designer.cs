
namespace DrugStore
{
    partial class AddBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBranch));
            this.lbl_branchName = new System.Windows.Forms.Label();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.lbl_branchAdress = new System.Windows.Forms.Label();
            this.tb_branchName = new System.Windows.Forms.TextBox();
            this.tb_phoneNumber = new System.Windows.Forms.TextBox();
            this.tb_branchAdress = new System.Windows.Forms.TextBox();
            this.btn_clearB = new System.Windows.Forms.Button();
            this.btn_saveB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_branchName
            // 
            this.lbl_branchName.AutoSize = true;
            this.lbl_branchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_branchName.Location = new System.Drawing.Point(47, 37);
            this.lbl_branchName.Name = "lbl_branchName";
            this.lbl_branchName.Size = new System.Drawing.Size(137, 25);
            this.lbl_branchName.TabIndex = 3;
            this.lbl_branchName.Text = "Branch Name:";
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.AutoSize = true;
            this.lbl_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_phoneNumber.Location = new System.Drawing.Point(47, 103);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(149, 25);
            this.lbl_phoneNumber.TabIndex = 4;
            this.lbl_phoneNumber.Text = "Phone Number:";
            // 
            // lbl_branchAdress
            // 
            this.lbl_branchAdress.AutoSize = true;
            this.lbl_branchAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_branchAdress.Location = new System.Drawing.Point(47, 172);
            this.lbl_branchAdress.Name = "lbl_branchAdress";
            this.lbl_branchAdress.Size = new System.Drawing.Size(147, 25);
            this.lbl_branchAdress.TabIndex = 5;
            this.lbl_branchAdress.Text = "Branch Adress:";
            // 
            // tb_branchName
            // 
            this.tb_branchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_branchName.Location = new System.Drawing.Point(194, 36);
            this.tb_branchName.Multiline = true;
            this.tb_branchName.Name = "tb_branchName";
            this.tb_branchName.Size = new System.Drawing.Size(261, 33);
            this.tb_branchName.TabIndex = 9;
            // 
            // tb_phoneNumber
            // 
            this.tb_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_phoneNumber.Location = new System.Drawing.Point(202, 101);
            this.tb_phoneNumber.Multiline = true;
            this.tb_phoneNumber.Name = "tb_phoneNumber";
            this.tb_phoneNumber.Size = new System.Drawing.Size(174, 33);
            this.tb_phoneNumber.TabIndex = 10;
            // 
            // tb_branchAdress
            // 
            this.tb_branchAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_branchAdress.Location = new System.Drawing.Point(202, 173);
            this.tb_branchAdress.Multiline = true;
            this.tb_branchAdress.Name = "tb_branchAdress";
            this.tb_branchAdress.Size = new System.Drawing.Size(300, 100);
            this.tb_branchAdress.TabIndex = 15;
            // 
            // btn_clearB
            // 
            this.btn_clearB.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_clearB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clearB.Location = new System.Drawing.Point(667, 331);
            this.btn_clearB.Name = "btn_clearB";
            this.btn_clearB.Size = new System.Drawing.Size(168, 54);
            this.btn_clearB.TabIndex = 17;
            this.btn_clearB.Text = "Clear";
            this.btn_clearB.UseVisualStyleBackColor = false;
            this.btn_clearB.Click += new System.EventHandler(this.btn_clearB_Click);
            // 
            // btn_saveB
            // 
            this.btn_saveB.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_saveB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_saveB.Location = new System.Drawing.Point(667, 409);
            this.btn_saveB.Name = "btn_saveB";
            this.btn_saveB.Size = new System.Drawing.Size(168, 54);
            this.btn_saveB.TabIndex = 18;
            this.btn_saveB.Text = "Save";
            this.btn_saveB.UseVisualStyleBackColor = false;
            this.btn_saveB.Click += new System.EventHandler(this.btn_saveB_Click);
            // 
            // AddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 512);
            this.Controls.Add(this.btn_saveB);
            this.Controls.Add(this.btn_clearB);
            this.Controls.Add(this.tb_branchAdress);
            this.Controls.Add(this.tb_phoneNumber);
            this.Controls.Add(this.tb_branchName);
            this.Controls.Add(this.lbl_branchAdress);
            this.Controls.Add(this.lbl_phoneNumber);
            this.Controls.Add(this.lbl_branchName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddBranch";
            this.Text = "AddBranch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_branchName;
        private System.Windows.Forms.Label lbl_phoneNumber;
        private System.Windows.Forms.Label lbl_branchAdress;
        private System.Windows.Forms.TextBox tb_branchName;
        private System.Windows.Forms.TextBox tb_phoneNumber;
        private System.Windows.Forms.TextBox tb_branchAdress;
        private System.Windows.Forms.Button btn_clearB;
        private System.Windows.Forms.Button btn_saveB;
    }
}