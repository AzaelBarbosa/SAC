﻿Public Class RANGOFECHASPARAFACTURACION

    Private Sub CDMREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CDMREPORTE.Click

        My.Forms.PAGOSALUMNOPARAFACTURAA.ShowDialog()
    End Sub

    Private Sub CMDSALIR_Click(sender As Object, e As EventArgs) Handles CMDSALIR.Click
        Me.Close()
    End Sub
End Class