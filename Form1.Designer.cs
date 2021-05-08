
namespace WinFormsApp_ToolPaintGraph_59103
{
    partial class Form_Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_Color = new System.Windows.Forms.Panel();
            this.comboBox_Draw = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel_DrawCentr = new System.Windows.Forms.Panel();
            this.comboBox_DrawCentr = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel_DrawDown = new System.Windows.Forms.Panel();
            this.comboBox_DrawDown = new System.Windows.Forms.ComboBox();
            this.panel_Draw = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel_Edge = new System.Windows.Forms.Panel();
            this.comboBox_Edge = new System.Windows.Forms.ComboBox();
            this.button_DrawByAlghorithm = new System.Windows.Forms.Button();
            this.button_DrawingWiper = new System.Windows.Forms.Button();
            this.button_DrawEdges = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_Color);
            this.groupBox1.Controls.Add(this.comboBox_Draw);
            this.groupBox1.Location = new System.Drawing.Point(501, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel_Color
            // 
            this.panel_Color.Location = new System.Drawing.Point(7, 23);
            this.panel_Color.Name = "panel_Color";
            this.panel_Color.Size = new System.Drawing.Size(125, 65);
            this.panel_Color.TabIndex = 2;
            // 
            // comboBox_Draw
            // 
            this.comboBox_Draw.FormattingEnabled = true;
            this.comboBox_Draw.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Silver",
            "Orange"});
            this.comboBox_Draw.Location = new System.Drawing.Point(6, 94);
            this.comboBox_Draw.Name = "comboBox_Draw";
            this.comboBox_Draw.Size = new System.Drawing.Size(126, 23);
            this.comboBox_Draw.TabIndex = 1;
            this.comboBox_Draw.SelectedIndexChanged += new System.EventHandler(this.comboBox_Draw_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel_DrawCentr);
            this.groupBox2.Controls.Add(this.comboBox_DrawCentr);
            this.groupBox2.Location = new System.Drawing.Point(645, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // panel_DrawCentr
            // 
            this.panel_DrawCentr.Location = new System.Drawing.Point(6, 23);
            this.panel_DrawCentr.Name = "panel_DrawCentr";
            this.panel_DrawCentr.Size = new System.Drawing.Size(126, 65);
            this.panel_DrawCentr.TabIndex = 2;
            // 
            // comboBox_DrawCentr
            // 
            this.comboBox_DrawCentr.FormattingEnabled = true;
            this.comboBox_DrawCentr.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Silver",
            "Orange"});
            this.comboBox_DrawCentr.Location = new System.Drawing.Point(6, 94);
            this.comboBox_DrawCentr.Name = "comboBox_DrawCentr";
            this.comboBox_DrawCentr.Size = new System.Drawing.Size(126, 23);
            this.comboBox_DrawCentr.TabIndex = 1;
            this.comboBox_DrawCentr.SelectedIndexChanged += new System.EventHandler(this.comboBox_DrawCentr_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel_DrawDown);
            this.groupBox3.Controls.Add(this.comboBox_DrawDown);
            this.groupBox3.Location = new System.Drawing.Point(789, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // panel_DrawDown
            // 
            this.panel_DrawDown.Location = new System.Drawing.Point(6, 23);
            this.panel_DrawDown.Name = "panel_DrawDown";
            this.panel_DrawDown.Size = new System.Drawing.Size(126, 65);
            this.panel_DrawDown.TabIndex = 2;
            // 
            // comboBox_DrawDown
            // 
            this.comboBox_DrawDown.FormattingEnabled = true;
            this.comboBox_DrawDown.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Silver",
            "Orange"});
            this.comboBox_DrawDown.Location = new System.Drawing.Point(6, 94);
            this.comboBox_DrawDown.Name = "comboBox_DrawDown";
            this.comboBox_DrawDown.Size = new System.Drawing.Size(126, 23);
            this.comboBox_DrawDown.TabIndex = 1;
            this.comboBox_DrawDown.SelectedIndexChanged += new System.EventHandler(this.comboBox_DrawDown_SelectedIndexChanged);
            // 
            // panel_Draw
            // 
            this.panel_Draw.Location = new System.Drawing.Point(12, 12);
            this.panel_Draw.Name = "panel_Draw";
            this.panel_Draw.Size = new System.Drawing.Size(480, 330);
            this.panel_Draw.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel_Edge);
            this.groupBox4.Controls.Add(this.comboBox_Edge);
            this.groupBox4.Location = new System.Drawing.Point(557, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(138, 123);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // panel_Edge
            // 
            this.panel_Edge.Location = new System.Drawing.Point(6, 23);
            this.panel_Edge.Name = "panel_Edge";
            this.panel_Edge.Size = new System.Drawing.Size(126, 65);
            this.panel_Edge.TabIndex = 2;
            // 
            // comboBox_Edge
            // 
            this.comboBox_Edge.FormattingEnabled = true;
            this.comboBox_Edge.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Silver",
            "Orange"});
            this.comboBox_Edge.Location = new System.Drawing.Point(6, 94);
            this.comboBox_Edge.Name = "comboBox_Edge";
            this.comboBox_Edge.Size = new System.Drawing.Size(126, 23);
            this.comboBox_Edge.TabIndex = 1;
            this.comboBox_Edge.SelectedIndexChanged += new System.EventHandler(this.comboBox_Edge_SelectedIndexChanged);
            // 
            // button_DrawByAlghorithm
            // 
            this.button_DrawByAlghorithm.Location = new System.Drawing.Point(757, 191);
            this.button_DrawByAlghorithm.Name = "button_DrawByAlghorithm";
            this.button_DrawByAlghorithm.Size = new System.Drawing.Size(136, 40);
            this.button_DrawByAlghorithm.TabIndex = 5;
            this.button_DrawByAlghorithm.Text = "Задание 1\r\nРаскраска углов\r\n";
            this.button_DrawByAlghorithm.UseVisualStyleBackColor = true;
            this.button_DrawByAlghorithm.Click += new System.EventHandler(this.button_DrawByAlghorithm_Click);
            // 
            // button_DrawingWiper
            // 
            this.button_DrawingWiper.Location = new System.Drawing.Point(757, 237);
            this.button_DrawingWiper.Name = "button_DrawingWiper";
            this.button_DrawingWiper.Size = new System.Drawing.Size(136, 40);
            this.button_DrawingWiper.TabIndex = 6;
            this.button_DrawingWiper.Text = "Задание 2\r\nУпорядочение углов\r\n";
            this.button_DrawingWiper.UseVisualStyleBackColor = true;
            this.button_DrawingWiper.Click += new System.EventHandler(this.button_DrawingWiper_Click);
            // 
            // button_DrawEdges
            // 
            this.button_DrawEdges.Location = new System.Drawing.Point(757, 283);
            this.button_DrawEdges.Name = "button_DrawEdges";
            this.button_DrawEdges.Size = new System.Drawing.Size(136, 40);
            this.button_DrawEdges.TabIndex = 7;
            this.button_DrawEdges.Text = "Задание 3\r\nРаскраска ветвей\r\n";
            this.button_DrawEdges.UseVisualStyleBackColor = true;
            this.button_DrawEdges.Click += new System.EventHandler(this.button_DrawEdges_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(563, 360);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(161, 30);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.Text = "Удалить все";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(748, 360);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(161, 30);
            this.button_Close.TabIndex = 9;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выбор цвета вершин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Выбор цвета ветвей";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_DrawEdges);
            this.Controls.Add(this.button_DrawingWiper);
            this.Controls.Add(this.button_DrawByAlghorithm);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel_Draw);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Main";
            this.Text = "Создание инструментов для рисования";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Draw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_DrawCentr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel_Draw;
        private System.Windows.Forms.Panel panel_Color;
        private System.Windows.Forms.Panel panel_DrawCentr;
        private System.Windows.Forms.Panel panel_DrawDown;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel_Edge;
        private System.Windows.Forms.ComboBox comboBox_Edge;
        private System.Windows.Forms.ComboBox comboBox_DrawDown;
        private System.Windows.Forms.Button button_DrawByAlghorithm;
        private System.Windows.Forms.Button button_DrawingWiper;
        private System.Windows.Forms.Button button_DrawEdges;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

