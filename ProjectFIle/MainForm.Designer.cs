namespace ProjectFIle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Search_Button = new System.Windows.Forms.Button();
            this.Calculator_Button = new System.Windows.Forms.Button();
            this.Text_Editor_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Search_Button
            // 
            this.Search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Button.Image = ((System.Drawing.Image)(resources.GetObject("Search_Button.Image")));
            this.Search_Button.Location = new System.Drawing.Point(467, 65);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(260, 90);
            this.Search_Button.TabIndex = 0;
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Browser_Button_Click);
            // 
            // Calculator_Button
            // 
            this.Calculator_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculator_Button.Image = ((System.Drawing.Image)(resources.GetObject("Calculator_Button.Image")));
            this.Calculator_Button.Location = new System.Drawing.Point(467, 161);
            this.Calculator_Button.Name = "Calculator_Button";
            this.Calculator_Button.Size = new System.Drawing.Size(260, 90);
            this.Calculator_Button.TabIndex = 1;
            this.Calculator_Button.UseVisualStyleBackColor = true;
            this.Calculator_Button.Click += new System.EventHandler(this.Calculator_Button_Click);
            // 
            // Text_Editor_Button
            // 
            this.Text_Editor_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.Text_Editor_Button.Image = ((System.Drawing.Image)(resources.GetObject("Text_Editor_Button.Image")));
            this.Text_Editor_Button.Location = new System.Drawing.Point(467, 257);
            this.Text_Editor_Button.Name = "Text_Editor_Button";
            this.Text_Editor_Button.Size = new System.Drawing.Size(260, 90);
            this.Text_Editor_Button.TabIndex = 2;
            this.Text_Editor_Button.UseVisualStyleBackColor = true;
            this.Text_Editor_Button.Click += new System.EventHandler(this.TextEditor_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Designed to Help";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_Editor_Button);
            this.Controls.Add(this.Calculator_Button);
            this.Controls.Add(this.Search_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Project File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Calculator_Button;
        private System.Windows.Forms.Button Text_Editor_Button;
        private System.Windows.Forms.Label label1;
    }
}

