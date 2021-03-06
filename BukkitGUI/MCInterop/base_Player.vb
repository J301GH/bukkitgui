﻿'Player class, for players on the minecraft server.
'ported from beta
Namespace MCInterop
    Public Class Player
        Public name As String,
               IP As String,
               time As Date,
               WhiteList As Boolean,
               OP As Boolean,
               location As String,
               avatar As Image

        Public Sub New()
            name = ""
            IP = ""
            time = Date.Now
            WhiteList = False
            OP = False

            location = "unknown"
        End Sub

        Public Sub New(playername As String)
            name = playername
            IP = ""
            time = Date.Now
            WhiteList = False
            OP = False

            location = "unknown"
        End Sub

        Public Sub New(playername As String, PlayerIp As String)
            name = playername
            IP = PlayerIp
            time = Date.Now
            WhiteList = False
            OP = False

            location = "unknown"
        End Sub

        Public Shared Function FromSimplePlayer(player As SimplePlayer) As Player
            Dim p As New Player
            p.name = player.name
            p.IP = player.IP
            p.time = player.time
            p.WhiteList = False
            p.OP = False
            p.location = "unknown"

            Return p
        End Function

        Public Function MeFromSimplePlayer(player As SimplePlayer) As Player
            Me.name = player.name
            Me.IP = player.IP
            Me.time = player.time
            Me.WhiteList = False
            Me.OP = False
            Me.location = "unknown"

            Return Me
        End Function
    End Class

    Public Class SimplePlayer
        Public name As String, IP As String, time As Date

        Public Sub New()
            name = ""
            IP = ""
            time = Date.Now
        End Sub

        Public Sub New(playername As String)
            name = playername
            IP = ""
            time = Date.Now
        End Sub

        Public Sub New(playername As String, PlayerIp As String)
            name = playername
            IP = PlayerIp
            time = Date.Now
        End Sub

        Public Shared Function FromPlayer(player As Player) As SimplePlayer
            Dim p As New SimplePlayer
            p.name = player.name
            p.IP = player.IP
            p.time = player.time
            Return p
        End Function
    End Class
End Namespace