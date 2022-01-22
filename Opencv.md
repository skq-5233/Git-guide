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
cv2.rectangle(img,(384,0),(510,128),(0,255,0),3)
cv2.imshow("img",img)
cv2.imwrite("E:\\Deep Learning\\DeepLearning\\Opencv\\rectangle.jpg",img)
cv2.waitKey(0)

# 005_3 画圆；
import numpy as np
import cv2
img=np.zeros((512,512,3), np.uint8)
cv2.circle(img,(447,63), 63, (0,0,255), -1)
cv2.imshow("img",img)
cv2.imwrite("E:\\Deep Learning\\DeepLearning\\Opencv\\circle.jpg",img)
cv2.waitKey(0)

# 005_4 画椭圆；
import numpy as np
import cv2
img=np.zeros((512,512,3), np.uint8)
cv2.line(img,(0,0),(511,511),(255,0,0),5)
cv2.rectangle(img, (384, 0), (510, 128), (0, 255, 0), 3)
cv2.circle(img,(447,63), 63, (0,0,255), -1)
cv2.ellipse(img,(256,256),(100,50),0,0,180,255,-1)
cv2.imshow("ellipse",img)
cv2.imwrite("E:\\Deep Learning\\DeepLearning\\Opencv\\ellipse.jpg",img)
cv2.waitKey(0)

# 005_6 在图片上添加文字;
# 在图像上绘制白色的 OpenCV；
import numpy as np
import cv2
img=np.zeros((512,512,3), np.uint8)
font=cv2.FONT_HERSHEY_SIMPLEX

pts = np.array([[10,5],[20,30],[70,20],[50,10]], np.int32)
pts=pts.reshape((-1,1,2))  # 这里 reshape 的第一个参数为-1, 表明这一维的长度是根据后面的维度的计算出来的。
cv2.line(img,(0,0),(511,511),(255,0,0),5)
cv2.rectangle(img, (384, 0), (510, 128), (0, 255, 0), 3)
cv2.circle(img,(447,63), 63, (0,0,255), -1)
cv2.ellipse(img,(256,256),(100,50),0,0,180,255,-1)
cv2.polylines(img,[pts],True,(255,0,255)) # 如果第三个参数是False,则多边形是不闭合的（首尾不相连）。

cv2.putText(img,'OpenCV',(10,500), font, 4,(255,255,255),2)

winname = 'example'
cv2.namedWindow(winname)
cv2.imshow(winname, img)
cv2.waitKey(0)
cv2.destroyWindow(winname)
cv2.imwrite('E:\\Deep Learning\\DeepLearning\\Opencv\\OpenCV.jpg',img)
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





