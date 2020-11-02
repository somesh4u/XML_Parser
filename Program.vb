Imports System.Xml

Module Program
    Sub Main(args As String())
        Dim lstPaxInfo As New List(Of PaxInfo)

        Try
            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load("F:\Projects\Mani\pq.xml")

            If Not String.IsNullOrEmpty(xmlDoc.InnerXml) Then
                For Each node_PaxInfo As XmlNode In xmlDoc.GetElementsByTagName("NameAssociation")

                    Dim objPaxInfo As New PaxInfo
                    With objPaxInfo
                        .FirstName = node_PaxInfo.Attributes("firstName").InnerText
                        .LastName = node_PaxInfo.Attributes("lastName").InnerText
                        .PaxType = node_PaxInfo("PriceQuote")("Passenger").Attributes("type").InnerText
                    End With
                    lstPaxInfo.Add(objPaxInfo)
                Next
            End If


        Catch ex As Exception
            Console.WriteLine("Error while Reading Pax XML")
        End Try

        If lstPaxInfo IsNot Nothing Then
            For Each myPaxInfo In lstPaxInfo
                Console.WriteLine(myPaxInfo.FirstName)
                Console.WriteLine(myPaxInfo.LastName)
                Console.WriteLine(myPaxInfo.PaxType)
                Console.WriteLine()
            Next
        End If
        Console.ReadKey()
    End Sub
End Module
