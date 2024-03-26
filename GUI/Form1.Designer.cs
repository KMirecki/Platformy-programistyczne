namespace GUI
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
            button1 = new Button();
            textBox_items = new TextBox();
            textBox_seed = new TextBox();
            textBox_capacity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_results = new TextBox();
            textBox_instance = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(31, 215);
            button1.Name = "button1";
            button1.Size = new Size(128, 34);
            button1.TabIndex = 0;
            button1.Text = "solve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_items
            // 
            textBox_items.Location = new Point(31, 31);
            textBox_items.Name = "textBox_items";
            textBox_items.Size = new Size(150, 31);
            textBox_items.TabIndex = 1;
            // 
            // textBox_seed
            // 
            textBox_seed.Location = new Point(31, 95);
            textBox_seed.Name = "textBox_seed";
            textBox_seed.Size = new Size(150, 31);
            textBox_seed.TabIndex = 2;
            // 
            // textBox_capacity
            // 
            textBox_capacity.Location = new Point(31, 155);
            textBox_capacity.Name = "textBox_capacity";
            textBox_capacity.Size = new Size(150, 31);
            textBox_capacity.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 3);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 4;
            label1.Text = "number of items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 67);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 5;
            label2.Text = "seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 129);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 6;
            label3.Text = "capacity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(678, 3);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 10;
            label4.Text = "instance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 266);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 11;
            label5.Text = "results";
            // 
            // textBox_results
            // 
            textBox_results.Location = new Point(31, 294);
            textBox_results.Multiline = true;
            textBox_results.Name = "textBox_results";
            textBox_results.ReadOnly = true;
            textBox_results.Size = new Size(282, 194);
            textBox_results.TabIndex = 12;
            // 
            // textBox_instance
            // 
            textBox_instance.Location = new Point(409, 31);
            textBox_instance.Multiline = true;
            textBox_instance.Name = "textBox_instance";
            textBox_instance.ReadOnly = true;
            textBox_instance.ScrollBars = ScrollBars.Vertical;
            textBox_instance.Size = new Size(345, 457);
            textBox_instance.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(185, 215);
            button2.Name = "button2";
            button2.Size = new Size(128, 34);
            button2.TabIndex = 14;
            button2.Text = "solve2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 517);
            Controls.Add(button2);
            Controls.Add(textBox_instance);
            Controls.Add(textBox_results);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_capacity);
            Controls.Add(textBox_seed);
            Controls.Add(textBox_items);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox_items;
        private TextBox textBox_seed;
        private TextBox textBox_capacity;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_results;
        private TextBox textBox_instance;
        private Button button2;
    }
}
