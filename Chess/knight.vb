Public Class knight
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
        '!!fornt left
        If x_pos + 2 <= 7 And y_pos - 1 >= 0 Then
            If Form1.ga.board(x_pos + 2, y_pos - 1) <= 0 Then
                flags(x_pos + 2, y_pos - 1) = True
            End If
        End If

        '!!fornt right
        If x_pos + 2 <= 7 And y_pos + 1 <= 7 Then
            If Form1.ga.board(x_pos + 2, y_pos + 1) <= 0 Then
                flags(x_pos + 2, y_pos + 1) = True
            End If
        End If

        '!!Back left
        If x_pos - 2 >= 0 And y_pos - 1 >= 0 Then
            If Form1.ga.board(x_pos - 2, y_pos - 1) <= 0 Then
                flags(x_pos - 2, y_pos - 1) = True
            End If
        End If

        '!!Back right
        If x_pos - 2 >= 0 And y_pos + 1 <= 7 Then
            If Form1.ga.board(x_pos - 2, y_pos + 1) <= 0 Then
                flags(x_pos - 2, y_pos + 1) = True
            End If
        End If


        '!!right back
        If x_pos - 1 >= 0 And y_pos + 2 <= 7 Then
            If Form1.ga.board(x_pos - 1, y_pos + 2) <= 0 Then
                flags(x_pos - 1, y_pos + 2) = True
            End If
        End If

        '!!right front
        If x_pos + 1 <= 7 And y_pos + 2 <= 7 Then
            If Form1.ga.board(x_pos + 1, y_pos + 2) <= 0 Then
                flags(x_pos + 1, y_pos + 2) = True
            End If
        End If

        '!!left back
        If x_pos - 1 >= 0 And y_pos - 2 >= 0 Then
            If Form1.ga.board(x_pos - 1, y_pos - 2) <= 0 Then
                flags(x_pos - 1, y_pos - 2) = True
            End If
        End If

        '!!left front
        If x_pos + 1 <= 7 And y_pos - 2 >= 0 Then
            If Form1.ga.board(x_pos + 1, y_pos - 2) <= 0 Then
                flags(x_pos + 1, y_pos - 2) = True
            End If
        End If

    End Sub

    Public Sub black_mov()
        '!!fornt left
        If x_pos + 2 <= 7 And y_pos - 1 >= 0 Then
            If Form1.ga.board(x_pos + 2, y_pos - 1) >= 0 Then
                flags(x_pos + 2, y_pos - 1) = True
            End If
        End If

        '!!fornt right
        If x_pos + 2 <= 7 And y_pos + 1 <= 7 Then
            If Form1.ga.board(x_pos + 2, y_pos + 1) >= 0 Then
                flags(x_pos + 2, y_pos + 1) = True
            End If
        End If

        '!!Back left
        If x_pos - 2 >= 0 And y_pos - 1 >= 0 Then
            If Form1.ga.board(x_pos - 2, y_pos - 1) >= 0 Then
                flags(x_pos - 2, y_pos - 1) = True
            End If
        End If

        '!!Back right
        If x_pos - 2 >= 0 And y_pos + 1 <= 7 Then
            If Form1.ga.board(x_pos - 2, y_pos + 1) >= 0 Then
                flags(x_pos - 2, y_pos + 1) = True
            End If
        End If


        '!!right back
        If x_pos - 1 >= 0 And y_pos + 2 <= 7 Then
            If Form1.ga.board(x_pos - 1, y_pos + 2) >= 0 Then
                flags(x_pos - 1, y_pos + 2) = True
            End If
        End If

        '!!right front
        If x_pos + 1 <= 7 And y_pos + 2 <= 7 Then
            If Form1.ga.board(x_pos + 1, y_pos + 2) >= 0 Then
                flags(x_pos + 1, y_pos + 2) = True
            End If
        End If

        '!!left back
        If x_pos - 1 >= 0 And y_pos - 2 >= 0 Then
            If Form1.ga.board(x_pos - 1, y_pos - 2) >= 0 Then
                flags(x_pos - 1, y_pos - 2) = True
            End If
        End If

        '!!left front
        If x_pos + 1 <= 7 And y_pos - 2 >= 0 Then
            If Form1.ga.board(x_pos + 1, y_pos - 2) >= 0 Then
                flags(x_pos + 1, y_pos - 2) = True
            End If
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
