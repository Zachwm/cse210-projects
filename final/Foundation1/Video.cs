class zmVideo
{
    public string zmTitle;
    public string zmAuthor;
    public int zmLength;

    public zmVideo(string title, string author, int length)
    {
        zmTitle = title;
        zmAuthor = author;
        zmLength = length;
    }

    public List<zmComment> zmComments = new List<zmComment>();

    public void AddComment(string commenter, string text)
    {
        zmComments.Add(new zmComment(commenter, text));
    }
}