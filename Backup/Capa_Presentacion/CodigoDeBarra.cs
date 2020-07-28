using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Capa_Presentacion
{
    public class CodigoDeBarra
    {
        

        public static void ConvertEAN(TextBox txtcodigo,TextBox mostrar)
        {
            int m_longitud=0;
            string CodigoBarra;
            CodigoBarra = "";
            if (txtcodigo.Text.Trim().Length > 0)
            {
                int strL = m_longitud - txtcodigo.Text.Trim().Length;
                string str = "";
                for (int i = 1; i <= strL; i++)
                {
                    str = str + "0";
                }
                CodigoBarra = txtcodigo.Text + str;
            }

            string m_final = "";

            m_final = (String)EANTrece(CodigoBarra);

            mostrar.Text = m_final;
        }


        private static object EANTrece(string valor)
        {
            object functionReturnValue = null;
            int i;
            int m_validador = 0;
            int m_primero;
            string CodigoBarra;
            bool tableA;
            functionReturnValue = "";
            if (valor.Length == 12)
            {
                for (i = 1; i <= 12; i++)
                {
                    int L1 = Convert.ToChar(valor.Substring(i - 1, 1));
                    if (L1 < 48 || L1 > 57)
                    {
                        i = 0;
                        break;
                    }
                }
                if (i == 13)
                {
                    for (i = 12; i >= 1; i += -2)
                    {
                        m_validador = m_validador + Convert.ToInt32(valor.Substring(i - 1, 1));
                    }
                    m_validador = m_validador * 3;
                    for (i = 11; i >= 1; i += -2)
                    {
                        m_validador = m_validador + Convert.ToInt32(valor.Substring(i - 1, 1));
                    }
                    valor = valor + (10 - m_validador % 10) % 10;
                    CodigoBarra = valor.Substring(0, 1) + Convert.ToChar(65 + Convert.ToInt32((valor.Substring(1, 1))));
                    m_primero = Convert.ToInt32(valor.Substring(0, 1));

                    for (i = 3; i <= 7; i++)
                    {
                        tableA = false;
                        switch (i)
                        {
                            case 3:
                                switch (m_primero)
                                {
                                    case 0:
                                    case 1:
                                    case 2:
                                    case 3:
                                        tableA = true;
                                        break;
                                }
                                break;
                            case 4:
                                switch (m_primero)
                                {
                                    case 0:
                                    case 4:
                                    case 7:
                                    case 8:
                                        tableA = true;
                                        break;
                                }
                                break;
                            case 5:
                                switch (m_primero)
                                {
                                    case 0:
                                    case 1:
                                    case 4:
                                    case 5:
                                    case 9:
                                        tableA = true;
                                        break;
                                }
                                break;
                            case 6:
                                switch (m_primero)
                                {
                                    case 0:
                                    case 2:
                                    case 5:
                                    case 6:
                                    case 7:
                                        tableA = true;
                                        break;
                                }
                                break;
                            case 7:
                                switch (m_primero)
                                {
                                    case 0:
                                    case 3:
                                    case 6:
                                    case 8:
                                    case 9:
                                        tableA = true;
                                        break;
                                }
                                break;
                        }
                        if (tableA)
                        {
                            CodigoBarra = CodigoBarra + Convert.ToChar(65 + Convert.ToInt32(valor.Substring(i - 1, 1)));
                        }
                        else
                        {
                            CodigoBarra = CodigoBarra + Convert.ToChar(75 + Convert.ToInt32(valor.Substring(i - 1, 1)));
                        }
                    }
                    CodigoBarra = CodigoBarra + "*";
                    for (i = 8; i <= 13; i++)
                    {
                        CodigoBarra = CodigoBarra + Convert.ToChar(97 + Convert.ToInt32(valor.Substring(i - 1, 1)));
                    }
                    CodigoBarra = CodigoBarra + "+";
                    functionReturnValue = CodigoBarra;
                }
            }
            return functionReturnValue;
        }

        public string AddOn(string valor)
        {
            int i;
            int checksum = 0;
            string AddOnn = "";

            bool tableA;

            if (valor.Length == 2 || valor.Length == 5)
            {
                for (i = 1; i < valor.Length; i++)
                {
                    int L1 = Convert.ToChar(valor.Substring(i - 1, 1));

                    if (L1 < 48 || L1 > 57)
                    {
                        break;
                    }
                    if (valor.Length == 2)
                    {
                        checksum = 10 + Convert.ToInt32(valor) % 4;
                    }
                    else if (valor.Length == 5)
                    {
                        for (i = 1; i == 5; i = i - 2)
                        {
                            checksum = checksum + Convert.ToInt32(valor.Substring(i - 1, 1));
                        }
                        checksum = (checksum * 3 + Convert.ToInt32(valor.Substring(2, 1)) * 9 + Convert.ToInt32(valor.Substring(4, 1)) * 9) % 10;
                    }
                    AddOnn = "[";
                    for (i = 1; i <= valor.Length; i++)
                    {
                        tableA = false;

                        switch (i)
                        {
                            case 1:
                                int[] str = { 4, 9, 10, 11 };
                                for (int j = 0; j < str.Length; j++)
                                {
                                    if (str[j] == checksum)
                                    {
                                        tableA = false;
                                        break;
                                    }
                                }
                                break;

                            case 2:
                                int[] str1 = { 1, 2, 3, 5, 6, 7, 10, 12 };
                                for (int j = 0; j < str1.Length; j++)
                                {
                                    if (str1[j] == checksum)
                                    {
                                        tableA = false;
                                        break;
                                    }
                                }
                                break;
                            case 3:
                                int[] str2 = { 0, 2, 3, 6, 7 };
                                for (int j = 0; j < str2.Length; j++)
                                {
                                    if (str2[j] == checksum)
                                    {
                                        tableA = false;
                                        break;
                                    }
                                }
                                break;
                            case 4:
                                int[] str3 = { 1, 3, 4, 8, 9 };
                                for (int j = 0; j < str3.Length; j++)
                                {
                                    if (str3[j] == checksum)
                                    {
                                        tableA = false;
                                        break;
                                    }
                                }
                                break;
                            case 5:
                                int[] str4 = { 0, 1, 2, 4, 5, 7 };
                                for (int j = 0; j < str4.Length; j++)
                                {
                                    if (str4[j] == checksum)
                                    {
                                        tableA = false;
                                        break;
                                    }
                                }
                                break;
                        }

                        if (tableA)
                            AddOnn = AddOnn + Convert.ToChar(65 + Convert.ToInt32(valor.Substring(i - 1, 1)));
                        else
                            AddOnn = AddOnn + Convert.ToChar(75 + Convert.ToInt32(valor.Substring(i - 1, 1)));

                        if ((valor.Length == 2 && i == 1) || (valor.Length == 5 && i < 5))
                            AddOnn = AddOnn + Convert.ToChar(92);

                    }


                }
            }
            return AddOnn;
        }

    }
}
