Public Class clsUserControl

   Public Shared Function ShowUserControl(ByVal ctrlControl As Control, ByVal pnlUserControl As Panel) As Control

      ' Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
      pnlUserControl.Controls.Add(ctrlControl)
      ' die Position und Methode zum Andocken eines Steuerelements angeben.
      ctrlControl.Dock = DockStyle.Fill
      ' Steuerelement am Anfang der Reihenfolge anzeigen.
      ctrlControl.BringToFront()
      Return ctrlControl
   End Function

End Class
