Public Class Form1
    Dim PQ1, PQ2, PQ3, PR, PA, PA1, PA2, PA3, PEX, PQT, PRT, PAT, PATT, PET, GG, GH, PT As Double
    Dim MQ1, MQ2, MQ3, MR, MA, MA1, MA2, MA3, MEX, MQT, MRT, MAT, MATT, MET, HH, MT As Double
    Dim FQ1, FQ2, FQ3, FR, FA, FA1, FA2, FA3, FEX, FQT, FRT, FAT, FATT, FET, LL, FT, total, TOTALGRADE As Double


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PQ1 = Val(TextBox1.Text)
        PQ2 = Val(TextBox2.Text)
        PQ3 = Val(TextBox3.Text)
        PR = Val(TextBox4.Text)
        PA = Val(TextBox5.Text)
        PA1 = Val(TextBox6.Text)
        PA2 = Val(TextBox7.Text)
        PA3 = Val(TextBox8.Text)
        PEX = Val(TextBox25.Text)

        PQT = (PQ1 + PQ2 + PQ3) / 3 * 0.2
        PRT = PR * 0.15
        PAT = PA * 0.1
        PATT = (PA1 + PA2 + PA3) / 3 * 0.25
        PET = PEX * 0.3
        PT = (PQT + PRT + PAT + PATT + PET) * 0.3
        GG = PT

        TextBox28.Text = GG


        MQ1 = Val(TextBox9.Text)
        MQ2 = Val(TextBox10.Text)
        MQ3 = Val(TextBox11.Text)
        MR = Val(TextBox12.Text)
        MA = Val(TextBox13.Text)
        MA1 = Val(TextBox14.Text)
        MA2 = Val(TextBox15.Text)
        MA3 = Val(TextBox16.Text)
        MEX = Val(TextBox26.Text)

        MQT = (MQ1 + MQ2 + MQ3) / 3 * 0.2
        MRT = MR * 0.15
        MAT = MA * 0.1
        MATT = (MA1 + MA2 + MA3) / 3 * 0.25
        MET = MEX * 0.3
        MT = (MQT + MRT + MAT + MATT + MET) * 0.3
        HH = MT

        TextBox29.Text = HH

        FQ1 = Val(TextBox17.Text)
        FQ2 = Val(TextBox18.Text)
        FQ3 = Val(TextBox19.Text)
        FR = Val(TextBox20.Text)
        FA = Val(TextBox21.Text)
        FA1 = Val(TextBox22.Text)
        FA2 = Val(TextBox23.Text)
        FA3 = Val(TextBox24.Text)
        FEX = Val(TextBox27.Text)

        FQT = (FQ1 + FQ2 + FQ3) / 3 * 0.2
        FRT = FR * 0.15
        FAT = FA * 0.1
        FATT = (FA1 + FA2 + FA3) / 3 * 0.25
        FET = FEX * 0.3
        FT = (FQT + FRT + FAT + FATT + FET) * 0.3
        LL = FT

        TextBox30.Text = LL

        total = LL + HH + GG

        TextBox31.Text = total


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PQ1 = Val(TextBox1.Text)
        PQ2 = Val(TextBox2.Text)
        PQ3 = Val(TextBox3.Text)
        PR = Val(TextBox4.Text)
        PA = Val(TextBox5.Text)
        PA1 = Val(TextBox6.Text)
        PA2 = Val(TextBox7.Text)
        PA3 = Val(TextBox8.Text)
        PEX = Val(TextBox25.Text)

        PQT = (PQ1 + PQ2 + PQ3) / 3 * 0.2
        PRT = PR * 0.15
        PAT = PA * 0.1
        PATT = (PA1 + PA2 + PA3) / 3 * 0.25
        PET = PEX * 0.3
        PT = (PQT + PRT + PAT + PATT + PET) * 0.3
        GG = PT

        TextBox28.Text = GG
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MQ1 = Val(TextBox9.Text)
        MQ2 = Val(TextBox10.Text)
        MQ3 = Val(TextBox11.Text)
        MR = Val(TextBox12.Text)
        MA = Val(TextBox13.Text)
        MA1 = Val(TextBox14.Text)
        MA2 = Val(TextBox15.Text)
        MA3 = Val(TextBox16.Text)
        MEX = Val(TextBox26.Text)

        MQT = (MQ1 + MQ2 + MQ3) / 3 * 0.2
        MRT = MR * 0.15
        MAT = MA * 0.1
        MATT = (MA1 + MA2 + MA3) / 3 * 0.25
        MET = MEX * 0.3
        MT = (MQT + MRT + MAT + MATT + MET) * 0.3
        HH = MT

        TextBox29.Text = HH

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        FQ1 = Val(TextBox17.Text)
        FQ2 = Val(TextBox18.Text)
        FQ3 = Val(TextBox19.Text)
        FR = Val(TextBox20.Text)
        FA = Val(TextBox21.Text)
        FA1 = Val(TextBox22.Text)
        FA2 = Val(TextBox23.Text)
        FA3 = Val(TextBox24.Text)
        FEX = Val(TextBox27.Text)

        FQT = (FQ1 + FQ2 + FQ3) / 3 * 0.2
        FRT = FR * 0.15
        FAT = FA * 0.1
        FATT = (FA1 + FA2 + FA3) / 3 * 0.25
        FET = FEX * 0.3
        FT = (FQT + FRT + FAT + FATT + FET) * 0.3
        LL = FT

        TextBox30.Text = LL
    End Sub
End Class
