'Imports System
'Imports System.Security.Cryptography
'
'Public Module Calcute 'Module static classdir'
'    Function Sum(num as Integer, num2 as Integer) as Integer 'Function neyise return etmek ucundur'
'        Return num + num2
'    End Function
'
'    public Sub s(num as Integer, num2 as Integer) 'Sub ise "void" kimidir hecneyi return etmir'
'        Console.WriteLine(num + num2)
'    End Sub
'End Module
'
'Public Class Person
'    Public Property Name As String
'    Public Property Surname as String
'    Public Property Age as Integer
'
'    Public Sub New(name as String, surname as String, age as Integer)
'        Me.Name = name
'        Me.Surname = surname
'        Me.Age = age
'    End Sub
'
'    Public Overrides Function ToString() As String
'        Return $"{Name} {Surname} {Age}"
'    End Function
'End class
'
'Public class Student
'    Inherits Person
'    public Property Avg as Double
'
'    Public Sub New(name as String, surname as string, age as Integer, avg as Double)
'        MyBase.New(name, surname, age)
'        Me.Avg = avg
'    End Sub
'    
'    Public Overrides Function ToString() As String
'        return $"{MyBase.ToString()} {Avg}"
'    End Function
'End class
'
'public class Admin
'End class
'
'
'Module Program
'    Sub Main(args As String())
'
'        
'        dim student as new Student("elgun","quliyev",22,33.3)
'        Console.WriteLine(student)
'
'
'    End Sub
'End Module