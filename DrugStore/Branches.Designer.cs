
namespace DrugStore
{
    partial class Branches
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
            this.datagw_branches = new System.Windows.Forms.DataGridView();
            this.btn_addBranch = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagw_branches)).BeginInit();
            this.SuspendLayout();
            // 
            // datagw_branches
            // 
            this.datagw_branches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagw_branches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagw_branches.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.datagw_branches.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagw_branches.ColumnHeadersHeight = 25;
            this.datagw_branches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagw_branches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.BranchName,
            this.BranchAdress,
            this.PhoneNumber});
            this.datagw_branches.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagw_branches.Location = new System.Drawing.Point(12, 3);
            this.datagw_branches.Name = "datagw_branches";
            this.datagw_branches.RowHeadersWidth = 51;
            this.datagw_branches.RowTemplate.Height = 24;
            this.datagw_branches.Size = new System.Drawing.Size(783, 345);
            this.datagw_branches.TabIndex = 0;
            // 
            // btn_addBranch
            // 
            this.btn_addBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addBranch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_addBranch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addBranch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_addBranch.Location = new System.Drawing.Point(625, 368);
            this.btn_addBranch.Name = "btn_addBranch";
            this.btn_addBranch.Size = new System.Drawing.Size(116, 57);
            this.btn_addBranch.TabIndex = 2;
            this.btn_addBranch.Text = "Add";
            this.btn_addBranch.UseVisualStyleBackColor = false;
            this.btn_addBranch.Click += new System.EventHandler(this.btn_addBranch_Click);
            // 
            // number
            // 
            this.number.FillWeight = 30F;
            this.number.HeaderText = "*";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            // 
            // BranchName
            // 
            this.BranchName.FillWeight = 54.27808F;
            this.BranchName.HeaderText = "BranchName";
            this.BranchName.MinimumWidth = 10;
            this.BranchName.Name = "BranchName";
            // 
            // BranchAdress
            // 
            this.BranchAdress.FillWeight = 54.27808F;
            this.BranchAdress.HeaderText = "BranchAdress";
            this.BranchAdress.MinimumWidth = 6;
            this.BranchAdress.Name = "BranchAdress";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.FillWeight = 54.27808F;
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Branches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addBranch);
            this.Controls.Add(this.datagw_branches);
            this.Name = "Branches";
            this.Text = "Branches";
            ((System.ComponentModel.ISupportInitialize)(this.datagw_branches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagw_branches;
        private System.Windows.Forms.Button btn_addBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
    }
}