using Naninovel;
using Naninovel.UI;
using UnityEngine;

public class MapScreen : CustomUI
{
    private LocationButton[] locationButtons;
    private GlobalMapServise mapServise;

    public override UniTask InitializeAsync()
    {
        locationButtons = GetComponentsInChildren<LocationButton>();
        mapServise = Engine.GetService<GlobalMapServise>();

        return base.InitializeAsync();
    }

    protected override void HandleVisibilityChanged(bool visible)
    {
        base.HandleVisibilityChanged(visible);

        if (visible)
        {
            UpdateButtons();
        }
    }

    protected void UpdateButtons()
    {
        foreach (var button in locationButtons)
        {
            button.SetAwaliable(mapServise.IsLocationAwaliable(button.LocationAlias));
            button.SetMarked(mapServise.MarkedLocation == button.LocationAlias);
        }
    }
}
