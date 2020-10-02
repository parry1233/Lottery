using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_hw8_lottery2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = imageList1.Images[0];
			pictureBox2.BackgroundImage = imageList1.Images[0];
			pictureBox3.BackgroundImage = imageList1.Images[0];
			pictureBox4.BackgroundImage = imageList1.Images[0];
			pictureBox5.BackgroundImage = imageList1.Images[0];
			pictureBox6.BackgroundImage = imageList1.Images[0];
		}
		private void button1_Click(object sender, EventArgs e)
		{
			int[] random_groups = new int[6];
			random_groups = GetRandom();
			pictureBox1.BackgroundImage = imageList1.Images[random_groups[0]];
			pictureBox2.BackgroundImage = imageList1.Images[random_groups[1]];
			pictureBox3.BackgroundImage = imageList1.Images[random_groups[2]];
			pictureBox4.BackgroundImage = imageList1.Images[random_groups[3]];
			pictureBox5.BackgroundImage = imageList1.Images[random_groups[4]];
			pictureBox6.BackgroundImage = imageList1.Images[random_groups[5]];
		}
		private int[] GetRandom()
		{
			int[] random_groups = new int[6];
			for (int i = 0; i < random_groups.Length; i++)
			{
				Random rand = new Random(Guid.NewGuid().GetHashCode());
				//ㄇㄉ一直中是怎樣 = = -->利用Guid.NewGuid()每一次所產生出來的結果都是不同的，再利用它產生雜湊碼來當成亂數產生器的種子，產生出真的很亂的亂數。
				int temp = rand.Next(1, 42);//1<=random<10
				Boolean check_duplicate = true;
				while(check_duplicate)
				{
					if(!random_groups.Contains(temp))//check whether the number of temp is already contained in gruops
					{
						check_duplicate = false;
						random_groups[i] = temp;
					}
					else
					{
						rand= new Random(Guid.NewGuid().GetHashCode());
						temp = rand.Next(1, 42);
					}
				}
			}
			return random_groups;
		}
	}
}
