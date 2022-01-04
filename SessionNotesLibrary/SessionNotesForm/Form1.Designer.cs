namespace SessionNotesForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Sessions = new System.Windows.Forms.TabPage();
            this.Stimulation = new System.Windows.Forms.TabPage();
            this.Neurofeedback = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.Summary = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.ElectricCurrentStimulation = new System.Windows.Forms.TabPage();
            this.ElectromagneticFieldStimulation = new System.Windows.Forms.TabPage();
            this.SNeurofeedback = new System.Windows.Forms.TabPage();
            this.SNotes = new System.Windows.Forms.TabPage();
            this.SessionNotes = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Sessions.SuspendLayout();
            this.Stimulation.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.ElectricCurrentStimulation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(602, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Load Last Session";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Session #";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(440, 14);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Sessions);
            this.tabControl1.Controls.Add(this.SessionNotes);
            this.tabControl1.Controls.Add(this.Stimulation);
            this.tabControl1.Controls.Add(this.Neurofeedback);
            this.tabControl1.Controls.Add(this.Summary);
            this.tabControl1.Location = new System.Drawing.Point(15, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 568);
            this.tabControl1.TabIndex = 12;
            // 
            // Sessions
            // 
            this.Sessions.Controls.Add(this.listBox1);
            this.Sessions.Location = new System.Drawing.Point(4, 22);
            this.Sessions.Name = "Sessions";
            this.Sessions.Padding = new System.Windows.Forms.Padding(3);
            this.Sessions.Size = new System.Drawing.Size(864, 542);
            this.Sessions.TabIndex = 0;
            this.Sessions.Text = "Sessions";
            this.Sessions.UseVisualStyleBackColor = true;
            // 
            // Stimulation
            // 
            this.Stimulation.Controls.Add(this.tabControl2);
            this.Stimulation.Location = new System.Drawing.Point(4, 22);
            this.Stimulation.Name = "Stimulation";
            this.Stimulation.Padding = new System.Windows.Forms.Padding(3);
            this.Stimulation.Size = new System.Drawing.Size(864, 542);
            this.Stimulation.TabIndex = 1;
            this.Stimulation.Text = "Stimulation";
            this.Stimulation.UseVisualStyleBackColor = true;
            // 
            // Neurofeedback
            // 
            this.Neurofeedback.Location = new System.Drawing.Point(4, 22);
            this.Neurofeedback.Name = "Neurofeedback";
            this.Neurofeedback.Padding = new System.Windows.Forms.Padding(3);
            this.Neurofeedback.Size = new System.Drawing.Size(864, 542);
            this.Neurofeedback.TabIndex = 2;
            this.Neurofeedback.Text = "Neurofeedback";
            this.Neurofeedback.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(808, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Use Today\'s Date";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Summary
            // 
            this.Summary.Location = new System.Drawing.Point(4, 22);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(864, 542);
            this.Summary.TabIndex = 3;
            this.Summary.Text = "Summary";
            this.Summary.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.ElectricCurrentStimulation);
            this.tabControl2.Controls.Add(this.ElectromagneticFieldStimulation);
            this.tabControl2.Controls.Add(this.SNeurofeedback);
            this.tabControl2.Controls.Add(this.SNotes);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(852, 533);
            this.tabControl2.TabIndex = 0;
            // 
            // ElectricCurrentStimulation
            // 
            this.ElectricCurrentStimulation.Controls.Add(this.groupBox1);
            this.ElectricCurrentStimulation.Location = new System.Drawing.Point(4, 22);
            this.ElectricCurrentStimulation.Name = "ElectricCurrentStimulation";
            this.ElectricCurrentStimulation.Padding = new System.Windows.Forms.Padding(3);
            this.ElectricCurrentStimulation.Size = new System.Drawing.Size(844, 507);
            this.ElectricCurrentStimulation.TabIndex = 0;
            this.ElectricCurrentStimulation.Text = "Electric Current Stimulation";
            this.ElectricCurrentStimulation.UseVisualStyleBackColor = true;
            // 
            // ElectromagneticFieldStimulation
            // 
            this.ElectromagneticFieldStimulation.Location = new System.Drawing.Point(4, 22);
            this.ElectromagneticFieldStimulation.Name = "ElectromagneticFieldStimulation";
            this.ElectromagneticFieldStimulation.Padding = new System.Windows.Forms.Padding(3);
            this.ElectromagneticFieldStimulation.Size = new System.Drawing.Size(844, 507);
            this.ElectromagneticFieldStimulation.TabIndex = 1;
            this.ElectromagneticFieldStimulation.Text = "Electromagnetic Field Stimulation";
            this.ElectromagneticFieldStimulation.UseVisualStyleBackColor = true;
            // 
            // SNeurofeedback
            // 
            this.SNeurofeedback.Location = new System.Drawing.Point(4, 22);
            this.SNeurofeedback.Name = "SNeurofeedback";
            this.SNeurofeedback.Size = new System.Drawing.Size(844, 507);
            this.SNeurofeedback.TabIndex = 2;
            this.SNeurofeedback.Text = "Neurofeedback";
            this.SNeurofeedback.UseVisualStyleBackColor = true;
            // 
            // SNotes
            // 
            this.SNotes.Location = new System.Drawing.Point(4, 22);
            this.SNotes.Name = "SNotes";
            this.SNotes.Size = new System.Drawing.Size(844, 507);
            this.SNotes.TabIndex = 3;
            this.SNotes.Text = "Notes";
            this.SNotes.UseVisualStyleBackColor = true;
            // 
            // SessionNotes
            // 
            this.SessionNotes.Location = new System.Drawing.Point(4, 22);
            this.SessionNotes.Name = "SessionNotes";
            this.SessionNotes.Size = new System.Drawing.Size(864, 542);
            this.SessionNotes.TabIndex = 4;
            this.SessionNotes.Text = "Session Notes";
            this.SessionNotes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primary Current Channel";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(852, 472);
            this.listBox1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 40);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 821);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Session Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Sessions.ResumeLayout(false);
            this.Stimulation.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ElectricCurrentStimulation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Sessions;
        private System.Windows.Forms.TabPage Stimulation;
        private System.Windows.Forms.TabPage Neurofeedback;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage Summary;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage SessionNotes;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage ElectricCurrentStimulation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage ElectromagneticFieldStimulation;
        private System.Windows.Forms.TabPage SNeurofeedback;
        private System.Windows.Forms.TabPage SNotes;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

