## Git使用指南:

**首先，安装Git Bash**；**Git Bash下载地址：https://git-scm.com/downloads**

### **一、注册Github仓库**（https://github.com/）

### **二、新建仓库**

**1、注册好了之后新建仓库，进入Github主界面，鼠标左击右上角“+”处，选择 New repository，接着创建Repository name，接着选择Public，接着选择Add a README file，然后选择Create repository；（第一步Git仓库创建完成）**

**三、git连接github远程仓库**

**Github支持两种同步方式`“https”`和`“ssh”`。**

**如果使用`https`很简单基本不需要配置就可以使用，但是每次提交代码和下载代码时都需要输入用户名和密码。**

**如果使用`ssh`方式就需要客户端先生成一个密钥对，即一个公钥一个私钥。然后还需要把公钥放到githib的服务器上。**

**我们直接使用ssh方式。**

**1、在任意位置创建一个空白文件夹，进入文件夹内，右击鼠标，选择Git Bash Here,选择git bash here弹出了git命令控制台！因为Git是分布式版本控制系统，所以需要填写用户名和邮箱作为一个标识。**

**2、刚开始在控制命令台输入以下命令：**

**git config --global user.name "XXXX"  用户名标识  ---- 实际也可以填写您的github仓库的名称 ;**

**git config --global user.email "xxxx@xxx.com"  邮箱标识  -------可以填写github仓库的邮箱;**

 **注意：`git config --global` “参数"，有了这个参数，表示你这台机器上所有的Git仓库都会使用这个配置，当然你也可以对某个仓库指定的不同的用户名和邮箱。**

**已注册github账号，由于你的本地Git仓库和github仓库之间的传输是通过SSH加密的，所以需要一点设置：**

 **3、创建`SSH Key`。在用户主目录下，看看有没有.ssh目录，如果有，再看看这个目录下有没有`id_rsa`和`id_rsa.pub`这两个文件，如果有的话，直接跳过此如下命令，如果没有的话，打开命令行，输入如下命令：**

**ssh-keygen -t rsa  //--创建秘钥;**

**当输入该行命名时，出现一系列指令，不用管，直接回车Enter,此时秘钥会存放在刚才新建的文件夹中，直接将其复制到.ssh文件夹中（.ssh一般在C:\Users\Administrator\.ssh），里面有2个文件一个是公钥 （后缀.pub）一个是私钥，打开方式用记事本打开即可：这里我们只用.pub公钥。**

**4、远程github配置ssh秘钥**

**密钥生成后需要在github上配置密钥本地才可以顺利访问。**

**进入github右上角你账号的头像选择settings，进去之后选择 SSH and GPG keys，点击New SSH key，可选择添加Title，在Key中添加.pub公钥，然后选择Add SSH key。**![img](https://img2020.cnblogs.com/blog/2144260/202102/2144260-20210210142233372-385677780.png)

![img](https://img2020.cnblogs.com/blog/2144260/202102/2144260-20210210142421415-2051802105.png)



![img](https://img2020.cnblogs.com/blog/2144260/202102/2144260-20210210142544987-585176617.png)



![img](https://img2020.cnblogs.com/blog/2144260/202102/2144260-20210210142842621-692781828.png)

**四、连接远程仓库**

**以上完成之后，接下来就是连接指定仓库。**

**git工具使用以下命令，看是否有没有远程仓库源。**

**1、git remote      //--git查看远程仓库信息；**

![img](https://img2020.cnblogs.com/blog/2144260/202102/2144260-20210210144515843-820456060.png)

**出现以上错误则表明在该文件夹中无.git文件，其原因是没有使用 git init命令 ，它不是一个仓库文件夹。**

**2、此时，再输入： git init**

**则显示在该文件夹中已存在.git文件，如下图所示：**

![img](https://img2020.cnblogs.com/blog/2144260/202102/2144260-20210210144814174-1900831386.png)

**3、然后再输入：git remote**

![img](https://img2020.cnblogs.com/blog/2144260/202102/2144260-20210210144833533-2077262239.png)

**没有任何显示，则表示没有仓库信息。**

**4、接下来需要手动创建添加仓库信息。**

**git remote add origin git@github.com:skq-5233/C-Sharp-Demo.git**

**（origin：仓库名；C-Sharp-Demo：GitHub中创建的仓库名）；**

**5、然后，输入下列命令：git remote -v**

![img](https://img2020.cnblogs.com/blog/2144260/202102/2144260-20210210145159710-1259541137.png)

**显示有fetch ：抓取；push：推；**

**五、如何把本地仓库上传到远程仓库的步骤**

**1、首先到本地仓库目录下使用:	git remote**	

**查看是否有.git文件夹，如果没有，在git的bash输入git init；如四.2;**

 **然后在本地仓库放需要上传的内容，新建一个文本测试**

![img](https://img2020.cnblogs.com/blog/2144260/202102/2144260-20210222105956280-1471987294.png)

**2、接着输入：**

**git add .**

**3、然后输入：**

**git commit -m "注释（任意注释均可）"**

![img](https://img2020.cnblogs.com/blog/2144260/202102/2144260-20210222111315606-988066102.png)

**4、把本地库的内容第一次推送到远程仓库，需要使用以下命令：**

**git push -u origin master       （第二次推送时，使用命令：git push origin master）;**

![img](https://img2020.cnblogs.com/blog/2144260/202102/2144260-20210222122730406-576858942.png)

**实际上是把当前分支master推送到远程，由于远程库是空的，我们第一次推送`master`分支时，加上 `–u`参数，Git不但会把本地的master分支内容推送的远程新的master分支，还会把本地的master分支和远程的master分支关联起来，推送成功后，可以立刻在github页面中看到远程库的内容已经和本地一模一样了。只要本地作了提交，就可以通过如下命令：`git push origin master`把本地master分支的最新修改推送到github上了。**

![img](https://img2020.cnblogs.com/blog/2144260/202102/2144260-20210222122751015-1397846945.png)

**完成本地仓库到远程仓库（Github）的推送。**

**六、本地仓库同步远程仓库**

**以上完成之后 如果需要把远程仓库同步到 本地仓库 我们就要拉取最新数据到本地仓库，命令如下：**

**1、git pull  origin master    (before  pull ,check local repository newer or not?if no, do it;if yes ,input: git add . (then) git commit -m "注释（任意注释均可）",product code number );**

**七、错误处理**

##### 在执行命令 git push origin master 时，报错 !

 **[rejected] master -> master (non-fast-forward) error: failed to push some refs to 'git@gitee.com:***‘**

**意思是远程仓库的README.md 与本地没有合并。（建仓库的时候勾选了创建 README.md）**

**1、解决：可以使用以下命令进行合并:**

**git pull --rebase origin master  (见六.1)**

**然后使用命令:git pull origin master上传即可。**

**2、在执行git pull origin main时，报错：error: src refspec main does not match any**

**原因是：本地仓库的名称与远程仓库名称(默认是main,受到"Black Lives Matter"运动的影响)不一致导致的，故需修改仓库名。**

**或使用命令：git pull origin master（当使用该条命令时，在远程仓库端会产生一个新的branch:mastere）；**

**git branch -m master main（如下图所示：本地仓库名由master改为main）；**

![image-20211225102906372](C:\Users\eivision\AppData\Roaming\Typora\typora-user-images\image-20211225102906372.png)

**然后再使用：**

**git push origin main**

