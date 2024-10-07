namespace StickyNoteApp.Models
{
    public class NoteManager
    {
        private List<INote> _notes;
        private int _nextId;

        public NoteManager()
        {
            _notes = new List<INote>();
            _nextId = 1;
        }

        public void AddNote(string title, string content)
        {

        }

        public void RemoveNote(int id)
        {

        }

        public void GetNoteById(int id)
        {

        }

        public void GetAllNotes(List<INote> notes)
        {

        }
        
        public void UpdateNote(int id, string title, string content)
        {

        }
    }
}