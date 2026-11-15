Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Private WithEvents timerClock As New Timer()

    Public Sub New()
        Me.DoubleBuffered = True
        Me.Text = "Analog Clock"
        Me.BackColor = Color.White
        Me.ClientSize = New Size(400, 400)
        Me.StartPosition = FormStartPosition.CenterScreen

        timerClock.Interval = 1000
        timerClock.Start()
    End Sub

    Private Sub timerClock_Tick(sender As Object, e As EventArgs) Handles timerClock.Tick
        Me.Invalidate() ' Redraw the clock each second
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim center As New Point(Me.ClientSize.Width \ 2, Me.ClientSize.Height \ 2)
        Dim radius As Integer = Math.Min(center.X, center.Y) - 20

        ' Draw clock face
        g.DrawEllipse(New Pen(Color.Black, 4), center.X - radius, center.Y - radius, radius * 2, radius * 2)

        ' Draw hour marks
        For i As Integer = 0 To 11
            Dim angle As Double = (Math.PI / 6) * i ' 30 degrees each
            Dim inner As New Point(CInt(center.X + (radius - 15) * Math.Sin(angle)),
                                   CInt(center.Y - (radius - 15) * Math.Cos(angle)))
            Dim outer As New Point(CInt(center.X + radius * Math.Sin(angle)),
                                   CInt(center.Y - radius * Math.Cos(angle)))
            g.DrawLine(New Pen(Color.Black, 2), inner, outer)
        Next

        ' Current time
        Dim now As DateTime = DateTime.Now

        ' Angles (in radians)
        Dim hourAngle As Double = ((now.Hour Mod 12) + now.Minute / 60.0) * Math.PI / 6
        Dim minuteAngle As Double = (now.Minute + now.Second / 60.0) * Math.PI / 30
        Dim secondAngle As Double = now.Second * Math.PI / 30

        ' Calculate hand endpoints
        Dim hourLength As Integer = CInt(radius * 0.5)
        Dim minuteLength As Integer = CInt(radius * 0.7)
        Dim secondLength As Integer = CInt(radius * 0.85)

        Dim hourEnd As New Point(CInt(center.X + hourLength * Math.Sin(hourAngle)),
                                 CInt(center.Y - hourLength * Math.Cos(hourAngle)))
        Dim minuteEnd As New Point(CInt(center.X + minuteLength * Math.Sin(minuteAngle)),
                                   CInt(center.Y - minuteLength * Math.Cos(minuteAngle)))
        Dim secondEnd As New Point(CInt(center.X + secondLength * Math.Sin(secondAngle)),
                                   CInt(center.Y - secondLength * Math.Cos(secondAngle)))

        ' Draw hour hand
        g.DrawLine(New Pen(Color.Black, 6), center, hourEnd)
        ' Draw minute hand
        g.DrawLine(New Pen(Color.DarkBlue, 4), center, minuteEnd)
        ' Draw second hand
        g.DrawLine(New Pen(Color.Red, 2), center, secondEnd)

        ' Draw center circle
        g.FillEllipse(Brushes.Black, center.X - 5, center.Y - 5, 10, 10)
    End Sub
End Class
