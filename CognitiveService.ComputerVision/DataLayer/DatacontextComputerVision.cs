using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CognitiveService.ComputerVision.DataLayer
{
    public class datacontextComputerVision
    {

        [Table("Department", Schema = "dbo")]
        public class Department
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Display(Name = "Id")]
            public int Id { get; set; }

            [Required]
            [Column(TypeName = "varchar(max)")]
            [Display(Name = "ImageUrl")]
            public string ImageUrl { get; set; }

            [Required]
            [Column(TypeName = "varchar(max)")]
            [Display(Name = "Description")]
            public string Description { get; set; }

            [Required]
            [Column(TypeName = "varchar(max)")]
            [Display(Name = "Tags")]
            public string Tags { get; set; }

            [Required]
            [Column(TypeName = "varchar(max)")]
            [Display(Name = "ObjectDetection")]
            public string ObjectDetection { get; set; }

            [Required]
            [Column(TypeName = "varchar(max)")]
            [Display(Name = "FaceDetection")]
            public string FaceDetection { get; set; }

            [Required]
            [Column(TypeName = "varchar(max)")]
            [Display(Name = "ImageColorScheme")]
            public string ImageColorScheme { get; set; }

            [Required]
            [Column(TypeName = "varchar(max)")]
            [Display(Name = "ImageType")]
            public string ImageType { get; set; }



           





        }


    }
}
