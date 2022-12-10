using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows.Input;

namespace TheCouncilLibrary.Entities
{
    public class Manga : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private int _volumesExisting;
        private int _volumesObtained;
        private string _bookwalkerLink;
        private ReadingSourceType _sourceType;
        private ReadingStatus _status;
        private bool _complete;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        public int VolumesExisting
        {
            get
            {
                return _volumesExisting;
            }
            set
            {
                _volumesExisting = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VolumesExisting)));
            }
        }

        public int VolumesObtained
        {
            get
            {
                return _volumesObtained;
            }
            set
            {
                _volumesObtained = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VolumesObtained)));
            }
        }
        public string BookwalkerLink
        {
            get
            {
                return _bookwalkerLink;
            }
            set
            {
                _bookwalkerLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BookwalkerLink)));
            }
        }
        public ReadingSourceType SourceType
        {
            get
            {
                return _sourceType;
            }
            set
            {
                _sourceType = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SourceType)));
            }
        }
        public ReadingStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Status)));
            }
        }
        public bool Complete
        {
            get
            {
                return _complete;
            }
            set
            {
                _complete = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Complete)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public Manga()
        {
            _name = "";
            _bookwalkerLink = "";
        }

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public enum ReadingSourceType
    {
        Physical = 1,
        Digital = 2,
        Subscription = 3,
        DigitalAndSubscription = 4,
        Piracy = 5
    }

    public enum ReadingStatus
    {
        NotStarted = 1,
        Teaser = 2,
        InProgress = 3,
        Stalled = 4,
        Completed = 5,
        Dropped = 6
    }
}