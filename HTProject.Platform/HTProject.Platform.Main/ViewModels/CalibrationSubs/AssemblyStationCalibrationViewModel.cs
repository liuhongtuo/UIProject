﻿using Caliburn.Micro;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Platform.Main.ViewModels.CalibrationSubs
{
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    [ImplementPropertyChanged]
    public class AssemblyStationCalibrationViewModel : Screen
    {
    }
}
