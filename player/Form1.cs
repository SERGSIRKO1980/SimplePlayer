using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using WMPLib;



namespace player
{
    public partial class A_player : Form
    {
        public const int width = 15, height = 25, k = 15;
        public int[,] shape = new int[2, 4];
        public int[,] field = new int[width, height];
        public Bitmap bitfield = new Bitmap(k * (width + 1) + 1, k * (height + 3) + 1);
        public Graphics gr;

        List<string> pley_list = new List<string>();
        int count;
        int pol_zv = 10;
        bool zvuk = true;
        bool list = true;
        bool tip_vospr = true;
        int a = 0;
        
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        bool play_pause = true;

        public object FieldPictureBox1 { get; private set; }

        //  public object Field { get; private set; }

        public A_player()
        {
            InitializeComponent();

            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;

            label1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            button1.FlatAppearance.BorderSize = 0;
            bt_back.FlatAppearance.BorderSize = 0;
            bt_play.FlatAppearance.BorderSize = 0;
            bt_next.FlatAppearance.BorderSize = 0;
            bt_stop.FlatAppearance.BorderSize = 0;
            label1.ForeColor = Color.White; float fontSize = 14;
            label1.Font = new Font("Microsoft Sans Serif", fontSize);

            gr = Graphics.FromImage(bitfield);
            for (int i = 0; i < width; i++)
                field[i, height - 1] = 1;
            for (int i = 0; i < height; i++)
            {
                field[0, i] = 1;
                field[width - 1, i] = 1;
            }
            SetShape();
        }

