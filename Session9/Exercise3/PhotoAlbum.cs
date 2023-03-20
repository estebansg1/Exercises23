using System;

public class PhotoAlbum
{
    private int numberOfPages;

    public PhotoAlbum()
    {
        numberOfPages = 16;
    }

    public PhotoAlbum(int pages)
    {
        numberOfPages = pages;
    }
    
    public int  GetNumberOfPages()
    {
        return numberOfPages;
    }
}

public class BigPhotoAlbum : PhotoAlbum
{
    public BigPhotoAlbum() : base(64)
    {
    }
}