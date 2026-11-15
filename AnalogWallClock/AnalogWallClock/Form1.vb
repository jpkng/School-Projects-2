Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.TimeZoneInfo

Public Class Form1
    Inherits Form

    Private WithEvents timerClock As New Timer()
    Private lblDigital As New Label()
    Private lblDate As New Label()
    Private lblZone As New Label()

    Public Sub New()
        Me.DoubleBuffered = True
        Me.Text = "Modern Analog + Digital Clock"
        Me.BackColor = Color.FromArgb(20, 20, 25)
        Me.ClientSize = New Size(520, 600)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        ' Timer Setup
        timerClock.Interval = 1000
        timerClock.Start()

        ' Digital Time Label
        lblDigital.AutoSize = True
        lblDigital.Font = New Font("Segoe UI", 30, FontStyle.Bold)
        lblDigital.ForeColor = Color.FromArgb(0, 255, 150)
        lblDigital.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lblDigital)

        ' Date Label
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI", 13, FontStyle.Italic)
        lblDate.ForeColor = Color.LightGray
        lblDate.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lblDate)

        ' Time Zone Label
        lblZone.AutoSize = True
        lblZone.Font = New Font("Segoe UI", 11, FontStyle.Regular)
        lblZone.ForeColor = Color.Gray
        lblZone.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lblZone)
    End Sub

    Private Sub timerClock_Tick(sender As Object, e As EventArgs) Handles timerClock.Tick
        Dim now As DateTime = DateTime.Now
        lblDigital.Text = now.ToString("hh:mm:ss tt")
        lblDate.Text = now.ToString("dddd, MMMM dd, yyyy")

        ' Display local time zone (example: PHT (UTC+8))
        Dim tz As TimeZoneInfo = TimeZoneInfo.Local
        Dim offset As TimeSpan = tz.GetUtcOffset(DateTime.Now)
        Dim sign As String = If(offset.Hours >= 0, "+", "-")
        lblZone.Text = $"{tz.StandardName} (UTC{sign}{Math.Abs(offset.Hours)})"

        PositionLabels()
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim center As New Point(Me.ClientSize.Width \ 2, Me.ClientSize.Height \ 2 - 70)
        Dim radius As Integer = Math.Min(center.X, center.Y) - 40

        ' BACKGROUND GRADIENT (Subtle radial light)
        Using bgBrush As New LinearGradientBrush(Me.ClientRectangle,
                                                 Color.FromArgb(35, 35, 45),
                                                 Color.FromArgb(10, 10, 15),
                                                 LinearGradientMode.Vertical)
            g.FillRectangle(bgBrush, Me.ClientRectangle)
        End Using

        ' SHADOW behind clock
        Using shadowPath As New GraphicsPath()
            shadowPath.AddEllipse(center.X - radius - 6, center.Y - radius + 6, (radius * 2) + 12, (radius * 2) + 12)
            Using shadowBrush As New PathGradientBrush(shadowPath)
                shadowBrush.CenterColor = Color.FromArgb(60, 0, 0, 0)
                shadowBrush.SurroundColors = {Color.Transparent}
                g.FillEllipse(shadowBrush, center.X - radius - 10, center.Y - radius + 10, (radius * 2) + 20, (radius * 2) + 20)
            End Using
        End Using

        ' CLOCK FACE with soft gradient
        Using faceBrush As New LinearGradientBrush(New Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2),
                                                   Color.FromArgb(230, 230, 240),
                                                   Color.FromArgb(180, 180, 200),
                                                   LinearGradientMode.ForwardDiagonal)
            g.FillEllipse(faceBrush, center.X - radius, center.Y - radius, radius * 2, radius * 2)
        End Using

        ' Outer border ring
        Using borderPen As New Pen(Color.FromArgb(0, 255, 128), 5)
            g.DrawEllipse(borderPen, center.X - radius, center.Y - radius, radius * 2, radius * 2)
        End Using

        ' HOUR MARKS
        For i As Integer = 0 To 11
            Dim angle As Double = (Math.PI / 6) * i
            Dim inner As New Point(CInt(center.X + (radius - 15) * Math.Sin(angle)),
                                   CInt(center.Y - (radius - 15) * Math.Cos(angle)))
            Dim outer As New Point(CInt(center.X + radius * Math.Sin(angle)),
                                   CInt(center.Y - radius * Math.Cos(angle)))
            Using markPen As New Pen(Color.Black, 3)
                g.DrawLine(markPen, inner, outer)
            End Using
        Next

        ' NUMBERS
        Dim fontNum As New Font("Segoe UI", 15, FontStyle.Bold)
        For i As Integer = 1 To 12
            Dim angle As Double = (Math.PI / 6) * i
            Dim numX As Integer = CInt(center.X + (radius - 35) * Math.Sin(angle))
            Dim numY As Integer = CInt(center.Y - (radius - 35) * Math.Cos(angle))
            Dim numStr As String = i.ToString()
            Dim size As SizeF = g.MeasureString(numStr, fontNum)
            g.DrawString(numStr, fontNum, Brushes.Black, numX - size.Width / 2, numY - size.Height / 2)
        Next

        ' HANDS
        Dim now As DateTime = DateTime.Now
        Dim hourAngle As Double = ((now.Hour Mod 12) + now.Minute / 60.0) * Math.PI / 6
        Dim minuteAngle As Double = (now.Minute + now.Second / 60.0) * Math.PI / 30
        Dim secondAngle As Double = now.Second * Math.PI / 30

        ' Lengths
        Dim hourLength As Integer = CInt(radius * 0.5)
        Dim minuteLength As Integer = CInt(radius * 0.7)
        Dim secondLength As Integer = CInt(radius * 0.85)

        ' Endpoints
        Dim hourEnd As New Point(CInt(center.X + hourLength * Math.Sin(hourAngle)),
                                 CInt(center.Y - hourLength * Math.Cos(hourAngle)))
        Dim minuteEnd As New Point(CInt(center.X + minuteLength * Math.Sin(minuteAngle)),
                                   CInt(center.Y - minuteLength * Math.Cos(minuteAngle)))
        Dim secondEnd As New Point(CInt(center.X + secondLength * Math.Sin(secondAngle)),
                                   CInt(center.Y - secondLength * Math.Cos(secondAngle)))

        Using hourPen As New Pen(Color.FromArgb(40, 40, 40), 6)
            hourPen.EndCap = LineCap.Round
            hourPen.StartCap = LineCap.Round
            g.DrawLine(hourPen, center, hourEnd)
        End Using

        Using minutePen As New Pen(Color.FromArgb(0, 120, 255), 4)
            minutePen.EndCap = LineCap.Round
            minutePen.StartCap = LineCap.Round
            g.DrawLine(minutePen, center, minuteEnd)
        End Using

        Using glowPen As New Pen(Color.FromArgb(150, 255, 50, 50), 6)
            g.DrawLine(glowPen, center, secondEnd)
        End Using
        Using secondPen As New Pen(Color.Red, 2)
            g.DrawLine(secondPen, center, secondEnd)
        End Using

        g.FillEllipse(New SolidBrush(Color.Black), center.X - 6, center.Y - 6, 12, 12)
        g.DrawEllipse(New Pen(Color.FromArgb(0, 255, 128), 2), center.X - 6, center.Y - 6, 12, 12)
    End Sub

    Private Sub PositionLabels()
        lblDigital.Location = New Point((Me.ClientSize.Width - lblDigital.Width) \ 2,
                                        Me.ClientSize.Height - 110)
        lblDate.Location = New Point((Me.ClientSize.Width - lblDate.Width) \ 2,
                                     Me.ClientSize.Height - 70)
        lblZone.Location = New Point((Me.ClientSize.Width - lblZone.Width) \ 2,
                                     Me.ClientSize.Height - 40)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        PositionLabels()
    End Sub
End Class
