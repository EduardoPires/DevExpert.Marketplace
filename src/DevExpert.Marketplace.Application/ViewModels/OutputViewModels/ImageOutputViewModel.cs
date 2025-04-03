using DevExpert.Marketplace.Application.Helpers;
using DevExpert.Marketplace.Business.Models;

namespace DevExpert.Marketplace.Application.ViewModels.OutputViewModels;

public class ImageOutputViewModel : OutputViewModelBase<Image, ImageOutputViewModel>
{
    public int DisplayPosition { get; private set; }
    public bool IsCover { get; private set; }
    public string? FilePath { get; set; }

    public override ImageOutputViewModel FromModel(Image? model)
    {
        if (model == null)
            return null;

        return new ImageOutputViewModel
        {
            Id = model.Id,
            DisplayPosition = model.DisplayPosition,
            IsCover = model.IsCover,
            FilePath = Path.Combine(
                Settings.Instance?.ProductImageDirectoryPath!,
                model.ProductId.ToString()!,
                model.Name!).Replace("\\", "/").Replace("//", "/"),
            AddedBy = model.AddedBy,
            AddedOn = model.AddedOn,
            ModifiedBy = model.ModifiedBy,
            ModifiedOn = model.ModifiedOn,
        };
    }
}