using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace doyo_kouza_RPG {
    public partial class Form1 : Form {
        //自分と敵のHPを宣言
        private int 敵のHP;
        private int 自分のHP;

        public Form1() {
            敵のHP = 200; //敵のHPの設定
            自分のHP = 200; //自分のHPの設定
            InitializeComponent();
            EnsHP.Text = "敵のHP: " + 敵のHP.ToString(); //敵のHPを表示
            MyHP.Text = "自分のHP: " + 自分のHP.ToString(); //自分のHPを表示
        }

        //aからbまでのランダム値を返す関数
        private static int 乱数生成(int a, int b) {
            Random p = new Random();
            return p.Next(a, b + 1);
        }

        //攻撃用関数（ここを書いてください）
        private void 攻撃(string 名前, int 強さ) {
            Console.Text = 名前 + " によって敵は " + 強さ + " ダメージを受けた！"; //状況を表示
            敵のHP = 敵のHP - 強さ; //敵のHPを減らす
            EnsHP.Text = "敵のHP: " + 敵のHP.ToString(); //敵のHPを表示
            判定(); //決着がついたか確認

            Refresh(); //コンソールの再描画に必要
            Thread.Sleep(2000); //2秒間停止

            int 乱数 = 乱数生成(1, 3);
            if (乱数 == 1) {
                相手の攻撃("炎", 10);
            } else if (乱数 == 2) {
                相手の攻撃("拳", 20);
            } else if (乱数 == 3) {
                相手の攻撃("頭突き", 30);
            }
            判定(); //決着がついたか確認
        }

        //決着がついたか確認
        private void 判定() {
            if (敵のHP <= 0) {
                MessageBox.Show("おめでとう、勝利した！");
                this.Close();
            }

            if (自分のHP <= 0) {
                MessageBox.Show("残念、負けてしまった。");
                this.Close();
            }
        }

        //相手の攻撃用関数
        private void 相手の攻撃(string 名前, int 強さ) {
            Console.Text = 名前 + " によって " + 強さ + " ダメージを受けてしまった！"; //状況を表示
            自分のHP = 自分のHP - 強さ; //自分のHPを減らす
            MyHP.Text = "自分のHP: " + 自分のHP.ToString(); //自分のHPを表示
        }

        private void Sword_Click(object sender, EventArgs e) {
            攻撃("剣", 20);
        }

        private void Magic_Click(object sender, EventArgs e) {
            攻撃("魔法", 50);
        }
    }
}
