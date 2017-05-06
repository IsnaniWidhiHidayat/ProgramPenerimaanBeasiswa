using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TubesAI
{
    class Rumus
    {

        public struct ColoumAndGain
        {
            public string Coloum;
            public float Gain;

        }



        #region Variabel
            public static List<ColoumAndGain> coloumAndGain = new List<ColoumAndGain>(); // Menampung Semua Gain dan telah terurut dari besar ke kecil
            public static List<double> AllEntropy = new List<double>(); // Menampung semua Entropy
        #endregion

        #region Function
            public static float Entropy(float diterima, float ditolak, float total) //Mencari Entropy
            {
                float A = diterima / total;
                float B = ditolak / total;

                double Hasil = (-A * Math.Log(A, 2)) - (B * Math.Log(B, 2));

                return (float)Hasil;
            }

            public static float Gain(int[,] data) //Mencari Gain dengan imputan array 2 dimensi (n x 3)
            {
                float Hasil = 0.0f;
                int DataLength = data.GetLength(0);
                for (int i = 0; i < DataLength; i++)
                {
                    if (i == 0)
                    {
                        Hasil = Entropy(data[i, 0], data[i, 1], data[i, 2]);
                    }
                    else
                    {
                        float temp = ((float)data[i, 2] / (float)data[0, 2]) * Entropy((float)data[i, 0], (float)data[i, 1], (float)data[i, 2]);

                        if (!Double.IsNaN((double)temp))
                        {
                            Hasil -= temp;
                        }

                    }
                }

                return Hasil;
            }

            public static float SearchGain(int coloum) //Mencari Gain sesuai colom;
            {
                float Hasil = 0.0f;
                int[,] data = new int[1, 3];
                int[] temp = new int[3];

                switch (coloum)
                {
                    case 1:
                        {
                            data = new int[3, 3];


                            for (int i = 1; i < 3; i++)
                            {
                                if (i == 1)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("Jenis_beasiswa", "PPA");
                                }
                                else
                                {
                                    temp = DatabaseScript.SearchDataEntropy("Jenis_beasiswa", "BBM");
                                }

                                data[i, 0] = temp[0];
                                data[i, 1] = temp[1];
                                data[i, 2] = temp[2];
                            }

                            break;
                        }

                    case 2:
                        {
                            data = new int[6, 3];


                            for (int i = 1; i < 4; i++)
                            {
                                if (i == 1)
                                {   //ipk 4
                                    temp = DatabaseScript.SearchDataEntropy("select count(if(ipk = '4',1,Null) AND if(Diterima='Ya',1,Null))as Ya,count(if(ipk = '4',1,Null) AND if(Diterima='Tidak',1,Null))as Tidak,count(if(ipk = '4',1,Null)) Total from beasiswa;");
                                }
                                else if (i == 2)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("select count(if(ipk < 4,1,Null) AND if(ipk >= 3.5,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(ipk < 4,1,Null) AND if(ipk >= 3.5,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(ipk < 4,1,Null) AND if(ipk >= 3.5,1,Null)) as Total from beasiswa;");
                                }
                                else if (i == 3)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("select count(if(ipk < 3.5,1,Null) AND if(ipk >= 3.25,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(ipk < 3.5,1,Null) AND if(ipk >= 3.25,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(ipk < 3.5,1,Null) AND if(ipk >= 3.25,1,Null)) as Total from beasiswa;");
                                }
                                else if (i == 4)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("select count(if(ipk < 3.25,1,Null) AND if(ipk >= 3,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(ipk < 3.25,1,Null) AND if(ipk >= 3,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(ipk < 3.25,1,Null) AND if(ipk >= 3,1,Null)) as Total from beasiswa;");
                                }
                                else if (i == 5)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("select count(if(ipk < 3,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(ipk < 3,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(ipk < 3,1,Null))as Total from beasiswa;");
                                }

                                data[i, 0] = temp[0];
                                data[i, 1] = temp[1];
                                data[i, 2] = temp[2];
                            }


                            break;
                        }

                    case 3:
                        {

                            data = new int[4, 3];


                            for (int i = 1; i < 4; i++)
                            {
                                if (i == 1)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("Aktif_Organisasi", "Ketua");
                                }
                                else if (i == 2)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("Aktif_Organisasi", "Pengurus");
                                }
                                else if (i == 3)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("Aktif_Organisasi", "Anggota");
                                }

                                data[i, 0] = temp[0];
                                data[i, 1] = temp[1];
                                data[i, 2] = temp[2];
                            }


                            break;
                        }

                    case 4:
                        {
                            data = new int[6, 3];

                            for (int i = 1; i < 4; i++)
                            {
                                if (i == 1)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("select count(if(Financial <= 1000000,1,Null) AND if(Diterima='Ya',1,Null))as Ya,count(if(Financial <= 1000000,1,Null) AND if(Diterima='Tidak',1,Null))as Tidak,count(if(Financial <= 1000000,1,Null)) Total from beasiswa;");
                                }
                                else if (i == 2)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("select count(if(Financial <= 5000000,1,Null) AND if(Financial > 1000000,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(Financial <= 5000000,1,Null) AND if(Financial > 1000000,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(Financial <= 5000000,1,Null) AND if(Financial > 1000000,1,Null)) as Total from beasiswa;");
                                }
                                else if (i == 3)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("select count(if(Financial <= 7500000,1,Null) AND if(Financial > 5000000,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(Financial <= 7500000,1,Null) AND if(Financial > 5000000,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(Financial <= 7500000,1,Null) AND if(Financial > 5000000,1,Null)) as Total from beasiswa;");
                                }
                                else if (i == 4)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("select count(if(Financial <= 10000000,1,Null) AND if(Financial > 7500000,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(Financial <= 10000000,1,Null) AND if(Financial > 7500000,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(Financial <= 10000000,1,Null) AND if(Financial > 7500000,1,Null)) as Total from beasiswa;");
                                }
                                else if (i == 5)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("select count(if(Financial > 10000000,1,Null) AND if(Diterima='Ya',1,Null))as Ya,count(if(Financial > 10000000,1,Null) AND if(Diterima='Tidak',1,Null))as Tidak,count(if(Financial > 10000000,1,Null)) Total from beasiswa;");
                                }

                                data[i, 0] = temp[0];
                                data[i, 1] = temp[1];
                                data[i, 2] = temp[2];
                            }

                            break;
                        }

                    case 5:
                        {
                            data = new int[6, 3];

                            for (int i = 1; i < 4; i++)
                            {
                                if (i == 1)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("select count(if(Prestasi is null,1,Null) AND if(Diterima='Ya',1,Null))as Ya,count(if(Prestasi is null,1,Null) AND if(Diterima='Tidak',1,Null))as Tidak,count(if(Prestasi is null,1,Null)) Total from beasiswa;");
                                }
                                else if (i == 2)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("Prestasi", "Internasional");
                                }
                                else if (i == 3)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("Prestasi", "Nasional");
                                }
                                else if (i == 4)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("Prestasi", "Regional");
                                }
                                else if (i == 5)
                                {
                                    temp = DatabaseScript.SearchDataEntropy("Prestasi", "Lokal");
                                }

                                data[i, 0] = temp[0];
                                data[i, 1] = temp[1];
                                data[i, 2] = temp[2];
                            }

                            break;
                        }


                    default:
                        {

                            break;
                        }
                }

                temp = DatabaseScript.SearchDataEntropy("Select count(IF(Diterima ='ya',1,Null)) as ya,count(IF(Diterima ='tidak',1,Null)) as tidak,count(IF(Diterima,1,Null)) as total from beasiswa;");
                data[0, 0] = temp[0];
                data[0, 1] = temp[1];
                data[0, 2] = temp[2];

                Hasil = Gain(data);

                return Hasil;

            }
        #endregion

        #region Prosedur
            public static void SearchAllGain() //Mencari semua Gain dan di simpan variabel coloumAndGain yang telah terurut dari besar ke kecil
            {


                ColoumAndGain temp = new ColoumAndGain();
                if (coloumAndGain.Count > 0)
                {
                    coloumAndGain.Clear();
                }
                for (int i = 1; i <= 5; i++)
                {
                    switch (i)
                    {
                        case 1:
                            temp.Coloum = "Jenis_beasiswa";
                            break;

                        case 2:
                            temp.Coloum = "ipk";
                            break;

                        case 3:
                            temp.Coloum = "Aktif_Organisasi";
                            break;

                        case 4:
                            temp.Coloum = "Financial";
                            break;

                        case 5:
                            temp.Coloum = "Prestasi";
                            break;

                    }

                    temp.Gain = SearchGain(i);
                    coloumAndGain.Add(temp);
                }


                coloumAndGain = coloumAndGain.OrderByDescending(a => a.Gain).ToList();

            } 
        #endregion

        

       
    }
}
