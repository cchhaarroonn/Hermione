namespace Hermione
{
    partial class SendMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMessage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(343, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 1);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(343, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 1);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(343, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Send Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(479, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Token";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(456, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Channel ID";
            // 
            // tokenBox
            // 
            this.tokenBox.BackColor = System.Drawing.Color.Black;
            this.tokenBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tokenBox.ForeColor = System.Drawing.Color.White;
            this.tokenBox.Location = new System.Drawing.Point(343, 89);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(351, 20);
            this.tokenBox.TabIndex = 16;
            this.tokenBox.TextChanged += new System.EventHandler(this.tokenBox_TextChanged);
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.Black;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBox.ForeColor = System.Drawing.Color.White;
            this.idBox.Location = new System.Drawing.Point(343, 182);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(351, 20);
            this.idBox.TabIndex = 17;
            this.idBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.Black;
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageBox.ForeColor = System.Drawing.Color.White;
            this.messageBox.Location = new System.Drawing.Point(343, 271);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(351, 20);
            this.messageBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(470, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Message";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(343, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 1);
            this.panel3.TabIndex = 18;
            // 
            // SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.tokenBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SendMessage";
            this.Text = "SendMessage";
            this.Load += new System.EventHandler(this.SendMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox tokenBox;
        private TextBox idBox;
        private TextBox messageBox;
        private Label label3;
        private Panel panel3;
    }
}