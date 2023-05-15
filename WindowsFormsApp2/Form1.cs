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
using System.Collections;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBox1.Text = "0"; Form이 일어나면 생기는 것이므로 여기 선언해주어도 되고 속성-Text에서 0으로 선언해줘도 된다.
            // private void textBox1_TextChanged에서 선언하면 해당 이벤트가 발생하지 않았기 때문에 실행이 되지 않은 상태로 의미가 없다.
            timer1.Start();
            timer1.Interval = 1000;

        }


        // 디자인할때 변수명 생각해서 짓기

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int _okCount = int.Parse(oKCount.Text);
            _okCount++;
            oKCount.Text = _okCount.ToString();

            // ng도 스코프때문에 일단 선언해줌
            int _ngCount = int.Parse(ngCount.Text);

            int _totalCount = int.Parse(totalCount.Text);
            _totalCount++;
            totalCount.Text = _totalCount.ToString();

            float _okPercent = (float)_okCount / _totalCount * 100;
            okPercent.Text = _okPercent.ToString("F");

            float _ngPercent = (float)_ngCount / _totalCount * 100;
            ngPercent.Text = _ngPercent.ToString("F");


            // 총 % 구하는 방식
            int percent = (int)Math.Round(_ngPercent + _okPercent);


            totalPercent.Text = percent.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ListBox 초기화
            boxFordataView.Items.Clear();
       

            // 선택된 파일의 내용을 ListBox에 추가
            string fileName = fileNameBox.SelectedItem.ToString();
            string filePath = Path.Combine(folderBrowserDialog1.SelectedPath, fileName);
            int lineCount = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;                
                boxFordataView.Items.Clear(); //다른파일 오픈 시 전 내용 clear

                while ((line = reader.ReadLine()) != null)
                {
                    boxFordataView.Items.Add(line);
                    lineCount++;
                }

            }

        }



        private void btnOKplus_Click(object sender, EventArgs e)
        {
            boxFordataView.Items.Add(boxForAppendtoFile.Text);
        }

        private void BtnInitialize_Click(object sender, EventArgs e)
        {

            oKCount.Text = "0";
            ngCount.Text = "0";
            totalCount.Text = "0";
            totalPercent.Text = "0";
            okPercent.Text = "0";
            ngPercent.Text = "0";
            upperOKCount.Text = "0";
            lowerNGCount.Text = "0";
            totalCountChange.Text = "0";
            upperOKPercent.Text = "0";
            lowerNGPercent.Text = "0";
            totalPercentChange.Text = "0";
        }

        private void totalCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnSelectfile_Click(object sender, EventArgs e)
        {
            // 주소창 clear
            selectedFolderPath.Clear();

            // folderBrowserDialog 시작위치 바탕화면으로 설정
            folderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // 선택된 파일의 full경로 불러와서 selectedFolderPath에 표시
                selectedFolderPath.Text = folderBrowserDialog1.SelectedPath;
                // 폴더 안에 있는 파일 제목을 ComboBox에 추가
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                foreach (string file in files)
                {
                    fileNameBox.Items.Add(Path.GetFileName(file));
                }
            }

        }

        private void selectedFolderPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelForDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd              HH:mm:ss");
        }

        private void btnNGplus_Click(object sender, EventArgs e)
        {
            int _ngCount = int.Parse(ngCount.Text);
            _ngCount++;
            ngCount.Text = _ngCount.ToString();

            int _totalCount = int.Parse(totalCount.Text);
            _totalCount++;
            totalCount.Text = _totalCount.ToString();

            // ok도 스코프때문에 일단 선언해줌
            int _okCount = int.Parse(oKCount.Text);

            float _okPercent = (float)_okCount / _totalCount * 100;
            okPercent.Text = _okPercent.ToString("F");

            float _ngPercent = (float)_ngCount / _totalCount * 100;
            ngPercent.Text = _ngPercent.ToString("F");

            // 총 % 구하는 방식
            int percent = (int)Math.Round(_ngPercent + _okPercent);


            totalPercent.Text = percent.ToString();
        }

        private void ngCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpperOK_Click(object sender, EventArgs e)
        {
            int _upperOKCount = int.Parse(upperOKCount.Text);
            _upperOKCount++;
            upperOKCount.Text = _upperOKCount.ToString();

            // ng도 스코프때문에 일단 선언해줌
            int _lowerNGCount = int.Parse(lowerNGCount.Text);

            int _totalCountChange = int.Parse(totalCountChange.Text);
            _totalCountChange++;
            totalCountChange.Text = _totalCountChange.ToString();

            float _upperOKPercent = (float)_upperOKCount / _totalCountChange * 100;
            upperOKPercent.Text = _upperOKPercent.ToString("F");

            float _lowerNGPercent = (float)_lowerNGCount / _totalCountChange * 100;
            lowerNGPercent.Text = _lowerNGPercent.ToString("F");


            // 총 % 구하는 방식
            int percentChange = (int)Math.Round(_lowerNGPercent + _upperOKPercent);


            totalPercentChange.Text = percentChange.ToString();

        }

        private void BtnLowerNG_Click(object sender, EventArgs e)
        {
            int _lowerNGCount = int.Parse(lowerNGCount.Text);
            _lowerNGCount++;
            lowerNGCount.Text = _lowerNGCount.ToString();

            int _totalCountChange = int.Parse(totalCountChange.Text);
            _totalCountChange++;
            totalCountChange.Text = _totalCountChange.ToString();

            // ok도 스코프때문에 일단 선언해줌
            int _upperOKCount = int.Parse(upperOKCount.Text);

            float _upperOKPercent = (float)_upperOKCount / _totalCountChange * 100;
            upperOKPercent.Text = _upperOKPercent.ToString("F");

            float _lowerNGPercent = (float)_lowerNGCount / _totalCountChange * 100;
            lowerNGPercent.Text = _lowerNGPercent.ToString("F");


            // 총 % 구하는 방식
            int percentChange = (int)Math.Round(_lowerNGPercent + _upperOKPercent);


            totalPercentChange.Text = percentChange.ToString();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            string[] insertData = { numBoxright.Text, idBox.Text };
            ListViewItem listViewItem = new ListViewItem(insertData);
            dataInsertBox.Items.Add(listViewItem);


            numBoxright.Text = "";
            idBox.Text = "";
        }

        private void numBoxForCompare_TextChanged(object sender, EventArgs e)
        {

        }

        private void compare_Click(object sender, EventArgs e)
        {
            // 기존 ListView의 모든 아이템을 가져와서 비교.
            foreach (ListViewItem item in dataInsertBox.Items)
            {
                // ListView의 0번째 데이터와 TextBox에 있는 데이터를 비교.
                if (item.SubItems[0].Text == numBoxForCompare.Text)
                {
                    // 데이터가 일치할 경우 messageBox 출력
                    MessageBox.Show("데이터 일치!");
                    return;
                }
            }
            // 일치하는 데이터가 없는 경우.
            MessageBox.Show("일치하는 데이터 없음.");
        }

        private void labelForDateTime_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boxFordataView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
