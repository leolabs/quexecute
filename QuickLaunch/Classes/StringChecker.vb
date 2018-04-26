Namespace StringChecker

    Class URL
        Dim MostUsedDomainList As New List(Of String)
        Dim UnsponsoredDomainList As New List(Of String)
        Dim SponsoredDomainList As New List(Of String)
        Dim StateDomainList As New List(Of String)

        Public Sub New()
            ' Meistgenutzte Domains
            MostUsedDomainList.AddRange({".com", ".de", ".net", ".uk", ".org", ".info", ".nl", ".eu", ".cn", ".biz"})

            ' Nichtgesponsorte Domains
            UnsponsoredDomainList.AddRange({".arpa", ".biz", ".com", ".info", ".name", ".net", ".org", ".pro"})

            ' Gesponsorte Domains
            SponsoredDomainList.AddRange({".aero", ".asia", ".cat", ".coop", ".edu", ".gov", ".int", ".jobs", ".mil", ".mobi", ".museum", ".post", ".tel", ".travel", ".xxx"})

            ' Länderspezfische Domains
            StateDomainList.AddRange({".ac", ".ad", ".ae", ".af", ".ag", ".ai", ".al", ".am", ".an", ".ao", ".aq", ".ar", ".as", ".at", ".au", ".aw", ".ax", ".az", _
                                 ".ba", ".bb", ".bd", ".be", ".bf", ".bg", ".bh", ".bi", ".bj", ".bl", ".bm", ".bn", ".bo", ".br", ".bq", ".bs", ".bt", ".bv", ".bw", ".by", ".bz", _
                                 ".ca", ".cc", ".cd", ".cf", ".cg", ".ch", ".ci", ".ck", ".cl", ".cm", ".cn", ".co", ".cr", ".cu", ".cv", ".cw", ".cx", ".cy", ".cz", ".cz", _
                                 ".de", ".dj", ".dk", ".dm", ".do", ".dz", _
                                 ".ec", ".ee", ".eg", ".eh", ".er", ".es", ".et", ".eu", _
                                 ".fi", ".fj", ".fk", ".fm", ".fo", ".fr", _
                                 ".ga", ".gb", ".gd", ".ge", ".gf", ".gg", ".gh", ".gi", ".gl", ".gm", ".gn", ".gp", ".gq", ".gr", ".gs", ".gt", ".gu", ".gw", ".gy", _
                                 ".hk", ".hm", ".hn", ".hr", ".ht", ".hu", _
                                 ".id", ".ie", ".il", ".im", ".in", ".io", ".iq", ".ir", ".is", ".it", _
                                 ".je", ".jm", ".jo", ".jp", _
                                 ".ke", ".kg", ".kh", ".ki", ".km", ".kn", ".kp", ".kr", ".kw", ".ky", ".kz", _
                                 ".la", ".lb", ".lc", ".li", ".lk", ".lr", ".ls", ".lt", ".lu", ".lv", ".ly", _
                                 ".ma", ".mc", ".md", ".me", ".mf", ".mg", ".mh", ".mk", ".ml", ".mm", ".mn", ".mo", ".mp", ".mq", ".mr", ".ms", ".mt", ".mu", ".mv", ".mw", ".mx", ".my", ".mz", _
                                 ".na", ".nc", ".ne", ".nf", ".ng", ".ni", ".nl", ".no", ".np", ".nr", ".nu", ".nz", _
                                 ".om", _
                                 ".pa", ".pe", ".pf", ".pg", ".ph", ".pk", ".pl", ".pm", ".pn", ".pr", ".ps", ".pt", ".pw", ".py", _
                                 ".qa", _
                                 ".re", ".ro", ".rs", ".ru", ".rw", _
                                 ".sa", ".sb", ".sc", ".sd", ".se", ".sg", ".sh", ".si", ".sj", ".sk", ".sl", ".sm", ".sn", ".so", ".sr", ".ss", ".st", ".su", ".sv", ".sx", ".sy", ".sz", _
                                 ".tc", ".td", ".tf", ".tg", ".th", ".tj", ".tk", ".tl", ".tm", ".tn", ".to", ".tp", ".tr", ".tt", ".tv", ".tw", ".tz", ".ua", ".ug", ".um", ".us", ".uy", ".uz", _
                                 ".va", ".vc", ".ve", ".vg", ".vi", ".vn", ".vu", _
                                 ".wf", ".ws", _
                                 ".ye", ".yt", _
                                 ".za", ".zm", ".zw"})
        End Sub

        Public Function isDomain(ByVal Text As String, Optional ByVal Level As Integer = 0) As Boolean
            Dim start As Boolean = Text.StartsWith("http://") Or Text.StartsWith("https://")
            Dim simple As Boolean = False
            Dim unsponsored As Boolean = False
            Dim sponsored As Boolean = False
            Dim state As Boolean = False

            If Level <= 3 And Level >= 0 Then
                simple = TestList(MostUsedDomainList, Text)
            Else
                Throw New ArgumentException("Level must be between 0 and 4")
            End If

            If Level > 0 Then
                unsponsored = TestList(UnsponsoredDomainList, Text)
            End If

            If Level > 1 Then
                sponsored = TestList(SponsoredDomainList, Text)
            End If

            If Level > 2 Then
                state = TestList(StateDomainList, Text)
            End If

            If (start Or simple Or unsponsored Or sponsored Or state) And Not Text.Contains(" ") Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Function TestList(ByVal List As List(Of String), ByVal Text As String) As Boolean
            Dim result As Boolean = False

            For Each item As String In List
                If Text.Contains(item) Then
                    result = True
                    Exit For
                End If
            Next

            Return result
        End Function
    End Class

    Class Math
        Dim Functions As New List(Of String)
        Dim Numbers As New List(Of String)
        Dim Operators As New List(Of String)
        Dim Constants As New List(Of String)

        Sub New()
            Functions.AddRange({"abs", "acos", "asin", "atan", "ceiling", "cos", "exp", "floor", "ieeeremainder", "log", "log10", "max", "min", "pow", "round", "sign", "sin", "sqrt", "tan", "truncate"})
            Numbers.AddRange({"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
            Operators.AddRange({"+", "-", "*", "/", "%", "^"})
            Constants.AddRange({"pi", "e", "tao"})
        End Sub

        Public Function isMath(ByVal Text As String) As Boolean
            Dim functStart As Boolean = False
            Dim numStart As Boolean = False
            Dim constStart As Boolean = False
            Dim incOperator As Boolean = False

            For Each item As String In Functions
                If Text.ToLower.StartsWith(item & "(") Then
                    functStart = True
                    Exit For
                End If
            Next

            For Each item As String In Numbers
                If Text.StartsWith(item) Then
                    numStart = True
                    Exit For
                End If
            Next

            For Each item As String In Constants
                If Text.ToLower.StartsWith(item) Then
                    constStart = True
                    Exit For
                End If
            Next

            For Each item As String In Operators
                If Text.ToLower.Contains(item) Then
                    incOperator = True
                    Exit For
                End If
            Next

            Return functStart Or ((numStart Or constStart) And incOperator)
        End Function

        Public Function isValid(ByVal Text As String)
            Dim math As Boolean = isMath(Text)
            Dim numCount As Integer = 0
            Dim opCount As Integer = 0
            Dim startBracket As Integer = 0
            Dim endBracket As Integer = 0
            Dim lastChar As Char = Nothing
            Dim term As String = Text.ToLower

            For Each c As String In Constants
                term = term.Replace(c, "0")
            Next

            For Each i As Char In term.ToList
                If Numbers.Contains(i.ToString) And Not Numbers.Contains(lastChar.ToString) And Not lastChar = "," And Not lastChar = "." Then
                    numCount += 1
                End If

                If Operators.Contains(i.ToString) Then
                    opCount += 1
                End If

                If i = "(" Then
                    startBracket += 1
                End If

                If i = ")" And Not startBracket = 0 Then
                    endBracket += 1
                End If

                lastChar = i
            Next

            Return (numCount = opCount + 1) And (startBracket = endBracket) And Not term.EndsWith(".") And Not term.EndsWith(",") And math
        End Function
    End Class

End Namespace
