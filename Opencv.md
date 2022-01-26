## 一、 读入、显示、保存图像；

```python
# 001;
import numpy as np
import cv2

# Load an color image in grayscale
# cv2.imread(读取图像)；
img = cv2.imread('D:/software/DL information/Opencv/Opencv.png',0) 

 # imshow(显示图像)；
cv2.imshow('image',img) 
cv2.waitKey(0)&0xFF  # 64 位系统，使用&0xFF;
cv2.destroyAllWindows()

# cv2.imwrite(保存图像)；
cv2.imwrite("D:/skq/DL/DL informaton/Opencv/VR-Gray.jpg",img) 
print(img)

# 警告： 就算图像的路径是错的， OpenCV 也不会提醒你的，但是当你使用命令print(img)时得到的结果是None。
```

## 二、加载图像，按下’s’键保存后退出，按下 ESC 键退出不保存。  

```python
# 002（先创建窗口，在加载图像）；
import numpy as np
import cv2
img = cv2.imread('D:/software/DL information/Opencv/Opencv.png',0) # cv2.imread(读取图像)；
cv2.namedWindow('image',cv2.WINDOW_NORMAL) # cv2.WINDOW_NORMAL,可手动调整显示图像的窗口大小;
cv2.imshow('image',img)
cv2.waitKey(0)&0xFF  # 64 位系统，使用&0xFF--- 将 k = cv2.waitKey(0) 这行改成k = cv2.waitKey(0)&0xFF;
cv2.destroyAllWindows()

cv2.imwrite("D:/skq/DL/DL informaton/Opencv/VR-Gray1.png",img)   # cv2.imwrite(保存图像);
```

## 三、使用 Matplotlib ;

```python
# 003;
使用 Matplotlib
import numpy as np
import cv2
from matplotlib import pyplot as plt

img = cv2.imread('D:/software/DL information/Opencv/Opencv.png',0) # 读取图像；

plt.imshow(img,cmap = 'gray', interpolation = 'bicubic')
plt.xticks([]), plt.yticks([]) # to hide tick values on X and Y axis
plt.show()
cv2.imwrite('D:/skq/DL/DL informaton/Opencv/VR003.png',img) # 保存图像；

# 注意：彩色图像使用 OpenCV 加载时是 BGR 模式。但是 Matplotib 是 RGB模式。所以彩色图像如果已经被 OpenCV 读取，那它将不会被 Matplotib 正确显示。
# https://matplotlib.org/2.0.2/index.html
```

## 四、播放视频；

```python
# 4.1 用摄像头捕获视频;
import numpy as np
import cv2
cap = cv2.VideoCapture(0) 
while(True):
    # Capture frame-by-frame
    ret, frame = cap.read() # cap.read() 返回一个布尔值（True/False）;
    # Our operations on the frame come here
    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    # Display the resulting frame
    cv2.imshow('frame', gray)
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break
# When everything done, release the capture
cap.release()
cv2.destroyAllWindows()

# 4.2 从文件中播放视频;
# 播放视频；
import cv2
cv =cv2.VideoCapture("Fall.mp4")
# 检查视频是否正确打开；
if cv.isOpened():
    open,frame = cv.read()
else:
    open = False
while open:
    ret,frame = cv.read()
    if frame is None:
        break
    if ret == True:
        gray = cv2.cvtColor(frame,cv2.COLOR_BGR2GRAY)
        cv2.imshow("result",gray)
        if cv2.waitKey(10) &0xFF == 27:
            break
cv.release()
cv2.destroyAllWindows()
```

## 五、**OpenCV** 中的绘图函数；

