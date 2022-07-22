
namespace imdb
{
    partial class MainForm
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
            this.movie_txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rateBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReviewBox1 = new System.Windows.Forms.RichTextBox();
            this.add_rate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.add_to_watch = new System.Windows.Forms.Button();
            this.show_list = new System.Windows.Forms.Button();
            this.add_review = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.watchListView = new System.Windows.Forms.Label();
            this.movie_name_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bnt_Search = new System.Windows.Forms.Button();
            this.mov_ID_txt = new System.Windows.Forms.TextBox();
            this.user_id_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_watch_list_rep = new System.Windows.Forms.Button();
            this.btn_file_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movie_txt
            // 
            this.movie_txt.AutoSize = true;
            this.movie_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_txt.ForeColor = System.Drawing.Color.White;
            this.movie_txt.Location = new System.Drawing.Point(216, 210);
            this.movie_txt.Name = "movie_txt";
            this.movie_txt.Size = new System.Drawing.Size(173, 29);
            this.movie_txt.TabIndex = 0;
            this.movie_txt.Text = "Movie Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Release Date :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateBox1
            // 
            this.DateBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.DateBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.DateBox1.Location = new System.Drawing.Point(352, 398);
            this.DateBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateBox1.Name = "DateBox1";
            this.DateBox1.ReadOnly = true;
            this.DateBox1.Size = new System.Drawing.Size(280, 27);
            this.DateBox1.TabIndex = 3;
            this.DateBox1.TextChanged += new System.EventHandler(this.DateBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(152, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rate Movie :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rateBox1
            // 
            this.rateBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.rateBox1.DropDownHeight = 116;
            this.rateBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rateBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.rateBox1.FormattingEnabled = true;
            this.rateBox1.IntegralHeight = false;
            this.rateBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.rateBox1.Location = new System.Drawing.Point(352, 457);
            this.rateBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rateBox1.MaxDropDownItems = 10;
            this.rateBox1.Name = "rateBox1";
            this.rateBox1.Size = new System.Drawing.Size(279, 37);
            this.rateBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(152, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add Review";
            // 
            // ReviewBox1
            // 
            this.ReviewBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.ReviewBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.ReviewBox1.Location = new System.Drawing.Point(352, 521);
            this.ReviewBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReviewBox1.Name = "ReviewBox1";
            this.ReviewBox1.Size = new System.Drawing.Size(279, 85);
            this.ReviewBox1.TabIndex = 7;
            this.ReviewBox1.Text = "";
            // 
            // add_rate
            // 
            this.add_rate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.add_rate.FlatAppearance.BorderSize = 0;
            this.add_rate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_rate.ForeColor = System.Drawing.Color.White;
            this.add_rate.Location = new System.Drawing.Point(23, 655);
            this.add_rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_rate.Name = "add_rate";
            this.add_rate.Size = new System.Drawing.Size(333, 62);
            this.add_rate.TabIndex = 8;
            this.add_rate.Text = "Add Rate";
            this.add_rate.UseVisualStyleBackColor = false;
            this.add_rate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(152, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Movie ID :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Username_txt
            // 
            this.Username_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.Username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_txt.ForeColor = System.Drawing.Color.White;
            this.Username_txt.Location = new System.Drawing.Point(16, 15);
            this.Username_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.ReadOnly = true;
            this.Username_txt.Size = new System.Drawing.Size(267, 30);
            this.Username_txt.TabIndex = 12;
            this.Username_txt.WordWrap = false;
            // 
            // add_to_watch
            // 
            this.add_to_watch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.add_to_watch.FlatAppearance.BorderSize = 0;
            this.add_to_watch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_to_watch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_to_watch.ForeColor = System.Drawing.Color.White;
            this.add_to_watch.Location = new System.Drawing.Point(704, 655);
            this.add_to_watch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_to_watch.Name = "add_to_watch";
            this.add_to_watch.Size = new System.Drawing.Size(333, 62);
            this.add_to_watch.TabIndex = 13;
            this.add_to_watch.Text = "Add to WatchList";
            this.add_to_watch.UseVisualStyleBackColor = false;
            this.add_to_watch.Click += new System.EventHandler(this.button2_Click);
            // 
            // show_list
            // 
            this.show_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.show_list.FlatAppearance.BorderSize = 0;
            this.show_list.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_list.ForeColor = System.Drawing.Color.White;
            this.show_list.Location = new System.Drawing.Point(1097, 607);
            this.show_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.show_list.Name = "show_list";
            this.show_list.Size = new System.Drawing.Size(467, 62);
            this.show_list.TabIndex = 15;
            this.show_list.Text = "Show Watch List";
            this.show_list.UseVisualStyleBackColor = false;
            this.show_list.Click += new System.EventHandler(this.button3_Click);
            // 
            // add_review
            // 
            this.add_review.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.add_review.FlatAppearance.BorderSize = 0;
            this.add_review.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_review.ForeColor = System.Drawing.Color.White;
            this.add_review.Location = new System.Drawing.Point(363, 655);
            this.add_review.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_review.Name = "add_review";
            this.add_review.Size = new System.Drawing.Size(333, 62);
            this.add_review.TabIndex = 17;
            this.add_review.Text = "add review";
            this.add_review.UseVisualStyleBackColor = false;
            this.add_review.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label6.Location = new System.Drawing.Point(16, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 2);
            this.label6.TabIndex = 18;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(1092, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "My Watch List";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label7.Location = new System.Drawing.Point(1093, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 2);
            this.label7.TabIndex = 20;
            // 
            // watchListView
            // 
            this.watchListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.watchListView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.watchListView.Location = new System.Drawing.Point(1097, 81);
            this.watchListView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.watchListView.Name = "watchListView";
            this.watchListView.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.watchListView.Size = new System.Drawing.Size(466, 521);
            this.watchListView.TabIndex = 21;
            this.watchListView.Text = "Movie Name";
            // 
            // movie_name_txt
            // 
            this.movie_name_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.movie_name_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movie_name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name_txt.ForeColor = System.Drawing.SystemColors.Window;
            this.movie_name_txt.Location = new System.Drawing.Point(408, 213);
            this.movie_name_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.movie_name_txt.Name = "movie_name_txt";
            this.movie_name_txt.Size = new System.Drawing.Size(181, 27);
            this.movie_name_txt.TabIndex = 22;
            this.movie_name_txt.Text = "Enter Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(48, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Search For Movie";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label9.Location = new System.Drawing.Point(49, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 1);
            this.label9.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label10.Location = new System.Drawing.Point(49, 320);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 1);
            this.label10.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(48, 290);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 29);
            this.label11.TabIndex = 25;
            this.label11.Text = "Movie Details";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label12.Location = new System.Drawing.Point(1087, -12);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(3, 831);
            this.label12.TabIndex = 27;
            // 
            // bnt_Search
            // 
            this.bnt_Search.BackColor = System.Drawing.Color.Transparent;
            this.bnt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Search.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Search.ForeColor = System.Drawing.Color.White;
            this.bnt_Search.Location = new System.Drawing.Point(685, 213);
            this.bnt_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_Search.Name = "bnt_Search";
            this.bnt_Search.Size = new System.Drawing.Size(143, 34);
            this.bnt_Search.TabIndex = 28;
            this.bnt_Search.Text = "SEARCH";
            this.bnt_Search.UseVisualStyleBackColor = false;
            this.bnt_Search.Click += new System.EventHandler(this.search_Click);
            // 
            // mov_ID_txt
            // 
            this.mov_ID_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.mov_ID_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mov_ID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov_ID_txt.ForeColor = System.Drawing.SystemColors.Window;
            this.mov_ID_txt.Location = new System.Drawing.Point(352, 338);
            this.mov_ID_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mov_ID_txt.Name = "mov_ID_txt";
            this.mov_ID_txt.ReadOnly = true;
            this.mov_ID_txt.Size = new System.Drawing.Size(252, 27);
            this.mov_ID_txt.TabIndex = 29;
            // 
            // user_id_txt
            // 
            this.user_id_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.user_id_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_id_txt.Location = new System.Drawing.Point(16, 81);
            this.user_id_txt.Margin = new System.Windows.Forms.Padding(1);
            this.user_id_txt.Name = "user_id_txt";
            this.user_id_txt.Size = new System.Drawing.Size(16, 15);
            this.user_id_txt.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(903, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 41);
            this.button1.TabIndex = 31;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.label13.Location = new System.Drawing.Point(404, 245);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(267, 2);
            this.label13.TabIndex = 32;
            // 
            // btn_watch_list_rep
            // 
            this.btn_watch_list_rep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btn_watch_list_rep.FlatAppearance.BorderSize = 0;
            this.btn_watch_list_rep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_watch_list_rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_watch_list_rep.ForeColor = System.Drawing.Color.White;
            this.btn_watch_list_rep.Location = new System.Drawing.Point(1097, 676);
            this.btn_watch_list_rep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_watch_list_rep.Name = "btn_watch_list_rep";
            this.btn_watch_list_rep.Size = new System.Drawing.Size(227, 62);
            this.btn_watch_list_rep.TabIndex = 33;
            this.btn_watch_list_rep.Text = "Watch List Report";
            this.btn_watch_list_rep.UseVisualStyleBackColor = false;
            this.btn_watch_list_rep.Click += new System.EventHandler(this.btn_watch_list_rep_Click);
            // 
            // btn_file_report
            // 
            this.btn_file_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btn_file_report.FlatAppearance.BorderSize = 0;
            this.btn_file_report.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_file_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_file_report.ForeColor = System.Drawing.Color.White;
            this.btn_file_report.Location = new System.Drawing.Point(1337, 676);
            this.btn_file_report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_file_report.Name = "btn_file_report";
            this.btn_file_report.Size = new System.Drawing.Size(227, 62);
            this.btn_file_report.TabIndex = 34;
            this.btn_file_report.Text = "Film Report";
            this.btn_file_report.UseVisualStyleBackColor = false;
            this.btn_file_report.Click += new System.EventHandler(this.btn_file_report_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1576, 762);
            this.Controls.Add(this.btn_file_report);
            this.Controls.Add(this.btn_watch_list_rep);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_id_txt);
            this.Controls.Add(this.mov_ID_txt);
            this.Controls.Add(this.bnt_Search);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.movie_name_txt);
            this.Controls.Add(this.watchListView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add_review);
            this.Controls.Add(this.show_list);
            this.Controls.Add(this.add_to_watch);
            this.Controls.Add(this.Username_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_rate);
            this.Controls.Add(this.ReviewBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rateBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.movie_txt);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DateBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rateBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ReviewBox1;
        private System.Windows.Forms.Button add_rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.Button add_to_watch;
        private System.Windows.Forms.Button show_list;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button add_review;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label watchListView;
        private System.Windows.Forms.Label movie_txt;
        private System.Windows.Forms.TextBox movie_name_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bnt_Search;
        private System.Windows.Forms.TextBox mov_ID_txt;
        private System.Windows.Forms.TextBox user_id_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_watch_list_rep;
        private System.Windows.Forms.Button btn_file_report;
    }
}