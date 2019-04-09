using System;
using System.Text;
using System.IO;

namespace MP3TagEditor
{
    struct MP3
    {
        public string filePath;
        public string fileName;
        public string fileComplete;

        public bool hasID3Tag;

        public string id3Title;
        public string id3Artist;
        public string id3Album;
        public string id3Year;
        public string id3Comment;
        public byte id3TrackNumber;
        public byte id3Genre;

        public MP3(string path, string name)
        {
            this.filePath = path;
            this.fileName = name;
            this.fileComplete = path + "\\" + name;

            this.hasID3Tag = false;
            this.id3Title = null;
            this.id3Artist = null;
            this.id3Album = null;
            this.id3Year = null;
            this.id3Comment = null;
            this.id3TrackNumber = 0;
            this.id3Genre = 0;
        }
    }

    class MP3Tag
    {

        public enum genres : byte
        {
            Blues, 
            ClassicRock,
            Country,
            Dance,
            Disco,
            Funk,
            Grunge,
            HipHop,
            Jazz,
            Metal,
            NewAge,
            Oldies,
            Other,
            Pop,
            RnB,
            Rap,
            Reggae,
            Rock,
            Techno,
            Industrial,
            Alternative,
            Ska,
            DeathMetal,
            Pranks,
            Soundtrack,
            EuroTechno,
            Ambient,
            TripHop,
            Vocal,
            JazzFunk,
            Fusion,
            Trance,
            Classical,
            Instrumental,
            Acid,
            House,
            Game,
            SoundClip,
            Gospel,
            Noise,
            AlternRock,
            Bass,
            Soul,
            Punk,
            Space,
            Mediative,
            InstrumentalPop,
            InstrumentalRock,
            Ethnic,
            Gothic,
            Darkwave,
            TechnoIndustrial,
            Electronic,
            PopFolk,
            Eurodance,
            Dream,
            SouthernRock,
            Comedy,
            Cult,
            Gangsta,
            Top40,
            ChristianRap,
            PopFunk,
            Jungle,
            NativeAmerican,
            Cabaret,
            NewWave,
            Psychadelic,
            Rave,
            Showtunes,
            Trailer,
            LoFi,
            Tribal,
            AcidPunk,
            AcidJazz,
            Polka,
            Retro,
            Musical,
            RocknRoll,
            HardRock,
            None = 255
        };

        // ������ ���������� �� MP3-�����
        public static void ReadMP3Tag(ref MP3 paramMP3)
        {
            // ��������� ��������� 128 ���� (���� ID3) � �������� ������
            FileStream fs;
            fs = new FileStream(paramMP3.fileComplete, FileMode.Open);
            byte[] bBuffer = new byte[128];
            fs.Seek(-128, SeekOrigin.End);
            fs.Read(bBuffer, 0, 128);
            fs.Close();

            // ������������ ������ ������ � ������
            //Encoding instEncoding = new ASCIIEncoding();
            Encoding encoding = Encoding.GetEncoding(1251); 
            
            string id3Tag = encoding.GetString(bBuffer);

            // ���� ������� ������ TAG, ����� �������� ��������� ���������� 
            if (id3Tag.Substring(0, 3) == "TAG")
            {
                paramMP3.id3Title   = id3Tag.Substring(3, 30).Trim();  // �������� �����
                paramMP3.id3Artist  = id3Tag.Substring(33, 30).Trim(); // �����������
                paramMP3.id3Album   = id3Tag.Substring(63, 30).Trim(); // �������� �������
                paramMP3.id3Year    = id3Tag.Substring(93, 4).Trim();  // ��� �������
                paramMP3.id3Comment = id3Tag.Substring(97, 28).Trim(); // �����������

                // ������� ����� �����, ���� ������������ ID3 v1.1
                // ���������� ������������ ���� �� ��������� ����
                if (id3Tag[125] == 0)
                    paramMP3.id3TrackNumber = bBuffer[126];
                else
                    paramMP3.id3TrackNumber = 0;

                paramMP3.id3Genre = bBuffer[127];
                paramMP3.hasID3Tag = true;    
            }
            else
            {
                // ���� ���� ID3 �� �������, �� ������� ������ ������,
                // ����� ����� ������������ ��� �������� ���� ������
                paramMP3.id3Title = "";
                paramMP3.id3Artist = "";
                paramMP3.id3Album = "";
                paramMP3.id3Year = "";
                paramMP3.id3Comment = "";
                paramMP3.id3TrackNumber = 0;
                paramMP3.id3Genre = 0;
                paramMP3.hasID3Tag = false;
            }
        }