```python
# 005_1 画线；
import numpy as np
import cv2
from matplotlib import pyplot as plt
# Create a black image
img=np.zeros((512,512,3), np.uint8)
# print(img)
# Draw a diagonal blue line with thickness of 5 px
cv2.line(img,(0,0),(511,511),(255,0,0),5)
cv2.imshow("img",img) # 画出蓝色直线（左上至右下）；
cv2.imwrite("E:\\Deep Learning\\DeepLearning\\Opencv\\Blue_Line.jpg",img) # 保存
cv2.waitKey(0)

# 005_2 画矩形；
import numpy as np
import cv2
img=np.zeros((512,512,3), np.uint8)
# cv2.line(img,(0,0),(511,511),(255,0,0),5)
# cv2.rectangle(img,(384,0),(510,128),(0,255,0),3)
cv2.rectangle(img,(384,0),(510,128),(0,255,0),3)
cv2.imshow("img",img)
cv2.imwrite("E:\\Deep Learning\\DeepLearning\\Opencv\\rectangle.jpg",img)
cv2.waitKey(0)

# 005_3 画圆；
import numpy as np
import cv2
img=np.zeros((512,512,3), np.uint8)
# cv2.line(img,(0,0),(511,511),(255,0,0),5)
# cv2.rectangle(img, (384, 0), (510, 128), (0, 255, 0), 3)
# cv2.circle(img,(447,63), 63, (0,0,255), -1)
cv2.circle(img,(447,63), 63, (0,0,255), -1)
cv2.imshow("img",img)
cv2.imwrite("E:\\Deep Learning\\DeepLearning\\Opencv\\circle.jpg",img)
cv2.waitKey(0)

# 005_4 画椭圆；
import numpy as np
import cv2
img=np.zeros((512,512,3), np.uint8)
<<<<<<< HEAD
# cv2.line(img,(0,0),(511,511),(255,0,0),5)
# cv2.rectangle(img, (384, 0), (510, 128), (0, 255, 0), 3)
# cv2.circle(img,(447,63), 63, (0,0,255), -1)
# cv2.ellipse(img,(256,256),(100,50),0,0,180,255,-1)
cv2.ellipse(img,(256,256),(100,50),0,0,180,255,-1)
cv2.imshow("img",img)
cv2.imwrite("E:\\Deep Learning\\DeepLearning\\Opencv\\ellipse.jpg",img)
cv2.waitKey(0)

# 005_5 画多边形；
import numpy as np
import cv2
import matplotlib.pyplot as plt

# 创建一个黑色图片 np.zeros()返回一个填充为0的数组
img = np.zeros((512,512,3),np.uint8)
pts=np.array([[100,150],[20,30],[400,20],[300,300]], np.int32)
pts=pts.reshape((-1,1,2))  # 这里 reshape 的第一个参数为-1, 表明这一维的长度是根据后面的维度的计算出来的。
# cv2.line(img,(0,0),(511,511),(255,0,0),5)
# cv2.rectangle(img, (384, 0), (510, 128), (0, 255, 0), 3)
# cv2.circle(img,(447,63), 63, (0,0,255), -1)
# cv2.ellipse(img,(256,256),(100,50),0,0,180,255,-1)
# cv2.polylines(img,[pts],True,(255,0,255))  # 如果第三个参数是 False，我们得到的多边形是不闭合的（首尾不相连）。
cv2.polylines(img,[pts],True,(255,0,255),cv2.LINE_AA)  # 如果第三个参数是 False，我们得到的多边形是不闭合的（首尾不相连）。
cv2.imshow("polylines",img)
cv2.imwrite("E:\\Deep Learning\\DeepLearning\\Opencv\\polygon.jpg",img)
cv2.waitKey(0)

=======
cv2.line(img,(0,0),(511,511),(255,0,0),5)
cv2.rectangle(img, (384, 0), (510, 128), (0, 255, 0), 3)
cv2.circle(img,(447,63), 63, (0,0,255), -1)
cv2.ellipse(img,(256,256),(100,50),0,0,180,255,-1)
cv2.imshow("ellipse",img)
cv2.imwrite("E:\\Deep Learning\\DeepLearning\\Opencv\\ellipse.jpg",img)
cv2.waitKey(0)

>>>>>>> 788726dc2794f0473eaf9698d132fbc4d41294fd
# 005_6 在图片上添加文字;
# 在图像上绘制白色的 OpenCV；
import numpy as np
import cv2
img=np.zeros((512,512,3), np.uint8)
font=cv2.FONT_HERSHEY_SIMPLEX

pts = np.array([[10,5],[20,30],[70,20],[50,10]], np.int32)
pts=pts.reshape((-1,1,2))  # 这里 reshape 的第一个参数为-1, 表明这一维的长度是根据后面的维度的计算出来的。
<<<<<<< HEAD
# cv2.line(img,(0,0),(511,511),(255,0,0),5)
# cv2.rectangle(img, (384, 0), (510, 128), (0, 255, 0), 3)
# cv2.circle(img,(447,63), 63, (0,0,255), -1)
# cv2.ellipse(img,(256,256),(100,50),0,0,180,255,-1)
# cv2.polylines(img,[pts],True,(255,0,255))  # 如果第三个参数是 False，我们得到的多边形是不闭合的（首尾不相连）。
=======
cv2.line(img,(0,0),(511,511),(255,0,0),5)
cv2.rectangle(img, (384, 0), (510, 128), (0, 255, 0), 3)
cv2.circle(img,(447,63), 63, (0,0,255), -1)
cv2.ellipse(img,(256,256),(100,50),0,0,180,255,-1)
cv2.polylines(img,[pts],True,(255,0,255)) # 如果第三个参数是False,则多边形是不闭合的（首尾不相连）。
>>>>>>> 788726dc2794f0473eaf9698d132fbc4d41294fd

cv2.putText(img,'OpenCV',(10,500), font, 4,(255,255,255),2)

winname = 'example'
cv2.namedWindow(winname)
cv2.imshow(winname, img)
cv2.waitKey(0)
cv2.destroyWindow(winname)
<<<<<<< HEAD
cv2.imwrite('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg',img)


# 005_7 把鼠标当画笔;
# import cv2
# events=[i for i in dir(cv2) if 'EVENT'in i]
# print (events)
# 打印['EVENT_FLAG_ALTKEY', 'EVENT_FLAG_CTRLKEY',
# 'EVENT_FLAG_LBUTTON', 'EVENT_FLAG_MBUTTON', 'EVENT_FLAG_RBUTTON', 'EVENT_FLAG_SHIFTKEY',
# 'EVENT_LBUTTONDBLCLK', 'EVENT_LBUTTONDOWN', 'EVENT_LBUTTONUP', 'EVENT_MBUTTONDBLCLK',
# 'EVENT_MBUTTONDOWN', 'EVENT_MBUTTONUP', 'EVENT_MOUSEHWHEEL', 'EVENT_MOUSEMOVE', 'EVENT_MOUSEWHEEL',
# 'EVENT_RBUTTONDBLCLK', 'EVENT_RBUTTONDOWN', 'EVENT_RBUTTONUP']

# 005_8 鼠标事件回调函数只用做一件事：在双击过的地方绘制一个圆圈。
import numpy as np
import cv2
img=np.zeros((512,512,3), np.uint8)
# mouse callback function
def draw_circle(event,x,y,flags,param):
    if event == cv2.EVENT_LBUTTONDBLCLK:
        cv2.circle(img, (x, y), 100, (255, 0, 0), -1)
# 创建图像与窗口并将窗口与回调函数绑定
img = np.zeros((512,512,3),np.uint8)
cv2.namedWindow('image')
cv2.setMouseCallback('image',draw_circle)
while(1):
    cv2.imshow('image', img)
    if cv2.waitKey(20) & 0xFF == 27:
        break
cv2.destroyAllWindows()

=======
cv2.imwrite('E:\\Deep Learning\\DeepLearning\\Opencv\\OpenCV.jpg',img)
>>>>>>> 788726dc2794f0473eaf9698d132fbc4d41294fd
```

## 六、把鼠标当画笔；

