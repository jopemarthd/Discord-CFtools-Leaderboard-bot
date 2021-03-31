namespace Cftools_Discordbot_Helper
{
    partial class frmGetServiceToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetServiceToken));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblServiceToken = new System.Windows.Forms.Label();
            this.lblUserAgent = new System.Windows.Forms.Label();
            this.txtUserAgent = new System.Windows.Forms.TextBox();
            this.lblSecret = new System.Windows.Forms.Label();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.btnGetServiceToken = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.pnlTop.Controls.Add(this.pcbLogo);
            this.pnlTop.Controls.Add(this.LblTitle);
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(587, 29);
            this.pnlTop.TabIndex = 0;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::Cftools_Discordbot_Helper.Properties.Resources.logo;
            this.pcbLogo.Location = new System.Drawing.Point(0, -3);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(32, 32);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 1;
            this.pcbLogo.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(35, 5);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(199, 16);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "CFTools DiscordBot Helper";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(549, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(94, 59);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(448, 20);
            this.txtClient.TabIndex = 1;
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // lblServiceToken
            // 
            this.lblServiceToken.AutoSize = true;
            this.lblServiceToken.Location = new System.Drawing.Point(35, 62);
            this.lblServiceToken.Name = "lblServiceToken";
            this.lblServiceToken.Size = new System.Drawing.Size(53, 13);
            this.lblServiceToken.TabIndex = 2;
            this.lblServiceToken.Text = "Client-ID :";
            // 
            // lblUserAgent
            // 
            this.lblUserAgent.AutoSize = true;
            this.lblUserAgent.Location = new System.Drawing.Point(35, 99);
            this.lblUserAgent.Name = "lblUserAgent";
            this.lblUserAgent.Size = new System.Drawing.Size(63, 13);
            this.lblUserAgent.TabIndex = 3;
            this.lblUserAgent.Text = "User-Agent:";
            // 
            // txtUserAgent
            // 
            this.txtUserAgent.Location = new System.Drawing.Point(100, 96);
            this.txtUserAgent.Name = "txtUserAgent";
            this.txtUserAgent.Size = new System.Drawing.Size(442, 20);
            this.txtUserAgent.TabIndex = 4;
            this.txtUserAgent.TextChanged += new System.EventHandler(this.txtUserAgent_TextChanged);
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Location = new System.Drawing.Point(35, 136);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(41, 13);
            this.lblSecret.TabIndex = 5;
            this.lblSecret.Text = "Secret:";
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(82, 133);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(460, 20);
            this.txtSecret.TabIndex = 6;
            this.txtSecret.TextChanged += new System.EventHandler(this.txtSecret_TextChanged);
            // 
            // btnGetServiceToken
            // 
            this.btnGetServiceToken.Enabled = false;
            this.btnGetServiceToken.Location = new System.Drawing.Point(238, 177);
            this.btnGetServiceToken.Name = "btnGetServiceToken";
            this.btnGetServiceToken.Size = new System.Drawing.Size(111, 23);
            this.btnGetServiceToken.TabIndex = 7;
            this.btnGetServiceToken.Text = "Get Service Token";
            this.btnGetServiceToken.UseVisualStyleBackColor = true;
            this.btnGetServiceToken.Click += new System.EventHandler(this.btnGetServiceToken_Click);
            // 
            // frmGetServiceToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 227);
            this.Controls.Add(this.btnGetServiceToken);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.lblSecret);
            this.Controls.Add(this.txtUserAgent);
            this.Controls.Add(this.lblUserAgent);
            this.Controls.Add(this.lblServiceToken);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGetServiceToken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblServiceToken;
        private System.Windows.Forms.Label lblUserAgent;
        private System.Windows.Forms.TextBox txtUserAgent;
        private System.Windows.Forms.Label lblSecret;
        private System.Windows.Forms.TextBox txtSecret;
        private System.Windows.Forms.Button btnGetServiceToken;
    }
}

