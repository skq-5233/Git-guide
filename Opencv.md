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

## 三、使用 Matplotlib  

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
```

