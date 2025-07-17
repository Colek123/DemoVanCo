namespace Demo_VanCoFPT
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
            buttonDemo = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkedListBox2 = new CheckedListBox();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            radioButton1 = new RadioButton();
            listView1 = new ListView();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // buttonDemo
            // 
            buttonDemo.Location = new Point(39, 57);
            buttonDemo.Name = "buttonDemo";
            buttonDemo.Size = new Size(132, 23);
            buttonDemo.TabIndex = 0;
            buttonDemo.Text = "button demo\r\n";
            buttonDemo.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(315, 229);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(586, 185);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(82, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(632, 70);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(120, 94);
            checkedListBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(138, 155);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(392, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(353, 178);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 97);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(230, 49);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(monthCalendar1);
            Controls.Add(listView1);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(checkedListBox2);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(buttonDemo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDemo;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckedListBox checkedListBox2;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton radioButton1;
        private ListView listView1;
        private MonthCalendar monthCalendar1;
    }
}
