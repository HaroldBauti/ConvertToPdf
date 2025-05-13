namespace PDFtoWORD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnInf = new FontAwesome.Sharp.IconButton();
            this.txtcarpetadestino = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcarpetaorigen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnConvert = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.btnInf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 39);
            this.panel1.TabIndex = 25;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.iconButton3.IconColor = System.Drawing.Color.Red;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 28;
            this.iconButton3.Location = new System.Drawing.Point(783, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(42, 34);
            this.iconButton3.TabIndex = 26;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 28;
            this.iconButton2.Location = new System.Drawing.Point(740, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(37, 34);
            this.iconButton2.TabIndex = 24;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnInf
            // 
            this.btnInf.FlatAppearance.BorderSize = 0;
            this.btnInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInf.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnInf.IconColor = System.Drawing.Color.Orange;
            this.btnInf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInf.IconSize = 28;
            this.btnInf.Location = new System.Drawing.Point(697, 2);
            this.btnInf.Name = "btnInf";
            this.btnInf.Size = new System.Drawing.Size(37, 34);
            this.btnInf.TabIndex = 19;
            this.btnInf.UseVisualStyleBackColor = true;
            this.btnInf.Click += new System.EventHandler(this.btnInf_Click);
            // 
            // txtcarpetadestino
            // 
            this.txtcarpetadestino.BackColor = System.Drawing.Color.White;
            this.txtcarpetadestino.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcarpetadestino.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcarpetadestino.ForeColor = System.Drawing.Color.Black;
            this.txtcarpetadestino.HintForeColor = System.Drawing.Color.Empty;
            this.txtcarpetadestino.HintText = "";
            this.txtcarpetadestino.isPassword = false;
            this.txtcarpetadestino.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcarpetadestino.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcarpetadestino.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcarpetadestino.LineThickness = 3;
            this.txtcarpetadestino.Location = new System.Drawing.Point(253, 204);
            this.txtcarpetadestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtcarpetadestino.Name = "txtcarpetadestino";
            this.txtcarpetadestino.Size = new System.Drawing.Size(379, 33);
            this.txtcarpetadestino.TabIndex = 22;
            this.txtcarpetadestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(280, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Convert Pdf to Word";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(114, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Origin File :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(44, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Destination Folder : ";
            // 
            // txtcarpetaorigen
            // 
            this.txtcarpetaorigen.BackColor = System.Drawing.Color.White;
            this.txtcarpetaorigen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcarpetaorigen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcarpetaorigen.ForeColor = System.Drawing.Color.Black;
            this.txtcarpetaorigen.HintForeColor = System.Drawing.Color.Empty;
            this.txtcarpetaorigen.HintText = "";
            this.txtcarpetaorigen.isPassword = false;
            this.txtcarpetaorigen.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcarpetaorigen.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcarpetaorigen.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcarpetaorigen.LineThickness = 3;
            this.txtcarpetaorigen.Location = new System.Drawing.Point(251, 160);
            this.txtcarpetaorigen.Margin = new System.Windows.Forms.Padding(4);
            this.txtcarpetaorigen.Name = "txtcarpetaorigen";
            this.txtcarpetaorigen.Size = new System.Drawing.Size(379, 33);
            this.txtcarpetaorigen.TabIndex = 21;
            this.txtcarpetaorigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(736, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Versión 1.0.1";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Lime;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 25;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(639, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 32);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnSearch.IconColor = System.Drawing.Color.Red;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 25;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(637, 159);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 32);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search Pdf";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConvert.IconChar = FontAwesome.Sharp.IconChar.FileWord;
            this.btnConvert.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConvert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConvert.IconSize = 30;
            this.btnConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConvert.Location = new System.Drawing.Point(354, 268);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(188, 42);
            this.btnConvert.TabIndex = 20;
            this.btnConvert.Text = "Convert To Word";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PDFtoWORD.Properties.Resources.HBATEC;
            this.pictureBox2.Location = new System.Drawing.Point(51, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(828, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtcarpetadestino);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcarpetaorigen);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private FontAwesome.Sharp.IconButton btnSave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcarpetadestino;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnInf;
        private FontAwesome.Sharp.IconButton btnConvert;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcarpetaorigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}

