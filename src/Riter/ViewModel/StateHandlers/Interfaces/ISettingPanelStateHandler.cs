﻿using System.ComponentModel;

namespace Riter.ViewModel.StateHandlers;
public interface ISettingPanelStateHandler : INotifyPropertyChanged
{
    bool SettingPanelVisibility { get; }

    void SetSettingPanelInvisibile();

    void SetSettingPanelVisibile();

    void ToggleBrushSettingsPanel(string button);

    void ToggleSettingsPanel();
}
