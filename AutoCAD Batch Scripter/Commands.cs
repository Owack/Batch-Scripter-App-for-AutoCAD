﻿using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;

namespace AutoCAD_Batch_Scripter
{
    public class BatchScripterDialog
    {
        [CommandMethod("OW:BatchScripter")]
        public void BatchScripter()
        {
            MainForm form = new MainForm();
            Application.ShowModalDialog(form);
        }
    }
}