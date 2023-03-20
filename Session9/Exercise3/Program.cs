public class AlbumTest
{
    public static void Main(string[] args)
    {
        PhotoAlbum defaultAlbum = new PhotoAlbum();
        PhotoAlbum customAlbum = new PhotoAlbum(24);
        BigPhotoAlbum bigAlbum = new BigPhotoAlbum();

        Console.WriteLine("Default album has {0} pages.", defaultAlbum.GetNumberOfPages());
        Console.WriteLine("Custom album has {0} pages.", customAlbum.GetNumberOfPages());
        Console.WriteLine("Big album has {0} pages.", bigAlbum.GetNumberOfPages());
    }
}