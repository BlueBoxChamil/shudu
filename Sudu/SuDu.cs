using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    class SuDu
    {
        public SuDu()
        {
        }
        public static int[][] arrray9_9;

        //创建9个3*3的二维数组
        public static int[,] arrray_1 = new int[3, 3];
        public static int[,] arrray_2 = new int[3, 3];
        public static int[,] arrray_3 = new int[3, 3];
        public static int[,] arrray_4 = new int[3, 3];
        public static int[,] arrray_5 = new int[3, 3];
        public static int[,] arrray_6 = new int[3, 3];
        public static int[,] arrray_7 = new int[3, 3];
        public static int[,] arrray_8 = new int[3, 3];
        public static int[,] arrray_9 = new int[3, 3];
        


        public static int[][] getSuDu()
        {
            //创建9*9二维数组
            arrray9_9 = new int[9][];
            for(int i = 0;i < 9; i++)
            {
                arrray9_9[i] = new int[9];
            }

            //生成1-9不重复随机数
            List<int> randomList = creatNineRondomArray(9);

            //生成9个3*3不重复数组
            CreatSudoku3_3(randomList);

            //对每个3*3数组进行打乱
            ChangeSudoku3_3();

            //将3*3数组合并为9*9数组
            int[][] result = creatSudokuArray(arrray9_9);

            //打印二维数组，数独矩阵
            printArray(result);


            return result;
        }


        /// <summary>
        /// 打印二维数组，数独矩阵,答案
        /// </summary>
        /// <param name="a"></param>
        private static void printArray(int[][] a)
        {
            string charss = "";
            string newline = "\n";
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                     charss += a[i][j] + "  ";
                }
                charss += newline;
            }
            
            Write(charss);
        }

        /// <summary>
        /// 生成1-9不重复随机数
        /// </summary>
        /// <returns></returns>
        public static List<int> creatNineRondomArray(int length)
        {
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {

                int randomNum = random.Next(9) + 1;
                while (true)
                {
                    if (!list.Contains(randomNum))
                    {
                        list.Add(randomNum);
                        break;
                    }
                    randomNum = random.Next(9) + 1;
                }

            }
            return list;
        }
        /// <summary>
        /// 生成9个3*3不重复数组
        /// </summary>
        /// <param name="randomList"></param>
        private static void CreatSudoku3_3(List<int> randomList)
        {
            //将一维数组转为5格3*3数组
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrray_5[i, j] = randomList[i * 3 + j];
                }
            }

            //生成4 6格数据
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrray_4[i, j] = arrray_5[(i + 2) % 3, j];
                    arrray_6[i, j] = arrray_5[(i + 1) % 3, j];
                }
            }

            //生成2 8格数据
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrray_2[i, j] = arrray_5[i, (j + 2) % 3];
                    arrray_8[i, j] = arrray_5[i, (j + 1) % 3];
                }
            }

            //生成1 3格数据
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrray_1[i, j] = arrray_2[(i + 2) % 3, j];
                    arrray_3[i, j] = arrray_2[(i + 1) % 3, j];
                }
            }

            //生成7 9格数据
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrray_7[i, j] = arrray_8[(i + 2) % 3, j];
                    arrray_9[i, j] = arrray_8[(i + 1) % 3, j];
                }
            }
        }

        /// <summary>
        /// 对每个3*3数组进行打乱
        /// </summary>
        private static void ChangeSudoku3_3()
        {
            //对4格进行3次横向乱序对调
            // 例如 abc  acb
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int ret_i = random.Next(0, 3);
                int ret_j1 = random.Next(0, 3);
                int ret_j2 = random.Next(0, 3);

                int temp;

                temp = arrray_4[ret_i, ret_j1];
                arrray_4[ret_i, ret_j1] = arrray_4[ret_i, ret_j2];
                arrray_4[ret_i, ret_j2] = temp;


            }

            //对6格进行3次横向乱序对调
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int ret_i = random.Next(0, 3);
                int ret_j1 = random.Next(0, 3);
                int ret_j2 = random.Next(0, 3);

                int temp;
                temp = arrray_6[ret_i, ret_j1];
                arrray_6[ret_i, ret_j1] = arrray_6[ret_i, ret_j2];
                arrray_6[ret_i, ret_j2] = temp;
            }

            //对2格进行3次纵向乱序对调
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int ret_j = random.Next(0, 3);
                int ret_i1 = random.Next(0, 3);
                int ret_i2 = random.Next(0, 3);

                int temp;
                temp = arrray_2[ret_i1, ret_j];
                arrray_2[ret_i1, ret_j] = arrray_2[ret_i2, ret_j];
                arrray_2[ret_i2, ret_j] = temp;
            }

            //对8格进行3次纵向乱序对调
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int ret_j = random.Next(0, 3);
                int ret_i1 = random.Next(0, 3);
                int ret_i2 = random.Next(0, 3);

                int temp;
                temp = arrray_8[ret_i1, ret_j];
                arrray_8[ret_i1, ret_j] = arrray_8[ret_i2, ret_j];
                arrray_8[ret_i2, ret_j] = temp;
            }

            //对1格进行3次横向乱序对调
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int ret_i = random.Next(0, 3);
                int ret_j1 = random.Next(0, 3);
                int ret_j2 = random.Next(0, 3);

                int temp;
                temp = arrray_1[ret_i, ret_j1];
                arrray_1[ret_i, ret_j1] = arrray_1[ret_i, ret_j2];
                arrray_1[ret_i, ret_j2] = temp;
            }

            //对3格进行3次横向乱序对调
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int ret_i = random.Next(0, 3);
                int ret_j1 = random.Next(0, 3);
                int ret_j2 = random.Next(0, 3);

                int temp;
                temp = arrray_3[ret_i, ret_j1];
                arrray_3[ret_i, ret_j1] = arrray_3[ret_i, ret_j2];
                arrray_3[ret_i, ret_j2] = temp;
            }

            //对7格进行3次横向乱序对调
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int ret_i = random.Next(0, 3);
                int ret_j1 = random.Next(0, 3);
                int ret_j2 = random.Next(0, 3);

                int temp;
                temp = arrray_7[ret_i, ret_j1];
                arrray_7[ret_i, ret_j1] = arrray_7[ret_i, ret_j2];
                arrray_7[ret_i, ret_j2] = temp;
            }

            //对9格进行3次横向乱序对调
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int ret_i = random.Next(0, 3);
                int ret_j1 = random.Next(0, 3);
                int ret_j2 = random.Next(0, 3);

                int temp;
                temp = arrray_9[ret_i, ret_j1];
                arrray_9[ret_i, ret_j1] = arrray_9[ret_i, ret_j2];
                arrray_9[ret_i, ret_j2] = temp;
            }
        }

        /// <summary>
        /// 将3*3数组合并为9*9数组
        /// </summary>
        /// <param name="seedArray"></param>
        /// <returns></returns>
        private static int[][] creatSudokuArray(int[][] seedArray)
        {
            //整合为9*9大数组
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    seedArray[i][j] = arrray_1[i, j];
                    seedArray[i + 3][j] = arrray_4[i, j];
                    seedArray[i + 6][j] = arrray_7[i, j];

                    seedArray[i][j + 3] = arrray_2[i, j];
                    seedArray[i + 3][j + 3] = arrray_5[i, j];
                    seedArray[i + 6][j + 3] = arrray_8[i, j];

                    seedArray[i][j + 6] = arrray_3[i, j];
                    seedArray[i + 3][j + 6] = arrray_6[i, j];
                    seedArray[i + 6][j + 6] = arrray_9[i, j];
                }
            }

            return seedArray;
        }
        
        /// <summary>
        /// 将字符写入txt文件中
        /// </summary>
        /// <param name="s"></param>
        public static void Write(String s)
        {
            FileStream fs = new FileStream("D:\\suduku_answer.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            //开始写入
            sw.Write(s);

            //清空缓冲区
            sw.Flush();

            //关闭流
            sw.Close();

            fs.Close();
        }
    }
}
