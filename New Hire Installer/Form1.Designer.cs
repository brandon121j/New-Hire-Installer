namespace New_Hire_Installer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bodyPN = new Panel();
            submitBT = new Button();
            folderTB = new Custom_Controls.CustomTextBox();
            folderPB = new PictureBox();
            folderPN = new Panel();
            msiTB = new Custom_Controls.CustomTextBox();
            msiPB = new PictureBox();
            msiPN = new Panel();
            infoLB = new Label();
            logoPB = new PictureBox();
            loadingPB = new PictureBox();
            titleBarPN = new Panel();
            buttonsPN = new Panel();
            minimizeBT = new Custom_Controls.MinimizeButton();
            closeBT = new Custom_Controls.CloseButton();
            headerPN = new Panel();
            errorProvider = new ErrorProvider(components);
            bodyPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)folderPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)msiPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loadingPB).BeginInit();
            titleBarPN.SuspendLayout();
            buttonsPN.SuspendLayout();
            headerPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // bodyPN
            // 
            bodyPN.BackColor = Color.Transparent;
            bodyPN.Controls.Add(submitBT);
            bodyPN.Controls.Add(folderTB);
            bodyPN.Controls.Add(folderPB);
            bodyPN.Controls.Add(folderPN);
            bodyPN.Controls.Add(msiTB);
            bodyPN.Controls.Add(msiPB);
            bodyPN.Controls.Add(msiPN);
            bodyPN.Dock = DockStyle.Fill;
            bodyPN.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bodyPN.Location = new Point(0, 35);
            bodyPN.Name = "bodyPN";
            bodyPN.Size = new Size(300, 427);
            bodyPN.TabIndex = 1;
            // 
            // submitBT
            // 
            submitBT.Cursor = Cursors.Hand;
            submitBT.FlatAppearance.BorderColor = Color.FromArgb(186, 40, 255);
            submitBT.FlatAppearance.MouseOverBackColor = Color.Transparent;
            submitBT.FlatStyle = FlatStyle.Flat;
            submitBT.ForeColor = Color.FromArgb(186, 40, 255);
            submitBT.Location = new Point(12, 372);
            submitBT.Name = "submitBT";
            submitBT.Size = new Size(276, 43);
            submitBT.TabIndex = 7;
            submitBT.Text = "Run Installer";
            submitBT.UseVisualStyleBackColor = true;
            submitBT.Click += SubmitBT_Click;
            // 
            // folderTB
            // 
            folderTB.BackColor = Color.FromArgb(24, 30, 54);
            folderTB.BorderStyle = BorderStyle.None;
            folderTB.ForeColor = Color.FromArgb(186, 40, 255);
            folderTB.Location = new Point(53, 311);
            folderTB.Multiline = false;
            folderTB.Name = "folderTB";
            folderTB.PlaceholderText = "Select C:\\ Drive Folders";
            folderTB.Size = new Size(235, 23);
            folderTB.TabIndex = 6;
            folderTB.Text = "Select C:\\ Drive Folders";
            folderTB.TextChanged += FolderTB_TextChanged;
            folderTB.Validating += FolderTB_Validating;
            // 
            // folderPB
            // 
            folderPB.Cursor = Cursors.Hand;
            folderPB.Image = Properties.Resources.add_folder_gradient_35;
            folderPB.Location = new Point(12, 299);
            folderPB.Name = "folderPB";
            folderPB.Size = new Size(35, 35);
            folderPB.SizeMode = PictureBoxSizeMode.CenterImage;
            folderPB.TabIndex = 5;
            folderPB.TabStop = false;
            folderPB.Click += FolderPB_Click;
            // 
            // folderPN
            // 
            folderPN.BackColor = Color.FromArgb(186, 40, 255);
            folderPN.Location = new Point(12, 334);
            folderPN.Name = "folderPN";
            folderPN.Size = new Size(276, 3);
            folderPN.TabIndex = 4;
            // 
            // msiTB
            // 
            msiTB.BackColor = Color.FromArgb(24, 30, 54);
            msiTB.BorderStyle = BorderStyle.None;
            msiTB.ForeColor = Color.FromArgb(186, 40, 255);
            msiTB.Location = new Point(53, 233);
            msiTB.Multiline = false;
            msiTB.Name = "msiTB";
            msiTB.PlaceholderText = "Select MSI Folder";
            msiTB.Size = new Size(235, 23);
            msiTB.TabIndex = 3;
            msiTB.Text = "Select MSI Folder";
            msiTB.TextChanged += MsiTB_TextChanged;
            msiTB.Validating += MsiTB_Validating;
            // 
            // msiPB
            // 
            msiPB.Cursor = Cursors.Hand;
            msiPB.Image = Properties.Resources.software_gradient_35;
            msiPB.Location = new Point(12, 221);
            msiPB.Name = "msiPB";
            msiPB.Size = new Size(35, 35);
            msiPB.SizeMode = PictureBoxSizeMode.CenterImage;
            msiPB.TabIndex = 1;
            msiPB.TabStop = false;
            msiPB.Click += MsiPB_Click;
            // 
            // msiPN
            // 
            msiPN.BackColor = Color.FromArgb(186, 40, 255);
            msiPN.Location = new Point(12, 256);
            msiPN.Name = "msiPN";
            msiPN.Size = new Size(276, 3);
            msiPN.TabIndex = 0;
            // 
            // infoLB
            // 
            infoLB.FlatStyle = FlatStyle.Flat;
            infoLB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            infoLB.ForeColor = Color.FromArgb(186, 40, 255);
            infoLB.Location = new Point(3, 167);
            infoLB.Name = "infoLB";
            infoLB.Size = new Size(300, 29);
            infoLB.TabIndex = 2;
            infoLB.Text = "Run New Hire Installer";
            infoLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoPB
            // 
            logoPB.Image = (Image)resources.GetObject("logoPB.Image");
            logoPB.Location = new Point(86, 36);
            logoPB.Name = "logoPB";
            logoPB.Size = new Size(128, 128);
            logoPB.SizeMode = PictureBoxSizeMode.CenterImage;
            logoPB.TabIndex = 0;
            logoPB.TabStop = false;
            // 
            // loadingPB
            // 
            loadingPB.Cursor = Cursors.Hand;
            loadingPB.Image = (Image)resources.GetObject("loadingPB.Image");
            loadingPB.Location = new Point(86, 36);
            loadingPB.Name = "loadingPB";
            loadingPB.Size = new Size(128, 128);
            loadingPB.SizeMode = PictureBoxSizeMode.CenterImage;
            loadingPB.TabIndex = 1;
            loadingPB.TabStop = false;
            // 
            // titleBarPN
            // 
            titleBarPN.Controls.Add(buttonsPN);
            titleBarPN.Dock = DockStyle.Top;
            titleBarPN.Location = new Point(0, 0);
            titleBarPN.Name = "titleBarPN";
            titleBarPN.Size = new Size(300, 35);
            titleBarPN.TabIndex = 0;
            titleBarPN.MouseDown += TitleBarPN_MouseDown;
            // 
            // buttonsPN
            // 
            buttonsPN.Controls.Add(minimizeBT);
            buttonsPN.Controls.Add(closeBT);
            buttonsPN.Dock = DockStyle.Right;
            buttonsPN.Location = new Point(225, 0);
            buttonsPN.Name = "buttonsPN";
            buttonsPN.Size = new Size(75, 35);
            buttonsPN.TabIndex = 0;
            // 
            // minimizeBT
            // 
            minimizeBT.BackColor = Color.Transparent;
            minimizeBT.FlatAppearance.BorderSize = 0;
            minimizeBT.FlatAppearance.MouseDownBackColor = Color.Transparent;
            minimizeBT.FlatAppearance.MouseOverBackColor = Color.Transparent;
            minimizeBT.FlatStyle = FlatStyle.Flat;
            minimizeBT.Image = (Image)resources.GetObject("minimizeBT.Image");
            minimizeBT.Location = new Point(3, 1);
            minimizeBT.Name = "minimizeBT";
            minimizeBT.Size = new Size(32, 32);
            minimizeBT.TabIndex = 3;
            minimizeBT.UseVisualStyleBackColor = false;
            minimizeBT.Click += MinimizeBT_Click;
            // 
            // closeBT
            // 
            closeBT.BackColor = Color.Transparent;
            closeBT.FlatAppearance.BorderSize = 0;
            closeBT.FlatAppearance.MouseDownBackColor = Color.Transparent;
            closeBT.FlatAppearance.MouseOverBackColor = Color.Transparent;
            closeBT.FlatStyle = FlatStyle.Flat;
            closeBT.Image = (Image)resources.GetObject("closeBT.Image");
            closeBT.Location = new Point(40, 1);
            closeBT.Name = "closeBT";
            closeBT.Size = new Size(32, 32);
            closeBT.TabIndex = 3;
            closeBT.UseVisualStyleBackColor = true;
            closeBT.Click += CloseBT_Click;
            // 
            // headerPN
            // 
            headerPN.Controls.Add(infoLB);
            headerPN.Controls.Add(logoPB);
            headerPN.Controls.Add(loadingPB);
            headerPN.Dock = DockStyle.Top;
            headerPN.Location = new Point(0, 35);
            headerPN.Name = "headerPN";
            headerPN.Size = new Size(300, 200);
            headerPN.TabIndex = 3;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            errorProvider.Icon = (Icon)resources.GetObject("errorProvider.Icon");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(300, 462);
            Controls.Add(headerPN);
            Controls.Add(bodyPN);
            Controls.Add(titleBarPN);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            bodyPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)folderPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)msiPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)loadingPB).EndInit();
            titleBarPN.ResumeLayout(false);
            buttonsPN.ResumeLayout(false);
            headerPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel bodyPN;
        private Panel titleBarPN;
        private Panel buttonsPN;
        private PictureBox logoPB;
        private PictureBox loadingPB;
        private Label infoLB;
        private Panel headerPN;
        private Button submitBT;
        private Custom_Controls.CloseButton closeBT;
        private Custom_Controls.MinimizeButton minimizeBT;
        public static ErrorProvider errorProvider;
        protected static Panel msiPN;
        protected static PictureBox msiPB;
        protected static PictureBox folderPB;
        protected static Panel folderPN;
        protected static Custom_Controls.CustomTextBox msiTB;
        protected static Custom_Controls.CustomTextBox folderTB;
    }
}