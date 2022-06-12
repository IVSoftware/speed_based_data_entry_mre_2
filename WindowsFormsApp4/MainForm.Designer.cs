namespace WindowsFormsApp4
{
    partial class MainForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.buttonABC = new System.Windows.Forms.Button();
            this.buttonCDE = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(800, 383);
            this.dgv.TabIndex = 0;
            // 
            // buttonABC
            // 
            this.buttonABC.Location = new System.Drawing.Point(12, 398);
            this.buttonABC.Name = "buttonABC";
            this.buttonABC.Size = new System.Drawing.Size(75, 40);
            this.buttonABC.TabIndex = 2;
            this.buttonABC.TabStop = false;
            this.buttonABC.Text = "ABC";
            this.buttonABC.UseVisualStyleBackColor = true;
            this.buttonABC.Click += new System.EventHandler(this.buttonABC_Click);
            // 
            // buttonCDE
            // 
            this.buttonCDE.Location = new System.Drawing.Point(93, 398);
            this.buttonCDE.Name = "buttonCDE";
            this.buttonCDE.Size = new System.Drawing.Size(75, 40);
            this.buttonCDE.TabIndex = 3;
            this.buttonCDE.TabStop = false;
            this.buttonCDE.Text = "CDE";
            this.buttonCDE.UseVisualStyleBackColor = true;
            this.buttonCDE.Click += new System.EventHandler(this.buttonCDE_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(670, 398);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(118, 40);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCDE);
            this.Controls.Add(this.buttonABC);
            this.Controls.Add(this.dgv);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttonABC;
        private System.Windows.Forms.Button buttonCDE;
        private System.Windows.Forms.Button buttonClear;
    }
}

