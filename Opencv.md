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

## 二、下面的程序将会加载一个灰度图， 显示图片，按下’s’键保存后退出，或者按下 ESC 键退出不保存。  

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

## 四、视频

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

# 005_6 在图片上添加文字;
# 在图像上绘制白色的 OpenCV；
import numpy as np
import cv2
img=np.zeros((512,512,3), np.uint8)
font=cv2.FONT_HERSHEY_SIMPLEX

pts = np.array([[10,5],[20,30],[70,20],[50,10]], np.int32)
pts=pts.reshape((-1,1,2))  # 这里 reshape 的第一个参数为-1, 表明这一维的长度是根据后面的维度的计算出来的。
# cv2.line(img,(0,0),(511,511),(255,0,0),5)
# cv2.rectangle(img, (384, 0), (510, 128), (0, 255, 0), 3)
# cv2.circle(img,(447,63), 63, (0,0,255), -1)
# cv2.ellipse(img,(256,256),(100,50),0,0,180,255,-1)
# cv2.polylines(img,[pts],True,(255,0,255))  # 如果第三个参数是 False，我们得到的多边形是不闭合的（首尾不相连）。

cv2.putText(img,'OpenCV',(10,500), font, 4,(255,255,255),2)

winname = 'example'
cv2.namedWindow(winname)
cv2.imshow(winname, img)
cv2.waitKey(0)
cv2.destroyWindow(winname)
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

```

