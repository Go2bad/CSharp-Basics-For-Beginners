namespace _8_StackAndQueue_Ex_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.result = new System.Windows.Forms.Label();
            this.nextLumberjack = new System.Windows.Forms.Button();
            this.bananaButton = new System.Windows.Forms.RadioButton();
            this.brownedButton = new System.Windows.Forms.RadioButton();
            this.soggyButton = new System.Windows.Forms.RadioButton();
            this.crispyButton = new System.Windows.Forms.RadioButton();
            this.addFlapjacks = new System.Windows.Forms.Button();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.line = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addLumberjack = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.result);
            this.groupBox1.Controls.Add(this.nextLumberjack);
            this.groupBox1.Controls.Add(this.bananaButton);
            this.groupBox1.Controls.Add(this.brownedButton);
            this.groupBox1.Controls.Add(this.soggyButton);
            this.groupBox1.Controls.Add(this.crispyButton);
            this.groupBox1.Controls.Add(this.addFlapjacks);
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Location = new System.Drawing.Point(126, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 271);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a Lumberjack";
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.Location = new System.Drawing.Point(7, 167);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(122, 70);
            this.result.TabIndex = 7;
            // 
            // nextLumberjack
            // 
            this.nextLumberjack.Location = new System.Drawing.Point(6, 240);
            this.nextLumberjack.Name = "nextLumberjack";
            this.nextLumberjack.Size = new System.Drawing.Size(123, 23);
            this.nextLumberjack.TabIndex = 6;
            this.nextLumberjack.Text = "Next lumberjack";
            this.nextLumberjack.UseVisualStyleBackColor = true;
            this.nextLumberjack.Click += new System.EventHandler(this.nextLumberjack_Click);
            // 
            // bananaButton
            // 
            this.bananaButton.AutoSize = true;
            this.bananaButton.Location = new System.Drawing.Point(6, 114);
            this.bananaButton.Name = "bananaButton";
            this.bananaButton.Size = new System.Drawing.Size(62, 17);
            this.bananaButton.TabIndex = 5;
            this.bananaButton.TabStop = true;
            this.bananaButton.Text = "Banana";
            this.bananaButton.UseVisualStyleBackColor = true;
            // 
            // brownedButton
            // 
            this.brownedButton.AutoSize = true;
            this.brownedButton.Location = new System.Drawing.Point(6, 91);
            this.brownedButton.Name = "brownedButton";
            this.brownedButton.Size = new System.Drawing.Size(67, 17);
            this.brownedButton.TabIndex = 4;
            this.brownedButton.TabStop = true;
            this.brownedButton.Text = "Browned";
            this.brownedButton.UseVisualStyleBackColor = true;
            // 
            // soggyButton
            // 
            this.soggyButton.AutoSize = true;
            this.soggyButton.Location = new System.Drawing.Point(6, 68);
            this.soggyButton.Name = "soggyButton";
            this.soggyButton.Size = new System.Drawing.Size(55, 17);
            this.soggyButton.TabIndex = 3;
            this.soggyButton.TabStop = true;
            this.soggyButton.Text = "Soggy";
            this.soggyButton.UseVisualStyleBackColor = true;
            // 
            // crispyButton
            // 
            this.crispyButton.AutoSize = true;
            this.crispyButton.Checked = true;
            this.crispyButton.Location = new System.Drawing.Point(6, 45);
            this.crispyButton.Name = "crispyButton";
            this.crispyButton.Size = new System.Drawing.Size(53, 17);
            this.crispyButton.TabIndex = 2;
            this.crispyButton.TabStop = true;
            this.crispyButton.Text = "Crispy";
            this.crispyButton.UseVisualStyleBackColor = true;
            // 
            // addFlapjacks
            // 
            this.addFlapjacks.Location = new System.Drawing.Point(6, 137);
            this.addFlapjacks.Name = "addFlapjacks";
            this.addFlapjacks.Size = new System.Drawing.Size(123, 23);
            this.addFlapjacks.TabIndex = 1;
            this.addFlapjacks.Text = "Add flapjacks";
            this.addFlapjacks.UseVisualStyleBackColor = true;
            this.addFlapjacks.Click += new System.EventHandler(this.addFlapjacks_Click);
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(6, 19);
            this.howMany.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(61, 20);
            this.howMany.TabIndex = 0;
            this.howMany.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.Location = new System.Drawing.Point(15, 87);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(105, 264);
            this.line.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Breakfast line";
            // 
            // addLumberjack
            // 
            this.addLumberjack.Location = new System.Drawing.Point(15, 32);
            this.addLumberjack.Name = "addLumberjack";
            this.addLumberjack.Size = new System.Drawing.Size(208, 23);
            this.addLumberjack.TabIndex = 8;
            this.addLumberjack.Text = "Add lumberjack";
            this.addLumberjack.UseVisualStyleBackColor = true;
            this.addLumberjack.Click += new System.EventHandler(this.addLumberjack_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(109, 6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(114, 20);
            this.name.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lumberjack name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addLumberjack);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button nextLumberjack;
        private System.Windows.Forms.RadioButton bananaButton;
        private System.Windows.Forms.RadioButton brownedButton;
        private System.Windows.Forms.RadioButton soggyButton;
        private System.Windows.Forms.RadioButton crispyButton;
        private System.Windows.Forms.Button addFlapjacks;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addLumberjack;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
    }
}

