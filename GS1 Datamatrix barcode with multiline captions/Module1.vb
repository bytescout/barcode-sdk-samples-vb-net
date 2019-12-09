'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports Bytescout.BarCode

Module Module1

    Sub Main()
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        barcode.Symbology = SymbologyType.GS1_DataMatrix

        ' Set GS1 barcode value            
        barcode.Value = "(01)07046261398572(17)130331(10)TEST5632(21)19067811811"

        ' you may also set the value without brackets and the SDK will automatically add brackets where needed
        ' also some values may include "|" character as the additional separator (for example, GS1 Australian Post)
        'barcode.Value = "01034531200000111729103010ABC123" ' it will be converted into "(01)03453120000011(17)291030(10)ABC123" automatically

        ' you may also optionally check if this value is valid according to GS1 subtype rules
        'bool isValidValue = barcode.ValueIsValidGS1(barcode.Value))

        ' Set barcode additional caption
        barcode.AdditionalCaption = "(01)07046261398572" + Environment.NewLine + "(17)130331(10)" + Environment.NewLine + "TEST5632(21)" + Environment.NewLine + "19067811811"

        ' Set caption position
        barcode.AdditionalCaptionPosition = CaptionPosition.After

        ' Save barcode to image
        barcode.SaveImage("result.png")

        ' Show image in default image viewer
        Process.Start("result.png")
    End Sub

End Module
