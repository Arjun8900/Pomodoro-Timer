namespace Pomodoro_Timer
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
            display = new Label();
            button = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // display
            // 
            display.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            display.BackColor = Color.Transparent;
            display.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            display.ForeColor = SystemColors.AppWorkspace;
            display.Location = new Point(-5, 5);
            display.Margin = new Padding(4, 0, 4, 0);
            display.Name = "display";
            display.Size = new Size(90, 27);
            display.TabIndex = 0;
            display.Text = "25 Min";
            display.TextAlign = ContentAlignment.TopCenter;
            display.Click += display_Click;
            // 
            // button
            // 
            button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button.Location = new Point(12, 35);
            button.Margin = new Padding(4, 3, 4, 3);
            button.Name = "button";
            button.Size = new Size(62, 23);
            button.TabIndex = 1;
            button.Text = "Start";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(86, 61);
            Controls.Add(button);
            Controls.Add(display);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Pomodoro";
            ResumeLayout(false);
        }

        #endregion

        private Label display;
        private Button button;
        private System.Windows.Forms.Timer timer;
    }
}
