using System;
using Common;

namespace Toolyy.Models
{
    public class Werkzeug : NotifyPropertyChanged
    {
        #region --------- Fields, Constants, Delegates, Events ------------

        private int _id;
        private string _name;
        private string _category;
        private bool _available;
        private string _location;
        private string _geborgtVon;
        private DateTime? _geborgtAm;

        #endregion

        #region ---------- Constructors, Destructors, Dispose, Clone -------

        public Werkzeug()
        {
        }

        public Werkzeug(int id, string name, string category, bool available, string location)
        {
            _id = id;
            _name = name;
            _category = category;
            _available = available;
            _location = location;
        }

        #endregion

        #region --------- Properties, Indexers ----------------------------

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

        public string GeborgtVon
        {
            get => _geborgtVon;
            set
            {
                if (_geborgtVon != value)
                {
                    _geborgtVon = value;
                    OnPropertyChanged(nameof(GeborgtVon));
                }
            }
        }

        public DateTime? GeborgtAm
        {
            get => _geborgtAm;
            set
            {
                if (_geborgtAm != value)
                {
                    _geborgtAm = value;
                    OnPropertyChanged(nameof(GeborgtAm));
                }
            }
        }

        #endregion
    }
}