```python
# 005_7 把鼠标当画笔;
import cv2
events=[i for i in dir(cv2) if 'EVENT'in i]
print (events)
# 打印['EVENT_FLAG_ALTKEY', 'EVENT_FLAG_CTRLKEY',
# 'EVENT_FLAG_LBUTTON', 'EVENT_FLAG_MBUTTON', 'EVENT_FLAG_RBUTTON', 'EVENT_FLAG_SHIFTKEY',
# 'EVENT_LBUTTONDBLCLK', 'EVENT_LBUTTONDOWN', 'EVENT_LBUTTONUP', 'EVENT_MBUTTONDBLCLK',
# 'EVENT_MBUTTONDOWN', 'EVENT_MBUTTONUP', 'EVENT_MOUSEHWHEEL', 'EVENT_MOUSEMOVE', 'EVENT_MOUSEWHEEL',
# 'EVENT_RBUTTONDBLCLK', 'EVENT_RBUTTONDOWN', 'EVENT_RBUTTONUP']

# 005_8 鼠标事件回调函数只用做一件事：在双击过的地方绘制一个圆圈。
import numpy as np
import cv2
img=np.zeros((512,512,3), np.uint8)
# mouse callback function
def draw_circle(event,x,y,flags,param):
    if event == cv2.EVENT_LBUTTONDBLCLK:
        cv2.circle(img, (x, y), 100, (255, 0, 0), -1)
# 创建图像与窗口并将窗口与回调函数绑定
img = np.zeros((512,512,3),np.uint8)
cv2.namedWindow('image')
cv2.setMouseCallback('image',draw_circle)
while(1):
    cv2.imshow('image', img)
    if cv2.waitKey(20) & 0xFF == 27:
        break
cv2.destroyAllWindows()

# 005_9 高级一点的示例;

import numpy as np
import cv2
# 当鼠标按下时变为 True
drawing=False
# 如果 mode 为 true 绘制矩形。按下'm' 变成绘制曲线。
mode=True
ix,iy=-1,-1
# 创建回调函数
def draw_circle(event,x,y,flags,param):
    global ix,iy,drawing,mode
# 当按下左键是返回起始位置坐标
    if event==cv2.EVENT_LBUTTONDOWN:
        drawing=True
        ix,iy=x,y
# 当鼠标左键按下并移动是绘制图形。event 可以查看移动，flag 查看是否按下
    elif event==cv2.EVENT_MOUSEMOVE and flags==cv2.EVENT_FLAG_LBUTTON:
        if drawing==True:
            if mode==True:
                cv2.rectangle(img,(ix,iy),(x,y),(0,255,0),-1)
            else:# 绘制圆圈，小圆点连在一起就成了线，3 代表了笔画的粗细
                cv2.circle(img,(x,y),3,(0,0,255),-1) # 下面注释掉的代码是起始点为圆心，起点到终点为半径的
                # r=int(np.sqrt((x-ix)**2+(y-iy)**2))
                # cv2.circle(img,(x,y),r,(0,0,255),-1)
                # 当鼠标松开停止绘画。
    elif event==cv2.EVENT_LBUTTONUP:
        drawing==False
        # if mode==True:
        # cv2.rectangle(img,(ix,iy),(x,y),(0,255,0),-1)
        # else:
        # cv2.circle(img,(x,y),5,(0,0,255),-1)
        img = np.zeros((512, 512, 3), np.uint8)
        cv2.namedWindow('image')
        cv2.setMouseCallback('image', draw_circle)
        while (1):
            cv2.imshow('image', img)
            k = cv2.waitKey(1) & 0xFF
            if k == ord('m'):
                mode = not mode
            elif k == 27:
                break
```

## 七、用滑动条做调色板；

```python
# 005_10 用滑动条做调色板;
import cv2
import numpy as np
def nothing(x):
    pass
# 创建一副黑色图像
img=np.zeros((300,512,3),np.uint8)
cv2.namedWindow('image')
cv2.createTrackbar('R','image',0,255,nothing)
cv2.createTrackbar('G','image',0,255,nothing)
cv2.createTrackbar('B','image',0,255,nothing)
switch='0:OFF\n1:ON'
cv2.createTrackbar(switch,'image',0,1,nothing)
while(1):
    cv2.imshow('image',img)
    k=cv2.waitKey(1)&0xFF
    if k==27:
        break
    r=cv2.getTrackbarPos('R','image')
    g=cv2.getTrackbarPos('G','image')
    b=cv2.getTrackbarPos('B','image')
    s=cv2.getTrackbarPos(switch,'image')
    if s==0:
        img[:]=0
    else:
        img[:]=[b,g,r]
cv2.destroyAllWindows()
```

## 八、图像的基础操作；

```python
# 005_11 获取并修改像素值;
import numpy as np
import cv2
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\OpenCV.jpg')

px=img[100,100]
print (px) # [0 0 0];
blue=img[100,100,0]
print (blue) # 0;

# 005_12 获取图像属性;
import numpy as np
import cv2
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\OpenCV.jpg')
print(img.shape)  # (512, 512, 3)--img.shape 可以获取图像的形状;
print(img.size)   # 786432--img.size 可以返回图像的像素数目(H*W*C);
print(img.dtype)  # uint8--img.dtype 返回的是图像的数据类型;

# 005_13 图像 ROI;
import numpy as np
import cv2
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\OpenCV.jpg')
ball=img[280:340,330:390]
img[273:333,100:160]=ball

# 005_14 拆分及合并图像通道;
import numpy as np
import cv2
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\OpenCV.jpg')

b,g,r=cv2.split(img)
img=cv2.merge(b,g)

b=img[:,:,0]
img[:,:,2]=0
print(img)

# 005_15 为图像扩边（填充）;
import cv2
import numpy as np
from matplotlib import pyplot as plt
BLUE=[255,0,0]
img1=cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\yanyan.jpg')
replicate = cv2.copyMakeBorder(img1,10,10,10,10,cv2.BORDER_REPLICATE)
reflect = cv2.copyMakeBorder(img1,10,10,10,10,cv2.BORDER_REFLECT)
reflect101 = cv2.copyMakeBorder(img1,10,10,10,10,cv2.BORDER_REFLECT_101)
wrap = cv2.copyMakeBorder(img1,10,10,10,10,cv2.BORDER_WRAP)
constant= cv2.copyMakeBorder(img1,10,10,10,10,cv2.BORDER_CONSTANT,value=BLUE)
plt.subplot(231),plt.imshow(img1,'gray'),plt.title('ORIGINAL')
plt.subplot(232),plt.imshow(replicate,'gray'),plt.title('REPLICATE')
plt.subplot(233),plt.imshow(reflect,'gray'),plt.title('REFLECT')
plt.subplot(234),plt.imshow(reflect101,'gray'),plt.title('REFLECT_101')
plt.subplot(235),plt.imshow(wrap,'gray'),plt.title('WRAP')
plt.subplot(236),plt.imshow(constant,'gray'),plt.title('CONSTANT')

plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\yanyan_splicing.jpg')
plt.show()

# 如何保存多幅拼接图像；

cv2.imwrite('E:\\Deep Learning\\DeepLearning\\Opencv\\yanyan_img.png',all)
cv2.imwrite('E:\\Deep Learning\\DeepLearning\\Opencv\\yanyan_img1.png',img1)
cv2.imwrite('E:\\Deep Learning\\DeepLearning\\Opencv\\yanyan_replicate.png',replicate)
cv2.imwrite('E:\\Deep Learning\\DeepLearning\\Opencv\\yanyan_reflect.png',reflect)
cv2.imwrite('E:\\Deep Learning\\DeepLearning\\Opencv\\yanyan_reflect101.png',reflect101)
cv2.imwrite('E:\\Deep Learning\\DeepLearning\\Opencv\\yanyan_wrap.png',wrap)
cv2.imwrite('E:\\Deep Learning\\DeepLearning\\Opencv\\yanyan_constant.png',constant)
```

