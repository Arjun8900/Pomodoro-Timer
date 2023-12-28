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
            display.BackColor = Color.FromArgb(192, 192, 0);
            display.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            display.Location = new Point(12, 9);
            display.Name = "display";
            display.Size = new Size(96, 24);
            display.TabIndex = 0;
            display.Text = "25 Min";
            display.TextAlign = ContentAlignment.TopCenter;
            display.Click += display_Click;
            // 
            // button
            // 
            button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button.Location = new Point(23, 45);
            button.Name = "button";
            button.Size = new Size(68, 27);
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
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(120, 74);
            Controls.Add(button);
            Controls.Add(display);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Pomodoro";
            ResumeLayout(false);
        }

        #endregion

        private Label display;
        private Button button;
        private System.Windows.Forms.Timer timer;
    }
}
