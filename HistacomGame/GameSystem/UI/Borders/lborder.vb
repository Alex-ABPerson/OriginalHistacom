﻿Public Class lborder
    Private Sub lborder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.SizeWE
    End Sub

    Private Sub lborder_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        pull.Start()
    End Sub

    Private Sub lborder_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        pull.Stop()
    End Sub

    Private Sub pull_Tick(sender As Object, e As EventArgs) Handles pull.Tick
        FindForm.Width = Cursor.Position.X - FindForm.Location.X
    End Sub
End Class
