﻿namespace PhotoAlbum.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string FileName { get; set; } = string.Empty;

        public DateTime Creation { get; set; }
    }
}
