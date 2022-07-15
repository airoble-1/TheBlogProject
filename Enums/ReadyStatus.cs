using System.ComponentModel.DataAnnotations;

namespace TheBlogProject.Enums
{
    public enum ReadyStatus
    {
        
        Incomplete,
        [Display(Name = "Production ready")]
        ProductionReady,
        [Display(Name = "Preview ready")]
        PreviewReady
    }
}