        // ��������� ���� � ����� MP3
        public static void SaveMP3Tag(ref MP3 paramMP3)
        {
            // ������� ����� �������
            paramMP3.id3Title = paramMP3.id3Title.Trim();
            paramMP3.id3Artist = paramMP3.id3Artist.Trim();
            paramMP3.id3Album = paramMP3.id3Album.Trim();
            paramMP3.id3Year = paramMP3.id3Year.Trim();
            paramMP3.id3Comment = paramMP3.id3Comment.Trim();

            // �� ��������� �������� ������ �� ���������� ������� �����
            if (paramMP3.id3Title.Length > 30)
                paramMP3.id3Title = paramMP3.id3Title.Substring(0, 30);
            if (paramMP3.id3Artist.Length > 30)
                paramMP3.id3Artist = paramMP3.id3Artist.Substring(0, 30);
            if (paramMP3.id3Album.Length > 30)
                paramMP3.id3Album = paramMP3.id3Album.Substring(0, 30);
            if (paramMP3.id3Year.Length > 4)
                paramMP3.id3Year = paramMP3.id3Year.Substring(0, 4);
            if (paramMP3.id3Comment.Length > 28)
                paramMP3.id3Comment = paramMP3.id3Comment.Substring(0, 28);

            // ������� ����� ��� ID3 (128 ����)
            byte[] tagByteArray = new byte[128];
            for (int i = 0; i < tagByteArray.Length; i++)
                tagByteArray[i] = 0; // ������������� ������� �� ��������� 0

            // ������������ ������ ������ � ������ ��������� Windows-1251
            Encoding encoding = Encoding.GetEncoding(1251); 
            
            // �������� "TAG" � ������
            byte[] newByteArray = encoding.GetBytes("TAG");
            Array.Copy(newByteArray, 0, tagByteArray, 0, newByteArray.Length);
            // �������� Title � ������
            newByteArray = encoding.GetBytes(paramMP3.id3Title);
            Array.Copy(newByteArray, 0, tagByteArray, 3, newByteArray.Length);
            // �������� Artist � ������
            newByteArray = encoding.GetBytes(paramMP3.id3Artist);
            Array.Copy(newByteArray, 0, tagByteArray, 33, newByteArray.Length);
            // �������� Album � ������
            newByteArray = encoding.GetBytes(paramMP3.id3Album);
            Array.Copy(newByteArray, 0, tagByteArray, 63, newByteArray.Length);
            // �������� Year � ������
            newByteArray = encoding.GetBytes(paramMP3.id3Year);
            Array.Copy(newByteArray, 0, tagByteArray, 93, newByteArray.Length);
            // �������� Comment � ������
            newByteArray = encoding.GetBytes(paramMP3.id3Comment);
            Array.Copy(newByteArray, 0, tagByteArray, 97, newByteArray.Length);

            // �������� Track � Genre � ������
            tagByteArray[126] = paramMP3.id3TrackNumber;
            tagByteArray[127] = paramMP3.id3Genre;

            // ��������� ��������� �� �����
            FileStream fs = new FileStream(paramMP3.fileComplete, FileMode.Open);
            if (paramMP3.hasID3Tag)
                fs.Seek(-128, SeekOrigin.End);
            else
                fs.Seek(0, SeekOrigin.End);
            fs.Write(tagByteArray, 0, 128);
            fs.Close();
            paramMP3.hasID3Tag = true;
        }
    }
}
