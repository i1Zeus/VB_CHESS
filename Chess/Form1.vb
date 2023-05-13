Public Class Form1

    Public pb(7, 7) As PictureBox
    Public w_king As king
    Public w_queen As queen
    Public w_bishop(1) As bishop
    Public w_knight(1) As knight
    Public w_rook(1) As rook
    Public w_pawn(7) As pawn
    Public b_king As king
    Public b_queen As queen
    Public b_bishop(1) As bishop
    Public b_knight(1) As knight
    Public b_rook(1) As rook
    Public b_pawn(7) As pawn
    Public ga As game
    Public x, y, sel_x, sel_y As Integer
    Public selected As Boolean = False      '! this is to check if a piece is selected by player or not
    Public sel_piece As String = Nothing
    Public Seconds As Integer = 0
    Public Minutes As Integer = 0
    Private Sub Newgame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Newgame.Click
        pb = New PictureBox(7, 7) {{Me.p00, Me.p01, Me.p02, Me.p03, Me.p04, Me.p05, Me.p06, Me.p07},
                                {Me.p10, Me.p11, Me.p12, Me.p13, Me.p14, Me.p15, Me.p16, Me.p17},
                                {Me.p20, Me.p21, Me.p22, Me.p23, Me.p24, Me.p25, Me.p26, Me.p27},
                                {Me.p30, Me.p31, Me.p32, Me.p33, Me.p34, Me.p35, Me.p36, Me.p37},
                                {Me.p40, Me.p41, Me.p42, Me.p43, Me.p44, Me.p45, Me.p46, Me.p47},
                                {Me.p50, Me.p51, Me.p52, Me.p53, Me.p54, Me.p55, Me.p56, Me.p57},
                                {Me.p60, Me.p61, Me.p62, Me.p63, Me.p64, Me.p65, Me.p66, Me.p67},
                                {Me.p70, Me.p71, Me.p72, Me.p73, Me.p74, Me.p75, Me.p76, Me.p77}}   '! picture boxes on chessboard
        all_objects()
        ga.re_can_move()
        ga.show()
        ga.re_back()
        ga.fill_chk_for_black()
        ga.fill_chk_for_white()
        Seconds = 0
        Minutes = 0
        Timer1.Start()
    End Sub

    Public Sub all_objects()
        w_king = New king(0, 4, 1)
        w_queen = New queen(0, 3, 2)
        w_bishop(0) = New bishop(0, 2, 3)
        w_bishop(1) = New bishop(0, 5, 3)
        w_knight(0) = New knight(0, 1, 4)
        w_knight(1) = New knight(0, 6, 4)
        w_rook(0) = New rook(0, 0, 5)
        w_rook(1) = New rook(0, 7, 5)
        w_pawn(0) = New pawn(1, 0, 6)
        w_pawn(1) = New pawn(1, 1, 6)
        w_pawn(2) = New pawn(1, 2, 6)
        w_pawn(3) = New pawn(1, 3, 6)
        w_pawn(4) = New pawn(1, 4, 6)
        w_pawn(5) = New pawn(1, 5, 6)
        w_pawn(6) = New pawn(1, 6, 6)
        w_pawn(7) = New pawn(1, 7, 6)

        '! BLACK PIECES OBJECTS

        b_king = New king(7, 4, -1)
        b_queen = New queen(7, 3, -2)
        b_bishop(0) = New bishop(7, 2, -3)
        b_bishop(1) = New bishop(7, 5, -3)
        b_knight(0) = New knight(7, 1, -4)
        b_knight(1) = New knight(7, 6, -4)
        b_rook(0) = New rook(7, 0, -5)
        b_rook(1) = New rook(7, 7, -5)
        b_pawn(0) = New pawn(6, 0, -6)
        b_pawn(1) = New pawn(6, 1, -6)
        b_pawn(2) = New pawn(6, 2, -6)
        b_pawn(3) = New pawn(6, 3, -6)
        b_pawn(4) = New pawn(6, 4, -6)
        b_pawn(5) = New pawn(6, 5, -6)
        b_pawn(6) = New pawn(6, 6, -6)
        b_pawn(7) = New pawn(6, 7, -6)

        ga = New game()

    End Sub             ''initialization of all objects

    Private Sub p00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p00.Click
        ga.re_back()
        x = 0
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If

    End Sub
    Private Sub p01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p01.Click
        ga.re_back()
        x = 0
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If

    End Sub
    Private Sub p02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p02.Click
        ga.re_back()
        x = 0
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If

    End Sub
    Private Sub p03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p03.Click
        ga.re_back()
        x = 0
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If

    End Sub
    Private Sub p04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p04.Click
        ga.re_back()
        x = 0
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If

    End Sub
    Private Sub p05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p05.Click
        ga.re_back()
        x = 0
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If

    End Sub
    Private Sub p06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p06.Click
        ga.re_back()
        x = 0
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If

    End Sub
    Private Sub p07_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p07.Click
        ga.re_back()
        x = 0
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If

    End Sub

    Private Sub p10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p10.Click
        ga.re_back()
        x = 1
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p11.Click
        ga.re_back()
        x = 1
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p12.Click
        ga.re_back()
        x = 1
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p13.Click
        ga.re_back()
        x = 1
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p14.Click
        ga.re_back()
        x = 1
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p15.Click
        ga.re_back()
        x = 1
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p16.Click
        ga.re_back()
        x = 1
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p17.Click
        ga.re_back()
        x = 1
        y = 7
        If selected <> True Then

            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub

    Private Sub p20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p20.Click
        ga.re_back()
        x = 2
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If

    End Sub
    Private Sub p21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p21.Click
        ga.re_back()
        x = 2
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p22.Click
        ga.re_back()
        x = 2
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p23.Click
        ga.re_back()
        x = 2
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p24.Click
        ga.re_back()
        x = 2
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p25.Click
        ga.re_back()
        x = 2
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p26.Click
        ga.re_back()
        x = 2
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p27.Click
        ga.re_back()
        x = 2
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub

    Private Sub p30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p30.Click
        ga.re_back()
        x = 3
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p31.Click
        ga.re_back()
        x = 3
        y = 1

        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()

        End If
    End Sub
    Private Sub p32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p32.Click
        ga.re_back()
        x = 3
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p33.Click
        ga.re_back()
        x = 3
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p34.Click
        ga.re_back()
        x = 3
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p35.Click
        ga.re_back()
        x = 3
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p36.Click
        ga.re_back()
        x = 3
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p37.Click
        ga.re_back()
        x = 3
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub

    Private Sub p40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p40.Click
        ga.re_back()
        x = 4
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p41.Click
        ga.re_back()
        x = 4
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p42.Click
        ga.re_back()
        x = 4
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p43.Click
        ga.re_back()
        x = 4
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p44.Click
        ga.re_back()
        x = 4
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p45.Click
        ga.re_back()
        x = 4
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p46.Click
        ga.re_back()
        x = 4
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p47.Click
        ga.re_back()
        x = 4
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub

    Private Sub p50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p50.Click
        ga.re_back()
        x = 5
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p51.Click
        ga.re_back()
        x = 5
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p52.Click
        ga.re_back()
        x = 5
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p53.Click
        ga.re_back()
        x = 5
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p54.Click
        ga.re_back()
        x = 5
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p55.Click
        ga.re_back()
        x = 5
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p56.Click
        ga.re_back()
        x = 5
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p57.Click
        ga.re_back()
        x = 5
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub

    Private Sub p60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p60.Click
        ga.re_back()
        x = 6
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p61.Click
        ga.re_back()
        x = 6
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p62.Click
        ga.re_back()
        x = 6
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p63.Click
        ga.re_back()
        x = 6
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p64.Click
        ga.re_back()
        x = 6
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p65.Click
        ga.re_back()
        x = 6
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p66.Click
        ga.re_back()
        x = 6
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p67.Click
        ga.re_back()
        x = 6
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub

    Private Sub p70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p70.Click
        ga.re_back()
        x = 7
        y = 0
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p71.Click
        ga.re_back()
        x = 7
        y = 1
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p72.Click
        ga.re_back()
        x = 7
        y = 2
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p73.Click
        ga.re_back()
        x = 7
        y = 3
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p74.Click
        ga.re_back()
        x = 7
        y = 4
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p75.Click
        ga.re_back()
        x = 7
        y = 5
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p76.Click
        ga.re_back()
        x = 7
        y = 6
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub
    Private Sub p77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p77.Click
        ga.re_back()
        x = 7
        y = 7
        If selected <> True Then
            ga.re_can_move()
            sel_piece = ga.selection(x, y)
            sel_x = x
            sel_y = y
            selected = True
        Else
            If ga.can_move(x, y) = True Then
                ga.mov(sel_piece, x, y, sel_x, sel_y)
            End If
            selected = False
            ga.show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000
        Seconds += 1
        If Seconds = 60 Then
            Minutes += 1
            Seconds = 0
        End If
        Label1.Text = "Timer: " & Minutes & " : " & Seconds
        Timer1.Start() '! Timer starts functioning
    End Sub
    Private Sub stopGame_Click(sender As Object, e As EventArgs) Handles stopGame.Click
        Timer1.Stop()
    End Sub
    Private Sub Reusme_Click(sender As Object, e As EventArgs) Handles Reusme.Click
        Timer1.Start()
    End Sub
End Class