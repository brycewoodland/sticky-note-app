namespace StickyNoteApp.Models
{
    public interface INote
    {
        int Id { get; }
        string Title { get; set; }
        string Content { get; set; }
        DateTime CreatedDate { get; }
        DateTime ModifiedDate { get; }
        void UpdateContent(string newContent);
        void UpdateModifiedDate(DateTime newModifiedDate);
        void UpdateTitle(string newTitle);
    }
}