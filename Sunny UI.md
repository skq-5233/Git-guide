## 一、UI headerbutton图标选择；

```c#
使用UI Headerbutton-->属性-->symbol切换图标；
```

## 二、利用图标实现退出功能；

```C#
//点击右上角图标，实现退出功能(2022-0118--start)；
private void uiAvatar1_Click(object sender, EventArgs e)
{
    Application.Exit();
}
//点击右上角图标，实现退出功能(2022-0118--end)；
```

##  三、实现界面加载完成时，button默认被选中；

```c#
//实现界面加载完成时，button默认选中状态(2022-0118--start)；
public Form1()
{
    InitializeComponent(); //初始化函数；
    defaultfilepath = "";  //默认文件夹路径；
    uiHeaderButton1.IsPress = true; //设置默认手动模式button；

}

//模式切换选择（2022-0113）；
bool auto_or_manual = true;

//模式切换选择（2022-0113--start）；

//手动模式（2022-0117）；
 private void uiHeaderButton1_Click(object sender, EventArgs e)
{
    //uiHeaderButton1.IsPress = true; //设置默认手动模式button； 
    if (auto_or_manual)
    {
        uiHeaderButton1.IsPress = true; //设置默认手动模式button打开；
        uiHeaderButton2.IsPress = false; //设置默认手动模式button关闭；
        groupBox3.Visible = false;
        groupBox1.Visible = true;
        auto_or_manual = !auto_or_manual;
    }
    //else
    //{
    //    groupBox3.Visible = true;
    //    groupBox1.Visible = false;
    //    auto_or_manual = !auto_or_manual;
    //}
}

//自动模式（2022-0117）；
private void uiHeaderButton2_Click(object sender, EventArgs e)
{
    if (!auto_or_manual)
    {
        uiHeaderButton1.IsPress = false; //设置默认手动模式button关闭；
        uiHeaderButton2.IsPress = true; //设置默认手动模式button打开；
        groupBox3.Visible = true;
        groupBox1.Visible = false;
        auto_or_manual = !auto_or_manual;
    }
}
//模式切换选择（2022-0113--end）；
//实现界面加载完成时，button默认选中状态(2022-0118--end)；
```

## 四、如何在picturebox中加载无边框的图像；

```c#
BackColor---Transparent；
```



