'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports Bytescout.BarCode

Class Program
	Friend Shared Sub Main()
		' Create new barcode and register it.
		Dim barcode As New Barcode()
		barcode.RegistrationName = "demo"
		barcode.RegistrationKey = "demo"

		' Set symbology
        barcode.Symbology = SymbologyType.PDF417
		' Set value
		barcode.Value = "Sample barcode"

        ' Place barcode at bottom-right corner of the image
        barcode.DrawToImage("wikipedia.png", -1, 400, 900, "result.png")

        ' Open output file in default image viewer
        System.Diagnostics.Process.Start("result.png")
	End Sub
End Class
