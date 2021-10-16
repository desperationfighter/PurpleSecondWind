﻿namespace BuildingTweaks.Configuration
{
    using SMLHelper.V2.Json;
    using SMLHelper.V2.Options.Attributes;
    using UnityEngine;

    [Menu("BuildingTweaks")]
    public class Config: ConfigFile
    {

        internal bool AttachToTarget = false;
        internal bool FullOverride = false;

        [Keybind("Attach to Target Toggle Key")]
        public KeyCode AttachToTargetToggle = KeyCode.T;

        [Keybind("Full Override Toggle Key")]
        public KeyCode FullOverrideToggle = KeyCode.G;

    }
}
