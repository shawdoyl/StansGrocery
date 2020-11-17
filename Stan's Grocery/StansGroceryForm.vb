'Doyle Shaw
'RCET0265
'Fall 2020
'Stans Grocery Assignment
'https://github.com/shawdoyl/StansGrocery.git

Option Strict On
Option Explicit On
Option Compare Text

Imports System.Text.RegularExpressions
Public Class StansGroceryForm
    Dim finalarray2(255, 2), sortedLocations(16), sortedCategories(23) As String

    Public Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This group of text handles the initial splash screen.
        Timer1.Start()
        SplashScreenForm.BackgroundImageLayout = ImageLayout.Stretch
        'SplashScreenForm.BackgroundImage = My.Resources.stansDraft2
        'SplashScreenForm.Size = Me.Size
        'SplashScreenForm.Show()
        Me.Show()

        Dim sizer, foodSizer, locationSizer, categorySizer As Integer
        Dim match As Match
        Dim initialSplit As String = Regex.Replace(My.Resources.Resource1.Grocery, "/", "Ω")
        Dim initialArray As String() = Regex.Split(initialSplit, "\p{P}|\p{Sc}")
        Dim initialArrayString As String = String.Join("", initialArray)
        Dim alphabetizer() As String
        alphabetizer = Regex.Split(initialArrayString, vbLf)
        array.Sort(alphabetizer)
        Dim sortedStr As String = String.Join("", alphabetizer)
        Dim array1() As String

        'Uses a zero width positive lookbehind assertion to split the array back 
        'into Single lines to prepare for matching
        array1 = Regex.Split(sortedStr, "(?=ITM)|(?=LOC)|(?=CAT)")

        'This section sizes the array columns and loads them with information from the first arr.
        For i = 0 To UBound(array1)
            match = Regex.Match(array1(i), "ITM")
            If match.Success = True Then
                sizer += 1
            End If
        Next
        Dim finalArray(sizer - 1, 2) As String
        'Food
        foodSizer = 0
        For p = 0 To UBound(array1)
            match = Regex.Match(array1(p), "ITM")
            If match.Success = True Then
                finalArray(foodSizer, 0) = array1(p)
                foodSizer += 1
            End If
        Next
        'Location
        locationSizer = 0
        For k = 0 To UBound(array1)
            match = Regex.Match(array1(k), "LOC")
            If match.Success = True Then
                finalArray(locationSizer, 1) = array1(k)
                locationSizer += 1
            End If
        Next
        Console.Read()
        'Categories
        categorySizer = 0
        For r = 0 To UBound(array1)
            match = Regex.Match(array1(r), "CAT")
            If match.Success = True Then
                finalArray(categorySizer, 2) = array1(r)
                categorySizer += 1
            End If
        Next
        'This puts the /'s back where they belong, and removes the tags.
        For j = 0 To (sizer - 1)
            For p = 0 To 2
                finalArray(j, p) = Regex.Replace(finalArray(j, p), "Ω", "/")
                finalArray(j, p) = Regex.Replace(finalArray(j, p), "ITM", String.Empty)
                finalArray(j, p) = Regex.Replace(finalArray(j, p), "LOC", String.Empty).PadLeft(2)
                finalArray(j, p) = Regex.Replace(finalArray(j, p), "CAT", String.Empty)
            Next
            DisplayListBox.Items.Add(finalArray(j, 0))
        Next
        'moved the array's information to a global array, this array needs global access
        finalarray2 = finalArray
        LocationSorter()
        CategorySorter()
        FilterComboBox.SelectedItem = "Show All"
    End Sub
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SearchToolStripMenuItem.Click, SearchContextMenuItem.Click
        'Handles the search button clicks.  Checks the search text box and loads the display list box based on matched to the searched text.
        Dim goodData As Boolean
        Dim searchMatch As Match
        goodData = False
        DisplayListBox.Items.Clear()
        DisplayLabel.Text = String.Empty
        'Too many items come up when only one character is used.
        If SearchTextBox.TextLength = 1 Then
            DisplayLabel.Text = "Please be more specific."
            Exit Sub
        ElseIf SearchTextBox.Text = "zzz" Then
            Me.Close()
        End If
        'Matches only occur on the front end of words in the strings, instead of pulling matches out of the center of words.
        For a = 0 To UBound(finalarray2) - 1
            searchMatch = Regex.Match(finalarray2(a, 0), "\b" & SearchTextBox.Text, RegexOptions.IgnoreCase)
            If searchMatch.Success = True Then
                DisplayListBox.Items.Add(finalarray2(a, 0))
                goodData = True
            End If
        Next
        If goodData = False Then
            DisplayLabel.Text = $"Sorry, no matches for {SearchTextBox.Text}"
        End If
        DisplayListBox.Items.Remove("  ")
    End Sub
    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        'This sub loads the display label with information, based on the users choice.
        For a = 0 To 255
            For b = 0 To 2
                If DisplayListBox.SelectedItem.ToString = finalarray2(a, b) Then
                    DisplayLabel.Text = "You will find " & finalarray2(a, b) & " on aisle " &
                        finalarray2(a, b + 1) & " with the " & finalarray2(a, b + 2)
                End If
            Next
        Next
    End Sub
    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AisleRadioButton.CheckedChanged, CategoryRadioButton.CheckedChanged
        'This sub watches for the radio buttons to change, then storts the filter combox box based on the users selection.
        If AisleRadioButton.Checked = True Then
            FilterComboBox.Items.Clear()
            FilterComboBox.Items.Add("Show All")
            FilterComboBox.Items.Add("Choose Aisle...")
            FilterComboBox.SelectedItem = "Choose Aisle..."
            For t = 0 To UBound(sortedLocations)
                FilterComboBox.Items.Add(sortedLocations(t))
            Next
        Else
            FilterComboBox.Items.Clear()
            FilterComboBox.Items.Add("Show All")
            FilterComboBox.Items.Add("Choose Category...")
            FilterComboBox.SelectedItem = "Choose Category..."
            For l = 0 To UBound(sortedLocations)
                FilterComboBox.Items.Add(sortedCategories(l))
            Next
        End If
        FilterComboBox.Items.Remove("  ")
    End Sub
    Private Sub FilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterComboBox.SelectedIndexChanged
        'This sub watches for the users selection within the filter combo box, adjusts the display list box accordingly.
        FilterComboBox.SelectedItem.ToString()
        DisplayListBox.Items.Clear()
        For a = 0 To 255
            If FilterComboBox.SelectedItem.ToString() = "Show All" Then
                DisplayListBox.Items.Add(finalarray2(a, 0))
            End If
            For b = 0 To 2
                If FilterComboBox.SelectedItem.ToString() = finalarray2(a, b) Then
                    DisplayListBox.Items.Add(finalarray2(a, 0))
                End If
            Next
        Next
        DisplayListBox.Items.Remove("  ")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Timer sub, for the splash screen.
        Timer1.Stop()
        'SplashScreenForm.Hide()
    End Sub
    Sub LocationSorter()
        Dim locations(UBound(finalarray2)) As String

        For a = 0 To UBound(finalarray2)
            locations(a) = finalarray2(a, 1)
        Next
        Dim preDedupe As String = String.Join(",", locations)
        Dim dedupe As String = DeDupeinator(preDedupe)
        sortedLocations = Regex.Split(dedupe, ",")
        Array.Sort(sortedLocations)
        Console.Read()
    End Sub
    Sub CategorySorter()
        Dim categories(UBound(finalarray2)) As String

        For a = 0 To UBound(finalarray2)
            categories(a) = finalarray2(a, 2)
        Next
        Dim preDedupe As String = String.Join(",", categories)
        Dim dedupe As String = DeDupeinator(preDedupe)
        sortedCategories = Regex.Split(dedupe, ",")
        Array.Sort(sortedCategories)
        Console.Read()
    End Sub
    Private Sub AboutTopMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click
        AboutForm.Size = Me.Size
        AboutForm.Show()
    End Sub
    Function DeDupeinator(ByVal sInput As String, Optional ByVal sDelimiter As String = ",") As String
        'This function is used for the location and category sorters to remove duplicates and return the individual instances once each.
        Dim varietySection As String
        Dim sTemp As String

        For Each varietySection In Split(sInput, sDelimiter)
            If InStr(1, sDelimiter & sTemp & sDelimiter, sDelimiter & varietySection & sDelimiter, vbTextCompare) = 0 Then
                sTemp = sTemp & sDelimiter & varietySection
            End If
        Next varietySection
        DeDupeinator = Mid(sTemp, Len(sDelimiter) + 1)
    End Function
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        'exit button is hidden from user. only exists to be assigned for cancel button
        Me.Close()
    End Sub
End Class