## 九、图像上的算术运算;

```python
# 10.1 图像上的算术运算;
# 函数 cv2.add() 将两幅图像进行加法运算;
import numpy as np
import cv2
x = np.uint8([250])
y = np.uint8([10])
print(cv2.add(x,y))  # 250+10 = 260 => 255;
print(x+y)           # 250+10 = 260 % 256 = 4;

# 10.2 图像混合--(图像大小需一致)(g (x) = (1 − α) f0 (x) + αf1 (x));
import cv2
import numpy as np

img1=cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\yanyan.jpg')
img2=cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\VR002.png')
dst= cv2.addWeighted(img1, 0.6, img2, 0.4, 0)
cv2.imshow('dst',dst)
cv2.imwrite('E:\\Deep Learning\\DeepLearning\\Opencv\\yy.jpg',dst)
cv2.waitKey(0)
cv2.destroyAllWindows()

# 10.3 按位运算;
import cv2
import numpy as np
# 加载图像
img1=cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\yanyan.jpg')
img2=cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\me.jpg') # I want to put logo on top-left corner, So I create a ROI
rows,cols,channels = img2.shape
roi = img1[0:rows, 0:cols ]
# Now create a mask of logo and create its inverse mask also
img2gray = cv2.cvtColor(img2,cv2.COLOR_BGR2GRAY)
ret, mask = cv2.threshold(img2gray, 175, 255, cv2.THRESH_BINARY)
mask_inv = cv2.bitwise_not(mask)
# Now black-out the area of logo in ROI
# 取 roi 中与 mask 中不为零的值对应的像素的值，其他值为 0 # 注意这里必须有 mask=mask 或者 mask=mask_inv, 其中的 mask= 不能忽略
img1_bg = cv2.bitwise_and(roi,roi,mask = mask)
# 取 roi 中与 mask_inv 中不为零的值对应的像素的值，其他值为 0。
# Take only region of logo from logo image.
img2_fg = cv2.bitwise_and(img2,img2,mask = mask_inv)
# Put logo in ROI and modify the main image
dst = cv2.add(img1_bg,img2_fg)
img1[0:rows, 0:cols ] = dst
cv2.imshow('res',img1)
cv2.imwrite('E:\\Deep Learning\\DeepLearning\\Opencv\\logo.png',img1)
cv2.waitKey(0)
cv2.destroyAllWindows()
```

## 十、使用 OpenCV 检测程序效率;

```python	
# cv2.getTickCount 函数返回从参考点到这个函数被执行的时钟数;cv2.getTickFrequency 返回时钟频率;
import cv2
import numpy as np
e1 = cv2.getTickCount()
# your code execution
e2 = cv2.getTickCount()
time = (e2 - e1)/ cv2.getTickFrequency()

import cv2
import numpy as np
img1 = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg')
e1 = cv2.getTickCount()
for i in range(5,49,2):
    img1 = cv2.medianBlur(img1,i)
e2 = cv2.getTickCount()
t = (e2 - e1)/cv2.getTickFrequency()
print (t) # 0.3033581;

# 11.2 OpenCV 中的默认优化
# import numpy as np
# import cv2
# cv2.useOptimized()  # return True or False;

# 11.3 在 IPython 中检测程序效率
# 11.4 更多 IPython 的魔法命令(profiling， line profiling，内存使用等)
#
# 1. Python Optimization Techniques
# 2. Scipy Lecture Notes - Advanced Numpy
# 3. Timing and Profiling in IPython
```

## 十一、OpenCV 中的图像处理；

```python
# OpenCV 中的图像处理
# 13.1 转换颜色空间

# cv2.cvtColor(input_image， flag),flag为转换类型；
# 对于 BGR<->Gray 的转换，我们要使用的 flag 就是 cv2.COLOR_BGR2GRAY；
# cv2.cvtColor(input_image,cv2.COLOR_BGR2GRAY)

# 对于 BGR<->HSV 的转换，我们用的 flag 就是 cv2.COLOR_BGR2HSV；
# CV2.cvtColor(input_image,cv2.COLOR_BRG2HSV);

# 注意： 在 OpenCV 的 HSV 格式中， H（色彩/色度）的取值范围是 [0， 179]，S（饱和度）的取值范围 [0， 255]， V（亮度）的取值范围 [0， 255]。但是不
# 同的软件使用的值可能不同。所以当你需要拿 OpenCV 的 HSV 值与其他软件的 HSV 值进行对比时，一定要记得归一化。

# 13.2 物体跟踪(提取带有某个特定颜色的物体，比如：在蓝色物体周围画一个圈。)
import cv2
import numpy as np
cap=cv2.VideoCapture(0)
while(1):
    # 获取每一帧
    ret, frame = cap.read()
    # 转换到 HSV
    hsv = cv2.cvtColor(frame, cv2.COLOR_BGR2HSV)
    # 设定蓝色的阈值
    lower_blue = np.array([110, 50, 50])
    upper_blue = np.array([130, 255, 255])
    # 根据阈值构建掩模
    mask = cv2.inRange(hsv, lower_blue, upper_blue)
    # 对原图像和掩模进行位运算
    res = cv2.bitwise_and(frame, frame, mask=mask)
    # 显示图像
    cv2.imshow('frame', frame)
    cv2.imshow('mask', mask)
    cv2.imshow('res', res)
    k = cv2.waitKey(5) & 0xFF
    if k == 27:
        break
# 关闭窗口；
cv2.destroyAllWindows()

# 13.3 怎样找到要跟踪对象的 HSV 值
# -*- coding: utf-8 -*-
# import cv2
# import numpy as np
# green=np.uint8([0,255,0])
# hsv_green=cv2.cvtColor(green,cv2.COLOR_BGR2HSV)
# error: /builddir/build/BUILD/opencv-2.4.6.1/
# modules/imgproc/src/color.cpp:3541:
# error: (-215) (scn == 3 || scn == 4) && (depth == CV_8U || depth == CV_32F)
# in function cvtColor
# scn (the number of channels of the source),
# i.e. self.img.channels(), is neither 3 nor 4.
#
# depth (of the source),
# i.e. self.img.depth(), is neither CV_8U nor CV_32F.
# 所以不能用 [0,255,0]，而要用 [[[0,255,0]]]
# 这里的三层括号应该分别对应于 cvArray， cvMat， IplImage
# green=np.uint8([[[0,255,0]]])
# hsv_green=cv2.cvtColor(green,cv2.COLOR_BGR2HSV)
# print (hsv_green)
# [[[60,255,255]]]
```

