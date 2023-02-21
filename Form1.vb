Imports System.Reflection
Imports System.IO

Public Class Launcher
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Public Shared APPLICATION_ID As String = "" ' CLASSIFIED
    Public APP_Details As String = "in the Launcher"
    Public APP_State As String = "thinking on what to play..."
    Public APP_LargeImageName As String = "scramreborn"
    Public APP_LargeImageText As String = "Scram Reborn"
    Public APP_SmallImageName As String = ""
    Public APP_SmallImageText As String = "discord.me/scram"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Handlers As DiscordEventHandlers = New DiscordEventHandlers With {.Ready = AddressOf IsReady}

        Discord_Initialize(APPLICATION_ID, Handlers, 1, 0)

        Dim Presence As DiscordRichPresence = New DiscordRichPresence With {.Details = APP_Details, .State = APP_State, .LargeImageKey = APP_LargeImageName, .LargeImageText = APP_LargeImageText, .SmallImageKey = APP_SmallImageName, .SmallImageText = APP_SmallImageText}

        Discord_UpdatePresence(Presence)
    End Sub

    Public Shared Sub IsReady(ByRef Request As DiscordUser)
        Diagnostics.Debug.Print("Discord initialized successfully!")
    End Sub


    Private Sub Launcher_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Launcher_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Launcher_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell(".\2019\Scram.bat")

        APP_Details = "scram 2019"
        APP_LargeImageName = "scram2019"
        APP_State = "killing some peanuts"
        APP_SmallImageName = "scramreborn"

        Dim Presence As DiscordRichPresence = New DiscordRichPresence With {.Details = APP_Details, .State = APP_State, .LargeImageKey = APP_LargeImageName, .LargeImageText = APP_LargeImageText, .SmallImageKey = APP_SmallImageName, .SmallImageText = APP_SmallImageText}

        Discord_UpdatePresence(Presence)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("Explorer.exe https://discord.com/invite/gdBvwXkdy2")
    End Sub

    Private Sub gotoTS_Click(sender As Object, e As EventArgs)
        Shell("Explorer.exe https://discord.com/invite/gdBvwXkdy2/")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Shell("Explorer.exe steam://url/SteamWorkshopPage/705210")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel2017.Hide()
        Panel2019.Show()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Panel2019.Hide()
        Panel2017.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Shell(".\2017\Scram.exe")

        APP_Details = "scram 2017"
        APP_LargeImageName = "scram2017"
        APP_State = "killing some peanuts"
        APP_SmallImageName = "scramreborn"

        Dim Presence As DiscordRichPresence = New DiscordRichPresence With {.Details = APP_Details, .State = APP_State, .LargeImageKey = APP_LargeImageName, .LargeImageText = APP_LargeImageText, .SmallImageKey = APP_SmallImageName, .SmallImageText = APP_SmallImageText}

        Discord_UpdatePresence(Presence)
    End Sub

End Class
