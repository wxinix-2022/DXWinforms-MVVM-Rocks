using System;
using System.ComponentModel;

namespace Webinar.Data
{
    public class TrackInfo : INotifyPropertyChanged
    {
        public TrackInfo(int genreId)
        {
            GenreId = genreId;
        }

        public TrackInfo(int trackId, string name, int albumId, int mediaTypeId, int genreId, string composer,
            double milliseconds, double bytes)
        {
            TrackId = trackId;
            Name = name;
            AlbumId = albumId;
            MediaTypeId = mediaTypeId;
            GenreId = genreId;
            Composer = composer;
            Milliseconds = milliseconds;
            Bytes = bytes;
        }

        private int _trackId;

        public int TrackId
        {
            get => _trackId;
            set
            {
                if (_trackId == value) return;
                _trackId = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TrackId)));
            }
        }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (_name == value) return;
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        private int _albumId;

        public int AlbumId
        {
            get => _albumId;
            set
            {
                if (_albumId == value) return;
                _albumId = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AlbumId)));
            }
        }

        private int _mediaTypeId;

        public int MediaTypeId
        {
            get => _mediaTypeId;
            set
            {
                if (_mediaTypeId == value) return;
                _mediaTypeId = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MediaTypeId)));
            }
        }

        private int _genreId;

        public int GenreId
        {
            get => _genreId;
            set
            {
                if (_genreId == value) return;
                _genreId = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GenreId)));
            }
        }

        private string _composer;

        public string Composer
        {
            get => _composer;
            set
            {
                if (_composer == value) return;
                _composer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Composer)));
            }
        }

        private double _milliseconds;

        public double Milliseconds
        {
            get => _milliseconds;
            set
            {
                if (Math.Abs(_milliseconds - value) <= Tolerance) return;
                _milliseconds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Milliseconds)));
            }
        }

        private const double Tolerance = 0.001;

        private double _bytes;

        public double Bytes
        {
            get => _bytes;
            set
            {
                if (Math.Abs(_bytes - value) <= Tolerance) return;
                _bytes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bytes)));
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Milliseconds: {Milliseconds}, Composer: {Composer}";
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
