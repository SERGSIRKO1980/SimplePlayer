namespace player
{
    partial class A_player
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open_m = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_men = new System.Windows.Forms.ToolStripMenuItem();
            this.men_del_tek = new System.Windows.Forms.ToolStripMenuItem();
            this.Men_del_vse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.men_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.роизведениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.men_pl_pau = new System.Windows.Forms.ToolStripMenuItem();
            this.men_stop = new System.Windows.Forms.ToolStripMenuItem();
            this.men_next = new System.Windows.Forms.ToolStripMenuItem();
            this.men_back = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.men_pllist_ot = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.men_spr = new System.Windows.Forms.ToolStripMenuItem();
            this.min_about = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_vsgo = new System.Windows.Forms.Label();
            this.tb_volume = new System.Windows.Forms.TrackBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cont_men_pl_paus = new System.Windows.Forms.ToolStripMenuItem();
            this.cont_men_stop = new System.Windows.Forms.ToolStripMenuItem();
            this.cont_men_back = new System.Windows.Forms.ToolStripMenuItem();
            this.cont_men_next = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cont_men_del = new System.Windows.Forms.ToolStripMenuItem();
            this.cont_men_del_vse = new System.Windows.Forms.ToolStripMenuItem();
            this.cont_men_open = new System.Windows.Forms.ToolStripMenuItem();
            this.cont_men_sver_pl = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_balanc = new System.Windows.Forms.TrackBar();
            this.time_tek = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_play = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volume)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_balanc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.роизведениеToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_m,
            this.delete_men,
            this.toolStripSeparator1,
            this.men_exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // open_m
            // 
            this.open_m.Image = global::player.Properties.Resources.openfolder;
            this.open_m.Name = "open_m";
            this.open_m.Size = new System.Drawing.Size(188, 34);
            this.open_m.Text = "Открыть";
            this.open_m.Click += new System.EventHandler(this.open_m_Click);
            // 
            // delete_men
            // 
            this.delete_men.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.men_del_tek,
            this.Men_del_vse});
            this.delete_men.Enabled = false;
            this.delete_men.Name = "delete_men";
            this.delete_men.Size = new System.Drawing.Size(188, 34);
            this.delete_men.Text = "Удалить  ";
            // 
            // men_del_tek
            // 
            this.men_del_tek.Name = "men_del_tek";
            this.men_del_tek.Size = new System.Drawing.Size(276, 34);
            this.men_del_tek.Text = "Tекущую песнью  ";
            this.men_del_tek.Click += new System.EventHandler(this.men_del_tek_Click);
            // 
            // Men_del_vse
            // 
            this.Men_del_vse.Image = global::player.Properties.Resources.edit_clear_1289;
            this.Men_del_vse.Name = "Men_del_vse";
            this.Men_del_vse.Size = new System.Drawing.Size(276, 34);
            this.Men_del_vse.Text = "Очистить плейлист  ";
            this.Men_del_vse.Click += new System.EventHandler(this.Men_del_vse_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // men_exit
            // 
            this.men_exit.Name = "men_exit";
            this.men_exit.Size = new System.Drawing.Size(188, 34);
            this.men_exit.Text = "Выход";
            this.men_exit.Click += new System.EventHandler(this.men_exit_Click);
            // 
            // роизведениеToolStripMenuItem
            // 
            this.роизведениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.men_pl_pau,
            this.men_stop,
            this.men_next,
            this.men_back});
            this.роизведениеToolStripMenuItem.Name = "роизведениеToolStripMenuItem";
            this.роизведениеToolStripMenuItem.Size = new System.Drawing.Size(174, 29);
            this.роизведениеToolStripMenuItem.Text = "Воспроизведение";
            // 
            // men_pl_pau
            // 
            this.men_pl_pau.Enabled = false;
            this.men_pl_pau.Name = "men_pl_pau";
            this.men_pl_pau.Size = new System.Drawing.Size(201, 34);
            this.men_pl_pau.Text = "play/pause";
            this.men_pl_pau.Click += new System.EventHandler(this.men_pl_pau_Click);
            // 
            // men_stop
            // 
            this.men_stop.Enabled = false;
            this.men_stop.Name = "men_stop";
            this.men_stop.Size = new System.Drawing.Size(201, 34);
            this.men_stop.Text = "stop";
            this.men_stop.Click += new System.EventHandler(this.men_stop_Click);
            // 
            // men_next
            // 
            this.men_next.Enabled = false;
            this.men_next.Name = "men_next";
            this.men_next.Size = new System.Drawing.Size(201, 34);
            this.men_next.Text = "next";
            this.men_next.Click += new System.EventHandler(this.bmen_next_Click);
            // 
            // men_back
            // 
            this.men_back.Enabled = false;
            this.men_back.Name = "men_back";
            this.men_back.Size = new System.Drawing.Size(201, 34);
            this.men_back.Text = "back";
            this.men_back.Click += new System.EventHandler(this.men_back_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.men_pllist_ot});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // men_pllist_ot
            // 
            this.men_pllist_ot.Name = "men_pllist_ot";
            this.men_pllist_ot.Size = new System.Drawing.Size(267, 34);
            this.men_pllist_ot.Text = "Свернуть плейлист";
            this.men_pllist_ot.Click += new System.EventHandler(this.men_pllist_ot_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.men_spr,
            this.min_about});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.информацияToolStripMenuItem.Text = "Справка";
            // 
            // men_spr
            // 
            this.men_spr.Image = global::player.Properties.Resources.helpandsupport_3737;
            this.men_spr.Name = "men_spr";
            this.men_spr.Size = new System.Drawing.Size(228, 34);
            this.men_spr.Text = "Справка";
            this.men_spr.Click += new System.EventHandler(this.men_spr_Click);
            // 
            // min_about
            // 
            this.min_about.Image = global::player.Properties.Resources.about;
            this.min_about.Name = "min_about";
            this.min_about.Size = new System.Drawing.Size(228, 34);
            this.min_about.Text = "О пограмме...";
            this.min_about.Click += new System.EventHandler(this.min_about_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.BackColor = System.Drawing.Color.DimGray;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(13, 583);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(1044, 69);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_vsgo
            // 
            this.time_vsgo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.time_vsgo.AutoSize = true;
            this.time_vsgo.BackColor = System.Drawing.Color.DimGray;
            this.time_vsgo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.time_vsgo.Location = new System.Drawing.Point(989, 583);
            this.time_vsgo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_vsgo.Name = "time_vsgo";
            this.time_vsgo.Size = new System.Drawing.Size(62, 20);
            this.time_vsgo.TabIndex = 8;
            this.time_vsgo.Text = "0:00:00";
            this.time_vsgo.Click += new System.EventHandler(this.Time_vsgo_Click);
            // 
            // tb_volume
            // 
            this.tb_volume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_volume.BackColor = System.Drawing.Color.DimGray;
            this.tb_volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_volume.Location = new System.Drawing.Point(825, 638);
            this.tb_volume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_volume.Maximum = 100;
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(226, 69);
            this.tb_volume.TabIndex = 9;
            this.tb_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_volume.Value = 50;
            this.tb_volume.Scroll += new System.EventHandler(this.tb_volume_Scroll);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(28, 55);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 468);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cont_men_pl_paus,
            this.cont_men_stop,
            this.cont_men_back,
            this.cont_men_next,
            this.toolStripSeparator2,
            this.cont_men_del,
            this.cont_men_del_vse,
            this.cont_men_open,
            this.cont_men_sver_pl});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 266);
            // 
            // cont_men_pl_paus
            // 
            this.cont_men_pl_paus.Enabled = false;
            this.cont_men_pl_paus.Name = "cont_men_pl_paus";
            this.cont_men_pl_paus.Size = new System.Drawing.Size(245, 32);
            this.cont_men_pl_paus.Text = "play/pause";
            this.cont_men_pl_paus.Click += new System.EventHandler(this.cont_men_pl_paus_Click);
            // 
            // cont_men_stop
            // 
            this.cont_men_stop.Enabled = false;
            this.cont_men_stop.Name = "cont_men_stop";
            this.cont_men_stop.Size = new System.Drawing.Size(245, 32);
            this.cont_men_stop.Text = "stop";
            this.cont_men_stop.Click += new System.EventHandler(this.cont_men_stop_Click);
            // 
            // cont_men_back
            // 
            this.cont_men_back.Enabled = false;
            this.cont_men_back.Name = "cont_men_back";
            this.cont_men_back.Size = new System.Drawing.Size(245, 32);
            this.cont_men_back.Text = "back";
            this.cont_men_back.Click += new System.EventHandler(this.cont_men_back_Click);
            // 
            // cont_men_next
            // 
            this.cont_men_next.Enabled = false;
            this.cont_men_next.Name = "cont_men_next";
            this.cont_men_next.Size = new System.Drawing.Size(245, 32);
            this.cont_men_next.Text = "next";
            this.cont_men_next.Click += new System.EventHandler(this.cont_men_next_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(242, 6);
            // 
            // cont_men_del
            // 
            this.cont_men_del.Enabled = false;
            this.cont_men_del.Name = "cont_men_del";
            this.cont_men_del.Size = new System.Drawing.Size(245, 32);
            this.cont_men_del.Text = "Удалить песню";
            this.cont_men_del.Click += new System.EventHandler(this.cont_men_del_Click);
            // 
            // cont_men_del_vse
            // 
            this.cont_men_del_vse.Enabled = false;
            this.cont_men_del_vse.Image = global::player.Properties.Resources.edit_clear_1289;
            this.cont_men_del_vse.Name = "cont_men_del_vse";
            this.cont_men_del_vse.Size = new System.Drawing.Size(245, 32);
            this.cont_men_del_vse.Text = "Очистить плейлист";
            this.cont_men_del_vse.Click += new System.EventHandler(this.cont_men_del_vse_Click);
            // 
            // cont_men_open
            // 
            this.cont_men_open.Image = global::player.Properties.Resources.openfolder;
            this.cont_men_open.Name = "cont_men_open";
            this.cont_men_open.Size = new System.Drawing.Size(245, 32);
            this.cont_men_open.Text = "Открыть";
            this.cont_men_open.Click += new System.EventHandler(this.cont_men_open_Click);
            // 
            // cont_men_sver_pl
            // 
            this.cont_men_sver_pl.Name = "cont_men_sver_pl";
            this.cont_men_sver_pl.Size = new System.Drawing.Size(245, 32);
            this.cont_men_sver_pl.Text = "Свернуть плейлист";
            this.cont_men_sver_pl.Click += new System.EventHandler(this.cont_men_sver_pl_Click);
            // 
            // tb_balanc
            // 
            this.tb_balanc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_balanc.BackColor = System.Drawing.Color.DimGray;
            this.tb_balanc.Location = new System.Drawing.Point(28, 638);
            this.tb_balanc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_balanc.Maximum = 1000;
            this.tb_balanc.Minimum = -1000;
            this.tb_balanc.Name = "tb_balanc";
            this.tb_balanc.Size = new System.Drawing.Size(242, 69);
            this.tb_balanc.TabIndex = 11;
            this.tb_balanc.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_balanc.Scroll += new System.EventHandler(this.tb_balanc_Scroll);
            // 
            // time_tek
            // 
            this.time_tek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.time_tek.AutoSize = true;
            this.time_tek.BackColor = System.Drawing.Color.DimGray;
            this.time_tek.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.time_tek.Location = new System.Drawing.Point(24, 583);
            this.time_tek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_tek.Name = "time_tek";
            this.time_tek.Size = new System.Drawing.Size(62, 20);
            this.time_tek.TabIndex = 13;
            this.time_tek.Text = "0:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 535);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 535);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 16;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackgroundImage = global::player.Properties.Resources.value_play;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(765, 637);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 42);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_play
            // 
            this.bt_play.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_play.BackgroundImage = global::player.Properties.Resources.play;
            this.bt_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_play.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_play.Location = new System.Drawing.Point(461, 637);
            this.bt_play.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_play.Name = "bt_play";
            this.bt_play.Size = new System.Drawing.Size(54, 54);
            this.bt_play.TabIndex = 1;
            this.bt_play.UseVisualStyleBackColor = true;
            this.bt_play.Click += new System.EventHandler(this.bt_play_Click);
            this.bt_play.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_play_MouseDown);
            this.bt_play.MouseEnter += new System.EventHandler(this.bt_play_MouseEnter);
            this.bt_play.MouseLeave += new System.EventHandler(this.bt_play_MouseLeave);
            this.bt_play.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_play_MouseUp);
            // 
            // bt_next
            // 
            this.bt_next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_next.BackgroundImage = global::player.Properties.Resources.next_;
            this.bt_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_next.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_next.Location = new System.Drawing.Point(585, 638);
            this.bt_next.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(54, 54);
            this.bt_next.TabIndex = 4;
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            this.bt_next.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_next_MouseDown);
            this.bt_next.MouseEnter += new System.EventHandler(this.bt_next_MouseEnter);
            this.bt_next.MouseLeave += new System.EventHandler(this.bt_next_MouseLeave);
            this.bt_next.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_next_MouseUp);
            // 
            // bt_stop
            // 
            this.bt_stop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_stop.BackgroundImage = global::player.Properties.Resources.stop;
            this.bt_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_stop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_stop.Location = new System.Drawing.Point(523, 638);
            this.bt_stop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(54, 54);
            this.bt_stop.TabIndex = 3;
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            this.bt_stop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_stop_MouseDown);
            this.bt_stop.MouseEnter += new System.EventHandler(this.bt_stop_MouseEnter);
            this.bt_stop.MouseLeave += new System.EventHandler(this.bt_stop_MouseLeave);
            this.bt_stop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_stop_MouseUp);
            // 
            // bt_back
            // 
            this.bt_back.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_back.BackgroundImage = global::player.Properties.Resources.back;
            this.bt_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_back.Location = new System.Drawing.Point(399, 637);
            this.bt_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(54, 54);
            this.bt_back.TabIndex = 2;
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            this.bt_back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_back_MouseDown);
            this.bt_back.MouseEnter += new System.EventHandler(this.bt_back_MouseEnter);
            this.bt_back.MouseLeave += new System.EventHandler(this.bt_back_MouseLeave);
            this.bt_back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_back_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(451, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 468);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // A_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1070, 702);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.time_tek);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tb_balanc);
            this.Controls.Add(this.tb_volume);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_play);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.time_vsgo);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.trackBar1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(458, 291);
            this.Name = "A_player";
            this.Text = "Аудио плеер";
            this.Load += new System.EventHandler(this.A_player_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_volume)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_balanc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open_m;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem men_exit;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem men_spr;
        private System.Windows.Forms.ToolStripMenuItem min_about;
        private System.Windows.Forms.Button bt_play;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_vsgo;
        private System.Windows.Forms.TrackBar tb_volume;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem delete_men;
        private System.Windows.Forms.ToolStripMenuItem men_del_tek;
        private System.Windows.Forms.ToolStripMenuItem Men_del_vse;
        private System.Windows.Forms.TrackBar tb_balanc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem men_pllist_ot;
        private System.Windows.Forms.Label time_tek;
        private System.Windows.Forms.ToolStripMenuItem роизведениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem men_pl_pau;
        private System.Windows.Forms.ToolStripMenuItem men_stop;
        private System.Windows.Forms.ToolStripMenuItem men_next;
        private System.Windows.Forms.ToolStripMenuItem men_back;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cont_men_pl_paus;
        private System.Windows.Forms.ToolStripMenuItem cont_men_stop;
        private System.Windows.Forms.ToolStripMenuItem cont_men_back;
        private System.Windows.Forms.ToolStripMenuItem cont_men_next;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cont_men_del;
        private System.Windows.Forms.ToolStripMenuItem cont_men_del_vse;
        private System.Windows.Forms.ToolStripMenuItem cont_men_open;
        private System.Windows.Forms.ToolStripMenuItem cont_men_sver_pl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
    }
}

