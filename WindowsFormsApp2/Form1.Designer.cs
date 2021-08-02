
namespace WindowsFormsApp2
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
            this.lbl_YanacaqNovu = new System.Windows.Forms.Label();
            this.lbl_LitrAzn = new System.Windows.Forms.Label();
            this.txt_1LitrQiymeti = new System.Windows.Forms.TextBox();
            this.rbtn_LitrToAzn = new System.Windows.Forms.RadioButton();
            this.rbtnAznToLitr = new System.Windows.Forms.RadioButton();
            this.txt_LitrToAzn = new System.Windows.Forms.TextBox();
            this.txtAznToLitr = new System.Windows.Forms.TextBox();
            this.lbl_BenzinQiymeti = new System.Windows.Forms.Label();
            this.lbl_BenzinQiymet = new System.Windows.Forms.Label();
            this.cmbox_YanacaqNovu = new System.Windows.Forms.ComboBox();
            this.lbl_AZN = new System.Windows.Forms.Label();
            this.txt_hotMiqdar = new System.Windows.Forms.TextBox();
            this.txt_HotQiymet = new System.Windows.Forms.TextBox();
            this.txt_HamQiymet = new System.Windows.Forms.TextBox();
            this.txt_HamMiqdar = new System.Windows.Forms.TextBox();
            this.txt_FreeQiymet = new System.Windows.Forms.TextBox();
            this.txt_FreeMiqdar = new System.Windows.Forms.TextBox();
            this.txt_ColaQiymet = new System.Windows.Forms.TextBox();
            this.txt_ColaMiqdar = new System.Windows.Forms.TextBox();
            this.lbl_MiniCafeQiymeti = new System.Windows.Forms.Label();
            this.lbl_MiniCafeQiymet = new System.Windows.Forms.Label();
            this.lbl_UmumiQiymeti = new System.Windows.Forms.Label();
            this.lbl_UmumiQiymet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chek_HotDog = new System.Windows.Forms.CheckBox();
            this.chek_Hamburger = new System.Windows.Forms.CheckBox();
            this.chek_Free = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_YanacaqNovu
            // 
            this.lbl_YanacaqNovu.AutoSize = true;
            this.lbl_YanacaqNovu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_YanacaqNovu.Location = new System.Drawing.Point(13, 70);
            this.lbl_YanacaqNovu.Name = "lbl_YanacaqNovu";
            this.lbl_YanacaqNovu.Size = new System.Drawing.Size(143, 25);
            this.lbl_YanacaqNovu.TabIndex = 0;
            this.lbl_YanacaqNovu.Text = "Yanacaq Novu";
            // 
            // lbl_LitrAzn
            // 
            this.lbl_LitrAzn.AutoSize = true;
            this.lbl_LitrAzn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LitrAzn.Location = new System.Drawing.Point(696, 30);
            this.lbl_LitrAzn.Name = "lbl_LitrAzn";
            this.lbl_LitrAzn.Size = new System.Drawing.Size(82, 25);
            this.lbl_LitrAzn.TabIndex = 0;
            this.lbl_LitrAzn.Text = "Qiymeti";
            // 
            // txt_1LitrQiymeti
            // 
            this.txt_1LitrQiymeti.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1LitrQiymeti.Location = new System.Drawing.Point(180, 134);
            this.txt_1LitrQiymeti.Name = "txt_1LitrQiymeti";
            this.txt_1LitrQiymeti.ReadOnly = true;
            this.txt_1LitrQiymeti.Size = new System.Drawing.Size(119, 33);
            this.txt_1LitrQiymeti.TabIndex = 2;
            this.txt_1LitrQiymeti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbtn_LitrToAzn
            // 
            this.rbtn_LitrToAzn.AutoSize = true;
            this.rbtn_LitrToAzn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_LitrToAzn.Location = new System.Drawing.Point(89, 206);
            this.rbtn_LitrToAzn.Name = "rbtn_LitrToAzn";
            this.rbtn_LitrToAzn.Size = new System.Drawing.Size(63, 29);
            this.rbtn_LitrToAzn.TabIndex = 3;
            this.rbtn_LitrToAzn.TabStop = true;
            this.rbtn_LitrToAzn.Text = "Litr";
            this.rbtn_LitrToAzn.UseVisualStyleBackColor = true;
            this.rbtn_LitrToAzn.CheckedChanged += new System.EventHandler(this.rbtn_LitrToAzn_CheckedChanged);
            // 
            // rbtnAznToLitr
            // 
            this.rbtnAznToLitr.AutoSize = true;
            this.rbtnAznToLitr.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAznToLitr.Location = new System.Drawing.Point(82, 261);
            this.rbtnAznToLitr.Name = "rbtnAznToLitr";
            this.rbtnAznToLitr.Size = new System.Drawing.Size(70, 29);
            this.rbtnAznToLitr.TabIndex = 3;
            this.rbtnAznToLitr.TabStop = true;
            this.rbtnAznToLitr.Text = "AZN";
            this.rbtnAznToLitr.UseVisualStyleBackColor = true;
            this.rbtnAznToLitr.CheckedChanged += new System.EventHandler(this.rbtnAznToLitr_CheckedChanged);
            // 
            // txt_LitrToAzn
            // 
            this.txt_LitrToAzn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LitrToAzn.Location = new System.Drawing.Point(180, 206);
            this.txt_LitrToAzn.Name = "txt_LitrToAzn";
            this.txt_LitrToAzn.Size = new System.Drawing.Size(165, 33);
            this.txt_LitrToAzn.TabIndex = 2;
            this.txt_LitrToAzn.TextChanged += new System.EventHandler(this.txt_LitrToAzn_TextChanged);
            // 
            // txtAznToLitr
            // 
            this.txtAznToLitr.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAznToLitr.Location = new System.Drawing.Point(180, 261);
            this.txtAznToLitr.Name = "txtAznToLitr";
            this.txtAznToLitr.Size = new System.Drawing.Size(165, 33);
            this.txtAznToLitr.TabIndex = 2;
            this.txtAznToLitr.TextChanged += new System.EventHandler(this.txtAznToLitr_TextChanged);
            // 
            // lbl_BenzinQiymeti
            // 
            this.lbl_BenzinQiymeti.AutoSize = true;
            this.lbl_BenzinQiymeti.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BenzinQiymeti.Location = new System.Drawing.Point(12, 353);
            this.lbl_BenzinQiymeti.Name = "lbl_BenzinQiymeti";
            this.lbl_BenzinQiymeti.Size = new System.Drawing.Size(208, 35);
            this.lbl_BenzinQiymeti.TabIndex = 0;
            this.lbl_BenzinQiymeti.Text = "Benzin Qiymeti";
            // 
            // lbl_BenzinQiymet
            // 
            this.lbl_BenzinQiymet.AutoSize = true;
            this.lbl_BenzinQiymet.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BenzinQiymet.Location = new System.Drawing.Point(242, 353);
            this.lbl_BenzinQiymet.Name = "lbl_BenzinQiymet";
            this.lbl_BenzinQiymet.Size = new System.Drawing.Size(39, 35);
            this.lbl_BenzinQiymet.TabIndex = 0;
            this.lbl_BenzinQiymet.Text = "0 ";
            // 
            // cmbox_YanacaqNovu
            // 
            this.cmbox_YanacaqNovu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_YanacaqNovu.FormattingEnabled = true;
            this.cmbox_YanacaqNovu.Items.AddRange(new object[] {
            "PREMIUM",
            "A92",
            "DIZEL"});
            this.cmbox_YanacaqNovu.Location = new System.Drawing.Point(180, 67);
            this.cmbox_YanacaqNovu.Name = "cmbox_YanacaqNovu";
            this.cmbox_YanacaqNovu.Size = new System.Drawing.Size(165, 33);
            this.cmbox_YanacaqNovu.TabIndex = 4;
            this.cmbox_YanacaqNovu.Text = "Secin";
            this.cmbox_YanacaqNovu.SelectedIndexChanged += new System.EventHandler(this.cmbox_YanacaqNovu_SelectedIndexChanged);
            // 
            // lbl_AZN
            // 
            this.lbl_AZN.AutoSize = true;
            this.lbl_AZN.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AZN.Location = new System.Drawing.Point(305, 142);
            this.lbl_AZN.Name = "lbl_AZN";
            this.lbl_AZN.Size = new System.Drawing.Size(52, 25);
            this.lbl_AZN.TabIndex = 0;
            this.lbl_AZN.Text = "AZN";
            // 
            // txt_hotMiqdar
            // 
            this.txt_hotMiqdar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hotMiqdar.Location = new System.Drawing.Point(818, 70);
            this.txt_hotMiqdar.Name = "txt_hotMiqdar";
            this.txt_hotMiqdar.ReadOnly = true;
            this.txt_hotMiqdar.Size = new System.Drawing.Size(109, 33);
            this.txt_hotMiqdar.TabIndex = 2;
            // 
            // txt_HotQiymet
            // 
            this.txt_HotQiymet.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HotQiymet.Location = new System.Drawing.Point(678, 70);
            this.txt_HotQiymet.Name = "txt_HotQiymet";
            this.txt_HotQiymet.ReadOnly = true;
            this.txt_HotQiymet.Size = new System.Drawing.Size(119, 33);
            this.txt_HotQiymet.TabIndex = 2;
            this.txt_HotQiymet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_HamQiymet
            // 
            this.txt_HamQiymet.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HamQiymet.Location = new System.Drawing.Point(678, 129);
            this.txt_HamQiymet.Name = "txt_HamQiymet";
            this.txt_HamQiymet.ReadOnly = true;
            this.txt_HamQiymet.Size = new System.Drawing.Size(119, 33);
            this.txt_HamQiymet.TabIndex = 2;
            this.txt_HamQiymet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_HamMiqdar
            // 
            this.txt_HamMiqdar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HamMiqdar.Location = new System.Drawing.Point(818, 129);
            this.txt_HamMiqdar.Name = "txt_HamMiqdar";
            this.txt_HamMiqdar.ReadOnly = true;
            this.txt_HamMiqdar.Size = new System.Drawing.Size(109, 33);
            this.txt_HamMiqdar.TabIndex = 2;
            // 
            // txt_FreeQiymet
            // 
            this.txt_FreeQiymet.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FreeQiymet.Location = new System.Drawing.Point(678, 187);
            this.txt_FreeQiymet.Name = "txt_FreeQiymet";
            this.txt_FreeQiymet.ReadOnly = true;
            this.txt_FreeQiymet.Size = new System.Drawing.Size(119, 33);
            this.txt_FreeQiymet.TabIndex = 2;
            this.txt_FreeQiymet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_FreeMiqdar
            // 
            this.txt_FreeMiqdar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FreeMiqdar.Location = new System.Drawing.Point(818, 187);
            this.txt_FreeMiqdar.Name = "txt_FreeMiqdar";
            this.txt_FreeMiqdar.ReadOnly = true;
            this.txt_FreeMiqdar.Size = new System.Drawing.Size(109, 33);
            this.txt_FreeMiqdar.TabIndex = 2;
            // 
            // txt_ColaQiymet
            // 
            this.txt_ColaQiymet.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ColaQiymet.Location = new System.Drawing.Point(678, 243);
            this.txt_ColaQiymet.Name = "txt_ColaQiymet";
            this.txt_ColaQiymet.ReadOnly = true;
            this.txt_ColaQiymet.Size = new System.Drawing.Size(119, 33);
            this.txt_ColaQiymet.TabIndex = 2;
            this.txt_ColaQiymet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ColaMiqdar
            // 
            this.txt_ColaMiqdar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ColaMiqdar.Location = new System.Drawing.Point(818, 243);
            this.txt_ColaMiqdar.Name = "txt_ColaMiqdar";
            this.txt_ColaMiqdar.ReadOnly = true;
            this.txt_ColaMiqdar.Size = new System.Drawing.Size(109, 33);
            this.txt_ColaMiqdar.TabIndex = 2;
            // 
            // lbl_MiniCafeQiymeti
            // 
            this.lbl_MiniCafeQiymeti.AutoSize = true;
            this.lbl_MiniCafeQiymeti.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MiniCafeQiymeti.Location = new System.Drawing.Point(648, 353);
            this.lbl_MiniCafeQiymeti.Name = "lbl_MiniCafeQiymeti";
            this.lbl_MiniCafeQiymeti.Size = new System.Drawing.Size(231, 35);
            this.lbl_MiniCafeQiymeti.TabIndex = 0;
            this.lbl_MiniCafeQiymeti.Text = "MiniCafe Qiymeti";
            // 
            // lbl_MiniCafeQiymet
            // 
            this.lbl_MiniCafeQiymet.AutoSize = true;
            this.lbl_MiniCafeQiymet.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MiniCafeQiymet.Location = new System.Drawing.Point(888, 353);
            this.lbl_MiniCafeQiymet.Name = "lbl_MiniCafeQiymet";
            this.lbl_MiniCafeQiymet.Size = new System.Drawing.Size(39, 35);
            this.lbl_MiniCafeQiymet.TabIndex = 0;
            this.lbl_MiniCafeQiymet.Text = "0 ";
            // 
            // lbl_UmumiQiymeti
            // 
            this.lbl_UmumiQiymeti.AutoSize = true;
            this.lbl_UmumiQiymeti.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UmumiQiymeti.Location = new System.Drawing.Point(304, 426);
            this.lbl_UmumiQiymeti.Name = "lbl_UmumiQiymeti";
            this.lbl_UmumiQiymeti.Size = new System.Drawing.Size(212, 35);
            this.lbl_UmumiQiymeti.TabIndex = 0;
            this.lbl_UmumiQiymeti.Text = "Umumi Qiymeti";
            // 
            // lbl_UmumiQiymet
            // 
            this.lbl_UmumiQiymet.AutoSize = true;
            this.lbl_UmumiQiymet.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UmumiQiymet.Location = new System.Drawing.Point(537, 426);
            this.lbl_UmumiQiymet.Name = "lbl_UmumiQiymet";
            this.lbl_UmumiQiymet.Size = new System.Drawing.Size(39, 35);
            this.lbl_UmumiQiymet.TabIndex = 0;
            this.lbl_UmumiQiymet.Text = "0 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(833, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miqdar";
            // 
            // chek_HotDog
            // 
            this.chek_HotDog.AutoSize = true;
            this.chek_HotDog.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chek_HotDog.Location = new System.Drawing.Point(555, 72);
            this.chek_HotDog.Name = "chek_HotDog";
            this.chek_HotDog.Size = new System.Drawing.Size(99, 29);
            this.chek_HotDog.TabIndex = 5;
            this.chek_HotDog.Text = "HotDog";
            this.chek_HotDog.UseVisualStyleBackColor = true;
            this.chek_HotDog.CheckedChanged += new System.EventHandler(this.chek_HotDog_CheckedChanged);
            // 
            // chek_Hamburger
            // 
            this.chek_Hamburger.AutoSize = true;
            this.chek_Hamburger.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chek_Hamburger.Location = new System.Drawing.Point(517, 131);
            this.chek_Hamburger.Name = "chek_Hamburger";
            this.chek_Hamburger.Size = new System.Drawing.Size(137, 29);
            this.chek_Hamburger.TabIndex = 5;
            this.chek_Hamburger.Text = "Hamburger";
            this.chek_Hamburger.UseVisualStyleBackColor = true;
            this.chek_Hamburger.CheckedChanged += new System.EventHandler(this.chek_Hamburger_CheckedChanged);
            // 
            // chek_Free
            // 
            this.chek_Free.AutoSize = true;
            this.chek_Free.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chek_Free.Location = new System.Drawing.Point(580, 189);
            this.chek_Free.Name = "chek_Free";
            this.chek_Free.Size = new System.Drawing.Size(74, 29);
            this.chek_Free.TabIndex = 5;
            this.chek_Free.Text = "Free";
            this.chek_Free.UseVisualStyleBackColor = true;
            this.chek_Free.CheckedChanged += new System.EventHandler(this.chek_Free_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(580, 245);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 29);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Cola";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.chek_Free);
            this.Controls.Add(this.chek_Hamburger);
            this.Controls.Add(this.chek_HotDog);
            this.Controls.Add(this.cmbox_YanacaqNovu);
            this.Controls.Add(this.rbtnAznToLitr);
            this.Controls.Add(this.rbtn_LitrToAzn);
            this.Controls.Add(this.txt_ColaMiqdar);
            this.Controls.Add(this.txt_FreeMiqdar);
            this.Controls.Add(this.txt_HamMiqdar);
            this.Controls.Add(this.txt_ColaQiymet);
            this.Controls.Add(this.txt_hotMiqdar);
            this.Controls.Add(this.txt_FreeQiymet);
            this.Controls.Add(this.txt_LitrToAzn);
            this.Controls.Add(this.txt_HamQiymet);
            this.Controls.Add(this.txtAznToLitr);
            this.Controls.Add(this.txt_HotQiymet);
            this.Controls.Add(this.txt_1LitrQiymeti);
            this.Controls.Add(this.lbl_AZN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_LitrAzn);
            this.Controls.Add(this.lbl_MiniCafeQiymet);
            this.Controls.Add(this.lbl_UmumiQiymet);
            this.Controls.Add(this.lbl_BenzinQiymet);
            this.Controls.Add(this.lbl_MiniCafeQiymeti);
            this.Controls.Add(this.lbl_UmumiQiymeti);
            this.Controls.Add(this.lbl_BenzinQiymeti);
            this.Controls.Add(this.lbl_YanacaqNovu);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_YanacaqNovu;
        private System.Windows.Forms.Label lbl_LitrAzn;
        private System.Windows.Forms.TextBox txt_1LitrQiymeti;
        private System.Windows.Forms.RadioButton rbtn_LitrToAzn;
        private System.Windows.Forms.RadioButton rbtnAznToLitr;
        private System.Windows.Forms.TextBox txt_LitrToAzn;
        private System.Windows.Forms.TextBox txtAznToLitr;
        private System.Windows.Forms.Label lbl_BenzinQiymeti;
        private System.Windows.Forms.Label lbl_BenzinQiymet;
        private System.Windows.Forms.ComboBox cmbox_YanacaqNovu;
        private System.Windows.Forms.Label lbl_AZN;
        private System.Windows.Forms.TextBox txt_hotMiqdar;
        private System.Windows.Forms.TextBox txt_HotQiymet;
        private System.Windows.Forms.TextBox txt_HamQiymet;
        private System.Windows.Forms.TextBox txt_HamMiqdar;
        private System.Windows.Forms.TextBox txt_FreeQiymet;
        private System.Windows.Forms.TextBox txt_FreeMiqdar;
        private System.Windows.Forms.TextBox txt_ColaQiymet;
        private System.Windows.Forms.TextBox txt_ColaMiqdar;
        private System.Windows.Forms.Label lbl_MiniCafeQiymeti;
        private System.Windows.Forms.Label lbl_MiniCafeQiymet;
        private System.Windows.Forms.Label lbl_UmumiQiymeti;
        private System.Windows.Forms.Label lbl_UmumiQiymet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chek_HotDog;
        private System.Windows.Forms.CheckBox chek_Hamburger;
        private System.Windows.Forms.CheckBox chek_Free;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

