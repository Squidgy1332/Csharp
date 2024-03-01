using TagLib;

namespace MP3_Player
{
    public class SongData
    {
        private string _Year;
        private string _Title;
        private string _Album;
        private string _Artist;
        private string _Genre;
        private byte[] _Cover;

        private string _SongUrl;
        TagLib.File CurrentSong;

        public SongData(string Songurl)
        {
            _SongUrl = Songurl;
            SetCerrentSongData();
        }

        private void SetCerrentSongData()
        {
            CurrentSong = TagLib.File.Create(_SongUrl);

            SetAlbum(CurrentSong.Tag.Album);
            SetArtist(CurrentSong.Tag.FirstPerformer);
            SetGenra(CurrentSong.Tag.FirstGenre);
            SetTitle(CurrentSong.Tag.Title);
            SetYear(CurrentSong.Tag.Year.ToString());

            if (CurrentSong.Tag.Pictures.Length > 0)
            {
                var picture = CurrentSong.Tag.Pictures[0];
                byte[] imageData = picture.Data.Data;
                SetImage(imageData);
            }
        }

        public void ChnageData(string ImgFilePath)
        {
            CurrentSong.Tag.Album = _Album;
            CurrentSong.Tag.Title = _Title;
            CurrentSong.Tag.Performers[0] = _Artist;
            CurrentSong.Tag.Genres[0] = _Genre;
            if(_Year == "")
            {
                CurrentSong.Tag.Year = 0;
            }
            else
            {
                CurrentSong.Tag.Year = UInt32.Parse(_Year);
            }

            if(ImgFilePath != "" && ImgFilePath != "File Path")
            {
                IPicture newPicture = new Picture(new ByteVector(GetCover()));
                CurrentSong.Tag.Pictures = new IPicture[] { newPicture };

                var picture = CurrentSong.Tag.Pictures[0];
                byte[] imageData = picture.Data.Data;
                SetImage(imageData);
            }
            CurrentSong.Save();
        }

        public void SetTitle(string Title)
        {
            _Title = Title;
        }

        public string GetTitle() 
        {
            return _Title;
        }

        public void SetAlbum(string Album)
        {
            _Album = Album;
        }

        public string GetAlbum()
        {
            return _Album;
        }

        public void SetYear(string Year)
        {
            _Year = Year;
        }

        public string GetYear()
        {
            return _Year;
        }

        public void SetArtist(string Artist)
        {
            _Artist = Artist;
        }

        public string GetArtist() 
        { 
            return _Artist; 
        }

        public void SetGenra(string Genra)
        {
            _Genre = Genra;
        }

        public string GetGenra()
        {
            return _Genre;
        }

        public string GetSongURL()
        {
            return _SongUrl;
        }

        public void SetImage(byte[] img)
        {
            _Cover = img;
        }

        public byte[] GetCover()
        {
            return _Cover;
        }
    }
}
