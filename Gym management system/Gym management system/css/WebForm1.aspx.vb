Public Class WebForm1
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		Try
			If Session("nm") <> Nothing Then
				Label1.Text = Session("nm").ToString()
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub



	Private Sub Label1_Load(sender As Object, e As EventArgs) Handles Label1.Load

	End Sub
End Class