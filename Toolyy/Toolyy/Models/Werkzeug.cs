using Common;

namespace Toolyy.Models
{
    public class Werkzeug : NotifyPropertyChanged
    {
        #region ---------Fields, Constants, Delegates, Events ------------

        private int _id;
        private string _name;
        private string _category;
        private bool _available;
        private string _location;

        #endregion

        #region ----------Constructors, Destructors, Dispose, Clone-------

        public Werkzeug()
        {
        }
        public Werkzeug(int id, string name, string category, bool available, string location)
        {
            Id = id;
            Name = name;
            Category = category;
            Available = available;
            Location = location;
        }

        #endregion

        #region---------Properties, Indexers ----------------------------

        public int Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Category
        {
            get => _category;
            set
            {
                if (_category != value)
                {
                    _category = value;
                    OnPropertyChanged(nameof(Category));
                }
            }
        }

        public bool Available
        {
            get => _available;
            set
            {
                if (_available != value)
                {
                    _available = value;
                    OnPropertyChanged(nameof(Available));
                }
            }
        }

        public string Location
        {
            get => _location;
            set
            {
                if (_location != value)
                {
                    _location = value;
                    OnPropertyChanged(nameof(Location));
                }
            }
        }

        #endregion
    }
}
