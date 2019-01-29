Public Class Home
	Inherits System.Web.UI.Page
	Public a As String = "ADMIN"
	Public b As String = "admin"
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

	End Sub

	Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Try


			Dim c As String
			Dim d As String
			Dim s As String
			Dim lbl As String = DropDownList1.SelectedItem.Text
			s = DropDownList1.SelectedItem.Text
			c = Request.Form("Name1")
			d = Request.Form("Email1")
			If c = a Then
				If d = b Then
					Session("nm") = lbl
					Response.Redirect("WebForm1.aspx")
					'WebForm1.Label1.Text = ListBox1.SelectedValue
				End If
			Else
				MsgBox("wrong id or pass")
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
End Class