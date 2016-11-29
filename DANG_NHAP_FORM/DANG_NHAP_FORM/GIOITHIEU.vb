Public Class frmGioiThieu
   
    Private Sub label1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles label1.LinkClicked
        Me.Capture = False
        System.Diagnostics.Process.Start( _
            "https://www.facebook.com/NewEpochProgram/")
    End Sub
End Class