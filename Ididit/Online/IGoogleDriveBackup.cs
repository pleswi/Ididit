﻿using System.Threading.Tasks;

namespace Ididit.Online;

public interface IGoogleDriveBackup : IDataExport
{
    Task ImportData();
}
