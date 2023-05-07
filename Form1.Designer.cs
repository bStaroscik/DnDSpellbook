
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
            this.AOEtxt = new System.Windows.Forms.TextBox();
            this.SpellRangetxt = new System.Windows.Forms.TextBox();
            this.SpellLeveltxt = new System.Windows.Forms.TextBox();
            this.Componentstxt = new System.Windows.Forms.TextBox();
            this.Spelllst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NameSearchcbo = new System.Windows.Forms.TextBox();
            this.SchoolSearchcbo = new System.Windows.Forms.ComboBox();
            this.ClassSearchcbo = new System.Windows.Forms.ComboBox();
            this.LevelSearchcbo = new System.Windows.Forms.ComboBox();
            this.SpellNametxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SpellSavetxt = new System.Windows.Forms.TextBox();
            this.SpellCastTimetxt = new System.Windows.Forms.TextBox();
            this.SpellDurationtxt = new System.Windows.Forms.TextBox();
            this.Descriptiontxt = new System.Windows.Forms.TextBox();
            this.Class = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Classtxt = new System.Windows.Forms.TextBox();
            this.Schooltxt = new System.Windows.Forms.TextBox();
            this.Booktxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AOEtxt
            // 
            this.AOEtxt.Location = new System.Drawing.Point(608, 207);
            this.AOEtxt.Name = "AOEtxt";
            this.AOEtxt.Size = new System.Drawing.Size(125, 27);
            this.AOEtxt.TabIndex = 0;
            // 
            // SpellRangetxt
            // 
            this.SpellRangetxt.Location = new System.Drawing.Point(437, 207);
            this.SpellRangetxt.Name = "SpellRangetxt";
            this.SpellRangetxt.Size = new System.Drawing.Size(125, 27);
            this.SpellRangetxt.TabIndex = 1;
            // 
            // SpellLeveltxt
            // 
            this.SpellLeveltxt.Location = new System.Drawing.Point(437, 154);
            this.SpellLeveltxt.Name = "SpellLeveltxt";
            this.SpellLeveltxt.Size = new System.Drawing.Size(125, 27);
            this.SpellLeveltxt.TabIndex = 2;
            // 
            // Componentstxt
            // 
            this.Componentstxt.Location = new System.Drawing.Point(608, 154);
            this.Componentstxt.Name = "Componentstxt";
            this.Componentstxt.Size = new System.Drawing.Size(125, 27);
            this.Componentstxt.TabIndex = 3;
            // 
            // Spelllst
            // 
            this.Spelllst.FormattingEnabled = true;
            this.Spelllst.ItemHeight = 20;
            this.Spelllst.Location = new System.Drawing.Point(56, 66);
            this.Spelllst.Name = "Spelllst";
            this.Spelllst.Size = new System.Drawing.Size(303, 404);
            this.Spelllst.TabIndex = 4;
            this.Spelllst.SelectedIndexChanged += new System.EventHandler(this.Spelllst_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Components";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Range";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Area of Effect (AoE)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Spell Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "School";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Class";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(608, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Level";
            // 
            // NameSearchcbo
            // 
            this.NameSearchcbo.Location = new System.Drawing.Point(56, 32);
            this.NameSearchcbo.Name = "NameSearchcbo";
            this.NameSearchcbo.Size = new System.Drawing.Size(125, 27);
            this.NameSearchcbo.TabIndex = 13;
            this.NameSearchcbo.TextChanged += new System.EventHandler(this.Search);
            // 
            // SchoolSearchcbo
            // 
            this.SchoolSearchcbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SchoolSearchcbo.FormattingEnabled = true;
            this.SchoolSearchcbo.Location = new System.Drawing.Point(226, 32);
            this.SchoolSearchcbo.Name = "SchoolSearchcbo";
            this.SchoolSearchcbo.Size = new System.Drawing.Size(151, 28);
            this.SchoolSearchcbo.TabIndex = 14;
            this.SchoolSearchcbo.SelectedValueChanged += new System.EventHandler(this.Search);
            // 
            // ClassSearchcbo
            // 
            this.ClassSearchcbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassSearchcbo.FormattingEnabled = true;
            this.ClassSearchcbo.Location = new System.Drawing.Point(420, 32);
            this.ClassSearchcbo.Name = "ClassSearchcbo";
            this.ClassSearchcbo.Size = new System.Drawing.Size(151, 28);
            this.ClassSearchcbo.TabIndex = 15;
            this.ClassSearchcbo.SelectedValueChanged += new System.EventHandler(this.Search);
            // 
            // LevelSearchcbo
            // 
            this.LevelSearchcbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelSearchcbo.FormattingEnabled = true;
            this.LevelSearchcbo.Location = new System.Drawing.Point(608, 32);
            this.LevelSearchcbo.Name = "LevelSearchcbo";
            this.LevelSearchcbo.Size = new System.Drawing.Size(72, 28);
            this.LevelSearchcbo.TabIndex = 16;
            this.LevelSearchcbo.SelectedValueChanged += new System.EventHandler(this.Search);
            // 
            // SpellNametxt
            // 
            this.SpellNametxt.Location = new System.Drawing.Point(476, 89);
            this.SpellNametxt.Name = "SpellNametxt";
            this.SpellNametxt.Size = new System.Drawing.Size(227, 27);
            this.SpellNametxt.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Spell Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Save";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(606, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Casting Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Duration";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(437, 396);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Description";
            // 
            // SpellSavetxt
            // 
            this.SpellSavetxt.Location = new System.Drawing.Point(437, 260);
            this.SpellSavetxt.Name = "SpellSavetxt";
            this.SpellSavetxt.Size = new System.Drawing.Size(125, 27);
            this.SpellSavetxt.TabIndex = 23;
            // 
            // SpellCastTimetxt
            // 
            this.SpellCastTimetxt.Location = new System.Drawing.Point(608, 260);
            this.SpellCastTimetxt.Name = "SpellCastTimetxt";
            this.SpellCastTimetxt.Size = new System.Drawing.Size(125, 27);
            this.SpellCastTimetxt.TabIndex = 24;
            // 
            // SpellDurationtxt
            // 
            this.SpellDurationtxt.Location = new System.Drawing.Point(437, 313);
            this.SpellDurationtxt.Name = "SpellDurationtxt";
            this.SpellDurationtxt.Size = new System.Drawing.Size(125, 27);
            this.SpellDurationtxt.TabIndex = 25;
            // 
            // Descriptiontxt
            // 
            this.Descriptiontxt.Location = new System.Drawing.Point(432, 419);
            this.Descriptiontxt.Multiline = true;
            this.Descriptiontxt.Name = "Descriptiontxt";
            this.Descriptiontxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Descriptiontxt.Size = new System.Drawing.Size(303, 196);
            this.Descriptiontxt.TabIndex = 27;
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Location = new System.Drawing.Point(608, 290);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(42, 20);
            this.Class.TabIndex = 28;
            this.Class.Text = "Class";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(437, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "School";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(608, 343);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Book";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // Classtxt
            // 
            this.Classtxt.Location = new System.Drawing.Point(608, 313);
            this.Classtxt.Name = "Classtxt";
            this.Classtxt.Size = new System.Drawing.Size(125, 27);
            this.Classtxt.TabIndex = 31;
            // 
            // Schooltxt
            // 
            this.Schooltxt.Location = new System.Drawing.Point(437, 366);
            this.Schooltxt.Name = "Schooltxt";
            this.Schooltxt.Size = new System.Drawing.Size(125, 27);
            this.Schooltxt.TabIndex = 32;
            // 
            // Booktxt
            // 
            this.Booktxt.Location = new System.Drawing.Point(608, 366);
            this.Booktxt.Name = "Booktxt";
            this.Booktxt.Size = new System.Drawing.Size(125, 27);
            this.Booktxt.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.Booktxt);
            this.Controls.Add(this.Schooltxt);
            this.Controls.Add(this.Classtxt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Descriptiontxt);
            this.Controls.Add(this.SpellDurationtxt);
            this.Controls.Add(this.SpellCastTimetxt);
            this.Controls.Add(this.SpellSavetxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SpellNametxt);
            this.Controls.Add(this.LevelSearchcbo);
            this.Controls.Add(this.ClassSearchcbo);
            this.Controls.Add(this.SchoolSearchcbo);
            this.Controls.Add(this.NameSearchcbo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Spelllst);
            this.Controls.Add(this.Componentstxt);
            this.Controls.Add(this.SpellLeveltxt);
            this.Controls.Add(this.SpellRangetxt);
            this.Controls.Add(this.AOEtxt);
            this.Name = "Form1";
            this.Text = "Dungeons and Dragons Spellbook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

