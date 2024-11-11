using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace z3_v9_SergeevaAgata
{
    public partial class Form1 : Form
    { 
        //создаём экземпляр класса-потомка
        private RetailStore newStore;
        //создаем коллекцию, в которой будем хранить все магазины и информацию о них
        private List<Stores> storeList = new List<Stores>();

        public Form1()
        {
            InitializeComponent();
            //устанавливаем количество столбцов в таблице
            dgvShowStores.ColumnCount = 10;
            //нстраиваем имена столбцов
            dgvShowStores.Columns[0].Name = "Название";
            dgvShowStores.Columns[1].Name = "Директор";
            dgvShowStores.Columns[2].Name = "Количество продаж";
            dgvShowStores.Columns[3].Name = "Выручка за октябрь";
            dgvShowStores.Columns[4].Name = "P";
            dgvShowStores.Columns[5].Name = "Рейтинг";
            dgvShowStores.Columns[6].Name = "Адрес";
            dgvShowStores.Columns[7].Name = "Онлайн";
            dgvShowStores.Columns[8].Name = "Q";
            dgvShowStores.Columns[9].Name = "Qp";
        }


        //проверка на то, что строка стостоит только из букв и пробелов
        static bool OnlyLetter(string text)
        {
            //Выражение для проверки, что строка состоит только из букв и пробелов
            return Regex.IsMatch(text, @"^[a-zA-Zа-яА-ЯёЁ\s]+$");
        }

        //проверка на формат адреса
        static bool Address(string text)
        {
            // Регулярное выражение для проверки формата адреса
            string pattern = @"^ул\.\s+[A-Za-zА-Яа-яЁё\s]+,\s+\d{1,2}$";

            // Проверка соответствия строки регулярному выражению
            return Regex.IsMatch(text, pattern);
        }

        //проверка на то, что введённая строка является числом типа int, а также больше 0
        static bool NumberInt(string number)
        {
            if (int.TryParse(number, out int numb))
            {
                if (numb > 0) return true;
                else return false;
            } 
            else return false;
        }

        //проверка на то, что введённая строка является числом типа double, а также больше 0 и меньше 5 (проверка рейтинга)
        static bool NumberDouble(string number)
        {
            if (double.TryParse(number, out double numb))
            {
                if (numb > 0 && numb <=5) return true;
                else return false;
            }
            else return false;
        }

        //проверка на то, что введённая строка является числом типа decimal, а также больше 0
        static bool Monthly(string number)
        {
            if (decimal.TryParse(number, out decimal numb)) 
            {
                if (numb > 0) return true;
                else return false;  
            }
            else return false;
        }

        //проверка на то, что в таблице нет объекта с одинаковым названием и адресом
        public bool DgvStores(string title, string address)
        {
            bool have= true;
            if (dgvShowStores.Rows.Count == 0)
            {
                return have;
            }

            foreach (DataGridViewRow row in dgvShowStores.Rows)
            {
                if ((row.Cells[0].Value != null) && String.Equals(row.Cells[0].Value.ToString(), title) && (row.Cells[6].Value != null) 
                    && String.Equals(row.Cells[6].Value.ToString(), address))
                {
                    have = false;
                    break;
                }
            }

            return have;
        }


        //отображение и обновление информации
        private void RefreshDataGridView()
        {
            dgvShowStores.Rows.Clear(); //очищаем таблицу
            foreach (var store in storeList) //по отельности добавляем элменты
            {
                store.Show(dgvShowStores);
            }
        }

        //событие для удаления магазинов по параметрам
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked) //если выбран 1 radioButton
            {
                if (!string.IsNullOrWhiteSpace(txtDelete.Text)) //проверка на пустоту
                {
                    if (OnlyLetter(txtDelete.Text)) //проверка на то, что в строке содержаться только буквы и пробелы
                    {
                        newStore.RemoveStore(storeList, txtDelete.Text); //вызов функции
                    }
                    else MessageBox.Show("Название магазина должно содержать только буквы и пробелы");
                }
                else
                {
                    MessageBox.Show("Введите название магазина!");
                }
            }
            else if (radioButton2.Checked) //если выбран 2 radioButton
            {
                if (txtDelete.Text != null)  //проверка на пустоту
                {
                    if (int.TryParse(txtDelete.Text, out int number)) //проверка на то, что введённое значение является типом int
                    {
                        if (number > 0)
                        {
                            newStore.RemoveStore(storeList, number); //вызов функции
                        }
                        else MessageBox.Show("Введите корректное значение количества продаж!");
                    }
                    else  MessageBox.Show("Введите корректное значение количества продаж!");
                }
                else MessageBox.Show("Введите количество продаж!");
            }
            else if (radioButton3.Checked) //если выбран 3 radioButton
            {
                if (txtDelete.Text != null)  //проверка на пустоту
                {
                    if (decimal.TryParse(txtDelete.Text, out decimal value)) //проверка на то, что введённое значение является типом decimal
                    {
                        if (value > 0)
                        { 
                        newStore.RemoveStore(storeList, value); //вызов функции
                        }
                        else MessageBox.Show("Введите корректное значение выручки!");
                    }
                    else MessageBox.Show("Введите корректное значение выручки!");
                }
                else MessageBox.Show("Введите выручку!");
            }
            else MessageBox.Show("Выберете по какому параметрку будем удалять!");

            RefreshDataGridView(); //вызов функции обновления таблицы
        }

        //событие добавления магазина
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtDirector.Text != ""
                && txtSalesCount.Text != "" && txtMonthlyRevenue.Text != ""
                && txtP.Text != "" && txtRatingStore.Text != ""
                && txtLocation.Text != "" && txtIsOnline.Text != "") //проверка на пустоту
            {
                if (OnlyLetter(txtTitle.Text)) //в строке только буквы и пробелы
                {
                    if (OnlyLetter(txtDirector.Text)) //в строке только буквы и пробелы
                    {
                        if (NumberInt(txtSalesCount.Text)) //введенное значение типа int и больше 0
                        {
                            if (Monthly(txtMonthlyRevenue.Text)) //введенное значение типа decimal и больше 0
                            {
                                if (NumberInt(txtP.Text)) //введенное значение типа int и больше 0
                                {
                                    if (NumberDouble(txtRatingStore.Text)) ///введенное значение типа double, больше 0 и меньше/равно 5
                                    {
                                        if (Address(txtLocation.Text)) //корректность ввода адреса
                                        {
                                            //получаем из textBox переменные, которые нужно конвертировать
                                            int count = int.Parse(txtSalesCount.Text);
                                            decimal monthly = decimal.Parse(txtMonthlyRevenue.Text);
                                            double rating = double.Parse(txtRatingStore.Text);
                                            int p = int.Parse(txtP.Text);
                                            bool isOnline = txtIsOnline.Text == "+";

                                            //проверяем, а есть ли уже такой магазин
                                            if (DgvStores(txtTitle.Text, txtLocation.Text))
                                            {
                                                //создаем объект
                                                newStore = new RetailStore(txtTitle.Text, txtDirector.Text, count, monthly, p, rating.ToString(), txtLocation.Text, isOnline);

                                                //добавляем магазин в коллекцию магазинов
                                                newStore.AddStore(storeList,newStore);
                                                //добавляем магазин в историю добавления магазинов
                                                newStore.AddHistory(txtTitle.Text);
                                                //выводим историю
                                                newStore.ShowHistory(lstHistory);
                                                //выводим магазины (обновляем таблицу)
                                                newStore.Show(dgvShowStores);

                                                //очищаем поля для воода
                                                txtTitle.Text = string.Empty;
                                                txtDirector.Text = string.Empty;
                                                txtSalesCount.Text = string.Empty;
                                                txtMonthlyRevenue.Text = string.Empty;
                                                txtP.Text = string.Empty;
                                                txtRatingStore.Text = string.Empty;
                                                txtLocation.Text = string.Empty;
                                                txtIsOnline.Text = string.Empty;
                                            }
                                            else MessageBox.Show("Такой магазин уже есть!");
                                        }
                                        else MessageBox.Show("Введите корректный адрес. Например: ул. Строителей, 14");
                                    }
                                    else MessageBox.Show("Введите корректный рейтинг магазина!");
                                }
                                else MessageBox.Show("Введите корректное колличество покупателей");
                            }
                            else MessageBox.Show("Введи екорректное значение выручки за октябрь");
                        }
                        else MessageBox.Show("Введите корректное число количества продаж");
                    }
                    else MessageBox.Show("В ФИО директора могут содержаться только буквы и пробелы!");
                }
                else MessageBox.Show("В названии магазина могут содержаться только буквы и пробелы!");
            }
            else MessageBox.Show("Вы ввели не все данные о магазине!");
        }
    }
}
