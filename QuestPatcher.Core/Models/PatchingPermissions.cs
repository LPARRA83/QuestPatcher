﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestPatcher.Core.Models
{
    /// <summary>
    /// Specifies which permissions will be added to the APK during patching
    /// </summary>
    public class PatchingPermissions
    {
        public bool ExternalFiles { get; set; } = true; // Not changeable in UI, since 90% of mods need this to work

        public bool Debuggable { get; set; } = false; // Allows debugging with GDB or LLDB

        public bool HandTracking { get; set; } = false; // Enables Oculus hand tracking permissions. Doesn't make the game use hand tracking - that's the job of a mod
    }
}
