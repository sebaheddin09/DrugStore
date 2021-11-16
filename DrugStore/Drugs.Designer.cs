
namespace DrugStore
{
    partial class Drugs
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
            this.datagw_drugs = new System.Windows.Forms.DataGridView();
            this.btn_addDrug = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagw_drugs)).BeginInit();
            this.SuspendLayout();
            // 
            // datagw_drugs
            // 
            this.datagw_drugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagw_drugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagw_drugs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.datagw_drugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagw_drugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.DrugId,
            this.DrugName,
            this.Destination,
            this.Value});
            this.datagw_drugs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagw_drugs.Location = new System.Drawing.Point(12, 3);
            this.datagw_drugs.Name = "datagw_drugs";
            this.datagw_drugs.RowHeadersWidth = 51;
            this.datagw_drugs.RowTemplate.Height = 24;
            this.datagw_drugs.Size = new System.Drawing.Size(783, 345);
            this.datagw_drugs.TabIndex = 0;
            // 
            // btn_addDrug
            // 
            this.btn_addDrug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addDrug.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_addDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addDrug.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_addDrug.Location = new System.Drawing.Point(625, 368);
            this.btn_addDrug.Name = "btn_addDrug";
            this.btn_addDrug.Size = new System.Drawing.Size(116, 57);
            this.btn_addDrug.TabIndex = 2;
            this.btn_addDrug.Text = "Add";
            this.btn_addDrug.UseVisualStyleBackColor = false;
            this.btn_addDrug.Click += new System.EventHandler(this.btn_addDrug_Click);
            // 
            // number
            // 
            this.number.FillWeight = 50F;
            this.number.HeaderText = "*";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            // 
            // DrugId
            // 
            this.DrugId.HeaderText = "DrugId";
            this.DrugId.MinimumWidth = 6;
            this.DrugId.Name = "DrugId";
            // 
            // DrugName
            // 
            this.DrugName.HeaderText = "DrugName";
            this.DrugName.MinimumWidth = 6;
            this.DrugName.Name = "DrugName";
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.MinimumWidth = 6;
            this.Destination.Name = "Destination";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            // 
            // Drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addDrug);
            this.Controls.Add(this.datagw_drugs);
            this.Name = "Drugs";
            this.Text = "Drugs";
            ((System.ComponentModel.ISupportInitialize)(this.datagw_drugs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagw_drugs;
        private System.Windows.Forms.Button btn_addDrug;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}