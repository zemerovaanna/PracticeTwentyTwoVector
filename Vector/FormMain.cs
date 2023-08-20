using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vector
{
    public partial class FormMain :Form
    {
        string[] vector;
        List<string[]> vectors;
        MyVector MyVectorA;
        MyVector MyVectorB;
        MyVector MyVectorC;

        public FormMain ()
        {
            InitializeComponent();

            vectors = new List<string[]>();

            СomboBoxChoiceFileName.Items.Clear();
            ComboBoxCreatedFileName.Items.Clear();

            StreamReader sr = new StreamReader("VectorList.txt");

            while (!sr.EndOfStream)
            {
                string srtxt = sr.ReadLine();

                if (File.Exists(srtxt))
                {
                    СomboBoxChoiceFileName.Items.Add(srtxt);
                    ComboBoxCreatedFileName.Items.Add(srtxt);
                }
            }
            sr.Close();

            StreamWriter sw = new StreamWriter("VectorList.txt");

            foreach (var item in СomboBoxChoiceFileName.Items)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();

            ComboBoxCreatedFileName.Items.Clear();

            StreamReader VectorList = new StreamReader("VectorList.txt");

            while (!VectorList.EndOfStream)
            {
                string srtxt = VectorList.ReadLine();

                if (File.Exists(srtxt))
                {
                    ComboBoxCreatedFileName.Items.Add(srtxt);
                }
            }
            VectorList.Close();
        }

        //Первая проверка названия вектора.
        static string CheckVectorName (string name)
        {
            if (name.Length == 1)
            {
                if (char.IsLetter(name[0]) && char.IsLower(name[0]))
                {
                    return "";
                } else
                    return "Вектор может называться только одной маленькой буквой.";
            } else
                return "Вектор может называться только одним символом.";
        }

        //Вторая проверка названия вектора.
        static string CheckVectorNameTwo (string name, string filename)
        {
            string[] input = File.ReadAllLines(filename);

            foreach (string symbol in input)
            {
                if (symbol == name)
                {
                    return "Такой вектор уже существует в файле.";
                }
            }
            return "";
        }

        //Проверка названия файла.
        static string CheckFileName (string name)
        {
            string message = "";
            if (name.Length <= 20)
            {
                foreach (char symbol in name)
                {
                    if (!char.IsLetter(symbol))
                    {
                        message = "В имени файла могут быть только буквы.";
                        break;
                    }
                }
            } else
            {
                message = "Имя файла не может быть больше 20 символов.";
            }

            return message;
        }

        //Сохранить вектор в файл.
        private void ButtonSave_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxVectorName.Text))
            {
                if (CheckVectorName(TextBoxVectorName.Text) == "")
                {
                    if (RadioButtonCreatedFile.Checked == true && !string.IsNullOrEmpty(ComboBoxCreatedFileName.Text))
                    {
                        if (CheckVectorNameTwo(TextBoxVectorName.Text, ComboBoxCreatedFileName.Text) == "")
                        {
                            StreamWriter vectortxt = new StreamWriter($"{ComboBoxCreatedFileName.Text}", true);
                            vectortxt.WriteLine($"{TextBoxVectorName.Text}");
                            vectortxt.WriteLine($"{NumericUpDownX.Value}");
                            vectortxt.WriteLine($"{NumericUpDownY.Value}");
                            vectortxt.WriteLine($"{NumericUpDownZ.Value}");
                            vectortxt.Close();
                            MessageBox.Show("Сохранено успешно.");
                        } else
                            MessageBox.Show(CheckVectorNameTwo(TextBoxVectorName.Text, ComboBoxCreatedFileName.Text));
                    } else if (RadioButtonCreateFile.Checked == true && !string.IsNullOrEmpty(ComboBoxCreateFileName.Text))
                    {
                        if (CheckFileName(ComboBoxCreateFileName.Text) == "")
                        {
                            if (File.Exists($"{ComboBoxCreateFileName.Text}.txt") == false)
                            {
                                /*                                if (CheckVectorNameTwo(TextBoxVectorName.Text, ComboBoxCreateFileName.Text) == "")
                                                                {*/
                                StreamWriter vectortxt = new StreamWriter($"{ComboBoxCreateFileName.Text}.txt", true);
                                vectortxt.WriteLine($"{TextBoxVectorName.Text}");
                                vectortxt.WriteLine($"{NumericUpDownX.Value}");
                                vectortxt.WriteLine($"{NumericUpDownY.Value}");
                                vectortxt.WriteLine($"{NumericUpDownZ.Value}");
                                vectortxt.Close();

                                StreamWriter vectorlist = new StreamWriter($"VectorList.txt", true);
                                vectorlist.WriteLine($"{ComboBoxCreateFileName.Text}.txt");
                                vectorlist.Close();
                                MessageBox.Show("Успешно создано и сохранено.");
                                /*                                }
                                                                else MessageBox.Show(CheckVectorNameTwo(TextBoxVectorName.Text, ComboBoxCreatedFileName.Text));
                                */
                            } else
                                MessageBox.Show("Такой файл уже существует.");
                        } else
                            MessageBox.Show(CheckFileName(ComboBoxCreateFileName.Text));
                    } else
                        MessageBox.Show("Не заполнено поле для ввода названия файла для сохранения вектора.");
                } else
                    MessageBox.Show(CheckVectorName(TextBoxVectorName.Text));
            } else
                MessageBox.Show("Отсутствует название вектора.");
        }

        //Обновить список векторов.
        private void ButtonLoad_Click (object sender, EventArgs e)
        {
            vectors.Clear();
            if (!string.IsNullOrEmpty(СomboBoxChoiceFileName.Text))
            {
                if (File.Exists($"{СomboBoxChoiceFileName.Text}") == true)
                {
                    StreamReader sr = File.OpenText($"{СomboBoxChoiceFileName.Text}");

                    while (!sr.EndOfStream)
                    {
                        vector = new string[4];

                        for (int i = 0; i < 4; i++)
                        {
                            vector[i] = sr.ReadLine();
                        }

                        vectors.Add(vector);
                    }

                    sr.Close();

                    ComboBoxVectorA.Items.Clear();
                    ComboBoxVectorB.Items.Clear();

                    for (int i = 0; i < vectors.Count; i++)
                    {
                        ComboBoxVectorA.Items.Add(vectors[i][0]);
                        ComboBoxVectorB.Items.Add(vectors[i][0]);
                    }
                }
            } else
                MessageBox.Show("Файл для обноваления списка векторов не выбран.");
        }

        //Информация и Действия с векторами.
        private void ComboBoxVectorA_SelectedIndexChanged (object sender, EventArgs e)
        {
            for (int i = 0; i < vectors.Count; i++)
            {
                if (vectors[i][0] == ComboBoxVectorA.Text)
                {
                    MyVectorA = new MyVector(Convert.ToInt32(vectors[i][1]), Convert.ToInt32(vectors[i][2]), Convert.ToInt32(vectors[i][3]));
                }
            }

            A.Text = MyVectorA.VectorPoints();
        }

        private void ComboBoxVectorB_SelectedIndexChanged (object sender, EventArgs e)
        {
            for (int i = 0; i < vectors.Count; i++)
            {
                if (vectors[i][0] == ComboBoxVectorB.Text)
                {
                    MyVectorB = new MyVector(Convert.ToInt32(vectors[i][1]), Convert.ToInt32(vectors[i][2]), Convert.ToInt32(vectors[i][3]));
                }
            }

            B.Text = MyVectorB.VectorPoints();
        }

        private void ComboBoxAction_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ComboBoxVectorA.Text) && !string.IsNullOrEmpty(ComboBoxVectorA.Text))
            {
                switch (ComboBoxAction.Text)
                {
                    case "Вычислить длину первого вектора":
                    {
                        LabelResultAction.Text = MyVectorA.VectorLength().ToString();
                        break;
                    }
                    case "Вычислить длину второго вектора":
                    {
                        LabelResultAction.Text = MyVectorB.VectorLength().ToString();
                        break;
                    }
                    case "Вычислить длину третьего вектора":
                    {
                        if (MyVectorC != null)
                        {
                            C.Text = MyVectorC.VectorLength().ToString();
                        } else
                            MessageBox.Show("Третий вектор не создан.");

                        break;
                    }
                    case "Получение третьего вектора сложением":
                    {
                        MyVectorC = new MyVector();
                        MyVectorC = MyVectorC.NewVectorSum(MyVectorA, MyVectorB);
                        C.Text = MyVectorC.VectorPoints();
                        break;
                    }
                    case "Получение третьего вектора вычитанием":
                    {
                        MyVectorC = new MyVector();
                        MyVectorC = MyVectorC.NewVectorSub(MyVectorA, MyVectorB);
                        C.Text = MyVectorC.VectorPoints();
                        break;
                    }
                    case "Скалярное произведение векторов":
                    {
                        LabelResultAction.Text = MyVector.ScalarProduct(MyVectorA, MyVectorB).ToString();
                        break;
                    }
                    case "Вычисление косинуса угла между векторами":
                    {
                        LabelResultAction.Text = MyVector.Cos(MyVectorA, MyVectorB).ToString();
                        break;
                    }
                    default:
                    {
                        LabelResultAction.Text = "действие не выбрано";
                        break;
                    }
                }
            } else
                MessageBox.Show("Векторы не выбраны.");
        }

        //Обновление ComboBox.
        private void TabPageCreateSaveVector_Click (object sender, EventArgs e)
        {
            ComboBoxCreatedFileName.Items.Clear();

            StreamReader sr = new StreamReader("VectorList.txt");

            while (!sr.EndOfStream)
            {
                string srtxt = sr.ReadLine();

                if (File.Exists(srtxt))
                {
                    ComboBoxCreatedFileName.Items.Add(srtxt);
                }
            }
            sr.Close();
        }

        private void InformationActionVector_Click (object sender, EventArgs e)
        {
            СomboBoxChoiceFileName.Items.Clear();

            StreamReader sr = new StreamReader("VectorList.txt");

            while (!sr.EndOfStream)
            {
                string srtxt = sr.ReadLine();

                if (File.Exists(srtxt))
                {
                    СomboBoxChoiceFileName.Items.Add(srtxt);
                }
            }
            sr.Close();

            StreamWriter sw = new StreamWriter("VectorList.txt");

            foreach (var item in СomboBoxChoiceFileName.Items)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();
        }
    }
}