using System.Windows.Forms;
using z3_v9_SergeevaAgata;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //��������� �������� Q, ��� salesCount = 10, monthlyRevenue = 1000.00m
        [Test]
        public void Q_MoreZero()
        {
            var store = new Stores("�������", "������ ���� ��������", 10, 1000.00m);
            decimal result = store.Q();
            Assert.AreEqual(100.00m, result);
        }

        //��������� �������� Q, ��� salesCount = 0, monthlyRevenue = 1000.00m
        [Test]
        public void Q_LessZero()
        {
            var store = new Stores("�������", "������ ���� ��������", 0, 1000.00m);
            decimal result = store.Q();
            Assert.AreEqual(0, result);
        }

        //��������� ���������� �� ���������� ������ � ��������� ( � ��������� �� ��� ����������)
        [Test]
        public void Add()
        {

            var storeList = new List<Stores>();
            var store = new Stores("�������", "������ ���� ��������", 10, 100);

            store.AddStore(storeList, store);

            Assert.AreEqual(1, storeList.Count);
            Assert.AreEqual("�������", storeList[0].title);
            Assert.AreEqual("������ ���� ��������", storeList[0].director);
            Assert.AreEqual(10, storeList[0].salesCount);
            Assert.AreEqual(100, storeList[0].monthlyRevenue);
        }

        //��������� �������� ������� �� �������� (���� �� ���� � ������)
        [Test]
        public void RemoveTitle_True()
        {
            var store = new Stores("�������", "������ ���� ��������", 10, 100);
            var storeList = new List<Stores>
            {
            store,
            new Stores("������", "����� ��� Ը�������", 20, 200)
            };
            var storeNameToRemove = "�������";


            var result = store.RemoveStore(storeList, storeNameToRemove);

            Assert.IsTrue(result); //���������, ��� ��������� ��������
            Assert.AreEqual(1, storeList.Count); //���������, ��� � ��������� ������� ������ ���� �������
            Assert.IsFalse(storeList.Any(s => s.title.Equals(storeNameToRemove, StringComparison.OrdinalIgnoreCase))); //���������, ��� ������ ��� �������� � ����� ���������
        }

        //��������� �������� ������� �� �������� (���� ������ ��� � ������)
        [Test]
        public void RemoveTitle_False()
        {
            var store = new Stores("�������", "������ ���� ��������", 10, 100);
            var storeList = new List<Stores>
            {
            store,
            new Stores("������", "����� ��� Ը�������", 20, 200)
            };
            var storeNameToRemove = "������";


            var result = store.RemoveStore(storeList, storeNameToRemove);

            Assert.IsFalse(result); //���������, ��� �������� �� ���������
            Assert.AreEqual(2, storeList.Count); //���������, ��� � ��������� �������� ��� ��������
        }

        //��������� �������� ������� �� ���������� ������, ����� �������� �������� ������/����� ��������� ��������� ������
        [Test]
        public void RemoveSalesCount_True()
        {
            var store = new Stores("�������", "������ ���� ��������", 10, 100);
            var storeList = new List<Stores>
            {
            store,
            new Stores("������", "����� ��� Ը�������", 20, 200),
            new Stores("�����", "����� ���������� �������������", 50, 200)
            };

            int salesCountToRemove = 20;
            bool result = store.RemoveStore(storeList, salesCountToRemove);

            Assert.IsTrue(result); //�������� �� ��, ��� �������� ���������
            Assert.AreEqual(1, storeList.Count);
            Assert.IsFalse(storeList.Any(s => s.salesCount <= salesCountToRemove)); // ��������, ��� �������� � salesCount <= 15 �������
        }

        //��������� �������� ������� �� ���������� ������, ����� �������� �������� ������ ���� �������� ������
        [Test]
        public void RemoveSalesCount_False()
        {
            var store = new Stores("�������", "������ ���� ��������", 10, 100);
            var storeList = new List<Stores>
            {
                 store,
                 new Stores("������", "����� ��� Ը�������", 20, 200),
                 new Stores("�����", "����� ���������� �������������", 50, 200)
            };

            int salesCountToRemove = 5;
            bool result = store.RemoveStore(storeList, salesCountToRemove);

            Assert.IsFalse(result); //�������� �� ��, ��� �������� ���������
            Assert.AreEqual(3, storeList.Count);
        }

        //��������� �������� �������� �� ������� �� �����, ���� ������� �������� ������/����� ��������� ��������� �������
        [Test]
        public void RemoveMonthlyRevenue_True()
        {
            var store = new Stores("�������", "������ ���� ��������", 10, 100);
            var storeList = new List<Stores>
            {
            store,
            new Stores("������", "����� ��� Ը�������", 20, 200),
            new Stores("�����", "����� ���������� �������������", 50, 100)
            };

            decimal monthlyRevenueToRemove = 150;
            bool result = store.RemoveStore(storeList, monthlyRevenueToRemove);

            Assert.IsTrue(result); //�������� �� ��, ��� �������� ���������
            Assert.AreEqual(1, storeList.Count);
            Assert.IsFalse(storeList.Any(s => s.monthlyRevenue <= monthlyRevenueToRemove)); // ��������, ��� �������� � salesCount <= 15 �������
        }

        //��������� �������� �������� �� ������� �� �����, ���� ������� �������� ������ ���� �������� �������
        [Test]
        public void RemoveMonthlyRevenue_False()
        {
            var store = new Stores("�������", "������ ���� ��������", 10, 100);
            var storeList = new List<Stores>
            {
            store,
            new Stores("������", "����� ��� Ը�������", 20, 200),
            new Stores("�����", "����� ���������� �������������", 50, 100)
            };

            decimal monthlyRevenueToRemove = 99;
            bool result = store.RemoveStore(storeList, monthlyRevenueToRemove);

            Assert.IsFalse(result); //�������� �� ��, ��� �������� ���������
            Assert.AreEqual(3, storeList.Count);
        }


        //�������� �� ��, ��� ��������� �������� Qp, ���� ���-�� ����������� ������� 50 ���.
        [Test]
        public void Qp_More50000()
        {
            // Arrange
            var instance = new RetailStore("�������", "������ ���� ��������", 10, 100, 60000, "4", "��. ������������, 73", false);

            // Act
            var result = instance.Qp();

            // Assert
            Assert.AreEqual(20m, result); //
        }

        //�������� �� ��, ��� ��������� �������� Qp, ���� ���-�� ����������� ������/����� 50 ���.
        [Test]
        public void Qp_Less50000()
        {
            // Arrange
            var instance = new RetailStore("�������", "������ ���� ��������", 10, 100, 50000, "4", "��. ������������, 73", false);

            // Act
            var result = instance.Qp();

            // Assert
            Assert.AreEqual(5m, result);
        }

        //�������� �� ��, ��� ����������� �������� � ������� ( � �������� �� ��� ����������)
        [Test]
        public void AddHistory()
        {
            var retailStore = new RetailStore("�������", "������ ���� ��������", 10, 100, 50000, "4", "��. ������������, 73", false);
            string storeName = "�������";

            retailStore.AddHistory(storeName);
            var historyQueue = retailStore.GetHistoryQueue();

            Assert.AreEqual(1, historyQueue.Count()); //���������, ��� � ������� 1 �������

            //�������� �� ��, ��������� �� ���������� ������
            string sub = $"{storeName} - ";
            string value = historyQueue.Dequeue();
            Assert.IsTrue(value.StartsWith(sub));

            //��������, ���� �� ����� � ��������
            DateTime time;
            string[] parts = value.Split(" - ");
            Assert.AreEqual(2, parts.Length); //���������, ��� ������ ������� �� ���� ������
            Assert.IsTrue(DateTime.TryParse(parts[1], out time)); //��������� �����
        }

        //�������� �� ��, ����� �������� ����������� � ������� �������
        [Test]
        public void GetHistoryQueue()
        {
            var retailStore = new RetailStore("�������", "������ ���� ��������", 10, 100, 50000, "4", "��. ������������, 73", false);
            string storeName = "�������";

            retailStore.AddHistory(storeName);

            //������� ��������
            Queue<string> historyQueue = retailStore.GetHistoryQueue();

            Assert.IsNotNull(historyQueue); //���������, ��� ������� �� ������
            Assert.AreEqual(1, historyQueue.Count); //���������, ��� ��� ���� 1 �������

            //���� ���������� ���������
            string value = historyQueue.Dequeue();

            //� ���������, ��� ��� ���������� � ������ ���, ��� ��� ����
            Assert.IsTrue(value.StartsWith($"{storeName} - "));

            //��������, ���� �� ����� � ��������
            DateTime time;
            string[] part= value.Split(" - ");

            Assert.AreEqual(2, part.Length); //���������, ��� ������ ������� �� ���� ������
            Assert.IsTrue(DateTime.TryParse(part[1], out time)); //��������� �����

            //[Test]
            //public void ShowStores()
            //{

            //    var store = new Stores("�������", "������ ���� ��������", 10, 100);

            //    var dgv = new DataGridView();
            //    dgv.Columns.Add("Title", "Title");
            //    dgv.Columns.Add("Director", "Director");
            //    dgv.Columns.Add("SalesCount", "Sales Count");
            //    dgv.Columns.Add("MonthlyRevenue", "Monthly Revenue");

            //    store.Show(dgv);

            //    Assert.AreEqual(1, dgv.Rows.Count); 
            //    Assert.AreEqual("�������", dgv.Rows[0].Cells["Title"].Value); 
            //    Assert.AreEqual("������ ���� ��������", dgv.Rows[0].Cells["Director"].Value); 
            //    Assert.AreEqual(10, dgv.Rows[0].Cells["SalesCount"].Value); 
            //    Assert.AreEqual(100, dgv.Rows[0].Cells["MonthlyRevenue"].Value); 
            //}

            //[Test]
            //public void ShowHistory()
            //{
            //    var retailStore = new RetailStore("�������", "������ ���� ��������", 10, 100, 50000, "4", "��. ������������, 73", false);

            //    retailStore.AddHistory("������� - 2024-11-10 10:00:00");
            //    retailStore.AddHistory("������� - 2024-11-10 10:01:00");

            //    ListBox listBox = new ListBox();

            //    retailStore.ShowHistory(listBox);

            //    Assert.AreEqual(2, listBox.Items.Count); 
            //    Assert.AreEqual("������� - 2024-11-10 10:00:00", listBox.Items[0]); 
            //    Assert.AreEqual("������� - 2024-11-10 10:01:00", listBox.Items[1]);
            //}


        }

    }
}