## 十一、几何变换；

```python
# 14 几何变换 (cv2.warpAffine 接收的参数是2 × 3 的变换矩阵，而 cv2.warpPerspective 接收的参数是 3 × 3 的变换矩阵。)
# 14.1 扩展缩放
# 扩展缩放只是改变图像的尺寸大小。 OpenCV 提供的函数 cv2.resize();
# 在缩放时我们推荐使用 cv2.INTER_AREA，
# 在扩展时我们推荐使用 v2.INTER_CUBIC（慢) 和 v2.INTER_LINEAR。
# 默认情况下所有改变图像尺寸大小的操作使用的插值方法都是 cv2.INTER_LINEAR

import numpy as np
import cv2
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg')
# 下面的 None 本应该是输出图像的尺寸，但是因为后边我们设置了缩放因子,因此这里为 None;
res=cv2.resize(img,None,fx=2,fy=2,interpolation=cv2.INTER_CUBIC)
# OR,这里呢，我们直接设置输出图像的尺寸，所以不用设置缩放因子;
height,width=img.shape[:2]
res=cv2.resize(img,(2*width,2*height),interpolation=cv2.INTER_CUBIC)
while(1):
    cv2.imshow('res', res)
    cv2.imshow('img', img)
    if cv2.waitKey(1) & 0xFF == 27:
        break
cv2.destroyAllWindows()

# 14.2 平移
# 下面这个例子，它被移动了（ 100,50）个像素。
# -*- coding: utf-8 -*-
import cv2
import numpy as np
cap=cv2.VideoCapture(0)
while(1):
    # 获取每一帧
    ret, frame = cap.read()
    # 转换到 HSV
    hsv = cv2.cvtColor(frame, cv2.COLOR_BGR2HSV)
    # 设定蓝色的阈值
    lower_blue = np.array([110, 50, 50])
    upper_blue = np.array([130, 255, 255])
    # 根据阈值构建掩模
    mask = cv2.inRange(hsv, lower_blue, upper_blue)
    # 对原图像和掩模进行位运算
    res = cv2.bitwise_and(frame, frame, mask=mask)
    # 显示图像
    cv2.imshow('frame', frame)
    cv2.imshow('mask', mask)
    cv2.imshow('res', res)
    k = cv2.waitKey(5) & 0xFF
    if k == 27:
        break
# 关闭窗口
cv2.destroyAllWindows()

# 14.3 旋转
# 为了构建这个旋转矩阵， OpenCV 提供了一个函数： cv2.getRotationMatrix2D。
# -*- coding: utf-8 -*-
import cv2
import numpy as np
img = cv2.imread('D:/software/DL information/Opencv/Opencv.png')
rows,cols=img.shape
# 这里的第一个参数为旋转中心，第二个为旋转角度，第三个为旋转后的缩放因子
# 可以通过设置旋转中心，缩放因子，以及窗口大小来防止旋转后超出边界的问题
M=cv2.getRotationMatrix2D((cols/2,rows/2),45,0.6)
# 第三个参数是输出图像的尺寸中心
dst=cv2.warpAffine(img,M,(2*cols,2*rows))
while(1):
    cv2.imshow('img',dst)
    if cv2.waitKey(1) & 0xFF == 27:
        break
cv2.destroyAllWindows()

# 14.3 旋转
# 为了构建这个旋转矩阵， OpenCV 提供了一个函数： cv2.getRotationMatrix2D。
# -*- coding: utf-8 -*-
import cv2
import numpy as np
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg',0)
rows,cols=img.shape
# 这里的第一个参数为旋转中心，第二个为旋转角度，第三个为旋转后的缩放因子
# 可以通过设置旋转中心，缩放因子，以及窗口大小来防止旋转后超出边界的问题
M=cv2.getRotationMatrix2D((cols/2,rows/2),45,0.6)
# 第三个参数是输出图像的尺寸中心
dst=cv2.warpAffine(img,M,(2*cols,2*rows))
cv2.imwrite('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv_Rotation.jpg',dst)
while(1):
    cv2.imshow('img',dst)
    if cv2.waitKey(1) & 0xFF == 27:
        break
cv2.destroyAllWindows()

# 14.4 仿射变换
# 为了创建这个矩阵我们需要从原图像中找到三个点以及他们在输出图像中的位置。然后cv2.getAffineTransform 会创建一个 2x3 的矩阵，最后这个矩阵会被传给函数 cv2.warpAffine;
import cv2 as cv
import numpy as np
import matplotlib.pyplot as plt

img = cv.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg')
rows, cols = img.shape[:2]

# 变换前的三个点
pts1 = np.float32([[50, 65], [150, 65], [210, 210]])
# 变换后的三个点
pts2 = np.float32([[50, 100], [150, 65], [100, 250]])

# 生成变换矩阵
M = cv.getAffineTransform(pts1, pts2)
# 第三个参数为dst的大小
dst = cv.warpAffine(img, M, (cols, rows))

plt.subplot(121), plt.imshow(img), plt.title('input')
plt.subplot(122), plt.imshow(dst), plt.title('output')
# plt.show() # 注释前，保存白底图像，无内容；
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\VR_warpAffine.jpg')

# 14.5 透视变换
# 对于视角变换，我们需要一个 3x3 变换矩阵。在变换前后直线还是直线。
# 要构建这个变换矩阵，你需要在输入图像上找 4 个点，以及他们在输出图
# 像上对应的位置。这四个点中的任意三个都不能共线。这个变换矩阵可以由
# 函数 cv2.getPerspectiveTransform() 构建。然后把这个矩阵传给函数cv2.warpPerspective;
import numpy as np
import cv2 as cv
import matplotlib.pyplot as plt
img = cv.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg')

# 原图中卡片的四个角点
pts1 = np.float32([[148, 80], [437, 114], [94, 247], [423, 288]])
# 变换后分别在左上、右上、左下、右下四个点
pts2 = np.float32([[0, 0], [320, 0], [0, 178], [320, 178]])

# 生成透视变换矩阵
M = cv.getPerspectiveTransform(pts1, pts2)
# 进行透视变换，参数3是目标图像大小
dst = cv.warpPerspective(img, M, (320, 178))

plt.subplot(121), plt.imshow(img[:, :, ::-1]), plt.title('input')
plt.subplot(122), plt.imshow(dst[:, :, ::-1]), plt.title('output')
# # plt.show() # 注释前，保存白底图像，无内容；
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\VR_warpPerspective.jpg')
```

