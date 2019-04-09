using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MP3TagEditor
{
    public partial class MP3Form : Form
    {
        

        public MP3Form()
        {
            InitializeComponent();
        }

        MP3 mp3file;

        private void butLoadMP3_Click(object sender, EventArgs e)
        {
            // Загружаем MP3-файл
            LoadMp3();
        }

        private void LoadMp3()
        {
            // Выбираем файл MP3
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "файлы MP3 (*.mp3)|*.mp3";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.Cancel) return;
            string fileName = fileDialog.FileName;

            FileInfo fFileInfo = new FileInfo(fileName);
            mp3file = new MP3(fFileInfo.DirectoryName, fFileInfo.Name);
            MP3Tag.ReadMP3Tag(ref mp3file);

            // Выводим полученную информацию на экран
            txtTitle.Text = mp3file.id3Title;
            txtArtist.Text = mp3file.id3Artist;
            txtAlbum.Text = mp3file.id3Album;
            txtYear.Text = mp3file.id3Year;
            txtComment.Text = mp3file.id3Comment;
            txtGenre.Text = mp3file.id3Genre.ToString();
            //cboGenres.SelectedIndex = mp3file.id3Genre;



            //cbo.SelectedItem = (value)10
            cboGenres.SelectedItem = (MP3Tag.genres)mp3file.id3Genre;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveMP3();
        }

        private void SaveMP3()
        {
            if (mp3file.id3Title == null) return;

            mp3file.id3Title = txtTitle.Text;
            mp3file.id3Artist = txtArtist.Text;
            mp3file.id3Album = txtAlbum.Text;
            mp3file.id3Year = txtYear.Text;
            mp3file.id3Comment = txtComment.Text;
            mp3file.id3Genre = Convert.ToByte(txtGenre.Text);

            MP3Tag.SaveMP3Tag(ref mp3file);
        }

        private void MP3Form_Load(object sender, EventArgs e)
        {
            //cboGenres.Items.Add("Блюз");
            //cboGenres.Items.Add("Классический рок");
            //cboGenres.Items.Add("Кантри");
            //cboGenres.Items.Add("Dance");
            //cboGenres.Items.Add("Диско");
            //cboGenres.Items.Add("Фанк");
            //cboGenres.Items.Add("Гранж");
            //cboGenres.Items.Add("Хип-Хоп");
            //cboGenres.Items.Add("Джаз");
            //cboGenres.Items.Add("Метал");
            //cboGenres.Items.Add("НьюЭйдж");
            //cboGenres.Items.Add("Oldies");
            //cboGenres.Items.Add("Другое");
            //cboGenres.Items.Add("Поп");

            //// дальше сами пишите
            //cboGenres.Items.Add("Не определен");


            //cbo.DataSource = Enum.GetValues(typeof(value)); 
            cboGenres.DataSource = Enum.GetValues(typeof(MP3Tag.genres));
        }
    }
}