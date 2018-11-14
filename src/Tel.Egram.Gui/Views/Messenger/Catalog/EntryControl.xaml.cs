﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Tel.Egram.Components.Messenger.Catalog;
using Tel.Egram.Components.Messenger.Catalog.Entries;

namespace Tel.Egram.Gui.Views.Messenger.Catalog
{
    public class EntryControl : BaseControl<EntryModel>
    {
        public EntryControl()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
