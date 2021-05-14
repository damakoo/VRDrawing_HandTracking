# VRDrawing_HandTracking

VR空間で空間または平面に絵を描くことができるアプリ

# DEMO

https://drive.google.com/file/d/1LAkQVf-wSpHAYD1dMbPN452YgHhtyYBi/view?usp=sharing


# Features

描く色，描く太さ，平面か空間どちらに描くかを変更することができる．

Oculus Linkを使えばパソコンからお手本となる字をリアルタイムに描くことができる．

# Requirement

Oculus Quest または Oculus Quest 2

Unity

# Installation & Usage

```bash
git clone https://github.com/damakoo/VRDrawing_HandTracking.git
```

Unity Hubでcloneしたプロジェクトを指定する

Project > Assets > Scenes > VRDrawing_handtracking.unity　を開く

Oculus Questを接続し，File > Build And Run で実行

椅子に座ってやることを想定した位置にボタンがある．
必要に応じて右コントローラのReservedボタンを長押ししてキャリブレーションを行う．
親指と人差し指でつまむような動作をしたとき字を書く/消すことができるようになっています．
VR空間のボタンを人差し指で押すことでモードなどが変わる．


各ボタン説明

太さ：描く線の太さを変えることができる．

色：描く線の色を変えることができる．
ピンク、赤、青、黒、黄、白、緑がある．

モード：モードに応じてつまみ動作を行ったときに何ができるかが異なる．

なし：何も起こらない．

書く：線を描くことができる

消す：線を消すことができる

全消去：描かれた線をすべて消すことができる．

次元：3Dだとペン先からインクが出る．2Dだとペンが黒板または机に接触した際に接触点にインクが出る．


# Author
Daiki Kodama

東京大学大学院情報理工学系研究科知能機械情報学専攻修士1年

email:d_kodama at cyber.t.u-tokyo.ac.jp

