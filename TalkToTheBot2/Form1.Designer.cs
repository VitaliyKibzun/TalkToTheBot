namespace TalkToTheBot2
{
    partial class Form1
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
            this.textBoxConversation = new System.Windows.Forms.TextBox();
            this.textBoxTypeMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxConversation
            // 
            this.textBoxConversation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConversation.BackColor = System.Drawing.Color.White;
            this.textBoxConversation.Location = new System.Drawing.Point(13, 16);
            this.textBoxConversation.Multiline = true;
            this.textBoxConversation.Name = "textBoxConversation";
            this.textBoxConversation.ReadOnly = true;
            this.textBoxConversation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConversation.Size = new System.Drawing.Size(396, 124);
            this.textBoxConversation.TabIndex = 0;
            // 
            // textBoxTypeMessage
            // 
            this.textBoxTypeMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTypeMessage.Location = new System.Drawing.Point(12, 161);
            this.textBoxTypeMessage.Multiline = true;
            this.textBoxTypeMessage.Name = "textBoxTypeMessage";
            this.textBoxTypeMessage.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxTypeMessage.Size = new System.Drawing.Size(396, 47);
            this.textBoxTypeMessage.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Location = new System.Drawing.Point(166, 222);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(112, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send Message";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 257);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxTypeMessage);
            this.Controls.Add(this.textBoxConversation);
            this.Name = "Form1";
            this.Text = "Form1";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConversation;
        private System.Windows.Forms.TextBox textBoxTypeMessage;
        private System.Windows.Forms.Button buttonSend;
    }
}

