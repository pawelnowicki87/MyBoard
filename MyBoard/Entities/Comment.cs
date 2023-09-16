namespace MyBoard.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public WorkItem WorkItem { get; set; }
        public int WorkItemId { get; set; }
    }
}
