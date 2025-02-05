
namespace DnDSpellbook
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
            AOEtxt = new System.Windows.Forms.TextBox();
            SpellRangetxt = new System.Windows.Forms.TextBox();
            SpellLeveltxt = new System.Windows.Forms.TextBox();
            Componentstxt = new System.Windows.Forms.TextBox();
            Spelllst = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            NameSearchcbo = new System.Windows.Forms.TextBox();
            SchoolSearchcbo = new System.Windows.Forms.ComboBox();
            ClassSearchcbo = new System.Windows.Forms.ComboBox();
            LevelSearchcbo = new System.Windows.Forms.ComboBox();
            SpellNametxt = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            SpellSavetxt = new System.Windows.Forms.TextBox();
            SpellCastTimetxt = new System.Windows.Forms.TextBox();
            SpellDurationtxt = new System.Windows.Forms.TextBox();
            Descriptiontxt = new System.Windows.Forms.TextBox();
            Class = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            Classtxt = new System.Windows.Forms.TextBox();
            Schooltxt = new System.Windows.Forms.TextBox();
            Booktxt = new System.Windows.Forms.TextBox();
            btnUpdate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // AOEtxt
            // 
            AOEtxt.Location = new System.Drawing.Point(518, 204);
            AOEtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            AOEtxt.Name = "AOEtxt";
            AOEtxt.Size = new System.Drawing.Size(110, 23);
            AOEtxt.TabIndex = 0;
            // 
            // SpellRangetxt
            // 
            SpellRangetxt.Location = new System.Drawing.Point(368, 276);
            SpellRangetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            SpellRangetxt.Name = "SpellRangetxt";
            SpellRangetxt.Size = new System.Drawing.Size(110, 23);
            SpellRangetxt.TabIndex = 1;
            // 
            // SpellLeveltxt
            // 
            SpellLeveltxt.Location = new System.Drawing.Point(368, 152);
            SpellLeveltxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            SpellLeveltxt.Name = "SpellLeveltxt";
            SpellLeveltxt.Size = new System.Drawing.Size(110, 23);
            SpellLeveltxt.TabIndex = 2;
            // 
            // Componentstxt
            // 
            Componentstxt.Location = new System.Drawing.Point(518, 152);
            Componentstxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Componentstxt.Name = "Componentstxt";
            Componentstxt.Size = new System.Drawing.Size(110, 23);
            Componentstxt.TabIndex = 3;
            // 
            // Spelllst
            // 
            Spelllst.FormattingEnabled = true;
            Spelllst.ItemHeight = 15;
            Spelllst.Location = new System.Drawing.Point(49, 85);
            Spelllst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Spelllst.Name = "Spelllst";
            Spelllst.Size = new System.Drawing.Size(266, 649);
            Spelllst.TabIndex = 4;
            Spelllst.SelectedIndexChanged += Spelllst_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(520, 135);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 15);
            label1.TabIndex = 5;
            label1.Text = "Components";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(368, 135);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 15);
            label2.TabIndex = 6;
            label2.Text = "Level";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(368, 255);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Range";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(518, 187);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 15);
            label4.TabIndex = 8;
            label4.Text = "Area of Effect (AoE)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(49, 7);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 15);
            label5.TabIndex = 9;
            label5.Text = "Spell Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(198, 7);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(43, 15);
            label6.TabIndex = 10;
            label6.Text = "School";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(368, 7);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(34, 15);
            label7.TabIndex = 11;
            label7.Text = "Class";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(532, 7);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(34, 15);
            label8.TabIndex = 12;
            label8.Text = "Level";
            // 
            // NameSearchcbo
            // 
            NameSearchcbo.Location = new System.Drawing.Point(49, 24);
            NameSearchcbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            NameSearchcbo.Name = "NameSearchcbo";
            NameSearchcbo.Size = new System.Drawing.Size(110, 23);
            NameSearchcbo.TabIndex = 13;
            NameSearchcbo.TextChanged += Search;
            // 
            // SchoolSearchcbo
            // 
            SchoolSearchcbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SchoolSearchcbo.FormattingEnabled = true;
            SchoolSearchcbo.Location = new System.Drawing.Point(198, 24);
            SchoolSearchcbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            SchoolSearchcbo.Name = "SchoolSearchcbo";
            SchoolSearchcbo.Size = new System.Drawing.Size(133, 23);
            SchoolSearchcbo.TabIndex = 14;
            SchoolSearchcbo.SelectedValueChanged += Search;
            // 
            // ClassSearchcbo
            // 
            ClassSearchcbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ClassSearchcbo.FormattingEnabled = true;
            ClassSearchcbo.Location = new System.Drawing.Point(368, 24);
            ClassSearchcbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ClassSearchcbo.Name = "ClassSearchcbo";
            ClassSearchcbo.Size = new System.Drawing.Size(133, 23);
            ClassSearchcbo.TabIndex = 15;
            ClassSearchcbo.SelectedValueChanged += Search;
            // 
            // LevelSearchcbo
            // 
            LevelSearchcbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LevelSearchcbo.FormattingEnabled = true;
            LevelSearchcbo.Location = new System.Drawing.Point(532, 24);
            LevelSearchcbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            LevelSearchcbo.Name = "LevelSearchcbo";
            LevelSearchcbo.Size = new System.Drawing.Size(64, 23);
            LevelSearchcbo.TabIndex = 16;
            LevelSearchcbo.SelectedValueChanged += Search;
            // 
            // SpellNametxt
            // 
            SpellNametxt.Location = new System.Drawing.Point(368, 99);
            SpellNametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            SpellNametxt.Name = "SpellNametxt";
            SpellNametxt.Size = new System.Drawing.Size(199, 23);
            SpellNametxt.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(368, 82);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(67, 15);
            label9.TabIndex = 18;
            label9.Text = "Spell Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(368, 301);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(31, 15);
            label10.TabIndex = 19;
            label10.Text = "Save";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(518, 238);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(76, 15);
            label11.TabIndex = 20;
            label11.Text = "Casting Time";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(368, 364);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(53, 15);
            label12.TabIndex = 21;
            label12.Text = "Duration";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(368, 439);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(67, 15);
            label13.TabIndex = 22;
            label13.Text = "Description";
            // 
            // SpellSavetxt
            // 
            SpellSavetxt.Location = new System.Drawing.Point(368, 318);
            SpellSavetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            SpellSavetxt.Name = "SpellSavetxt";
            SpellSavetxt.Size = new System.Drawing.Size(110, 23);
            SpellSavetxt.TabIndex = 23;
            // 
            // SpellCastTimetxt
            // 
            SpellCastTimetxt.Location = new System.Drawing.Point(518, 255);
            SpellCastTimetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            SpellCastTimetxt.Name = "SpellCastTimetxt";
            SpellCastTimetxt.Size = new System.Drawing.Size(110, 23);
            SpellCastTimetxt.TabIndex = 24;
            // 
            // SpellDurationtxt
            // 
            SpellDurationtxt.Location = new System.Drawing.Point(368, 381);
            SpellDurationtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            SpellDurationtxt.Name = "SpellDurationtxt";
            SpellDurationtxt.Size = new System.Drawing.Size(110, 23);
            SpellDurationtxt.TabIndex = 25;
            // 
            // Descriptiontxt
            // 
            Descriptiontxt.Location = new System.Drawing.Point(368, 456);
            Descriptiontxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Descriptiontxt.Multiline = true;
            Descriptiontxt.Name = "Descriptiontxt";
            Descriptiontxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            Descriptiontxt.Size = new System.Drawing.Size(340, 283);
            Descriptiontxt.TabIndex = 27;
            // 
            // Class
            // 
            Class.AutoSize = true;
            Class.Location = new System.Drawing.Point(520, 301);
            Class.Name = "Class";
            Class.Size = new System.Drawing.Size(34, 15);
            Class.TabIndex = 28;
            Class.Text = "Class";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(368, 187);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(43, 15);
            label15.TabIndex = 29;
            label15.Text = "School";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(520, 364);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(34, 15);
            label16.TabIndex = 30;
            label16.Text = "Book";
            // 
            // Classtxt
            // 
            Classtxt.Location = new System.Drawing.Point(518, 318);
            Classtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Classtxt.Name = "Classtxt";
            Classtxt.Size = new System.Drawing.Size(110, 23);
            Classtxt.TabIndex = 31;
            // 
            // Schooltxt
            // 
            Schooltxt.Location = new System.Drawing.Point(368, 204);
            Schooltxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Schooltxt.Multiline = true;
            Schooltxt.Name = "Schooltxt";
            Schooltxt.Size = new System.Drawing.Size(110, 47);
            Schooltxt.TabIndex = 32;
            // 
            // Booktxt
            // 
            Booktxt.Location = new System.Drawing.Point(518, 381);
            Booktxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Booktxt.Multiline = true;
            Booktxt.Name = "Booktxt";
            Booktxt.Size = new System.Drawing.Size(110, 57);
            Booktxt.TabIndex = 33;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(653, 99);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 23);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(740, 777);
            Controls.Add(btnUpdate);
            Controls.Add(Booktxt);
            Controls.Add(Schooltxt);
            Controls.Add(Classtxt);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(Class);
            Controls.Add(Descriptiontxt);
            Controls.Add(SpellDurationtxt);
            Controls.Add(SpellCastTimetxt);
            Controls.Add(SpellSavetxt);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(SpellNametxt);
            Controls.Add(LevelSearchcbo);
            Controls.Add(ClassSearchcbo);
            Controls.Add(SchoolSearchcbo);
            Controls.Add(NameSearchcbo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Spelllst);
            Controls.Add(Componentstxt);
            Controls.Add(SpellLeveltxt);
            Controls.Add(SpellRangetxt);
            Controls.Add(AOEtxt);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Dungeons and Dragons Spellbook";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox AOEtxt;
        private System.Windows.Forms.TextBox SpellRangetxt;
        private System.Windows.Forms.TextBox SpellLeveltxt;
        private System.Windows.Forms.TextBox Componentstxt;
        private System.Windows.Forms.ListBox Spelllst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameSearchcbo;
        private System.Windows.Forms.ComboBox SchoolSearchcbo;
        private System.Windows.Forms.ComboBox ClassSearchcbo;
        private System.Windows.Forms.ComboBox LevelSearchcbo;
        private System.Windows.Forms.TextBox SpellNametxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SpellSavetxt;
        private System.Windows.Forms.TextBox SpellCastTimetxt;
        private System.Windows.Forms.TextBox SpellDurationtxt;
        private System.Windows.Forms.TextBox Descriptiontxt;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Classtxt;
        private System.Windows.Forms.TextBox Schooltxt;
        private System.Windows.Forms.TextBox Booktxt;
        private System.Windows.Forms.Button btnUpdate;
    }
}

