using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

using System.Diagnostics;

namespace MahoaDES
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }
        public String[,] cypherText = new String[4, 4];
        public String[,] plainText = new String[4, 4];
        public String[,] khoa = new String[4, 4];
        public String[,] khoa_1 = new String[4, 4];
        public String[,] khoa_2 = new String[4, 4];
        public String[,] khoa_3 = new String[4, 4];
        public String[,] khoa_4 = new String[4, 4];
        public String[,] khoa_5 = new String[4, 4];
        public String[,] khoa_6 = new String[4, 4];
        public String[,] khoa_7 = new String[4, 4];
        public String[,] khoa_8 = new String[4, 4];
        public String[,] khoa_9 = new String[4, 4];
        public String[,] khoa_10 = new String[4, 4];
        public String[,] addRoundKey = new String[4, 4];
        public String[,] subBytes = new String[4, 4];
        public String[,] shiftRows = new String[4, 4];
        public String[,] mixColumns = new String[4, 4];
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public string[] stringArr_NhiPhan(string key)
        {
           
            string[] keyBinaryArray = DES.HexToBin4bit(key);
            return keyBinaryArray;
        }

        public void Key_Binary()
        { 
            string temp = "";
            foreach (var item in stringArr_NhiPhan(txtKhoa.Text))
            {
                temp += (item + " ");
            }
            txtKetQua.AppendText("  K nhị phân: "+temp+ Environment.NewLine);
        }

        public void tim_K_table(string[] matranPC02_Array)
        {    
            for (int i = 0; i < 16; i++)
            {
                string[] key_Array = new string[56];
                key_Array = DES.hoanVi(matranPC02_Array, DES.listCnDn[i], 48);
                DES.key_List.Add(key_Array);
            }
            
            for (int k = 0; k < 16; k++)
            {
                txtKetQua.AppendText("  K"+(k+1)+" :");
                if(k < 9) txtKetQua.AppendText("  ");
                for (int j = 0; j < 48; j++)
                {
                    txtKetQua.AppendText(DES.key_List[k][j].ToString() + " ");

                }
                txtKetQua.AppendText(Environment.NewLine);
            }
        }

        public void HoanViKey()
        {
            string[] binaryStr64 = DES.Convert_16unit4bit_To_64unit1bit(stringArr_NhiPhan(txtKhoa.Text));
            string[] strArray = DES.hoanVi(DES.MT_PC1, binaryStr64, 56);
            string temp = "";
          
            for (int i = 0; i < strArray.Length; i++)
            {
                temp += strArray[i];
                if ((i+1) % 4 == 0) temp += " ";
            }
          
            txtKetQua.AppendText("  K hoán vị  : " + temp + Environment.NewLine);
        }

        public void CnDnTable()
        {
            string[] binaryStr64 = DES.Convert_16unit4bit_To_64unit1bit(stringArr_NhiPhan(txtKhoa.Text));
            string[] keyHoanVi = DES.hoanVi(DES.MT_PC1, binaryStr64, 56);
            DES.CnDnTable(DES.Dich_CnDn, keyHoanVi);
           
            txtKetQua.AppendText(Environment.NewLine);
            for (int i = 0; i <= 16; i++)
            {
               
                txtKetQua.AppendText("  C" + i + ": ");
                if (i <= 9) txtKetQua.AppendText("  ");
                for (int j = 0; j < 28; j++)
                {
                    
                    txtKetQua.AppendText((DES.listCn[i][j] + " "));
                }
                txtKetQua.AppendText("|D" + i + ": ");
                if (i <= 9) txtKetQua.AppendText("  ");
                for (int j = 0; j < 28; j++)
                {
                    
                    txtKetQua.AppendText((DES.listDn[i][j] + " "));

                }
                txtKetQua.AppendText(Environment.NewLine);
            }
        }
        public void TimLnRn_MaHoa(string plainText)
        {
            tim_K_table(DES.MT_PC2);
            for (int i = 0; i < 16; i++)
            {
                //moi vong co SiBi

                //tinh R tiep theo de gan cho L
                //muon tim dc R1 thi phai lat L0 XOR f(ER0,K1). L0 co, R0 co, K1 co. 
                //b1.Phai tim f(ER0,K1). 
                //b2: f chia thanh 8 nhom 6 bit,
                //b3:moix nhom 6bit hoan vi qua bang sbox tuong ung
                //b3.1: tim x,y;
                //b3.2: tim x,y tuong ung trong Sbox => hoan thanh 1 Si(Bi), lap lai 8 lan;
                //Thuc hien b1:tim f(ER0,K1)

                //listLn[1] = listRn[0];

                DES.L0R0(stringArr_NhiPhan(plainText));
                string[] f = DES.KeyXorER(DES.key_List[i], DES.listRn[i]);//xong b1;
                                                          
                string[] Bn_array = DES.Bn(f);//xong b2;
                DES.listSboxOut.Add(Bn_array);
                //thuc hien buoc 3;
                //ket qua ra S1(B1) -> S8(B8)
                DES.timXY(Bn_array);
                DES.hoanViFquaSBox(Bn_array);
                string[] tempSnBn = DES.DecimalToBin4bit(DES.SnBnArray);
                DES.listSnBnArray.Add(tempSnBn);
                //hoan vi cua f(R0,K1) ;
                string[] binaryStr = DES.Convert_8unit4bit_To_32unit1bit(tempSnBn);
                string[] F_RK = DES.hoanVi(DES.MT_P, binaryStr, 32);
                DES.listFRK.Add(F_RK);
                string[] temp = DES.listRn[i];
                DES.listLn.Insert(i+1,temp);
             
                string[] temp2 = DES.L_Xor_F_RK(DES.listLn[i],F_RK);
                DES.listRn.Insert(i+1,temp2);

            }

        }

        public void TimLR_GiaiMa(string cypher)
        {
            
            Key_Binary();

            //hoan vi khoa 56 bit
            HoanViKey();

            //bang dich theo key theo bang CnDn
            CnDnTable();
            tim_K_table(DES.MT_PC2);
            string cypherText = cypher;
            string[] ipNegative1 = DES.HexToBin4bit(cypherText);
            ipNegative1 = DES.Convert_16unit4bit_To_64unit1bit(ipNegative1);
            string[] L16R16 = DES.hoanViNguoc(DES.MT_IP_negative1, ipNegative1);
            //txtKetQua.AppendText(string.Join("", ipNegative1));
            // txtKetQua.AppendText("\r\nL16R16: "+string.Join("",L16R16));
            string[] temp = new string[32];
          
            for (int j = 0; j < 32; j++)
            {
                temp[j] = L16R16[j];
            }
            DES.listLn.Add(temp);
            temp = new string[32];
            int index = 0;
            for (int j = 32; j < 64; j++)
            {
                temp[index] = L16R16[j];
                index++;
            }
            DES.listRn.Add(temp);
            int ind = 0;
            for (int i = 15; i >= 0; i--)
            {

              
                string[] f = DES.KeyXorER(DES.key_List[i], DES.listRn[ind]);//xong b1;

                string[] Bn_array = DES.Bn(f);//xong b2;
                DES.listSboxOut.Add(Bn_array);
                //thuc hien buoc 3;
                //ket qua ra S1(B1) -> S8(B8)
                DES.timXY(Bn_array);
                DES.hoanViFquaSBox(Bn_array);
                string[] tempSnBn = DES.DecimalToBin4bit(DES.SnBnArray);
                DES.listSnBnArray.Add(tempSnBn);
                //hoan vi cua f(R0,K1) ;
                string[] binaryStr = DES.Convert_8unit4bit_To_32unit1bit(tempSnBn);
                string[] F_RK = DES.hoanVi(DES.MT_P, binaryStr, 32);
                DES.listFRK.Add(F_RK);
                string[] temp1 = DES.listRn[ind];
                
                DES.listLn.Insert(ind + 1, temp1);

                string[] temp2 = DES.L_Xor_F_RK(DES.listLn[ind], F_RK);
                DES.listRn.Insert(ind + 1, temp2);
                ind++;
            }
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            if (rbdes.Checked == true)
            {
                txtKetQua.Clear();
                if (txtKhoa.Text.Length != 16)
                {
                    MessageBox.Show("  Độ dài K phải = 16!", "Thông báo");
                    return;
                }
                if (txtBanRo.Text == "")
                {
                    MessageBox.Show("Mời bạn nhập dữ liệu cần mã hóa!", "Thông báo");
                    return;
                }
                string cypherText = "";
                string plainText = txtBanRo.Text;
                while (plainText.Length % 16 != 0)
                {
                    plainText += "F";
                }
                txtBanRo.Text = plainText;
                string[] plainTextArray = new string[plainText.Length / 16];
                int index = 0;
                for (int i = 0; i < plainTextArray.Length; i++)
                {
                    plainTextArray[i] = plainText.Substring(index, 16);
                    index += 16;
                }

                txtKetQua.AppendText("  Bản rõ chia thành các đoạn: ");
                txtKetQua.AppendText(Environment.NewLine);
                for (int i = 0; i < plainTextArray.Length; i++)
                {
                    txtKetQua.AppendText("  Đoạn " + (i + 1) + ": ");
                    txtKetQua.AppendText(plainTextArray[i]);
                    txtKetQua.AppendText(Environment.NewLine);
                }
                for (int k = 0; k < plainTextArray.Length; k++)
                {

                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  Đoạn rõ " + (k + 1) + ": " + plainTextArray[k]); txtKetQua.AppendText(Environment.NewLine);
                    plainText = plainTextArray[k];
                    //bien doi key - > nhi phan
                    Key_Binary();

                    //hoan vi khoa 56 bit
                    HoanViKey();

                    //bang dich theo key theo bang CnDn
                    CnDnTable();

                    //bang key tu 1->16

                    txtKetQua.AppendText(Environment.NewLine);
                    //DES.LnRn(stringArr_NhiPhan(txtBanRo.Text));

                    TimLnRn_MaHoa(plainText);
                    // 16 vong DES
                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  L0:" + string.Join("", DES.listLn[0]));
                    txtKetQua.AppendText("  R0:" + string.Join("", DES.listRn[0]));
                    for (int i = 1; i <= 16; i++)
                    {
                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("----------------------------------------------------------------------Vòng " + i + "---------------------------------------------------------------");


                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("  L" + i + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                        for (int j = 0; j < DES.listLn[i].Length; j++)
                            txtKetQua.AppendText(DES.listLn[i][j]);

                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  E(R" + (i - 1) + ") :"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listE_R[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  K" + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.key_List[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  ER" + (i - 1) + " XOR K" + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listERXorK[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  SBox_Out " + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listSboxOut[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  S" + (i) + "  B" + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listSnBnArray[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  F(R" + (i - 1) + "K" + (i) + "):"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listFRK[i - 1]));

                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("  L" + (i - 1) + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                        for (int j = 0; j < DES.listLn[i].Length; j++)
                            txtKetQua.AppendText(DES.listLn[i - 1][j] + " ");
                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("  R" + i + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                        for (int j = 0; j < DES.listRn[i].Length; j++)
                            txtKetQua.AppendText(DES.listRn[i][j] + " ");

                    }
                    string[] R16L16 = DES.listRn[16].Concat(DES.listLn[16]).ToArray();
                    string[] hoanviIpNegative1 = DES.hoanVi(DES.MT_IP_negative1, R16L16, 64);

                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText(Environment.NewLine);
                    string hoanviIpNegative1Str = string.Join("", hoanviIpNegative1);
                    txtKetQua.AppendText("  IP-1:" + hoanviIpNegative1Str);
                    cypherText += DES.binary4bitToHexDecimal(hoanviIpNegative1Str); txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  Bản mã của đoạn: " + DES.binary4bitToHexDecimal(hoanviIpNegative1Str)); txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("_____________________________________________________________________________________"); txtKetQua.AppendText(Environment.NewLine);
                    DES.DisposeAll();
                }

                txtBanMaHoa.Text = cypherText;
            }
            else if (rbaes.Checked == true)
            {
                txtKetQua.Text = "";
                input();
                tao10khoa();
                AddRoundKey();

                for (int i = 1; i <= 9; i++)
                {
                    txtKetQua.Text += "Vòng lặp thứ " + i + " : " + "\n";
                    SubBytes();
                    ShiftRows();
                    MixColumns();
                    if (i == 1) AddRoundKeyvonglap(mixColumns, khoa_1);
                    else if (i == 2) AddRoundKeyvonglap(mixColumns, khoa_2);
                    else if (i == 3) AddRoundKeyvonglap(mixColumns, khoa_3);
                    else if (i == 4) AddRoundKeyvonglap(mixColumns, khoa_4);
                    else if (i == 5) AddRoundKeyvonglap(mixColumns, khoa_5);
                    else if (i == 6) AddRoundKeyvonglap(mixColumns, khoa_6);
                    else if (i == 7) AddRoundKeyvonglap(mixColumns, khoa_7);
                    else if (i == 8) AddRoundKeyvonglap(mixColumns, khoa_8);
                    else if (i == 9) AddRoundKeyvonglap(mixColumns, khoa_9);

                }
                txtKetQua.Text += "Bước tạo ngõ ra : " + "\n";
                SubBytes();
                ShiftRows();
                txtKetQua.Text += "Bản mã :\n";
                for (int i = 0; i <= 3; i++)
                    for (int j = 0; j <= 3; j++)
                    {
                        addRoundKey[i, j] = AES.XOR16(shiftRows[i, j], khoa_10[i, j]);
                        if (j == 3) txtKetQua.Text += "  " + addRoundKey[i, j] + "\n";
                        else txtKetQua.Text += "  " + addRoundKey[i, j] + " ";

                    }
                for (int i = 0; i <= 3; i++)
                    for (int j = 0; j <= 3; j++)
                    {
                        txtBanMaHoa.Text += addRoundKey[i, j] + " ";
                    }
            }
            
        }
        public void input()
        {
            String[] plainTextStr = txtBanRo.Text.Split(' ');
            String[] key = txtKhoa.Text.Split(' ');
            int i = 0;
            int j = 0;
            foreach (String w in plainTextStr)
            {
                plainText[i, j] = w;
                i++;
                if (i > 3 && j != 3)
                {
                    i = 0;
                    j++;
                }

            }
            int a = 0;
            int b = 0;
            foreach (String w in key)
            {
                khoa[a, b] = w;
                a++;
                if (a > 3 && b != 3)
                {
                    a = 0;
                    b++;
                }

            }

        }
        public void input123()
        {
           // String[] plainTextStr = txtBanRo.Text.Split(' ');
            String[] key = txtKhoa.Text.Split(' ');
            int i = 0;
            int j = 0;
            //foreach (String w in plainTextStr)
            //{
            //    plainText[i, j] = w;
            //    i++;
            //    if (i > 3 && j != 3)
            //    {
            //        i = 0;
            //        j++;
            //    }

            //}
            int a = 0;
            int b = 0;
            foreach (String w in key)
            {
                khoa[a, b] = w;
                a++;
                if (a > 3 && b != 3)
                {
                    a = 0;
                    b++;
                }

            }

        }
        public void xuatmatran(String[,] matran)
        {
            for (int i = 0; i <= 3; i++)
                for (int j = 0; j <= 3; j++)
                {

                    if (j == 3) txtKetQua.Text += "  " + matran[i, j] + "\n";
                    else txtKetQua.Text += "  " + matran[i, j] + " ";

                }
        }
        private void AddRoundKey()
        {
            txtKetQua.Text += "AddRoundKey : \n";
            for (int i = 0; i <= 3; i++)
                for (int j = 0; j <= 3; j++)
                {
                    addRoundKey[i, j] = AES.XOR16(plainText[i, j], khoa[i, j]);
                    if (j == 3) txtKetQua.Text += "  " + addRoundKey[i, j] + "\n";
                    else txtKetQua.Text += "  " + addRoundKey[i, j] + " ";

                }
        }
        private void AddRoundKeyvonglap(String[,] kqdr, String[,] khoamoi)
        {
            txtKetQua.Text += "AddRoundKey (input đầu ra của vòng lặp kết hợp với Khóa mới): \n";
            for (int i = 0; i <= 3; i++)
                for (int j = 0; j <= 3; j++)
                {
                    addRoundKey[i, j] = AES.XOR16(kqdr[i, j], khoamoi[i, j]);
                    if (j == 3) txtKetQua.Text += "  " + addRoundKey[i, j] + "\n";
                    else txtKetQua.Text += "  " + addRoundKey[i, j] + " ";

                }
        }
        private void AddRoundKeyvonglap123(String[,] kqdr, String[,] khoamoi)
        {
            txtKetQua.Text += "AddRoundKey (input đầu ra của vòng lặp kết hợp với Khóa mới): \n";
            for (int i = 0; i <= 3; i--)
                for (int j = 0; j <= 3; j--)
                {
                    addRoundKey[i, j] = AES.XOR16(kqdr[i, j], khoamoi[i, j]);
                    if (j == 0) txtKetQua.Text += "  " + addRoundKey[i, j] + "\n";
                    else txtKetQua.Text += "  " + addRoundKey[i, j] + " ";

                }
        }
        private void SubBytes()
        {
            txtKetQua.Text += "SubBytes : \n";
            for (int i = 0; i <= 3; i++)
                for (int j = 0; j <= 3; j++)
                {
                    String ark = addRoundKey[i, j];
                    subBytes[i, j] = AES.sbox[AES.chuyen16sangso(ark[0]), AES.chuyen16sangso(ark[1])];
                    if (j == 3) txtKetQua.Text += "  " + subBytes[i, j] + "\n";
                    else txtKetQua.Text += "  " + subBytes[i, j] + " ";
                }

        }
        public void ShiftRows()
        {
            String teap;
            teap = subBytes[1, 0];
            subBytes[1, 0] = subBytes[1, 3];
            subBytes[1, 3] = teap;
            teap = subBytes[1, 0];
            subBytes[1, 0] = subBytes[1, 2];
            subBytes[1, 2] = teap;
            teap = subBytes[1, 0];
            subBytes[1, 0] = subBytes[1, 1];
            subBytes[1, 1] = teap;

            teap = subBytes[2, 0];
            subBytes[2, 0] = subBytes[2, 2];
            subBytes[2, 2] = teap;
            teap = subBytes[2, 1];
            subBytes[2, 1] = subBytes[2, 3];
            subBytes[2, 3] = teap;

            teap = subBytes[3, 0];
            subBytes[3, 0] = subBytes[3, 3];
            subBytes[3, 3] = teap;
            teap = subBytes[3, 1];
            subBytes[3, 1] = subBytes[3, 3];
            subBytes[3, 3] = teap;
            teap = subBytes[3, 2];
            subBytes[3, 2] = subBytes[3, 3];
            subBytes[3, 3] = teap;

            shiftRows = subBytes;
           txtKetQua.Text += " ShiftRows : \n";
            xuatmatran(shiftRows);

        }
        public void MixColumns()
        {
            for (int j = 0; j <= 3; j++)
            {
                String[] lay1cot = new String[4];
                for (int i = 0; i <= 3; i++)
                {
                    lay1cot[i] = shiftRows[i, j];
                }
                for (int k = 0; k <= 3; k++)
                {
                    String[] kqsaubangbd = new String[4];
                    for (int q = 0; q <= 3; q++)
                    {
                        kqsaubangbd[q] = AES.nhanbangbd(lay1cot[q], AES.matranbd[k, q]);
                    }
                    mixColumns[k, j] = AES.XOR16voi4kytu(kqsaubangbd[0], kqsaubangbd[1], kqsaubangbd[2], kqsaubangbd[3]);
                }
            }
            txtKetQua.Text += " MixColumns : \n";
            xuatmatran(mixColumns);
        }

        public void tao10khoa()
        {
            txtKetQua.Text += "Tính khóa : " + "\n";
            for (int i = 1; i <= 10; i++)
            {
                String[] R_con = new String[4];
                R_con = AES.layR_con(i);
                if (i == 1)
                {
                    khoa_1 = AES.tinhkhoa(R_con, khoa);
                    txtKetQua.Text += "Khóa 1 " + "\n";
                    xuatmatran(khoa_1);
                }
                else if (i == 2)
                {
                    khoa_2 = AES.tinhkhoa(R_con, khoa_1);
                    txtKetQua.Text += "Khóa 2 " + "\n";
                    xuatmatran(khoa_2);
                }
                else if (i == 3)
                {
                    khoa_3 = AES.tinhkhoa(R_con, khoa_2);
                    txtKetQua.Text += "Khóa 3 " + "\n";
                    xuatmatran(khoa_3);
                }
                else if (i == 4)
                {
                    khoa_4 = AES.tinhkhoa(R_con, khoa_3);
                    txtKetQua.Text += "Khóa 4 " + "\n";
                    xuatmatran(khoa_4);
                }
                else if (i == 5)
                {
                    khoa_5 = AES.tinhkhoa(R_con, khoa_4);
                    txtKetQua.Text += "Khóa 5 " + "\n";
                    xuatmatran(khoa_5);
                }
                else if (i == 6)
                {
                    khoa_6 = AES.tinhkhoa(R_con, khoa_5);
                    txtKetQua.Text += "Khóa 6 " + "\n";
                    xuatmatran(khoa_6);
                }
                else if (i == 7)
                {
                    khoa_7 = AES.tinhkhoa(R_con, khoa_6);
                    txtKetQua.Text += "Khóa 7 " + "\n";
                    xuatmatran(khoa_7);
                }
                else if (i == 8)
                {
                    khoa_8 = AES.tinhkhoa(R_con, khoa_7);
                    txtKetQua.Text += "Khóa 8 " + "\n";
                    xuatmatran(khoa_8);
                }
                else if (i == 9)
                {
                    khoa_9 = AES.tinhkhoa(R_con, khoa_8);
                    txtKetQua.Text += "Khóa 9 " + "\n";
                    xuatmatran(khoa_9);
                }
                else if (i == 10)
                {
                    khoa_10 = AES.tinhkhoa(R_con, khoa_9);
                    txtKetQua.Text += "Khóa 10 " + "\n";
                    xuatmatran(khoa_10);
                }
            }
        }

        private void rtbK1_16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBanMaHoa.Clear();
            txtBanRo.Clear();
            txtKetQua.Clear();
            txtKhoa.Clear();
            txtBanRo.Focus();
        }


        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                sw.WriteLine("Bản rõ M: "+txtBanRo.Text);
                sw.WriteLine("Khóa K: " + txtKhoa.Text);
                sw.WriteLine("Bản mã hóa: " + txtBanMaHoa.Text);
                sw.WriteLine("--------------------------------------------Chi tiết------------------------------------------------");
                sw.WriteLine(txtKetQua.Text);
                sw.Close();
            }
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            if (rbdes.Checked == true)
            {
                txtKetQua.Clear();
                if (txtKhoa.Text.Length != 16)
                {
                    MessageBox.Show("  Độ dài K phải = 16!", "Thông báo");
                    return;
                }
                if (txtBanMaHoa.Text == "")
                {
                    MessageBox.Show("Mời bạn nhập dữ liệu cần giải mã!", "Thông báo");
                    return;
                }
                string cypher = "";
                string cypherText1 = txtBanMaHoa.Text;
                while (cypherText1.Length % 16 != 0)
                {
                    cypherText1 += "F";
                }
                txtBanMaHoa.Text = cypherText1;
                string[] cypherTextArray = new string[cypherText1.Length / 16];
                int index1 = 0;
                for (int i = 0; i < cypherTextArray.Length; i++)
                {
                    cypherTextArray[i] = cypherText1.Substring(index1, 16);
                    index1 += 16;
                }

                txtKetQua.AppendText("  Bản mã chia thành các đoạn: ");
                txtKetQua.AppendText(Environment.NewLine);
                for (int i = 0; i < cypherTextArray.Length; i++)
                {
                    txtKetQua.AppendText("  Đoạn " + (i + 1) + ": ");
                    txtKetQua.AppendText(cypherTextArray[i]);
                    txtKetQua.AppendText(Environment.NewLine);
                }
                for (int k = 0; k < cypherTextArray.Length; k++)
                {

                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  Đoạn rõ " + (k + 1) + ": " + cypherTextArray[k]); txtKetQua.AppendText(Environment.NewLine);
                    cypher = cypherTextArray[k];

                    TimLR_GiaiMa(cypher);
                    string[] R0L0 = DES.listRn[16].Concat(DES.listLn[16]).ToArray();
                    string[] cypherText = DES.hoanViNguoc(DES.MT_IP, R0L0);

                    string banRoCuaDoan = DES.binary4bitToHexDecimal(string.Join("", cypherText));
                    txtBanRo.Text += banRoCuaDoan;

                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  L0:" + string.Join("", DES.listLn[0]));
                    txtKetQua.AppendText("  R0:" + string.Join("", DES.listRn[0]));
                    int index = 16;
                    for (int i = 1; i <= 16; i++)
                    {
                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("----------------------------------------------------------------------Vòng " + i + "---------------------------------------------------------------");


                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("  L" + i + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                        for (int j = 0; j < DES.listLn[i].Length; j++)
                            txtKetQua.AppendText(DES.listLn[i][j]);

                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  E(R" + (i - 1) + ") :"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listE_R[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  K" + (index) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.key_List[index - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  ER" + (i - 1) + " XOR K" + (index) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listERXorK[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  SBox_Out " + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listSboxOut[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  S" + (i) + "  B" + (i) + ":"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listSnBnArray[i - 1]));
                        txtKetQua.AppendText(Environment.NewLine);

                        txtKetQua.AppendText("  F(R" + (i - 1) + "K" + (index) + "):"); if (i <= 9) txtKetQua.AppendText("  ");
                        txtKetQua.AppendText(string.Join(" ", DES.listFRK[i - 1]));

                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("  L" + (i - 1) + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                        for (int j = 0; j < DES.listLn[i].Length; j++)
                            txtKetQua.AppendText(DES.listLn[i - 1][j] + " ");
                        txtKetQua.AppendText(Environment.NewLine);
                        txtKetQua.AppendText("  R" + i + " :"); if (i <= 9) txtKetQua.AppendText("  ");
                        for (int j = 0; j < DES.listRn[i].Length; j++)
                            txtKetQua.AppendText(DES.listRn[i][j] + " ");

                        index--;



                    }

                    txtKetQua.AppendText(Environment.NewLine);
                    txtKetQua.AppendText("  Bản rõ của đoạn: " + banRoCuaDoan);
                    txtKetQua.AppendText(Environment.NewLine);

                    DES.DisposeAll();
                }


                txtKetQua.AppendText("_____________________________________________________________________________________");
                txtKetQua.AppendText(Environment.NewLine);
            }
            else if (rbaes.Checked == true)
            {
                txtBanRo.Clear();
                txtKetQua.Clear();
                txtBanMaHoa.Clear();
                String[] key = txtKhoa.Text.Split(' ');
                txtKetQua.Text += "Bản mã :\n";
                for (int i = 0; i <= 3; i++)
                    for (int j = 0; j <= 3; j++)
                    {
                        addRoundKey[i, j] = AES.XOR16(shiftRows[i, j], khoa_10[i, j]);
                        if (j == 3) txtKetQua.Text += "  " + addRoundKey[i, j] + "\n";
                        else txtKetQua.Text += "  " + addRoundKey[i, j] + " ";

                    }
                for (int i = 0; i <= 3; i++)
                    for (int j = 0; j <= 3; j++)
                    {
                        txtBanMaHoa.Text += addRoundKey[i, j] + " ";
                    }
                txtKetQua.Text += "Bước tạo ngõ ra : " + "\n";
                ShiftRows();
                SubBytes();
                for (int i = 1; i <= 9; i++)
                {
                    txtKetQua.Text += "Vòng lặp thứ " + i + " : " + "\n";
                    SubBytes();
                    ShiftRows();
                    MixColumns();
                    if (i == 1) AddRoundKeyvonglap(mixColumns, khoa_9);
                    else if (i == 2) AddRoundKeyvonglap(mixColumns, khoa_8);
                    else if (i == 3) AddRoundKeyvonglap(mixColumns, khoa_7);
                    else if (i == 4) AddRoundKeyvonglap(mixColumns, khoa_6);
                    else if (i == 5) AddRoundKeyvonglap(mixColumns, khoa_5);
                    else if (i == 6) AddRoundKeyvonglap(mixColumns, khoa_4);
                    else if (i == 7) AddRoundKeyvonglap(mixColumns, khoa_3);
                    else if (i == 8) AddRoundKeyvonglap(mixColumns, khoa_2);
                    else if (i == 9) AddRoundKeyvonglap(mixColumns, khoa_1);

                }
                AddRoundKey();
                tao10khoa();
             //   int i = 0;
              //  int j = 0;
                //foreach (String w in plainTextStr)
                //{
                //    plainText[i, j] = w;
                //    i++;
                //    if (i > 3 && j != 3)
                //    {
                //        i = 0;
                //        j++;
                //    }

                //}
                //int a = 0;
                //int b = 0;
                //foreach (String w in key)
                //{
                //    khoa[a, b] = w;
                //    a++;
                //    if (a > 3 && b != 3)
                //    {
                //        a = 0;
                //        b++;
                //    }
                //    Console.WriteLine("\n Khoa :" + khoa[a, b]);
                //}
             
                // input123();
                txtKetQua.Text += "Bản rõ :\n";
                for (int i = 0; i <= 3; i++)
                    for (int j = 0; j <= 3; j++)
                    {
                        addRoundKey[i, j] = AES.XOR16(khoa[i,j], khoa_1[i, j]);
                        if (j == 3) txtKetQua.Text += "  " + addRoundKey[i, j] + "\n";
                        else txtKetQua.Text += "  " + addRoundKey[i, j] + " ";

                    }
                for (int i = 0; i <= 3; i++)
                    for (int j = 0; j <= 3; j++)
                    {
                       txtBanRo.Text += addRoundKey[i, j] + " ";
                    }
            }
        }
         
        

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            this.Text = this.Text.Substring(1, this.Text.Length - 1) + this.Text.Substring(0, 1);
        }
    }

   
}
