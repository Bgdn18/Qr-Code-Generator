namespace QrCodeGenerator
{
    partial class Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generator));
            pictureBoxQRCode = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            SaveQRCode = new Button();
            menuStrip1 = new MenuStrip();
            themeToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxQRCode.Image = Properties.Resources.TG_QR_CODE;
            pictureBoxQRCode.Location = new Point(12, 56);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(617, 234);
            pictureBoxQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQRCode.TabIndex = 0;
            pictureBoxQRCode.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 336);
            button1.Name = "button1";
            button1.Size = new Size(370, 65);
            button1.TabIndex = 1;
            button1.Text = "Generate Qr Code";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 296);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Qr Code Text";
            textBox1.Size = new Size(617, 34);
            textBox1.TabIndex = 2;
            // 
            // SaveQRCode
            // 
            SaveQRCode.Anchor = AnchorStyles.Bottom;
            SaveQRCode.Cursor = Cursors.Hand;
            SaveQRCode.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveQRCode.Location = new Point(388, 336);
            SaveQRCode.Name = "SaveQRCode";
            SaveQRCode.Size = new Size(241, 65);
            SaveQRCode.TabIndex = 3;
            SaveQRCode.Text = "Save Qr Code";
            SaveQRCode.UseVisualStyleBackColor = true;
            SaveQRCode.Click += buttonSave_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { themeToolStripMenuItem, aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(641, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whiteToolStripMenuItem, blackToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(56, 20);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // whiteToolStripMenuItem
            // 
            whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            whiteToolStripMenuItem.Size = new Size(105, 22);
            whiteToolStripMenuItem.Text = "White";
            whiteToolStripMenuItem.Click += whiteToolStripMenuItem_Click;
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(105, 22);
            blackToolStripMenuItem.Text = "Black";
            blackToolStripMenuItem.Click += blackToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(42, 20);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // Generator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(641, 413);
            Controls.Add(SaveQRCode);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBoxQRCode);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Generator";
            Text = "Qr-Code Generator";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxQRCode;
        private Button button1;
        private TextBox textBox1;
        private Button SaveQRCode;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}
