namespace SuperBook;

public class SuperPhotoBook
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

    public SuperPhotoBook()
	{
        _numPages = 16;
    }
}
