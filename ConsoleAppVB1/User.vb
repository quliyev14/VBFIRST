Public Class User(of T)
    Public Property Name as T
    public Property Surname as T
    Public Property Age as integer

    Public Sub New(name as T, surname as T, age as Integer)
        Me.Name = name
        Me.Surname = surname
        Me.Age = age
    End Sub

    public overrides Function ToString() as String
        Return $"{Name} {Surname} {Age}"
    End Function
End Class