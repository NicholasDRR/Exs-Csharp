namespace Book;

public class PhotoBook
{
    private int _numPages;

    public int numPages 
    {
        get 
        {
            return _numPages;
        } 
        set 
        {
            _numPages = value;
        }
    }

    public PhotoBook()
    {
        _numPages = 16;
    }
    public PhotoBook(int numPages)
    {
        _numPages = numPages;
    }

    public int GetNumPage()
    {
        return numPages;
    }
    
}