## 十二、图像阈值；

```python
import cv2
import numpy as np
from matplotlib import pyplot as plt
img=cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg',0)
ret,thresh1=cv2.threshold(img,127,255,cv2.THRESH_BINARY)
ret,thresh2=cv2.threshold(img,127,255,cv2.THRESH_BINARY_INV)
ret,thresh3=cv2.threshold(img,127,255,cv2.THRESH_TRUNC)
ret,thresh4=cv2.threshold(img,127,255,cv2.THRESH_TOZERO)
ret,thresh5=cv2.threshold(img,127,255,cv2.THRESH_TOZERO_INV)
titles = ['Original Image','BINARY','BINARY_INV','TRUNC','TOZERO','TOZERO_INV']
images = [img, thresh1, thresh2, thresh3, thresh4, thresh5]
for i in range(6):
    plt.subplot(2, 3, i + 1), plt.imshow(images[i], 'gray')
    plt.title(titles[i])
    plt.xticks([]), plt.yticks([])
# plt.show() # 注释前，保存白底图像，无内容；
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\VR_threshold.jpg')

# 15.2 自适应阈值
# 当同一幅图像上的不同部分的具有不同亮度时。
# 这种情况下我们需要采用自适应阈值。此时的阈值是根据图像上的
# 每一个小区域计算与其对应的阈值。因此在同一幅图像上的不同区域采用的是
# 不同的阈值，从而使我们能在亮度不同的情况下得到更好的结果。
# Adaptive Method- 指定计算阈值的方法。
# Block Size - 邻域大小（用来计算阈值的区域大小）。
# C - 这就是是一个常数，阈值就等于的平均值或者加权平均值减去这个常数。
# -*- coding: utf-8 -*-
import cv2
import numpy as np
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg',0)
# 中值滤波
img = cv2.medianBlur(img,5)
ret,th1 = cv2.threshold(img,127,255,cv2.THRESH_BINARY)
#11 为 Block size, 2 为 C 值
th2 = cv2.adaptiveThreshold(img,255,cv2.ADAPTIVE_THRESH_MEAN_C,cv2.THRESH_BINARY,11,2)
th3 = cv2.adaptiveThreshold(img,255,cv2.ADAPTIVE_THRESH_GAUSSIAN_C,cv2.THRESH_BINARY,11,2)
titles = ['Original Image', 'Global Thresholding (v = 127)','Adaptive Mean Thresholding', 'Adaptive Gaussian Thresholding']
images = [img, th1, th2, th3]
for i in range(4):
    plt.subplot(2, 2, i + 1), plt.imshow(images[i], 'gray')
    plt.title(titles[i])
    plt.xticks([]), plt.yticks([])
# plt.show()
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\VR_AdaptiveThreshold.jpg')

# 15.3 Otsu’s 二值化
# 这里用到到的函数还是 cv2.threshold()，但是需要多传入一个参数
# （ flag）： cv2.THRESH_OTSU。这时要把阈值设为 0。然后算法会找到最
# 优阈值，这个最优阈值就是返回值 retVal。如果不使用 Otsu 二值化，返回的
# retVal 值与设定的阈值相等。
# -*- coding: utf-8 -*-

import cv2
import numpy as np
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg',0)
# global thresholding
ret1,th1 = cv2.threshold(img,127,255,cv2.THRESH_BINARY)
# Otsu's thresholding
ret2,th2 = cv2.threshold(img,0,255,cv2.THRESH_BINARY+cv2.THRESH_OTSU)
# Otsu's thresholding after Gaussian filtering
#（ 5,5）为高斯核的大小， 0 为标准差
blur = cv2.GaussianBlur(img,(5,5),0)
# 阈值一定要设为 0！
ret3,th3 = cv2.threshold(blur,0,255,cv2.THRESH_BINARY+cv2.THRESH_OTSU)
# plot all the images and their histograms
images = [img, 0, th1,
img, 0, th2,
blur, 0, th3]
titles = ['Original Noisy Image','Histogram','Global Thresholding (v=127)','Original Noisy Image','Histogram',"Otsu's Thresholding",
          'Gaussian filtered Image','Histogram',"Otsu's Thresholding"]
# 这里使用了 pyplot 中画直方图的方法， plt.hist, 要注意的是它的参数是一维数组
# 所以这里使用了（ numpy） ravel 方法，将多维数组转换成一维，也可以使用 flatten 方法
# ndarray.flat 1-D iterator over an array.
# ndarray.flatten 1-D array copy of the elements of an array in row-major order.
for i in range(3):
    plt.subplot(3, 3, i * 3 + 1), plt.imshow(images[i * 3], 'gray')
    plt.title(titles[i * 3]), plt.xticks([]), plt.yticks([])
    plt.subplot(3, 3, i * 3 + 2), plt.hist(images[i * 3].ravel(), 256)
    plt.title(titles[i * 3 + 1]), plt.xticks([]), plt.yticks([])
    plt.subplot(3, 3, i * 3 + 3), plt.imshow(images[i * 3 + 2], 'gray')
    plt.title(titles[i * 3 + 2]), plt.xticks([]), plt.yticks([])
# plt.show()
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\VR_ Otsu-threshold.jpg')

# 15.4 Otsu’s 二值化是如何工作的？
import cv2
import numpy as np
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg',0)
blur = cv2.GaussianBlur(img,(5,5),0)
# find normalized_histogram, and its cumulative distribution function
# 计算归一化直方图
#CalcHist(image, accumulate=0, mask=NULL)
hist = cv2.calcHist([blur],[0],None,[256],[0,256])
hist_norm = hist.ravel()/hist.max()
Q = hist_norm.cumsum()
bins = np.arange(256)
fn_min = np.inf
thresh = -1
for i in range(1,256):
    p1, p2 = np.hsplit(hist_norm, [i])  # probabilities
    q1, q2 = Q[i], Q[255] - Q[i]  # cum sum of classes
    b1, b2 = np.hsplit(bins, [i])  # weights
    # finding means and variances
    m1, m2 = np.sum(p1 * b1) / q1, np.sum(p2 * b2) / q2
    v1, v2 = np.sum(((b1 - m1) ** 2) * p1) / q1, np.sum(((b2 - m2) ** 2) * p2) / q2
    # calculates the minimization function
    fn = v1 * q1 + v2 * q2
    if fn < fn_min:
        fn_min = fn
        thresh = i
# find otsu's threshold value with OpenCV function
ret, otsu = cv2.threshold(blur,0,255,cv2.THRESH_BINARY+cv2.THRESH_OTSU)
print(thresh,ret)
```

