using CognitiveService.ComputerVision.Service.Dto;

namespace CognitiveService.ComputerVision.Service
{
    public interface IComputerVisionService
    {

        Task<ImageAnalysisViewModel> AnalyzeImageUrl(string imageUrl );



    }
}