        public void FillField()
        {
            gr.Clear(Color.Black); //Очистим поле
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    if (field[i, j] == 1)
                    { // Если клетка поля существует
                        gr.FillRectangle(Brushes.Green, i * k, j * k, k, k); // Рисуем в этом месте квадратик
                        gr.DrawRectangle(Pens.Black, i * k, j * k, k, k);
                    }
            for (int i = 0; i < 4; i++)
            { // Рисуем падающую фигуру
                gr.FillRectangle(Brushes.Red, shape[1, i] * k, shape[0, i] * k, k, k);
                gr.DrawRectangle(Pens.Black, shape[1, i] * k, shape[0, i] * k, k, k);
            }
            FieldPictureBox1 = bitfield;
        }
        private void TickTimer_Tick(object sender, System.EventArgs e)
        {
            if (field[8, 3] == 1)
                Environment.Exit(0);
            for (int i = 0; i < 4; i++)
                shape[0, i]++;
            for (int i = height - 2; i > 2; i--)
            {
                var cross = (from t in Enumerable.Range(0, field.GetLength(0)).Select(j => field[j, i]).ToArray() where t == 1 select t).Count();
                if (cross == width)
                    for (int k = i; k > 1; k--)
                        for (int l = 1; l < width - 1; l++)
                            field[l, k] = field[l, k - 1];
            }
            if (FindMistake())
            {
                for (int i = 0; i < 4; i++)
                    field[shape[1, i], --shape[0, i]]++;
                SetShape();
            }
            FillField();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    for (int i = 0; i < 4; i++)
                        shape[1, i]--;
                    if (FindMistake())
                        for (int i = 0; i < 4; i++)
                            shape[1, i]++;
                    break;
                case Keys.D:
                    for (int i = 0; i < 4; i++)
                        shape[1, i]++;
                    if (FindMistake())
                        for (int i = 0; i < 4; i++)
                            shape[1, i]--;
                    break;
                case Keys.W:
                    var shapeT = new int[2, 4];
                    Array.Copy(shape, shapeT, shape.Length);
                    int maxx = 0, maxy = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (shape[0, i] > maxy)
                            maxy = shape[0, i];
                        if (shape[1, i] > maxx)
                            maxx = shape[1, i];
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        int temp = shape[0, i];
                        shape[0, i] = maxy - (maxx - shape[1, i]) - 1;
                        shape[1, i] = maxx - (3 - (maxy - temp)) + 1;
                    }
                    if (FindMistake())
                        Array.Copy(shapeT, shape, shape.Length);
                    break;
            }
        }
        public bool FindMistake()
        {
            for (int i = 0; i < 4; i++)
                if (shape[1, i] >= width || shape[0, i] >= height ||
                    shape[1, i] <= 0 || shape[0, i] <= 0 ||
                    field[shape[1, i], shape[0, i]] == 1)
                    return true;
            return false;
        }

        public void SetShape()
        {
            Random x = new Random(DateTime.Now.Millisecond);
            switch (x.Next(7))
            {
                case 0: shape = new int[,] { { 2, 3, 4, 5 }, { 8, 8, 8, 8 } }; break;
                case 1: shape = new int[,] { { 2, 3, 2, 3 }, { 8, 8, 9, 9 } }; break;
                case 2: shape = new int[,] { { 2, 3, 4, 4 }, { 8, 8, 8, 9 } }; break;
                case 3: shape = new int[,] { { 2, 3, 4, 4 }, { 8, 8, 8, 7 } }; break;
                case 4: shape = new int[,] { { 3, 3, 4, 4 }, { 7, 8, 8, 9 } }; break;
                case 5: shape = new int[,] { { 3, 3, 4, 4 }, { 9, 8, 8, 7 } }; break;
                case 6: shape = new int[,] { { 3, 4, 4, 4 }, { 8, 7, 8, 9 } }; break;
            }
        }

        private void open_m_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "MP3 files|*.mp3|WMV files|*.wmv";
            open.FilterIndex = 1;

            if (open.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < open.FileNames.LongLength; i++)
                {
                   
                    try
                    {
                        if (listBox1.Items.Contains(open.FileNames.GetValue(i)) == false)
                        {
                            listBox1.Items.Add(open.SafeFileNames.GetValue(i));
                            count += 1;
                            pley_list.Add(open.FileNames[i]);
                            

                            cont_men_pl_paus.Enabled = true;
                            cont_men_back.Enabled = true;
                            cont_men_del.Enabled = true;
                            cont_men_del_vse.Enabled = true;
                            cont_men_next.Enabled = true;
                            cont_men_stop.Enabled = true;
                            men_back.Enabled = true;
                            men_del_tek.Enabled = true;
                            Men_del_vse.Enabled = true;
                            men_pl_pau.Enabled = true;
                            men_next.Enabled = true;
                            men_stop.Enabled = true;
                            delete_men.Enabled = true;
                        }
                    }catch{};

                }
                if (listBox1.SelectedIndex < 0) { listBox1.SetSelected(0, true); } 
         
            }         
          
        }

          private void bt_play_MouseLeave(object sender, EventArgs e)
          {
              if (play_pause)
              {
                  bt_play.BackgroundImage = Properties.Resources.play;
              }
              else {
                  bt_play.BackgroundImage = Properties.Resources.pause;
              }
          }

          private void bt_play_MouseDown(object sender, MouseEventArgs e)
          {
              
              if (play_pause)
              {
                  bt_play.BackgroundImage = Properties.Resources.play_yd;
              }
              else
              {
                  bt_play.BackgroundImage = Properties.Resources.pause_yd;
              }
          }

          private void bt_play_MouseEnter(object sender, EventArgs e)
          {
             
             if (play_pause)
             {
                 bt_play.BackgroundImage = Properties.Resources.play_poiv;
             }
             else
             {
                 bt_play.BackgroundImage = Properties.Resources.pause_poiv;
             }
          }

          private void bt_play_MouseUp(object sender, MouseEventArgs e)
          {
              if (play_pause)
              {
                  bt_play.BackgroundImage = Properties.Resources.play_poiv;
              }
              else
              {
                  bt_play.BackgroundImage = Properties.Resources.pause_poiv;
              }
          }

          private void bt_play_Click(object sender, EventArgs e)
          {
              
              if (play_pause)
              {
                if (pley_list.Count > 0 && (int)wmp.controls.currentPosition == 0)
                {
                    play_pause = false;
                    trackBar1.Enabled = true;
                    timer1.Enabled = true;
                    timer1.Interval = 1000;

                    listBox1.SetSelected(listBox1.SelectedIndex, true);
                    wmp.URL = pley_list[listBox1.SelectedIndex];
                    timer1.Start();

                    label1.Text = wmp.currentPlaylist.Item[0].name;
                    bt_play.BackgroundImage = Properties.Resources.pause;
                }
                else if (pley_list.Count > 0)
                {
                    label1.Text = wmp.currentPlaylist.Item[0].name;
                    play_pause = false;
                    wmp.controls.play();
                    bt_play.BackgroundImage = Properties.Resources.pause;
                }
                
                
            }
              else
              {
                if ((int)wmp.controls.currentPosition != 0)
                {
                    play_pause = true;
                    wmp.controls.pause();
                    bt_play.BackgroundImage = Properties.Resources.play;
                }
                else {
                   
                }
               
            }
             
          }
          private void MyClose()
          {
              if (MessageBox.Show("Закончить работу?", "Завершение работы",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button2) == DialogResult.Yes)
              {
                  Application.Exit();
                  
              }
          }
          private void men_exit_Click(object sender, EventArgs e)
          {
              MyClose();
          }

          private void min_about_Click(object sender, EventArgs e)
          {
              About about= new About();
              about.ShowDialog();
          }

          private void trackBar1_Scroll(object sender, EventArgs e)
          {
              wmp.controls.currentPosition = trackBar1.Value;
          }

          private void timer1_Tick(object sender, EventArgs e)
          {
              trackBar1.Maximum = Convert.ToInt32(wmp.currentMedia.duration);
              trackBar1.Value = Convert.ToInt32(wmp.controls.currentPosition);
              if (tip_vospr) {
            }
              if (wmp != null)
              {
               
                int s = (int)wmp.currentMedia.duration;
                  int h = s / 3600;
                  int m = (s - (h * 3600)) / 60;
                  s = s - (h * 3600 + m * 60);
                  time_vsgo.Text = String.Format("{0:D}:{1:D2}:{2:D2}", h, m, s);
                
                    s = (int)wmp.controls.currentPosition;
                    h = s / 3600;
                    m = (s - (h * 3600)) / 60;
                    s = s - (h * 3600 + m * 60);
                    time_tek.Text = String.Format("{0:D}:{1:D2}:{2:D2}", h, m, s);
               
                if ((int)wmp.controls.currentPosition + 2 == (int)wmp.currentMedia.duration)
                {
                    if (listBox1.Items.Count != 0)
                    {
                        if (listBox1.SelectedIndex != listBox1.Items.Count - 1)
                        {
                            listBox1.SetSelected(listBox1.SelectedIndex + 1, true);
                            wmp.URL = pley_list[listBox1.SelectedIndex];
                            label1.Text = wmp.currentPlaylist.Item[0].name;
                            bt_play.BackgroundImage = Properties.Resources.pause;
                            bt_play_Click(sender, e);
                        }
                        else
                        {
                            listBox1.SetSelected(listBox1.SelectedIndex - listBox1.Items.Count + 1, true);
                            wmp.URL = pley_list[listBox1.SelectedIndex];
                            label1.Text = wmp.currentPlaylist.Item[0].name;
                            bt_play.BackgroundImage = Properties.Resources.pause;
                            bt_play_Click(sender, e);
                        }

                    }
                }
            }
              else
              {
                  time_vsgo.Text = "0:00:00";
                  time_tek.Text = "0:00:00";
                
            }
          }

        

          private void bt_next_Click(object sender, EventArgs e)
          {
             
              if (listBox1.Items.Count != 0)
              {
                  if (listBox1.SelectedIndex != listBox1.Items.Count - 1)
                  {
                        listBox1.SetSelected(listBox1.SelectedIndex + 1, true);
                        wmp.URL = pley_list[listBox1.SelectedIndex];
                        label1.Text = wmp.currentPlaylist.Item[0].name;
                        bt_play.BackgroundImage = Properties.Resources.pause;
                    bt_stop_Click(sender, e);
                }
                  else {
                      listBox1.SetSelected(listBox1.SelectedIndex - listBox1.Items.Count+1, true);
                      wmp.URL = pley_list[listBox1.SelectedIndex];
                      label1.Text = wmp.currentPlaylist.Item[0].name;
                    bt_play.BackgroundImage = Properties.Resources.pause;
                    bt_stop_Click(sender, e);
                }
                
            }
          }

          private void bt_back_Click(object sender, EventArgs e)
          {
              if (listBox1.Items.Count != 0)
              {
                  if (listBox1.SelectedIndex != 0)
                  {
                      listBox1.SetSelected(listBox1.SelectedIndex - 1, true);
                      wmp.URL = pley_list[listBox1.SelectedIndex];
                      label1.Text = wmp.currentPlaylist.Item[0].name;
                    bt_play.BackgroundImage = Properties.Resources.pause;
                    bt_stop_Click(sender, e);
                }
                  else
                  {
                      listBox1.SetSelected(listBox1.SelectedIndex + listBox1.Items.Count-1 , true);
                      wmp.URL = pley_list[listBox1.SelectedIndex];
                      label1.Text = wmp.currentPlaylist.Item[0].name;
                    bt_play.BackgroundImage = Properties.Resources.pause;
                    bt_stop_Click(sender, e);
                }
                
            }
          }

          private void men_del_tek_Click(object sender, EventArgs e)
          {
              for (int i = 0; i < pley_list.Count; i++)
              {
                  if (i == listBox1.SelectedIndex)
                  {
                      time_vsgo.Text = "0:00:00";
                      time_tek.Text = "0:00:00";
                      cont_men_pl_paus.Enabled = false;
                      cont_men_back.Enabled = false;
                      cont_men_del.Enabled = false;
                      cont_men_del_vse.Enabled = false;
                      cont_men_next.Enabled = false;
                      cont_men_stop.Enabled = false;
                      men_back.Enabled = false;
                      men_del_tek.Enabled = false;
                      Men_del_vse.Enabled = false;
                      men_pl_pau.Enabled = false;
                      men_next.Enabled = false;
                      men_stop.Enabled = false;
                      delete_men.Enabled = false;
                      bt_stop_Click(sender,e);
                      pley_list.RemoveAt(i);
                     
                      break;
                  }
              }
              listBox1.Items.RemoveAt(listBox1.SelectedIndex);

          }

          private void Men_del_vse_Click(object sender, EventArgs e)
          {
                  time_vsgo.Text = "0:00:00";
                  time_tek.Text = "0:00:00";
                  cont_men_pl_paus.Enabled = false;
                  cont_men_back.Enabled = false;
                  cont_men_del.Enabled = false;
                  cont_men_del_vse.Enabled = false;
                  cont_men_next.Enabled = false;
                  cont_men_stop.Enabled = false;
                  men_back.Enabled = false;
                  men_del_tek.Enabled = false;
                  Men_del_vse.Enabled = false;
                  men_pl_pau.Enabled = false;
                  men_next.Enabled = false;
                  men_stop.Enabled = false;
                  delete_men.Enabled = false;
                  pley_list.Clear();
                  listBox1.Items.Clear();
                  wmp.controls.pause();
                  bt_play.BackgroundImage = Properties.Resources.pause;
                  play_pause = true;
                
          }

          private void men_spr_Click(object sender, EventArgs e)
          {
              Spravka spravka = new Spravka();
              spravka.ShowDialog();
          }

          private void tb_balanc_Scroll(object sender, EventArgs e)
          {
              wmp.settings.balance = tb_balanc.Value;
          }

          private void listBox1_DoubleClick(object sender, EventArgs e)
          {

            if (pley_list.Count > 0)
            {

                play_pause = false;
                trackBar1.Enabled = true;
                timer1.Enabled = true;
                timer1.Interval = 1000;

                listBox1.SetSelected(listBox1.SelectedIndex, true);
                wmp.URL = pley_list[listBox1.SelectedIndex];

                timer1.Start();

                label1.Text = wmp.currentPlaylist.Item[0].name;
                label1.ForeColor = Color.White;
                float fontSize = 14;
                label1.Font = new Font("Microsoft Sans Serif", fontSize);
                bt_play.BackgroundImage = Properties.Resources.pause;
            }
        }
       
            private void button1_Click(object sender, EventArgs e)
          {
              if (zvuk)
              {
                  pol_zv = tb_volume.Value;
                  wmp.settings.volume = 0;
                  tb_volume.Value = 0;
                  zvuk = false;
                button1.BackgroundImage = Properties.Resources.value_stop;
                
            }
              else {
                  tb_volume.Value = pol_zv;
              wmp.settings.volume = tb_volume.Value;
              zvuk = true; button1.BackgroundImage = Properties.Resources.value_play;
               
            }
          }

          private void men_pllist_ot_Click(object sender, EventArgs e)
          {
              if (list) { listBox1.Size= new Size(128,316); list = false;
              men_pllist_ot.Text = "Развернуть плейлист";
              cont_men_sver_pl.Text = "Развернуть плейлист"; 
              }
              else {listBox1.Size= new Size(480,316);
                  list = true;
              men_pllist_ot.Text = "Свернуть плейлист";
              cont_men_sver_pl.Text = "Свернуть плейлист";
              
              }
          }

 

          private void men_pl_pau_Click(object sender, EventArgs e)
          {
            
              bt_play_Click(sender, e);
          
          }

          private void men_stop_Click(object sender, EventArgs e)
          {
              bt_stop_Click(sender, e);
          }

          private void bmen_next_Click(object sender, EventArgs e)
          {
              bt_next_Click(sender, e);
          }

          private void men_back_Click(object sender, EventArgs e)
          {
              bt_back_Click(sender, e);
          }

          private void cont_men_pl_paus_Click(object sender, EventArgs e)
          {
              bt_play_Click(sender, e);

          }

          private void cont_men_stop_Click(object sender, EventArgs e)
          {
              bt_stop_Click(sender, e);
          }

          private void cont_men_back_Click(object sender, EventArgs e)
          {
              bt_back_Click(sender, e);
        }

          private void cont_men_next_Click(object sender, EventArgs e)
          {
              bt_next_Click(sender, e);
        }

          private void cont_men_del_Click(object sender, EventArgs e)
          {
              men_del_tek_Click(sender, e);
          }

          private void cont_men_del_vse_Click(object sender, EventArgs e)
          {
              Men_del_vse_Click(sender, e);
          }

          private void cont_men_open_Click(object sender, EventArgs e)
          {
              open_m_Click(sender, e);
          }

          private void cont_men_sver_pl_Click(object sender, EventArgs e)
          {
              men_pllist_ot_Click(sender, e);
          }

          private void bt_tip_vospr_Click(object sender, EventArgs e)
          {
              tip_vospr = false;
          }

        /// /////////////////////////////////////////
     
          private void bt_back_MouseLeave(object sender, EventArgs e)
          {
              bt_back.BackgroundImage = Properties.Resources.back;
          }

          private void bt_back_MouseDown(object sender, MouseEventArgs e)
          {
              bt_back.BackgroundImage = Properties.Resources.back_yd;
          }

          private void bt_back_MouseEnter(object sender, EventArgs e)
          {
              bt_back.BackgroundImage = Properties.Resources.back_poiv;
          }

          private void bt_back_MouseUp(object sender, MouseEventArgs e)
          {
              bt_back.BackgroundImage = Properties.Resources.back_poiv;
          }



          private void bt_next_MouseLeave(object sender, EventArgs e)
          {
              bt_next.BackgroundImage = Properties.Resources.next_;
          }

          private void bt_next_MouseDown(object sender, MouseEventArgs e)
          {
              bt_next.BackgroundImage = Properties.Resources.next_yd;
          }

          private void bt_next_MouseEnter(object sender, EventArgs e)
          {
              bt_next.BackgroundImage = Properties.Resources.next_poiv;
          }

          private void bt_next_MouseUp(object sender, MouseEventArgs e)
          {
              bt_next.BackgroundImage = Properties.Resources.next_poiv;

          }



          private void bt_stop_MouseLeave(object sender, EventArgs e)
          {
            bt_stop.BackgroundImage = Properties.Resources.stop;
        }

          private void bt_stop_MouseDown(object sender, MouseEventArgs e)
          {
            bt_stop.BackgroundImage = Properties.Resources.stop_yd;
        }

          private void bt_stop_MouseEnter(object sender, EventArgs e)
          {
            bt_stop.BackgroundImage = Properties.Resources.stop_poiv;
        }

          private void bt_stop_MouseUp(object sender, MouseEventArgs e)
          {
            bt_stop.BackgroundImage = Properties.Resources.stop_poiv;
        }

          private void tb_volume_Scroll(object sender, EventArgs e)
          {
              wmp.settings.volume = tb_volume.Value;

          }

          private void bt_stop_Click(object sender, EventArgs e)
          {
              wmp.controls.stop();
              bt_play.BackgroundImage = Properties.Resources.play;
              play_pause = true;
          }

        private void Time_vsgo_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void A_player_Load(object sender, EventArgs e)
        {

        }


    }
    }

