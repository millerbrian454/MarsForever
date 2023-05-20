namespace MarsForever.Data
{
    public class Photo
    {
        public int photoId { get; set; }
        public int sol { get; set; }
        public string imageId { get; set; }
        public Camera camera { get; set; }
        public Rover rover { get; set; }
    }
}
