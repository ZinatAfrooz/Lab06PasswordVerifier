Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim strPassword As String
        Dim isValidPassword As Boolean

        strPassword = txtPassword.Text

        'verif if it is less than six charactres
        If strPassword.Length < 6 Then
            MessageBox.Show("The password should be at least six characters long")
        Else
            'calling the IsValid fucntion to veirfy the at least one numeric  and at least one alpha character
            isValidPassword = IsValid(strPassword)
            If isValidPassword = True Then
                MessageBox.Show("The password is valid")
            Else
                MessageBox.Show("The password should contain at least one numeric digit and at least one alphabetic character")
            End If
        End If

    End Sub

    Function IsValid(ByVal strPassword As String) As Boolean
        Dim boolNumric As Boolean
        Dim boolAlphabetic As Boolean

        For Each c As Char In strPassword
            If Char.IsLetter(c) Then boolAlphabetic = True
            If Char.IsNumber(c) Then boolNumric = True
        Next
        If boolAlphabetic And boolNumric Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
