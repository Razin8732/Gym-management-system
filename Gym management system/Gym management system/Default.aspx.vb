Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Home
	Inherits System.Web.UI.Page
	Public a As String = "ADMIN"
	Public b As String = "admin"
	Dim cnn As New SqlConnection("Data Source=DESKTOP-UGUH6CR;Initial Catalog=Gym;User ID=sa;Password=sabir@1996")

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

	End Sub

	Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Try
			Dim cmd As New SqlCommand
			Dim str As String
			cnn.Open()
			str = "select * from Login where uname='" & DropDownList1.SelectedItem.Text.Trim() & "'"
			cmd = New SqlCommand(str, cnn)
			Dim reader As SqlDataReader = cmd.ExecuteReader()
			If reader.Read() Then
				If TextBox2.Text = reader("pass").ToString() And DropDownList1.SelectedValue.ToString() = reader("utype").ToString() Then


					Session("nm") = reader("utype").ToString()
					Response.Redirect("WebForm1.aspx", False)

					reader.Close()
					cnn.Close()
				Else
					MsgBox("User Not Found!!", MsgBoxStyle.Critical)

				End If

			Else
				MsgBox("!!Error:")
				End If


			Catch ex As Exception
			MsgBox(ex.Message)
			MsgBox(ex.ToString)
		End Try

	End Sub
End Class