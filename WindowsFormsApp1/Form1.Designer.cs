
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Start.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Steinberg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Start.Location = new System.Drawing.Point(291, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(205, 69);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_Message
            // 
            this.lbl_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Message.Font = new System.Drawing.Font("Comfortaa", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Message.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Message.Location = new System.Drawing.Point(291, 243);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(0, 75);
            this.lbl_Message.TabIndex = 0;
            this.lbl_Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_ID
            // 
            this.tb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ID.BackColor = System.Drawing.Color.Azure;
            this.tb_ID.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tb_ID.Location = new System.Drawing.Point(291, 153);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.PlaceholderText = "User ID";
            this.tb_ID.Size = new System.Drawing.Size(205, 50);
            this.tb_ID.TabIndex = 2;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.btn_Start);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polytoria_Api";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.TextBox tb_ID;
    }
}

