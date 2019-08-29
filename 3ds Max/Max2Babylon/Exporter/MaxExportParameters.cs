﻿using BabylonExport.Entities;

namespace Max2Babylon
{
    public class MaxExportParameters : ExportParameters
    {
        public Autodesk.Max.IINode exportNode;
        public bool usePreExportProcess = false;
        public bool mergeInheritedContainers = false;
        public bool flattenScene = false;
    }
}