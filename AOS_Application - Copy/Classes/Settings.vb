
Namespace My

    'This class allows you to handle specific events on the settings class:
    ' The SettingChanging event is raised before a setting's value is changed.
    ' The PropertyChanged event is raised after a setting's value is changed.
    ' The SettingsLoaded event is raised after the setting values are loaded.
    ' The SettingsSaving event is raised before the setting values are saved.
    Partial Friend NotInheritable Class MySettings

        Public Function getSystemParameters() As Sysparameters
            Dim oSysparameters As New Sysparameters
            oSysparameters.Query.Where(oSysparameters.Query.RecordID.Equal(cSYSPARAMETERSRECORDID))
            oSysparameters.Query.Load()
            If oSysparameters.RecordID Is Nothing = False Then
                Return oSysparameters
            End If
            Return Nothing
        End Function

    End Class
End Namespace
