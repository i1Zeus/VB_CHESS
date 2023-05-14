Public Class queen
    Public x_pos, y_pos As Integer
    Public piece_val As Integer
    Private flags(7, 7) As Boolean
    Public check_the_king(7, 7) As Boolean

    Public Sub New(ByVal x, ByVal y, ByVal p_val)   '!color=+ve val if white color=-ve if black  
        x_pos = x
        y_pos = y
        piece_val = p_val
        re_flags()

    End Sub

    Public Function ret_x() As Integer
        Return x_pos
    End Function

    Public Function ret_y() As Integer
        Return y_pos
    End Function

    Public Function ret_val() As Integer
        Return piece_val
    End Function

    Public Function poss_mov() As Boolean(,)    '!'!to show possible moves
        re_flags()
        If piece_val > 0 Then
            white_mov()
        End If
        If piece_val < 0 Then
            black_mov()
        End If
        Return flags
    End Function

    Public Sub white_mov()
        Dim x As Integer = x_pos
        Dim y As Integer = y_pos

        '! diagnoal left bottom to top (backward) 
        While (x < 7 And y > 0)
            x = x + 1
            y = y - 1
            If Form1.ga.board(x, y) <= 0 Then
                flags(x, y) = True
                If Form1.ga.board(x, y) < 0 Then
                    Exit While
                End If
            Else
                Exit While
            End If
        End While

        '!diagnoal left bottom to top (forward) 
        x = x_pos
        y = y_pos
        While (x > 0 And y < 7)
            x = x - 1
            y = y + 1
            If Form1.ga.board(x, y) <= 0 Then
                flags(x, y) = True
                If Form1.ga.board(x, y) < 0 Then
                    Exit While
                End If
            Else
                Exit While
            End If
        End While


        '!diagnoal Right bottom to top (backward) 
        x = x_pos
        y = y_pos
        While (x < 7 And y < 7)
            x = x + 1
            y = y + 1
            If Form1.ga.board(x, y) <= 0 Then
                flags(x, y) = True
                If Form1.ga.board(x, y) < 0 Then
                    Exit While
                End If
            Else
                Exit While
            End If
        End While


        '!diagnoal Right bottom to top (forward) 
        x = x_pos
        y = y_pos
        While (x > 0 And y > 0)
            x = x - 1
            y = y - 1
            If Form1.ga.board(x, y) <= 0 Then
                flags(x, y) = True
                If Form1.ga.board(x, y) < 0 Then
                    Exit While
                End If
            Else
                Exit While
            End If
        End While

        '!horizonal and vertical
        If x_pos > 0 Then
            For i As Integer = x_pos - 1 To 0 Step -1
                If Form1.ga.board(i, y_pos) <= 0 Then
                    flags(i, y_pos) = True
                    If Form1.ga.board(i, y_pos) < 0 Then
                        Exit For
                    End If
                Else
                    Exit For
                End If
            Next
        End If
        If x_pos <= 7 Then
            For i As Integer = x_pos + 1 To 7
                If Form1.ga.board(i, y_pos) <= 0 Then
                    flags(i, y_pos) = True
                    If Form1.ga.board(i, y_pos) < 0 Then
                        Exit For
                    End If
                Else
                    Exit For
                End If
            Next
        End If

        '!this is for column'!

        If y_pos > 0 Then
            For i As Integer = y_pos - 1 To 0 Step -1
                If Form1.ga.board(x_pos, i) <= 0 Then
                    flags(x_pos, i) = True
                    If Form1.ga.board(x_pos, i) < 0 Then
                        Exit For
                    End If
                Else
                    Exit For
                End If
            Next
        End If
        If y_pos <= 7 Then
            For i As Integer = y_pos + 1 To 7
                If Form1.ga.board(x_pos, i) <= 0 Then
                    flags(x_pos, i) = True
                    If Form1.ga.board(x_pos, i) < 0 Then
                        Exit For
                    End If
                Else
                    Exit For
                End If
            Next
        End If

    End Sub

    Public Sub black_mov()
        Dim x As Integer = x_pos
        Dim y As Integer = y_pos

        '! diagnoal left bottom to top (backward) 
        While (x < 7 And y > 0)
            x = x + 1
            y = y - 1
            If Form1.ga.board(x, y) >= 0 Then
                flags(x, y) = True
                If Form1.ga.board(x, y) > 0 Then
                    Exit While
                End If
            Else
                Exit While
            End If
        End While

        '!diagnoal left bottom to top (forward) 
        x = x_pos
        y = y_pos
        While (x > 0 And y < 7)
            x = x - 1
            y = y + 1
            If Form1.ga.board(x, y) >= 0 Then
                flags(x, y) = True
                If Form1.ga.board(x, y) > 0 Then
                    Exit While
                End If
            Else
                Exit While
            End If
        End While


        '!diagnoal Right bottom to top (backward) 
        x = x_pos
        y = y_pos
        While (x < 7 And y < 7)
            x = x + 1
            y = y + 1
            If Form1.ga.board(x, y) >= 0 Then
                flags(x, y) = True
                If Form1.ga.board(x, y) > 0 Then
                    Exit While
                End If
            Else
                Exit While
            End If
        End While


        '!diagnoal Right bottom to top (forward) 
        x = x_pos
        y = y_pos
        While (x > 0 And y > 0)
            x = x - 1
            y = y - 1
            If Form1.ga.board(x, y) >= 0 Then
                flags(x, y) = True
                If Form1.ga.board(x, y) > 0 Then
                    Exit While
                End If
            Else
                Exit While
            End If
        End While

        '!horizonal and vertical
        If x_pos > 0 Then
            For i As Integer = x_pos - 1 To 0 Step -1
                If Form1.ga.board(i, y_pos) >= 0 Then
                    flags(i, y_pos) = True
                    If Form1.ga.board(i, y_pos) > 0 Then
                        Exit For
                    End If
                Else
                    Exit For
                End If
            Next
        End If
        If x_pos <= 7 Then
            For i As Integer = x_pos + 1 To 7
                If Form1.ga.board(i, y_pos) >= 0 Then
                    flags(i, y_pos) = True
                    If Form1.ga.board(i, y_pos) > 0 Then
                        Exit For
                    End If
                Else
                    Exit For
                End If
            Next
        End If

        '!this is for column

        If y_pos > 0 Then
            For i As Integer = y_pos - 1 To 0 Step -1
                If Form1.ga.board(x_pos, i) >= 0 Then
                    flags(x_pos, i) = True
                    If Form1.ga.board(x_pos, i) > 0 Then
                        Exit For
                    End If
                Else
                    Exit For
                End If
            Next
        End If
        If y_pos <= 7 Then
            For i As Integer = y_pos + 1 To 7
                If Form1.ga.board(x_pos, i) >= 0 Then
                    flags(x_pos, i) = True
                    If Form1.ga.board(x_pos, i) > 0 Then
                        Exit For
                    End If
                Else
                    Exit For
                End If
            Next
        End If
    End Sub

    Public Sub re_flags()
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                flags(i, j) = False
            Next
        Next
    End Sub

    Public Sub fill_chk_king()
        poss_mov()
        For i As Integer = 0 To 7
            For j As Integer = 0 To 7
                If flags(i, j) = True Then
                    check_the_king(i, j) = True
                Else
                    check_the_king(i, j) = False
                End If
            Next
        Next
    End Sub

    Public Sub change_pos(ByVal x, ByVal y, ByVal pre_x, ByVal pre_y)
        Form1.ga.board(x, y) = Form1.ga.board(pre_x, pre_y)
        Form1.ga.board(pre_x, pre_y) = 0
        x_pos = x
        y_pos = y
    End Sub
End Class
