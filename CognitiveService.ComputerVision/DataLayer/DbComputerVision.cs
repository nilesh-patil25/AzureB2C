namespace CognitiveService.ComputerVision.DataLayer
{
    public class dbComputerVision
    {

        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string Tags { get; set; }
        public string ObjectDetection { get; set; }
        public string FaceDetection { get; set; }

        public string ImageColorScheme { get; set; }

        public string ImageType { get; set; }

    
            
    }
}
