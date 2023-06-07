// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var st = ThaiBaht("319321");
Console.WriteLine(st.ToString());
string a = "\u2649";

Console.WriteLine(a);

static string ThaiBaht(string txt)
{
    string bahtTxt, n, bahtTH = "";
    double amount;
    try { amount = Convert.ToDouble(txt); }
    catch { amount = 0; }
    bahtTxt = amount.ToString("####.00");
    string[] num = { "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ" };
    string[] rank = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };
    string[] temp = bahtTxt.Split('.');
    string intVal = temp[0];
    string decVal = temp[1];
    if (Convert.ToDouble(bahtTxt) == 0)
        bahtTH = "ศูนย์บาทถ้วน";
    else
    {
        for (int i = 0; i < intVal.Length; i++)
        {
            n = intVal.Substring(i, 1);
            if (n != "0")
            {
                if ((i == (intVal.Length - 1)) && (n == "1"))
                    bahtTH += "เอ็ด";
                else if ((i == (intVal.Length - 2)) && (n == "2"))
                    bahtTH += "ยี่";
                else if ((i == (intVal.Length - 2)) && (n == "1"))
                    bahtTH += "";
                else
                    bahtTH += num[Convert.ToInt32(n)];
                bahtTH += rank[(intVal.Length - i) - 1];
            }
        }
        bahtTH += "บาท";
        if (decVal == "00")
            bahtTH += "ถ้วน";
        else
        {
            for (int i = 0; i < decVal.Length; i++)
            {
                n = decVal.Substring(i, 1);
                if (n != "0")
                {
                    if ((i == decVal.Length - 1) && (n == "1"))
                        bahtTH += "เอ็ด";
                    else if ((i == (decVal.Length - 2)) && (n == "2"))
                        bahtTH += "ยี่";
                    else if ((i == (decVal.Length - 2)) && (n == "1"))
                        bahtTH += "";
                    else
                        bahtTH += num[Convert.ToInt32(n)];
                    bahtTH += rank[(decVal.Length - i) - 1];
                }
            }
            bahtTH += "สตางค์";
        }
    }
    return bahtTH;
}

/*
 Public Shared Function ConvertToThaiBaht(ByVal txt As String) As String
    Dim bahtTxt, n As String, bahtTH As String = ""
    Dim amount As Double

    Try
        amount = Convert.ToDouble(txt)
    Catch
        amount = 0
    End Try

    bahtTxt = amount.ToString("####.00")
    Dim num As String() = {"ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ"}
    Dim rank As String() = {"", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน"}
    Dim temp As String() = bahtTxt.Split("."c)
    Dim intVal As String = temp(0)
    Dim decVal As String = temp(1)

    If Convert.ToDouble(bahtTxt) = 0 Then
        bahtTH = "ศูนย์บาทถ้วน"
    Else

        For i As Integer = 0 To intVal.Length - 1
            n = intVal.Substring(i, 1)

            If n <> "0" Then

                If (i = (intVal.Length - 1)) AndAlso (n = "1") Then
                    bahtTH += "เอ็ด"
                ElseIf (i = (intVal.Length - 2)) AndAlso (n = "2") Then
                    bahtTH += "ยี่"
                ElseIf (i = (intVal.Length - 2)) AndAlso (n = "1") Then
                    bahtTH += ""
                Else
                    bahtTH += num(Convert.ToInt32(n))
                End If

                bahtTH += rank((intVal.Length - i) - 1)
            End If
        Next

        bahtTH += "บาท"

        If decVal = "00" Then
            bahtTH += "ถ้วน"
        Else

            For i As Integer = 0 To decVal.Length - 1
                n = decVal.Substring(i, 1)

                If n <> "0" Then

                    If (i = decVal.Length - 1) AndAlso (n = "1") Then
                        bahtTH += "เอ็ด"
                    ElseIf (i = (decVal.Length - 2)) AndAlso (n = "2") Then
                        bahtTH += "ยี่"
                    ElseIf (i = (decVal.Length - 2)) AndAlso (n = "1") Then
                        bahtTH += ""
                    Else
                        bahtTH += num(Convert.ToInt32(n))
                    End If

                    bahtTH += rank((decVal.Length - i) - 1)
                End If
            Next

            bahtTH += "สตางค์"
        End If
    End If

    Return bahtTH
End Function
 */