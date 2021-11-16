
namespace DrugStore
{
    partial class AddDrug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDrug));
            this.lbl_drugID = new System.Windows.Forms.Label();
            this.lbl_drugName = new System.Windows.Forms.Label();
            this.lbl_destination = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.tb_drugID = new System.Windows.Forms.TextBox();
            this.tb_drugName = new System.Windows.Forms.TextBox();
            this.tb_destination = new System.Windows.Forms.TextBox();
            this.btn_clearD = new System.Windows.Forms.Button();
            this.btn_saveD = new System.Windows.Forms.Button();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_drugID
            // 
            this.lbl_drugID.AutoSize = true;
            this.lbl_drugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_drugID.Location = new System.Drawing.Point(58, 38);
            this.lbl_drugID.Name = "lbl_drugID";
            this.lbl_drugID.Size = new System.Drawing.Size(84, 25);
            this.lbl_drugID.TabIndex = 4;
            this.lbl_drugID.Text = "Drug ID:";
            // 
            // lbl_drugName
            // 
            this.lbl_drugName.AutoSize = true;
            this.lbl_drugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_drugName.Location = new System.Drawing.Point(58, 109);
            this.lbl_drugName.Name = "lbl_drugName";
            this.lbl_drugName.Size = new System.Drawing.Size(117, 25);
            this.lbl_drugName.TabIndex = 5;
            this.lbl_drugName.Text = "Drug Name:";
            // 
            // lbl_destination
            // 
            this.lbl_destination.AutoSize = true;
            this.lbl_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_destination.Location = new System.Drawing.Point(60, 248);
            this.lbl_destination.Name = "lbl_destination";
            this.lbl_destination.Size = new System.Drawing.Size(115, 25);
            this.lbl_destination.TabIndex = 6;
            this.lbl_destination.Text = "Destination:";
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_value.Location = new System.Drawing.Point(58, 181);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(99, 25);
            this.lbl_value.TabIndex = 7;
            this.lbl_value.Text = "Value ($):";
            // 
            // tb_drugID
            // 
            this.tb_drugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_drugID.Location = new System.Drawing.Point(148, 37);
            this.tb_drugID.Multiline = true;
            this.tb_drugID.Name = "tb_drugID";
            this.tb_drugID.Size = new System.Drawing.Size(140, 33);
            this.tb_drugID.TabIndex = 10;
            // 
            // tb_drugName
            // 
            this.tb_drugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_drugName.Location = new System.Drawing.Point(181, 108);
            this.tb_drugName.Multiline = true;
            this.tb_drugName.Name = "tb_drugName";
            this.tb_drugName.Size = new System.Drawing.Size(235, 33);
            this.tb_drugName.TabIndex = 11;
            // 
            // tb_destination
            // 
            this.tb_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_destination.Location = new System.Drawing.Point(181, 249);
            this.tb_destination.Multiline = true;
            this.tb_destination.Name = "tb_destination";
            this.tb_destination.Size = new System.Drawing.Size(300, 100);
            this.tb_destination.TabIndex = 16;
            // 
            // btn_clearD
            // 
            this.btn_clearD.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_clearD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clearD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clearD.Location = new System.Drawing.Point(667, 331);
            this.btn_clearD.Name = "btn_clearD";
            this.btn_clearD.Size = new System.Drawing.Size(168, 54);
            this.btn_clearD.TabIndex = 18;
            this.btn_clearD.Text = "Clear";
            this.btn_clearD.UseVisualStyleBackColor = false;
            this.btn_clearD.Click += new System.EventHandler(this.btn_clearD_Click);
            // 
            // btn_saveD
            // 
            this.btn_saveD.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_saveD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_saveD.Location = new System.Drawing.Point(667, 409);
            this.btn_saveD.Name = "btn_saveD";
            this.btn_saveD.Size = new System.Drawing.Size(168, 54);
            this.btn_saveD.TabIndex = 19;
            this.btn_saveD.Text = "Save";
            this.btn_saveD.UseVisualStyleBackColor = false;
            this.btn_saveD.Click += new System.EventHandler(this.btn_saveD_Click);
            // 
            // tb_value
            // 
            this.tb_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_value.Location = new System.Drawing.Point(163, 180);
            this.tb_value.Multiline = true;
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(96, 33);
            this.tb_value.TabIndex = 20;
            // 
            // AddDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 512);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.btn_saveD);
            this.Controls.Add(this.btn_clearD);
            this.Controls.Add(this.tb_destination);
            this.Controls.Add(this.tb_drugName);
            this.Controls.Add(this.tb_drugID);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.lbl_destination);
            this.Controls.Add(this.lbl_drugName);
            this.Controls.Add(this.lbl_drugID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddDrug";
            this.Text = "AddDrug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_drugID;
        private System.Windows.Forms.Label lbl_drugName;
        private System.Windows.Forms.Label lbl_destination;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.TextBox tb_drugID;
        private System.Windows.Forms.TextBox tb_drugName;
        private System.Windows.Forms.TextBox tb_destination;
        private System.Windows.Forms.Button btn_clearD;
        private System.Windows.Forms.Button btn_saveD;
        private System.Windows.Forms.TextBox tb_value;
    }
}