## 十三、图像平滑、模糊处理；

```python
# 16 图像平滑
# OpenCV 提供的函数 cv.filter2D() 可以让我们对一幅图像进行卷积操作。
# 2D 卷积
import numpy as np
import cv2
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg')
kernel = np.ones((5,5),np.float32)/25
#cv.Filter2D(src, dst, kernel, anchor=(-1, -1))
#ddepth –desired depth of the destination image;
#if it is negative, it will be the same as src.depth();
#the following combinations of src.depth() and ddepth are supported:
#src.depth() = CV_8U, ddepth = -1/CV_16S/CV_32F/CV_64F
#src.depth() = CV_16U/CV_16S, ddepth = -1/CV_32F/CV_64F
#src.depth() = CV_32F, ddepth = -1/CV_32F/CV_64F
#src.depth() = CV_64F, ddepth = -1/CV_64F
#when ddepth=-1, the output image will have the same depth as the source.
dst = cv2.filter2D(img,-1,kernel)
plt.subplot(121),plt.imshow(img),plt.title('Original')
plt.xticks([]), plt.yticks([])
plt.subplot(122),plt.imshow(dst),plt.title('Averaging')
plt.xticks([]), plt.yticks([])
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\VR_filter2D.jpg')
plt.show()

# 图像模糊（图像平滑）使用低通滤波器可以达到图像模糊的目的。
# 16.1 平均
# -*- coding: utf-8 -*-
import cv2
import numpy as np
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg')
blur = cv2.blur(img,(5,5))
plt.subplot(121),plt.imshow(img),plt.title('Original')
plt.xticks([]), plt.yticks([])
plt.subplot(122),plt.imshow(blur),plt.title('Blurred')
plt.xticks([]), plt.yticks([])
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\VR_blur.jpg')
plt.show()

# 16.2 高斯模糊
# 实现的函数是 cv2.GaussianBlur()。
# 高斯滤波可以有效的从图像中去除高斯噪音。
# 0 是指根据窗口大小（ 5,5）来计算高斯函数标准差
import cv2
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg')
blur = cv2.GaussianBlur(img,(5,5),0)
cv2.imshow("GaussianBlur",blur)
cv2.waitKey()
cv2.imwrite("E:\\Deep Learning\\DeepLearning\\Opencv\\VR_GaussianBlur.jpg",blur) # work;
# plt.savefig('D:\\DL information\\Opencv\\VR_GaussianBlur.jpg')
# plt.show()

# 16.3 中值模糊
# 是用与卷积框对应像素的中值来替代中心像素的值；
# 中值滤波器经常用来去除椒盐噪声；
import cv2
from matplotlib import pyplot as plt
# img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\Opencv.jpg')
img =cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\noise.jpeg')
median = cv2.medianBlur(img,5)
# cv2.imshow("medianBlur",median)
# cv2.waitKey()
# cv2.imwrite("D:\\DL information\\Opencv\\VR_medianBlur.jpg",median) # work;
plt.subplot(),plt.imshow(median),plt.title('median-image')
plt.xticks([]), plt.yticks([])
# plt.show()
# plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\VR_median.jpg')
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\noise_median.jpeg')

# 16.4 双边滤波;
# 函数 cv2.bilateralFilter() 能在保持边界清晰的情况下有效的去除噪音。
# 双边滤波会确保边界不会被模糊掉，因为边界处的灰度值变化比较大;
# cv2.bilateralFilter(src, d, sigmaColor, sigmaSpace)
# d – Diameter of each pixel neighborhood that is used during filtering.
# If it is non-positive, it is computed from sigmaSpace
# 9 邻域直径，两个 75 分别是空间高斯函数标准差，灰度值相似性高斯函数标准差
import cv2
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\VR.jpg')
blur = cv2.bilateralFilter(img,9,75,75)
plt.subplot(),plt.imshow(blur),plt.title('bilateralFilter-image')
plt.xticks([]), plt.yticks([])
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\VR_bilateralFilter.jpg')
plt.show()
```

## 十四、形态学转换；

