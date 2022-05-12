namespace Sim.Core;

public interface ICanvasConfigDialog<TModel> 
    : ICanvasCursor<TModel>
{
    void OnSettingContext(object sender, EventArgs eventArgs);

    void OnSettingFilledFlag(object sender, EventArgs eventArgs);

    void OnSettingHeight(object sender, EventArgs eventArgs);

    void OnSettingImagePath(object sender, ImageEventArgs imageEventArgs);

    void OnSettingRadiusWidth(object sender, EventArgs eventArgs);

    void OnSettingShapeColor(object sender, EventArgs eventArgs);

    void OnSettingTextFlag(object sender, EventArgs eventArgs);

    void SetingShapeHandler(object sender, EventArgs eventArgs);
}