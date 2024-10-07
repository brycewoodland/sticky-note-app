namespace StickyNoteApp.Models
{
    public class BaseNote : INote
    {
        private int _id;
        private string _title;
        private string _content;
        private DateTime _createdDate;
        private DateTime _modifiedDate;

            public BaseNote(int id, string title, string content)
        {
            _id = id;
            _title = title;
            _content = content;
            _createdDate = DateTime.Now;
            _modifiedDate = DateTime.Now;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Title
        {
            get => _title;
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(value), "Title cannot be null or empty.");
                _title = value;
                _modifiedDate = DateTime.Now;
            }
        }

        public string Content 
        {
            get => _content;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(value), "Content cannot be null or empty.");
                _content = value;
                _modifiedDate = DateTime.Now;
            }
        }

        public DateTime CreatedDate 
        {
            get => _createdDate;
            private set => _createdDate = value;
        }

        public DateTime ModifiedDate
        {
            get => _modifiedDate;
            private set => _modifiedDate = value;
        }

        public void UpdateTitle(string newTitle)
        {
            Title = newTitle;
        }

        public void UpdateContent(string newContent)
        {
            Content = newContent;
        }

        public void UpdateModifiedDate(DateTime newModifiedDate)
        {
            ModifiedDate = newModifiedDate;
        }
    }
}