```python
# 17 形态学转换
# 学习不同的形态学操作，例如腐蚀，膨胀，开运算，闭运算等;
# 我们要学习的函数有： cv2.erode()， cv2.dilate()， cv2.morphologyEx()等;

# 17.1 腐蚀 (去除白噪声很有用)
# -*- coding: utf-8 -*-
import cv2
import numpy as np
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise.jpg',0)
kernel = np.ones((5,5),np.uint8)
erosion = cv2.erode(img,kernel,iterations = 1) # iterations = 1腐蚀次数；
cv2.imshow("erosion",erosion)
cv2.waitKey()
cv2.imwrite("E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise_erosion.jpg",erosion) # work;


# 17.2 膨胀
import cv2
import numpy as np
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise.jpg',0)
kernel = np.ones((3,3),np.uint8)
dilation = cv2.dilate(img,kernel,iterations = 1)
plt.subplot(),plt.imshow(dilation),plt.title('dilation-image')
plt.xticks([]), plt.yticks([])
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise_dilation.jpg')
plt.show()


# 17.3 开运算 (先进行腐蚀再进行膨胀就叫做开运算)；
import cv2
import numpy as np
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise.jpg',0)
kernel = np.ones((3,3),np.uint8)
opening = cv2.morphologyEx(img, cv2.MORPH_OPEN, kernel)
plt.subplot(),plt.imshow(opening),plt.title('opening-image')
plt.xticks([]), plt.yticks([])
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise_opening.jpg')
plt.show()


# 17.4 闭运算(先膨胀再腐蚀; 经常被用来填充前景物体中的小洞，或者前景物体上的小黑点);
import cv2
import numpy as np
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise.jpg',0)
kernel = np.ones((3,3),np.uint8)
closing = cv2.morphologyEx(img, cv2.MORPH_CLOSE, kernel)
plt.subplot(),plt.imshow(closing),plt.title('closing-image')
plt.xticks([]), plt.yticks([])
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise_closing.jpg')
plt.show()


# 17.5 形态学梯度(其实就是一幅图像膨胀与腐蚀的差别,结果看上去就像前景物体的轮廓。)
import cv2
import numpy as np
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise.jpg',0)
kernel = np.ones((3,3),np.uint8)
gradient = cv2.morphologyEx(img, cv2.MORPH_GRADIENT, kernel)
plt.subplot(),plt.imshow(gradient),plt.title('gradient-image')
plt.xticks([]), plt.yticks([])
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise_gradient.jpg')
plt.show()


# 17.6 礼帽(原始图像与进行开运算之后得到的图像的差);
import cv2
import numpy as np
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise.jpg',0)
kernel = np.ones((3,3),np.uint8)
tophat = cv2.morphologyEx(img, cv2.MORPH_TOPHAT, kernel)

plt.subplot(),plt.imshow(tophat),plt.title('tophat-image')
plt.xticks([]), plt.yticks([])
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise_tophat.jpg')
plt.show()


# 17.7 黑帽(进行闭运算之后得到的图像与原始图像的差);
import cv2
import numpy as np
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise.jpg',0)
kernel = np.ones((3,3),np.uint8)
blackhat = cv2.morphologyEx(img, cv2.MORPH_BLACKHAT, kernel)
plt.subplot(),plt.imshow(blackhat),plt.title('blackhat-image')
plt.xticks([]), plt.yticks([])
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise_blackhat.jpg')
plt.show()
```

## 十五、图像梯度；

```python
# 18 图像梯度
import cv2
import numpy as np
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise.jpg',0)

# cv2.CV_64F 输出图像的深度（数据类型），可以使用-1, 与原图像保持一致 np.uint8
laplacian=cv2.Laplacian(img,cv2.CV_64F)
# 参数 1,0 为只在 x 方向求一阶导数，最大可以求 2 阶导数。
sobelx=cv2.Sobel(img,cv2.CV_64F,1,0,ksize=5)
# 参数 0,1 为只在 y 方向求一阶导数，最大可以求 2 阶导数。
sobely=cv2.Sobel(img,cv2.CV_64F,0,1,ksize=5)
plt.subplot(2,2,1),plt.imshow(img,cmap = 'gray')
plt.title('Original'), plt.xticks([]), plt.yticks([])
plt.subplot(2,2,2),plt.imshow(laplacian,cmap = 'gray')
plt.title('Laplacian'), plt.xticks([]), plt.yticks([])
plt.subplot(2,2,3),plt.imshow(sobelx,cmap = 'gray')
plt.title('Sobel X'), plt.xticks([]), plt.yticks([])
plt.subplot(2,2,4),plt.imshow(sobely,cmap = 'gray')
plt.title('Sobel Y'), plt.xticks([]), plt.yticks([])
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise_blackhat.jpg')
plt.show()


# 输出图片的深度不同造成的不同效果
import cv2
import numpy as np
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise.jpg',0)
# Output dtype = cv2.CV_8U
sobelx8u = cv2.Sobel(img,cv2.CV_8U,1,0,ksize=5)
# 也可以将参数设为-1
# sobelx8u = cv2.Sobel(img,-1,1,0,ksize=5)
# Output dtype = cv2.CV_64F. Then take its absolute and convert to cv2.CV_8U
sobelx64f = cv2.Sobel(img,cv2.CV_64F,1,0,ksize=5)
abs_sobel64f = np.absolute(sobelx64f)
sobel_8u = np.uint8(abs_sobel64f)
plt.subplot(1,3,1),plt.imshow(img,cmap = 'gray')
plt.title('Original'), plt.xticks([]), plt.yticks([])
plt.subplot(1,3,2),plt.imshow(sobelx8u,cmap = 'gray')
plt.title('Sobel CV_8U'), plt.xticks([]), plt.yticks([])
plt.subplot(1,3,3),plt.imshow(sobel_8u,cmap = 'gray')
plt.title('Sobel abs(CV_64F)'), plt.xticks([]), plt.yticks([])
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\white-noise-depth.jpg')
plt.show()
```

## 十六、Canny 边缘检测；

```python
# 19 Canny 边缘检测
import cv2
import numpy as np
from matplotlib import pyplot as plt
img = cv2.imread('E:\\Deep Learning\\DeepLearning\\Opencv\\VR.jpg',0)
edges = cv2.Canny(img,100,200)
plt.subplot(121),plt.imshow(img,cmap = 'gray')
plt.title('Original Image'), plt.xticks([]), plt.yticks([])
plt.subplot(122),plt.imshow(edges,cmap = 'gray')
plt.title('Edge Image'), plt.xticks([]), plt.yticks([])
plt.savefig('E:\\Deep Learning\\DeepLearning\\Opencv\\VR-Canny.jpg')
plt.show()
```





